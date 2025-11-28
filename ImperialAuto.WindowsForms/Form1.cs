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
                btnLogin.Text = "Зареєструватись";
                lbText.Text = "Уже маєте аккаунт?";
                lbPassword.Visible = false;
                lbNotUser.Visible = false;
                tbUsername.Clear();
                tbPassword.Clear();
                isLogin = false;
            }
            else if (!isLogin)
            {
                lbPass.Visible = false;
                tbPass.Visible = false;
                btnLogin.Text = "Увійти";
                lbText.Text = "Не маєте аккаунт?";
                lbPassword.Visible = false;
                lbNotUser.Visible = false;
                tbUsername.Clear();
                tbPassword.Clear();

                isLogin = true;
            }

        }

        private void fMain_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _db.Users.FirstOrDefault(u => u.Name == tbUsername.Text);
            lbNotUser.Visible = false;
            lbPassword.Visible = false;
            if (isLogin)
            {
                if (user == null)
                {
                    tbPassword.Clear();
                    lbNotUser.Visible = true;
                    return;
                }
                if (user.Password != tbPassword.Text)
                {
                    lbPassword.Visible = true;
                    lbPassword.Text = "Не вірний пароль";
                    tbPassword.Clear();
                    return;
                }

                if (user != null && user.Password == tbPassword.Text)
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
                if (user!=null )
                {
                    lbNotUser.Visible = true;
                    lbNotUser.Text = "Користувач з таким ім'ям вже існує!";
                    return;
                }
                else
                {
                    if(tbPassword.Text.Length==0)
                    {
                        tbPassword.Clear();
                        tbPass.Clear();
                        lbPassword.Visible = true;
                        lbPassword.Text = "Введіть пароль";
                        return;
                    }
                    else
                    {
                        if (tbPassword.Text == tbPass.Text)
                        {
                            var newUser = new User
                            {
                                Name = tbUsername.Text,
                                Password = tbPassword.Text,
                                Role = UserRole.User
                            };

                            _db.Users.Add(newUser);
                            _db.SaveChanges();
                            var form = new CarList(_db, newUser, newUser.Role);
                            form.Show();
                            this.Hide();
                        }
                        else if (tbPassword.Text != tbPass.Text)
                        {
                            lbPassword.Visible = true;
                            lbPassword.Text = "Паролі не співпадають";
                            lbCorrectPass.Visible = true;
                            tbPassword.Clear();
                            tbPass.Clear();

                        }
                    }
                    
                }
            }
        }

        private void lbPass_Click(object sender, EventArgs e)
        {

        }
    }
}
