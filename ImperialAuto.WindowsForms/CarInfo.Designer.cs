namespace ImperialAuto.WindowsForms
{
    partial class CarInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarInfo));
            carGallery1 = new CarGallery();
            lbBrandModel = new CuoreUI.Controls.cuiLabel();
            lbYear = new CuoreUI.Controls.cuiLabel();
            label1 = new Label();
            cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
            label2 = new Label();
            lbBrandSpec = new Label();
            lbModelSpec = new Label();
            label4 = new Label();
            lbYearSpec = new Label();
            label6 = new Label();
            lbColorSpec = new Label();
            label8 = new Label();
            lbFuelSpec = new Label();
            label10 = new Label();
            lbVolumeSpec = new Label();
            label12 = new Label();
            label13 = new Label();
            lbPriceSpec = new Label();
            btnBuy = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // carGallery1
            // 
            carGallery1.BackColor = Color.FromArgb(28, 27, 32);
            carGallery1.Dock = DockStyle.Fill;
            carGallery1.Location = new Point(0, 0);
            carGallery1.Name = "carGallery1";
            carGallery1.Size = new Size(861, 921);
            carGallery1.TabIndex = 0;
            // 
            // lbBrandModel
            // 
            lbBrandModel.BackColor = Color.FromArgb(28, 27, 32);
            lbBrandModel.Content = "Mercedes\\ benz\\ ";
            lbBrandModel.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbBrandModel.ForeColor = Color.FromArgb(212, 175, 55);
            lbBrandModel.HorizontalAlignment = StringAlignment.Near;
            lbBrandModel.Location = new Point(13, 484);
            lbBrandModel.Margin = new Padding(4, 3, 4, 3);
            lbBrandModel.Name = "lbBrandModel";
            lbBrandModel.Size = new Size(590, 73);
            lbBrandModel.TabIndex = 1;
            lbBrandModel.VerticalAlignment = StringAlignment.Near;
            // 
            // lbYear
            // 
            lbYear.BackColor = Color.FromArgb(28, 27, 32);
            lbYear.Content = "22";
            lbYear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbYear.ForeColor = Color.FromArgb(212, 175, 55);
            lbYear.HorizontalAlignment = StringAlignment.Near;
            lbYear.Location = new Point(18, 527);
            lbYear.Margin = new Padding(4, 3, 4, 3);
            lbYear.Name = "lbYear";
            lbYear.Size = new Size(245, 30);
            lbYear.TabIndex = 2;
            lbYear.VerticalAlignment = StringAlignment.Near;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(28, 27, 32);
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(212, 175, 55);
            label1.Location = new Point(13, 602);
            label1.Name = "label1";
            label1.Size = new Size(231, 47);
            label1.TabIndex = 3;
            label1.Text = "Specifications";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cuiSeparator1
            // 
            cuiSeparator1.BackColor = Color.FromArgb(28, 27, 32);
            cuiSeparator1.ForeColor = Color.FromArgb(128, 128, 128, 128);
            cuiSeparator1.Location = new Point(13, 570);
            cuiSeparator1.Margin = new Padding(4, 3, 4, 3);
            cuiSeparator1.Name = "cuiSeparator1";
            cuiSeparator1.SeparatorMargin = 8;
            cuiSeparator1.Size = new Size(835, 24);
            cuiSeparator1.TabIndex = 4;
            cuiSeparator1.Thickness = 0.5F;
            cuiSeparator1.Vertical = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(28, 27, 32);
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(212, 175, 55);
            label2.Location = new Point(18, 663);
            label2.Name = "label2";
            label2.Size = new Size(76, 32);
            label2.TabIndex = 5;
            label2.Text = "Brand";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbBrandSpec
            // 
            lbBrandSpec.AutoSize = true;
            lbBrandSpec.BackColor = Color.FromArgb(28, 27, 32);
            lbBrandSpec.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbBrandSpec.ForeColor = Color.FromArgb(212, 175, 55);
            lbBrandSpec.Location = new Point(282, 663);
            lbBrandSpec.Name = "lbBrandSpec";
            lbBrandSpec.Size = new Size(68, 32);
            lbBrandSpec.TabIndex = 6;
            lbBrandSpec.Text = "Merc";
            lbBrandSpec.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbModelSpec
            // 
            lbModelSpec.AutoSize = true;
            lbModelSpec.BackColor = Color.FromArgb(28, 27, 32);
            lbModelSpec.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbModelSpec.ForeColor = Color.FromArgb(212, 175, 55);
            lbModelSpec.Location = new Point(282, 704);
            lbModelSpec.Name = "lbModelSpec";
            lbModelSpec.Size = new Size(36, 32);
            lbModelSpec.TabIndex = 8;
            lbModelSpec.Text = "W";
            lbModelSpec.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(28, 27, 32);
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.FromArgb(212, 175, 55);
            label4.Location = new Point(18, 704);
            label4.Name = "label4";
            label4.Size = new Size(83, 32);
            label4.TabIndex = 7;
            label4.Text = "Model";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label4.Click += label4_Click;
            // 
            // lbYearSpec
            // 
            lbYearSpec.AutoSize = true;
            lbYearSpec.BackColor = Color.FromArgb(28, 27, 32);
            lbYearSpec.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbYearSpec.ForeColor = Color.FromArgb(212, 175, 55);
            lbYearSpec.Location = new Point(282, 745);
            lbYearSpec.Name = "lbYearSpec";
            lbYearSpec.Size = new Size(40, 32);
            lbYearSpec.TabIndex = 10;
            lbYearSpec.Text = "22";
            lbYearSpec.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(28, 27, 32);
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.FromArgb(212, 175, 55);
            label6.Location = new Point(18, 745);
            label6.Name = "label6";
            label6.Size = new Size(58, 32);
            label6.TabIndex = 9;
            label6.Text = "Year";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbColorSpec
            // 
            lbColorSpec.AutoSize = true;
            lbColorSpec.BackColor = Color.FromArgb(28, 27, 32);
            lbColorSpec.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbColorSpec.ForeColor = Color.FromArgb(212, 175, 55);
            lbColorSpec.Location = new Point(282, 868);
            lbColorSpec.Name = "lbColorSpec";
            lbColorSpec.Size = new Size(78, 32);
            lbColorSpec.TabIndex = 16;
            lbColorSpec.Text = "Green";
            lbColorSpec.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(28, 27, 32);
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.FromArgb(212, 175, 55);
            label8.Location = new Point(18, 868);
            label8.Name = "label8";
            label8.Size = new Size(71, 32);
            label8.TabIndex = 15;
            label8.Text = "Color";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbFuelSpec
            // 
            lbFuelSpec.AutoSize = true;
            lbFuelSpec.BackColor = Color.FromArgb(28, 27, 32);
            lbFuelSpec.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbFuelSpec.ForeColor = Color.FromArgb(212, 175, 55);
            lbFuelSpec.Location = new Point(282, 827);
            lbFuelSpec.Name = "lbFuelSpec";
            lbFuelSpec.Size = new Size(79, 32);
            lbFuelSpec.TabIndex = 14;
            lbFuelSpec.Text = "Diesel";
            lbFuelSpec.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(28, 27, 32);
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.FromArgb(212, 175, 55);
            label10.Location = new Point(18, 827);
            label10.Name = "label10";
            label10.Size = new Size(59, 32);
            label10.TabIndex = 13;
            label10.Text = "Fuel";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbVolumeSpec
            // 
            lbVolumeSpec.AutoSize = true;
            lbVolumeSpec.BackColor = Color.FromArgb(28, 27, 32);
            lbVolumeSpec.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbVolumeSpec.ForeColor = Color.FromArgb(212, 175, 55);
            lbVolumeSpec.Location = new Point(282, 786);
            lbVolumeSpec.Name = "lbVolumeSpec";
            lbVolumeSpec.Size = new Size(63, 32);
            lbVolumeSpec.TabIndex = 12;
            lbVolumeSpec.Text = "2.2 L";
            lbVolumeSpec.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(28, 27, 32);
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label12.ForeColor = Color.FromArgb(212, 175, 55);
            label12.Location = new Point(18, 786);
            label12.Name = "label12";
            label12.Size = new Size(95, 32);
            label12.TabIndex = 11;
            label12.Text = "Volume";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(28, 27, 32);
            label13.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label13.ForeColor = Color.FromArgb(212, 175, 55);
            label13.Location = new Point(607, 602);
            label13.Name = "label13";
            label13.Size = new Size(94, 47);
            label13.TabIndex = 17;
            label13.Text = "Price";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbPriceSpec
            // 
            lbPriceSpec.AutoSize = true;
            lbPriceSpec.BackColor = Color.FromArgb(28, 27, 32);
            lbPriceSpec.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbPriceSpec.ForeColor = Color.FromArgb(212, 175, 55);
            lbPriceSpec.Location = new Point(607, 663);
            lbPriceSpec.Name = "lbPriceSpec";
            lbPriceSpec.Size = new Size(213, 65);
            lbPriceSpec.TabIndex = 18;
            lbPriceSpec.Text = "$123,123";
            lbPriceSpec.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.FromArgb(28, 27, 32);
            btnBuy.CheckButton = false;
            btnBuy.Checked = false;
            btnBuy.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnBuy.CheckedForeColor = Color.White;
            btnBuy.CheckedImageTint = Color.White;
            btnBuy.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnBuy.Content = "Buy now!";
            btnBuy.DialogResult = DialogResult.None;
            btnBuy.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnBuy.ForeColor = Color.FromArgb(212, 175, 55);
            btnBuy.HoverBackground = Color.White;
            btnBuy.HoverForeColor = Color.Black;
            btnBuy.HoverImageTint = Color.White;
            btnBuy.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnBuy.Image = null;
            btnBuy.ImageAutoCenter = true;
            btnBuy.ImageExpand = new Point(0, 0);
            btnBuy.ImageOffset = new Point(0, 0);
            btnBuy.Location = new Point(681, 855);
            btnBuy.Name = "btnBuy";
            btnBuy.NormalBackground = Color.FromArgb(28, 27, 32);
            btnBuy.NormalForeColor = Color.FromArgb(212, 175, 55);
            btnBuy.NormalImageTint = Color.White;
            btnBuy.NormalOutline = Color.FromArgb(212, 175, 55);
            btnBuy.OutlineThickness = 3F;
            btnBuy.PressedBackground = Color.WhiteSmoke;
            btnBuy.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnBuy.PressedImageTint = Color.White;
            btnBuy.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnBuy.Rounding = new Padding(8);
            btnBuy.Size = new Size(153, 45);
            btnBuy.TabIndex = 19;
            btnBuy.TextAlignment = StringAlignment.Center;
            btnBuy.TextOffset = new Point(0, 0);
            btnBuy.Click += btnBuy_Click;
            // 
            // CarInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 921);
            Controls.Add(btnBuy);
            Controls.Add(lbPriceSpec);
            Controls.Add(label13);
            Controls.Add(lbColorSpec);
            Controls.Add(label8);
            Controls.Add(lbFuelSpec);
            Controls.Add(label10);
            Controls.Add(lbVolumeSpec);
            Controls.Add(label12);
            Controls.Add(lbYearSpec);
            Controls.Add(label6);
            Controls.Add(lbModelSpec);
            Controls.Add(label4);
            Controls.Add(lbBrandSpec);
            Controls.Add(label2);
            Controls.Add(cuiSeparator1);
            Controls.Add(label1);
            Controls.Add(lbYear);
            Controls.Add(lbBrandModel);
            Controls.Add(carGallery1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CarInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CarGallery carGallery1;
        private CuoreUI.Controls.cuiLabel lbBrandModel;
        private CuoreUI.Controls.cuiLabel lbYear;
        private Label label1;
        private CuoreUI.Controls.cuiSeparator cuiSeparator1;
        private Label label2;
        private Label lbBrandSpec;
        private Label lbModelSpec;
        private Label label4;
        private Label lbYearSpec;
        private Label label6;
        private Label lbColorSpec;
        private Label label8;
        private Label lbFuelSpec;
        private Label label10;
        private Label lbVolumeSpec;
        private Label label12;
        private Label label13;
        private Label lbPriceSpec;
        private CuoreUI.Controls.cuiButton btnBuy;
    }
}