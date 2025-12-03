using ImperialAuto.Domain.Entities;
using ImperialAuto.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ImperialAuto.WindowsForms
{

    public partial class CarInfo : Form
    {
        private Car _car;
        private readonly ImperialAutoDbContext _db;
        public CarInfo(Car car, ImperialAutoDbContext db)
        {
            InitializeComponent();
            _car = car;
            _db = db;
            LoadCarInfo();
        }
        private void LoadCarInfo()
        {
            
            if (_car == null) return;
            if (_db != null)
            {
                if (_car.Brand == null)
                    _db.Entry(_car).Reference(c => c.Brand).Load();
                if (_car.EngineType == null)
                    _db.Entry(_car).Reference(c => c.EngineType).Load();
                if (_car.Color == null)
                    _db.Entry(_car).Reference(c => c.Color).Load();
            }
            carGallery1.LoadCar(_car);
            lbBrandModel.Content = _car.Brand?.Name.ToString()+" "+_car.Model.ToString();
            lbYear.Content = _car.Year.ToString();

            lbBrandSpec.Text = _car.Brand?.Name.ToString();
            lbModelSpec.Text = _car.Model.ToString();
            lbYearSpec.Text = _car.Year.ToString();
            lbVolumeSpec.Text = _car.Volume.ToString()+"L";
            lbFuelSpec.Text = _car.EngineType.FuelType;
            lbColorSpec.Text = _car.Color.Color;



            lbPriceSpec.Text = "$" + _car.Price.ToString("N0");
        }

        private void lbYear_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Thank you for your order. Our manager will call you shortly to complete your purchase.",
                "Purchase",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
        }
    }
}
