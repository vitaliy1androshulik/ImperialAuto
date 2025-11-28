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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ImperialAuto.WindowsForms
{
    public partial class BrandAdd : Form
    {
        private readonly ImperialAutoDbContext _db;
        private string selectedImagePath = null;
        public BrandAdd(ImperialAutoDbContext db)
        {
            InitializeComponent();
            _db = db;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Оберіть картинку";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    pbImage.ImageLocation = selectedImagePath;
                }
            }
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Оберіть картинку для машини!");
                return;
            }

            string imagesFolder = Path.Combine(Application.StartupPath, "BrandLogos");
            if (!Directory.Exists(imagesFolder))
                Directory.CreateDirectory(imagesFolder);

            string fileName = Path.GetFileName(selectedImagePath);
            string destPath = Path.Combine(imagesFolder, fileName);
            File.Copy(selectedImagePath, destPath, true);

            string relativePath = Path.Combine("BrandLogos", fileName);

            var brand = new Brand
            {
                Name = tbName.contentTextField.Text,
                LogoUrl = relativePath
            };
            MessageBox.Show(brand.Name);
            _db.Brands.Add(brand);
            _db.SaveChanges();
            MessageBox.Show("Brand has added!");
            pbImage.Image = null;
            selectedImagePath = null;
            this.Close();
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
