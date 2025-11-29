using ImperialAuto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImperialAuto.WindowsForms
{
    public partial class CarCard : UserControl
    {
        public Car _car { get; set; }
        public CarCard(Car car)
        {
            InitializeComponent();
            _car = car;

            LoadCarData();


        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }
        private void LoadCarData()
        {
            if (_car == null) return;

            lbName.Text = _car.Brand?.Name.ToString();
            lbModel.Content = _car.Model ?? "Невідомо";
            lbYear.Content = _car.Year.ToString();
            lbPrice.Content = "$" + _car.Price.ToString("N0");

            if (_car.ImageUrls != null && _car.ImageUrls.Any())
            {
                var firstImage = _car.ImageUrls.First().ImageUrl;
                if (File.Exists(firstImage))
                    cuiPbImage.Content = Image.FromFile(firstImage);
            }
        }
    }
}
