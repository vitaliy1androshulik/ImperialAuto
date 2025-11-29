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
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnLogin = new Button();
            lbText = new Label();
            tbPass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lbPass = new Label();
            lbCorrectPass = new Label();
            lbPassword = new Label();
            lbNotUser = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 64);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(244, 97);
            label1.TabIndex = 0;
            label1.Text = "Логін";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Palatino Linotype", 11.25F);
            tbUsername.Location = new Point(54, 301);
            tbUsername.Margin = new Padding(6, 7, 6, 7);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(501, 53);
            tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Palatino Linotype", 11.25F);
            tbPassword.Location = new Point(54, 491);
            tbPassword.Margin = new Padding(6, 7, 6, 7);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(501, 53);
            tbPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Palatino Linotype", 9F);
            btnLogin.Location = new Point(54, 819);
            btnLogin.Margin = new Padding(6, 7, 6, 7);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(225, 62);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Увійти";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            btnLogin.Enter += btnLogin_Enter;
            // 
            // lbText
            // 
            lbText.AutoSize = true;
            lbText.BackColor = Color.Transparent;
            lbText.Cursor = Cursors.Hand;
            lbText.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbText.ForeColor = SystemColors.Highlight;
            lbText.Location = new Point(319, 829);
            lbText.Margin = new Padding(6, 0, 6, 0);
            lbText.Name = "lbText";
            lbText.Size = new Size(240, 36);
            lbText.TabIndex = 6;
            lbText.Text = "Не маєте аккаунт?";
            lbText.Click += label4_Click;
            // 
            // tbPass
            // 
            tbPass.Font = new Font("Palatino Linotype", 11.25F);
            tbPass.Location = new Point(54, 673);
            tbPass.Margin = new Padding(6, 7, 6, 7);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(501, 53);
            tbPass.TabIndex = 8;
            tbPass.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(54, 227);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(364, 58);
            label2.TabIndex = 9;
            label2.Text = "Ім'я користувача";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(54, 419);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(178, 58);
            label3.TabIndex = 10;
            label3.Text = "Пароль";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbPass.Location = new Point(54, 602);
            lbPass.Margin = new Padding(6, 0, 6, 0);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(495, 58);
            lbPass.TabIndex = 11;
            lbPass.Text = "Підтвердження пароля";
            lbPass.Visible = false;
            lbPass.Click += lbPass_Click;
            // 
            // lbCorrectPass
            // 
            lbCorrectPass.AutoSize = true;
            lbCorrectPass.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbCorrectPass.ForeColor = Color.IndianRed;
            lbCorrectPass.Location = new Point(54, 750);
            lbCorrectPass.Margin = new Padding(6, 0, 6, 0);
            lbCorrectPass.Name = "lbCorrectPass";
            lbCorrectPass.Size = new Size(299, 36);
            lbCorrectPass.TabIndex = 12;
            lbCorrectPass.Text = "Паролі не співпадають";
            lbCorrectPass.Visible = false;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbPassword.ForeColor = Color.IndianRed;
            lbPassword.Location = new Point(54, 567);
            lbPassword.Margin = new Padding(6, 0, 6, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(299, 36);
            lbPassword.TabIndex = 13;
            lbPassword.Text = "Паролі не співпадають";
            lbPassword.Visible = false;
            // 
            // lbNotUser
            // 
            lbNotUser.AutoSize = true;
            lbNotUser.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbNotUser.ForeColor = Color.IndianRed;
            lbNotUser.Location = new Point(54, 377);
            lbNotUser.Margin = new Padding(6, 0, 6, 0);
            lbNotUser.Name = "lbNotUser";
            lbNotUser.Size = new Size(329, 36);
            lbNotUser.TabIndex = 14;
            lbNotUser.Text = "Користувача не знайдено";
            lbNotUser.Visible = false;
            // 
            // fMain
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 932);
            Controls.Add(lbNotUser);
            Controls.Add(lbPassword);
            Controls.Add(lbCorrectPass);
            Controls.Add(lbPass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbPass);
            Controls.Add(lbText);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 7, 6, 7);
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Imperial Auto";
            Load += fMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnLogin;
        private Label lbText;
        private TextBox tbPass;
        private Label label2;
        private Label label3;
        private Label lbPass;
        private Label lbCorrectPass;
        private Label lbPassword;
        private Label lbNotUser;
    }
}
