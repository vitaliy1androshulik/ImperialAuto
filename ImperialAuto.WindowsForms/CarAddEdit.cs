using CuoreUI.Controls;
using ImperialAuto.Domain.Entities;
using ImperialAuto.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ImperialAuto.WindowsForms
{
    public partial class CarAddEdit : Form
    {
        private readonly ImperialAutoDbContext _db;
        private string selectedImagePath = null;
        private List<string> imagePaths = new List<string>();
        public CarAddEdit(ImperialAutoDbContext db)
        {
            InitializeComponent();
            _db = db;
            this.Load += CarAddEdit_Load;
        }


        public void LoadInfo()
        {
            var brands = _db.Brands.OrderBy(b => b.Name).ToList();
            cbBrand.Items = brands.Select(b => b.Name).ToArray();

            var colors = _db.CarColors.OrderBy(b => b.Color).ToList();
            cbColor.Items = colors.Select(c => c.Color).ToArray();

            var engine = _db.EngineTypes.OrderBy(b => b.FuelType).ToList();
            cbEnginetype.Items = engine.Select(e => e.FuelType).ToArray();
        }

        private void CarAddEdit_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void cuiButton3_Click(object sender, EventArgs e)
        {

            cuiPictureBox pb = new cuiPictureBox();
            pb.Width = 145;
            pb.Height = 145;
            pb.Margin = new Padding(0, 0, 5, 0);
            pb.BackgroundImageLayout = ImageLayout.Zoom;
            pb.OutlineThickness = 1F;
            pb.PanelOutlineColor = Color.FromArgb(212, 175, 55);
            pb.Rounding = new Padding(15);

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Оберіть картинку";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    pb.BackgroundImage = Image.FromFile(selectedImagePath);
                    imagePaths.Add(selectedImagePath);
                }

            }
            pb.Click += (s, e) =>
            {
                if (MessageBox.Show("Видалити це фото?", "Підтвердження",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (pb.Tag is string path)
                        imagePaths.Remove(path);
                    flPanel.Controls.Remove(pb);
                    pb.Dispose();
                }
            };

            flPanel.Controls.Add(pb);
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            string selectedBrandName = cbBrand.SelectedItem.ToString();
            var brand = _db.Brands.FirstOrDefault(b => b.Name == selectedBrandName);
            int brandId = brand.Id;

            string selectedColor = cbColor.SelectedItem.ToString();
            var color = _db.CarColors.FirstOrDefault(b => b.Color == selectedColor);
            int colorId = color.Id;

            string selectedEngine = cbEnginetype.SelectedItem.ToString();
            var engine = _db.EngineTypes.FirstOrDefault(b => b.FuelType == selectedEngine);
            int engineId = engine.Id;

            

            var Car = new Car
            {
                BrandId = brandId,
                Model= tbModel.contentTextField.Text,
                Year=int.Parse(tbYear.contentTextField.Text),
                Price = int.Parse(tbPrice.contentTextField.Text),
                Volume = double.Parse(tbVolume.contentTextField.Text),
                EngineTypeId = engineId,
                ColorId = colorId,
                
            };
            _db.Cars.Add(Car);
            _db.SaveChanges();
            foreach (var path in imagePaths)
            {
                string imagesFolder = Path.Combine(Application.StartupPath, "carImages");
                if (!Directory.Exists(imagesFolder))
                    Directory.CreateDirectory(imagesFolder);

                string fileName = Path.GetFileName(path);
                string destPath = Path.Combine(imagesFolder, fileName);

                File.Copy(path, destPath, true);
                string relativePath = Path.Combine("carImages", fileName);

                _db.CarImages.Add(new CarImage
                {
                    CarId = Car.Id,
                    ImageUrl = relativePath
                });
            }
            _db.SaveChanges(); 

            MessageBox.Show("Автомобіль успішно додано!");
            this.Close();
        }
    }
}
