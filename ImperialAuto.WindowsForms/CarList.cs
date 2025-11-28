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
        }

        public void LoadUser()
        {
            var user = _user;

            var brands = _db.Brands.OrderBy(b => b.Name).ToList();
            cbBrand.Items = brands.Select(b => b.Name).ToArray();


        }

        private void CarList_Load(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void cuiLabel1_Load(object sender, EventArgs e)
        {

        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            var form = new CarAddEdit(_db);
            form.Show();

        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            var form = new BrandAdd(_db);
            form.Show();
        }

        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBrandName = cbBrand.SelectedItem.ToString();

            var brand = _db.Brands.FirstOrDefault(b => b.Name == selectedBrandName);

            int brandId = brand.Id;
        }
    }
}
