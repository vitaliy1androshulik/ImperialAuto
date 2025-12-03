namespace ImperialAuto.WindowsForms
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            label1 = new Label();
            lbText = new Label();
            label2 = new Label();
            label3 = new Label();
            lbPass = new Label();
            lbCorrectPass = new Label();
            lbPassword = new Label();
            lbNotUser = new Label();
            pictureBox1 = new PictureBox();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            tbPassword = new CuoreUI.Controls.cuiTextBox();
            btnLogin = new CuoreUI.Controls.cuiButton();
            tbPass = new CuoreUI.Controls.cuiTextBox();
            tbUsername = new CuoreUI.Controls.cuiTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(212, 175, 55);
            label1.Location = new Point(82, 98);
            label1.Name = "label1";
            label1.Size = new Size(104, 45);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // lbText
            // 
            lbText.AutoSize = true;
            lbText.BackColor = Color.Transparent;
            lbText.Cursor = Cursors.Hand;
            lbText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbText.ForeColor = Color.FromArgb(212, 175, 55);
            lbText.Location = new Point(59, 360);
            lbText.Name = "lbText";
            lbText.Size = new Size(143, 17);
            lbText.TabIndex = 6;
            lbText.Text = "Don`t have an account?";
            lbText.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(212, 175, 55);
            label2.Location = new Point(17, 154);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 9;
            label2.Text = "User name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(212, 175, 55);
            label3.Location = new Point(17, 232);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.BackColor = Color.Transparent;
            lbPass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbPass.ForeColor = Color.FromArgb(212, 175, 55);
            lbPass.Location = new Point(17, 306);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(164, 25);
            lbPass.TabIndex = 11;
            lbPass.Text = "Confirm Password";
            lbPass.Visible = false;
            lbPass.Click += lbPass_Click;
            // 
            // lbCorrectPass
            // 
            lbCorrectPass.AutoSize = true;
            lbCorrectPass.BackColor = Color.Transparent;
            lbCorrectPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbCorrectPass.ForeColor = Color.IndianRed;
            lbCorrectPass.Location = new Point(17, 366);
            lbCorrectPass.Name = "lbCorrectPass";
            lbCorrectPass.Size = new Size(137, 15);
            lbCorrectPass.TabIndex = 12;
            lbCorrectPass.Text = "Passwords do not match";
            lbCorrectPass.Visible = false;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.BackColor = Color.Transparent;
            lbPassword.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbPassword.ForeColor = Color.IndianRed;
            lbPassword.Location = new Point(14, 293);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(133, 26);
            lbPassword.TabIndex = 13;
            lbPassword.Text = "\r\nPasswords do not match";
            lbPassword.Visible = false;
            // 
            // lbNotUser
            // 
            lbNotUser.AutoSize = true;
            lbNotUser.BackColor = Color.Transparent;
            lbNotUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbNotUser.ForeColor = Color.IndianRed;
            lbNotUser.Location = new Point(17, 215);
            lbNotUser.Name = "lbNotUser";
            lbNotUser.Size = new Size(86, 15);
            lbNotUser.TabIndex = 14;
            lbNotUser.Text = "User not found";
            lbNotUser.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.iconImp;
            pictureBox1.Location = new Point(76, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(tbPassword);
            cuiPanel1.Controls.Add(lbPassword);
            cuiPanel1.Controls.Add(lbText);
            cuiPanel1.Controls.Add(btnLogin);
            cuiPanel1.Controls.Add(tbPass);
            cuiPanel1.Controls.Add(tbUsername);
            cuiPanel1.Controls.Add(label1);
            cuiPanel1.Controls.Add(pictureBox1);
            cuiPanel1.Controls.Add(lbNotUser);
            cuiPanel1.Controls.Add(lbCorrectPass);
            cuiPanel1.Controls.Add(lbPass);
            cuiPanel1.Controls.Add(label3);
            cuiPanel1.Controls.Add(label2);
            cuiPanel1.Location = new Point(12, 12);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 3F;
            cuiPanel1.PanelColor = Color.FromArgb(42, 46, 48);
            cuiPanel1.PanelOutlineColor = Color.FromArgb(212, 175, 55);
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(261, 388);
            cuiPanel1.TabIndex = 16;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.Transparent;
            tbPassword.BackgroundColor = Color.FromArgb(28, 29, 32);
            tbPassword.Content = "";
            tbPassword.FocusBackgroundColor = Color.FromArgb(28, 29, 32);
            tbPassword.FocusImageTint = Color.White;
            tbPassword.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            tbPassword.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.ForeColor = Color.DimGray;
            tbPassword.Image = null;
            tbPassword.ImageExpand = new Point(0, 0);
            tbPassword.ImageOffset = new Point(0, 0);
            tbPassword.Location = new Point(17, 258);
            tbPassword.Margin = new Padding(4);
            tbPassword.Multiline = false;
            tbPassword.Name = "tbPassword";
            tbPassword.NormalImageTint = Color.Wheat;
            tbPassword.OutlineColor = Color.FromArgb(212, 175, 55);
            tbPassword.Padding = new Padding(16, 7, 16, 0);
            tbPassword.PasswordChar = true;
            tbPassword.PlaceholderColor = Color.DimGray;
            tbPassword.PlaceholderText = "Password";
            tbPassword.Rounding = new Padding(15);
            tbPassword.Size = new Size(226, 30);
            tbPassword.TabIndex = 17;
            tbPassword.TextOffset = new Size(0, 0);
            tbPassword.UnderlinedStyle = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.CheckButton = false;
            btnLogin.Checked = false;
            btnLogin.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnLogin.CheckedForeColor = Color.White;
            btnLogin.CheckedImageTint = Color.White;
            btnLogin.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnLogin.Content = "Login";
            btnLogin.DialogResult = DialogResult.None;
            btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLogin.ForeColor = Color.Black;
            btnLogin.HoverBackground = Color.FromArgb(200, 170, 50);
            btnLogin.HoverForeColor = Color.Black;
            btnLogin.HoverImageTint = Color.White;
            btnLogin.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnLogin.Image = null;
            btnLogin.ImageAutoCenter = true;
            btnLogin.ImageExpand = new Point(0, 0);
            btnLogin.ImageOffset = new Point(0, 0);
            btnLogin.Location = new Point(17, 318);
            btnLogin.Name = "btnLogin";
            btnLogin.NormalBackground = Color.FromArgb(212, 175, 55);
            btnLogin.NormalForeColor = Color.Black;
            btnLogin.NormalImageTint = Color.White;
            btnLogin.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnLogin.OutlineThickness = 1F;
            btnLogin.PressedBackground = Color.FromArgb(205, 155, 25);
            btnLogin.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnLogin.PressedImageTint = Color.White;
            btnLogin.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnLogin.Rounding = new Padding(8);
            btnLogin.Size = new Size(226, 33);
            btnLogin.TabIndex = 19;
            btnLogin.TextAlignment = StringAlignment.Center;
            btnLogin.TextOffset = new Point(0, 0);
            btnLogin.Click += btnLogin_Click;
            // 
            // tbPass
            // 
            tbPass.BackColor = Color.Transparent;
            tbPass.BackgroundColor = Color.FromArgb(28, 29, 32);
            tbPass.Content = "";
            tbPass.FocusBackgroundColor = Color.FromArgb(28, 29, 32);
            tbPass.FocusImageTint = Color.White;
            tbPass.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            tbPass.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPass.ForeColor = Color.DimGray;
            tbPass.Image = null;
            tbPass.ImageExpand = new Point(0, 0);
            tbPass.ImageOffset = new Point(0, 0);
            tbPass.Location = new Point(17, 332);
            tbPass.Margin = new Padding(4);
            tbPass.Multiline = false;
            tbPass.Name = "tbPass";
            tbPass.NormalImageTint = Color.Wheat;
            tbPass.OutlineColor = Color.FromArgb(212, 175, 55);
            tbPass.Padding = new Padding(16, 7, 16, 0);
            tbPass.PasswordChar = true;
            tbPass.PlaceholderColor = Color.DimGray;
            tbPass.PlaceholderText = "Confirm Password";
            tbPass.Rounding = new Padding(15);
            tbPass.Size = new Size(226, 30);
            tbPass.TabIndex = 18;
            tbPass.TextOffset = new Size(0, 0);
            tbPass.UnderlinedStyle = true;
            tbPass.Visible = false;
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.Transparent;
            tbUsername.BackgroundColor = Color.FromArgb(28, 29, 32);
            tbUsername.Content = "";
            tbUsername.FocusBackgroundColor = Color.FromArgb(28, 29, 32);
            tbUsername.FocusImageTint = Color.White;
            tbUsername.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            tbUsername.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.ForeColor = Color.DimGray;
            tbUsername.Image = null;
            tbUsername.ImageExpand = new Point(0, 0);
            tbUsername.ImageOffset = new Point(0, 0);
            tbUsername.Location = new Point(17, 181);
            tbUsername.Margin = new Padding(4);
            tbUsername.Multiline = false;
            tbUsername.Name = "tbUsername";
            tbUsername.NormalImageTint = Color.Wheat;
            tbUsername.OutlineColor = Color.FromArgb(212, 175, 55);
            tbUsername.Padding = new Padding(16, 7, 16, 0);
            tbUsername.PasswordChar = false;
            tbUsername.PlaceholderColor = Color.DimGray;
            tbUsername.PlaceholderText = "User name";
            tbUsername.Rounding = new Padding(15);
            tbUsername.Size = new Size(226, 30);
            tbUsername.TabIndex = 16;
            tbUsername.TextOffset = new Size(0, 0);
            tbUsername.UnderlinedStyle = true;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 4, 5);
            ClientSize = new Size(285, 408);
            Controls.Add(cuiPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Imperial Auto";
            Load += fMain_Load;
            Enter += btnLogin_Enter;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lbText;
        private Label label2;
        private Label label3;
        private Label lbPass;
        private Label lbCorrectPass;
        private Label lbPassword;
        private Label lbNotUser;
        private PictureBox pictureBox1;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiTextBox tbUsername;
        private CuoreUI.Controls.cuiTextBox tbPass;
        private CuoreUI.Controls.cuiTextBox tbPassword;
        private CuoreUI.Controls.cuiButton btnLogin;
    }
}
