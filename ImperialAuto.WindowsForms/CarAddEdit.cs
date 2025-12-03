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
        private Car _car;
        private List<string> imagePaths = new List<string>();
        private bool isEdit = false;
        public CarAddEdit(ImperialAutoDbContext db, Car car=null)
        {
            InitializeComponent();
            _db = db;
            _car = car;
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
            if (_car != null)
            {
                isEdit = true;
                LoadCarForEdit(); 
            }
        }
        private void LoadInfoForEdit()
        {
            LoadInfo();
            var brand = _db.Brands.FirstOrDefault(b => b.Id == _car.BrandId);

            if (brand != null)
            {
                cbBrand.SelectedItem = brand.Name;
            }
            var fuel = _db.EngineTypes.FirstOrDefault(e => e.Id == _car.EngineTypeId);

            if (fuel != null)
            {
                cbEnginetype.SelectedItem = fuel.FuelType;
            }
            var color = _db.CarColors.FirstOrDefault(c => c.Id == _car.ColorId);

            if (color != null)
            {
                cbColor.SelectedItem = color.Color;
            }
        }
        private void LoadCarForEdit()
        {
            if (_car == null) return;
            LoadInfoForEdit();
            tbModel.contentTextField.Text = _car.Model;
            tbYear.contentTextField.Text = _car.Year.ToString();
            tbPrice.contentTextField.Text = _car.Price.ToString();
            tbVolume.contentTextField.Text = _car.Volume.ToString();
            
            if (_car.ImageUrls != null && _car.ImageUrls.Any())
            {
                flPanel.Controls.Clear();

                foreach (var imgObj in _car.ImageUrls)
                {
                    var imgPath = imgObj.ImageUrl;

                    if (!File.Exists(imgPath))
                        continue;

                    cuiPictureBox pb = new cuiPictureBox();
                    pb.Width = 145;
                    pb.Height = 145;
                    pb.Margin = new Padding(0, 0, 5, 0);
                    pb.BackgroundImageLayout = ImageLayout.Zoom;
                    pb.OutlineThickness = 1F;
                    pb.PanelOutlineColor = Color.FromArgb(212, 175, 55);
                    pb.Rounding = new Padding(15);
                    pb.Content = Image.FromFile(imgPath);

                    flPanel.Controls.Add(pb);
                }
            }
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
                    pb.Content = Image.FromFile(selectedImagePath);
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
            
            if(isEdit==true)
            {
                if (_car == null)
                {
                    _car = new Car();
                    _db.Cars.Add(_car);
                }

                _car.Model = tbModel.contentTextField.Text;
                _car.Year = int.Parse(tbYear.contentTextField.Text);
                _car.Volume = double.Parse(tbVolume.contentTextField.Text);
                _car.Price = int.Parse(tbPrice.contentTextField.Text);

                var brandEd = _db.Brands.FirstOrDefault(b => b.Name == cbBrand.SelectedItem.ToString());
                if (brandEd != null)
                    _car.BrandId = brandEd.Id;
                var fuelEd = _db.EngineTypes.FirstOrDefault(e => e.FuelType == cbEnginetype.SelectedItem.ToString());

                if (fuelEd != null)
                {
                    _car.EngineTypeId = fuelEd.Id;
                }
                var colorEd = _db.CarColors.FirstOrDefault(c => c.Color == cbColor.SelectedItem.ToString());

                if (colorEd != null)
                {
                    _car.ColorId = colorEd.Id;
                }
                _db.SaveChanges();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if(isEdit==false)
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
                    Model = tbModel.contentTextField.Text,
                    Year = int.Parse(tbYear.contentTextField.Text),
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

                this.Close();
            }
        }
    }
}
