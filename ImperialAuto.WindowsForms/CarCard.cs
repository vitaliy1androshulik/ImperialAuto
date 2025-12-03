using ImperialAuto.Domain.Entities;
using ImperialAuto.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        private ImperialAutoDbContext _db;
        private Car _car { get; set; }
        public event Action OnCarEdited;
        public CarCard(Car car, ImperialAutoDbContext db)
        {
            InitializeComponent();
            _car = car;
            _db = db;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_car == null) return;

            var result = MessageBox.Show(
                "Ви впевнені, що хочете видалити це авто?",
                "Підтвердження",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            try
            {
                var carToDelete = _db.Cars
                    .Include(c => c.ImageUrls)
                    .FirstOrDefault(c => c.Id == _car.Id);

                if (carToDelete == null)
                {
                    MessageBox.Show("Авто не знайдено");
                    return;
                }
                foreach (var img in carToDelete.ImageUrls)
                {
                    if (File.Exists(img.ImageUrl))
                        File.Delete(img.ImageUrl);
                }
                _db.Cars.Remove(carToDelete);
                _db.SaveChanges();

                MessageBox.Show("Авто успішно видалено!");
                OnCarEdited?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при видаленні: " + ex.Message);
            }
            OnCarEdited?.Invoke();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_car == null) return;

            var form = new CarAddEdit(_db, _car);
            form.ShowDialog();
            OnCarEdited?.Invoke();
        }

        private void CarCard_Click(object sender, EventArgs e)
        {
            var form = new CarInfo(_car, _db);
            form.ShowDialog();
        }
    }
}
