using ImperialAuto.Domain.Entities;
using ImperialAuto.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Xml.Linq;

namespace ImperialAuto.WindowsForms
{
    public partial class fMain : Form
    {
        private readonly ImperialAutoDbContext _db;
        private bool isLogin = true;
        public fMain()
        {
            InitializeComponent();
            var conn = ConfigurationManager.ConnectionStrings["NeontechConnection"].ConnectionString;
            var options = new DbContextOptionsBuilder<ImperialAutoDbContext>()
                            .UseNpgsql(conn)
                            .Options;
            _db = new ImperialAutoDbContext(options);
            this.Load += fMain_Load;
        }

        public void LoadUsers()
        {
            var users = _db.Users.ToList();
        }

        private void label4_Click(object sender, EventArgs e)
        {

            if (isLogin)
            {
                lbPass.Visible = true;
                tbPass.Visible = true;
                btnLogin.Text = "Register";
                label1.Text = "Register";
                lbText.Text = "Already have an account? Login";
                lbPassword.Visible = false;
                lbNotUser.Visible = false;
                tbUsername.contentTextField.Text=null;
                tbPassword.contentTextField.Text = null;
                isLogin = false;
                cuiPanel1.Size = new System.Drawing.Size(261, 458);
                this.Size = new System.Drawing.Size(301, 521);
                btnLogin.Location = new System.Drawing.Point(17, 392);
                lbText.Location = new System.Drawing.Point(36, 429);
                label1.Location = new System.Drawing.Point(60, 98);
            }
            else if (!isLogin)
            {
                lbPass.Visible = false;
                tbPass.Visible = false;
                btnLogin.Text = "Login";
                label1.Text = "Login";
                lbText.Text = "Don`t have an account?";
                lbCorrectPass.Visible = false;
                lbPassword.Visible = false;
                lbNotUser.Visible = false;
                tbUsername.contentTextField.Text = null;
                tbPassword.contentTextField.Text = null;

                isLogin = true;
                cuiPanel1.Size = new System.Drawing.Size(261, 388);
                this.Size = new System.Drawing.Size(301, 447);
                btnLogin.Location = new System.Drawing.Point(17, 318);
                lbText.Location = new System.Drawing.Point(59, 360);
                label1.Location = new System.Drawing.Point(82, 98);
            }

        }

        private void fMain_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _db.Users.FirstOrDefault(u => u.Name == tbUsername.contentTextField.Text);
            lbNotUser.Visible = false;
            lbPassword.Visible = false;
            if (isLogin)
            {
                if (user == null)
                {
                    tbPassword.contentTextField.Text = null;
                    lbNotUser.Visible = true;
                    return;
                }
                if (user.Password != tbPassword.contentTextField.Text)
                {
                    lbPassword.Visible = true;
                    lbPassword.Text = "Incorrect password";
                    tbPassword.contentTextField.Text = null;
                    
                    return;
                }

                if (user != null && user.Password == tbPassword.contentTextField.Text)
                {
                    if (user.Role == UserRole.Admin)
                    {
                        var form = new CarList(_db, user, user.Role);
                        form.Show();
                        this.Hide();
                    }
                    else if (user.Role == UserRole.User)
                    {
                        var form = new CarList(_db, user, user.Role);
                        form.Show();
                        this.Hide();

                    }
                }

            }
            else if (!isLogin)
            {
                if (user != null)
                {
                    lbNotUser.Visible = true;
                    lbNotUser.Text = "A user with that name already exists!";
                    return;
                }
                else
                {
                    if (tbPassword.contentTextField.Text.Length == 0)
                    {
                        tbPassword.contentTextField.Text = null;
                        tbPass.contentTextField.Text = null;
                        lbPassword.Visible = true;
                        lbPassword.Text = "Enter the password";
                        return;
                    }
                    else
                    {
                        if (tbPassword.contentTextField.Text == tbPass.contentTextField.Text)
                        {
                            var newUser = new User
                            {
                                Name = tbUsername.contentTextField.Text,
                                Password = tbPassword.contentTextField.Text,
                                Role = UserRole.User
                            };

                            _db.Users.Add(newUser);
                            _db.SaveChanges();
                            var form = new CarList(_db, newUser, newUser.Role);
                            form.Show();
                            this.Hide();
                        }
                        else if (tbPassword.contentTextField.Text != tbPass.contentTextField.Text)
                        {
                            lbPassword.Visible = true;
                            lbPassword.Text = "Passwords do not match";
                            lbCorrectPass.Visible = true;
                            tbPassword.contentTextField.Text = null;
                            tbPass.contentTextField.Text = null;

                        }
                    }

                }
            }
        }

        private void lbPass_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
            btnLogin_Click(sender,e);
        }
    }
}
