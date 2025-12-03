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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ImperialAuto.WindowsForms
{

    public partial class CarList : Form
    {
        private readonly ImperialAutoDbContext _db;
        private readonly User _user;
        private UserRole _user_role = 0;
        public CarList(ImperialAutoDbContext db, User user, UserRole role)
        {
            InitializeComponent();
            _db = db;
            _user = user;
            _user_role = role;
            this.Load += CarList_Load;
            flPanel.AutoScroll = true;
            flPanel.WrapContents = true;
            flPanel.FlowDirection = FlowDirection.LeftToRight;
            
        }

        public void LoadInfo()
        {
            var user = _user;

            var brands = _db.Brands.OrderBy(b => b.Name).ToList();
            cbBrand.Items = brands.Select(b => b.Name).ToArray();

            flPanel.Controls.Clear();

            var cars = _db.Cars
            .Include(c => c.Brand)
             .Include(c => c.ImageUrls)
             .ToList();

            foreach (var car in cars)
            {
                var card = new CarCard(car, _db);
                card.OnCarEdited += () => LoadInfo();
                flPanel.Controls.Add(card);
            }

        }

        private void CarList_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void cuiLabel1_Load(object sender, EventArgs e)
        {

        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            var form = new CarAddEdit(_db);
            form.ShowDialog();
            LoadInfo();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            var form = new BrandAdd(_db);
            form.Show();
        }

        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBrand.SelectedItem == null)
                return;
            string selectedBrandName = cbBrand.SelectedItem.ToString();

            var brand = _db.Brands.FirstOrDefault(b => b.Name == selectedBrandName);

            if (brand == null)
                return;

            int brandId = brand.Id;

            if (brandId == 11)
            {
                LoadInfo();
            }
            else
            {
                flPanel.Controls.Clear();

                var cars = _db.Cars
                    .Where(c => c.BrandId == brandId)
                    .Include(c => c.Brand)
                    .Include(c => c.ImageUrls)
                    .ToList();
                foreach (var car in cars)
                {
                    flPanel.Controls.Add(new CarCard(car, _db));
                }
            }

        }

        private void cuiTextBox1_ContentChanged(object sender, EventArgs e)
        {
            string query = cuiTextBox1.contentTextField.Text.Trim().ToLower();

            flPanel.Controls.Clear();
            var carsQuery = _db.Cars
                .Include(c => c.Brand)
                .Include(c => c.ImageUrls)
                .AsQueryable();

            if (string.IsNullOrWhiteSpace(query))
            {
                foreach (var car in carsQuery.ToList())
                    flPanel.Controls.Add(new CarCard(car, _db));
                return;
            }
            carsQuery = carsQuery.Where(c =>
                c.Model.ToLower().Contains(query) ||
                c.Brand.Name.ToLower().Contains(query) ||
                c.Year.ToString().Contains(query) ||
                c.Price.ToString().Contains(query)
            );
            foreach (var car in carsQuery.ToList())
                flPanel.Controls.Add(new CarCard(car, _db));
        }
    }
}
