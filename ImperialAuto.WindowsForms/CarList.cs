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
        }

        private void CarList_Load(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void cuiLabel1_Load(object sender, EventArgs e)
        {

        }
    }
}
