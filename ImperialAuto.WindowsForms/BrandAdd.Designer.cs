namespace ImperialAuto.WindowsForms
{
    partial class BrandAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandAdd));
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            pbImage = new PictureBox();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            cuiButton2 = new CuoreUI.Controls.cuiButton();
            cuiLabel9 = new CuoreUI.Controls.cuiLabel();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            tbName = new CuoreUI.Controls.cuiTextBox();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(pbImage);
            cuiPanel1.Controls.Add(cuiButton1);
            cuiPanel1.Controls.Add(cuiButton2);
            cuiPanel1.Controls.Add(cuiLabel9);
            cuiPanel1.Controls.Add(cuiLabel3);
            cuiPanel1.Controls.Add(tbName);
            cuiPanel1.Controls.Add(cuiLabel1);
            cuiPanel1.Location = new Point(12, 12);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 2F;
            cuiPanel1.PanelColor = Color.FromArgb(42, 46, 48);
            cuiPanel1.PanelOutlineColor = Color.FromArgb(212, 175, 55);
            cuiPanel1.Rounding = new Padding(12);
            cuiPanel1.Size = new Size(466, 449);
            cuiPanel1.TabIndex = 1;
            // 
            // pbImage
            // 
            pbImage.BackColor = Color.WhiteSmoke;
            pbImage.Image = (Image)resources.GetObject("pbImage.Image");
            pbImage.InitialImage = (Image)resources.GetObject("pbImage.InitialImage");
            pbImage.Location = new Point(19, 204);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(184, 166);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 23;
            pbImage.TabStop = false;
            pbImage.Click += pictureBox1_Click;
            // 
            // cuiButton1
            // 
            cuiButton1.BackColor = Color.Transparent;
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "Save";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cuiButton1.ForeColor = Color.FromArgb(2, 4, 2);
            cuiButton1.HoverBackground = Color.White;
            cuiButton1.HoverForeColor = Color.Black;
            cuiButton1.HoverImageTint = Color.White;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.ImageOffset = new Point(0, 0);
            cuiButton1.Location = new Point(75, 390);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.FromArgb(212, 175, 55);
            cuiButton1.NormalForeColor = Color.FromArgb(2, 4, 2);
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.FromArgb(212, 175, 55);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(12);
            cuiButton1.Size = new Size(149, 45);
            cuiButton1.TabIndex = 22;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 0);
            cuiButton1.Click += cuiButton1_Click;
            // 
            // cuiButton2
            // 
            cuiButton2.BackColor = Color.Transparent;
            cuiButton2.CheckButton = false;
            cuiButton2.Checked = false;
            cuiButton2.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton2.CheckedForeColor = Color.White;
            cuiButton2.CheckedImageTint = Color.White;
            cuiButton2.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton2.Content = "Cancel";
            cuiButton2.DialogResult = DialogResult.None;
            cuiButton2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cuiButton2.ForeColor = Color.FromArgb(212, 175, 55);
            cuiButton2.HoverBackground = Color.White;
            cuiButton2.HoverForeColor = Color.Black;
            cuiButton2.HoverImageTint = Color.White;
            cuiButton2.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton2.Image = null;
            cuiButton2.ImageAutoCenter = true;
            cuiButton2.ImageExpand = new Point(0, 0);
            cuiButton2.ImageOffset = new Point(0, 0);
            cuiButton2.Location = new Point(263, 390);
            cuiButton2.Name = "cuiButton2";
            cuiButton2.NormalBackground = Color.FromArgb(2, 4, 2);
            cuiButton2.NormalForeColor = Color.FromArgb(212, 175, 55);
            cuiButton2.NormalImageTint = Color.White;
            cuiButton2.NormalOutline = Color.FromArgb(212, 175, 55);
            cuiButton2.OutlineThickness = 1F;
            cuiButton2.PressedBackground = Color.WhiteSmoke;
            cuiButton2.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton2.PressedImageTint = Color.White;
            cuiButton2.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton2.Rounding = new Padding(12);
            cuiButton2.Size = new Size(143, 45);
            cuiButton2.TabIndex = 21;
            cuiButton2.TextAlignment = StringAlignment.Center;
            cuiButton2.TextOffset = new Point(0, 0);
            cuiButton2.Click += cuiButton2_Click;
            // 
            // cuiLabel9
            // 
            cuiLabel9.BackColor = Color.Transparent;
            cuiLabel9.Content = "Image\\ Upload\\ \\(Click\\ to\\ Upload\\)";
            cuiLabel9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cuiLabel9.ForeColor = Color.FromArgb(212, 175, 55);
            cuiLabel9.HorizontalAlignment = StringAlignment.Center;
            cuiLabel9.Location = new Point(19, 173);
            cuiLabel9.Margin = new Padding(4, 3, 4, 3);
            cuiLabel9.Name = "cuiLabel9";
            cuiLabel9.Size = new Size(286, 25);
            cuiLabel9.TabIndex = 20;
            cuiLabel9.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel3
            // 
            cuiLabel3.BackColor = Color.Transparent;
            cuiLabel3.Content = "Brand\\ Name";
            cuiLabel3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cuiLabel3.ForeColor = Color.FromArgb(212, 175, 55);
            cuiLabel3.HorizontalAlignment = StringAlignment.Center;
            cuiLabel3.Location = new Point(19, 76);
            cuiLabel3.Margin = new Padding(4, 3, 4, 3);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(132, 29);
            cuiLabel3.TabIndex = 7;
            cuiLabel3.VerticalAlignment = StringAlignment.Near;
            // 
            // tbName
            // 
            tbName.BackColor = Color.Transparent;
            tbName.BackgroundColor = Color.FromArgb(28, 29, 32);
            tbName.Content = "";
            tbName.FocusBackgroundColor = Color.White;
            tbName.FocusImageTint = Color.White;
            tbName.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            tbName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbName.ForeColor = Color.DimGray;
            tbName.Image = null;
            tbName.ImageExpand = new Point(0, 0);
            tbName.ImageOffset = new Point(0, 0);
            tbName.Location = new Point(19, 112);
            tbName.Margin = new Padding(4);
            tbName.Multiline = false;
            tbName.Name = "tbName";
            tbName.NormalImageTint = Color.White;
            tbName.OutlineColor = Color.FromArgb(212, 175, 55);
            tbName.Padding = new Padding(22, 9, 22, 0);
            tbName.PasswordChar = false;
            tbName.PlaceholderColor = Color.Gray;
            tbName.PlaceholderText = "Name";
            tbName.Rounding = new Padding(15);
            tbName.Size = new Size(417, 41);
            tbName.TabIndex = 6;
            tbName.TextOffset = new Size(0, 0);
            tbName.UnderlinedStyle = true;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Add\\ Car\\ Brand";
            cuiLabel1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cuiLabel1.ForeColor = Color.FromArgb(212, 175, 55);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(75, 16);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(331, 54);
            cuiLabel1.TabIndex = 0;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // BrandAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 4, 5);
            ClientSize = new Size(492, 473);
            Controls.Add(cuiPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BrandAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Brand";
            cuiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private CuoreUI.Controls.cuiLabel cuiLabel9;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiTextBox tbName;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private PictureBox pbImage;
    }
}