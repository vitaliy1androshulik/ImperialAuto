namespace ImperialAuto.WindowsForms
{
    partial class CarList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarList));
            pictureBox1 = new PictureBox();
            panelTop = new CuoreUI.Controls.cuiPanel();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            cbBrand = new CuoreUI.Controls.cuiComboBox();
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            cuiButton2 = new CuoreUI.Controls.cuiButton();
            btnAddBrand = new CuoreUI.Controls.cuiButton();
            flPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTop.SuspendLayout();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.iconImp;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(cuiPanel1);
            panelTop.Controls.Add(cuiButton1);
            panelTop.Controls.Add(cuiLabel1);
            panelTop.Controls.Add(pictureBox1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.OutlineThickness = 1F;
            panelTop.PanelColor = Color.FromArgb(0, 4, 5);
            panelTop.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            panelTop.Rounding = new Padding(0, 0, 45, 45);
            panelTop.Size = new Size(1062, 438);
            panelTop.TabIndex = 2;
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackColor = Color.Transparent;
            cuiPanel1.Controls.Add(cbBrand);
            cuiPanel1.Controls.Add(cuiTextBox1);
            cuiPanel1.Controls.Add(cuiLabel3);
            cuiPanel1.Controls.Add(cuiLabel2);
            cuiPanel1.Controls.Add(cuiSeparator1);
            cuiPanel1.Location = new Point(28, 161);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 2F;
            cuiPanel1.PanelColor = Color.FromArgb(42, 46, 48);
            cuiPanel1.PanelOutlineColor = Color.FromArgb(212, 175, 55);
            cuiPanel1.Rounding = new Padding(15);
            cuiPanel1.Size = new Size(1004, 234);
            cuiPanel1.TabIndex = 3;
            // 
            // cbBrand
            // 
            cbBrand.BackgroundColor = Color.FromArgb(28, 29, 32);
            cbBrand.DropDownBackgroundColor = Color.FromArgb(28, 29, 32);
            cbBrand.DropDownForeColor = Color.FromArgb(212, 175, 55);
            cbBrand.ExpandArrowColor = Color.Gray;
            cbBrand.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbBrand.ForeColor = Color.FromArgb(212, 175, 55);
            cbBrand.Items = new string[]
    {
    "Item 1",
    "Item 2",
    "Item 3"
    };
            cbBrand.Location = new Point(21, 170);
            cbBrand.Margin = new Padding(5, 4, 5, 4);
            cbBrand.Name = "cbBrand";
            cbBrand.NoSelectionText = "Brand";
            cbBrand.OutlineColor = Color.FromArgb(212, 175, 55);
            cbBrand.OutlineThickness = 1F;
            cbBrand.RightToLeft = RightToLeft.No;
            cbBrand.Rounding = 25;
            cbBrand.SelectedIndex = -1;
            cbBrand.SelectedItem = "";
            cbBrand.Size = new Size(959, 51);
            cbBrand.SortAlphabetically = true;
            cbBrand.TabIndex = 4;
            cbBrand.SelectedIndexChanged += cbBrand_SelectedIndexChanged;
            // 
            // cuiTextBox1
            // 
            cuiTextBox1.BackgroundColor = Color.FromArgb(28, 29, 32);
            cuiTextBox1.Content = "";
            cuiTextBox1.FocusBackgroundColor = Color.White;
            cuiTextBox1.FocusImageTint = Color.White;
            cuiTextBox1.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            cuiTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cuiTextBox1.ForeColor = Color.DimGray;
            cuiTextBox1.Image = null;
            cuiTextBox1.ImageExpand = new Point(0, 0);
            cuiTextBox1.ImageOffset = new Point(0, 0);
            cuiTextBox1.Location = new Point(21, 53);
            cuiTextBox1.Margin = new Padding(4);
            cuiTextBox1.Multiline = false;
            cuiTextBox1.Name = "cuiTextBox1";
            cuiTextBox1.NormalImageTint = Color.White;
            cuiTextBox1.OutlineColor = Color.FromArgb(212, 175, 55);
            cuiTextBox1.Padding = new Padding(22, 14, 22, 0);
            cuiTextBox1.PasswordChar = false;
            cuiTextBox1.PlaceholderColor = Color.Gray;
            cuiTextBox1.PlaceholderText = "Search";
            cuiTextBox1.Rounding = new Padding(25);
            cuiTextBox1.Size = new Size(959, 51);
            cuiTextBox1.TabIndex = 3;
            cuiTextBox1.TextOffset = new Size(0, 0);
            cuiTextBox1.UnderlinedStyle = true;
            // 
            // cuiLabel3
            // 
            cuiLabel3.Content = "Brand";
            cuiLabel3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cuiLabel3.ForeColor = Color.FromArgb(212, 175, 55);
            cuiLabel3.HorizontalAlignment = StringAlignment.Center;
            cuiLabel3.Location = new Point(-64, 130);
            cuiLabel3.Margin = new Padding(4, 3, 4, 3);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(245, 54);
            cuiLabel3.TabIndex = 2;
            cuiLabel3.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel2
            // 
            cuiLabel2.Content = "Search";
            cuiLabel2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cuiLabel2.ForeColor = Color.FromArgb(212, 175, 55);
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(-64, 17);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(245, 54);
            cuiLabel2.TabIndex = 1;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiSeparator1
            // 
            cuiSeparator1.ForeColor = Color.FromArgb(128, 128, 128, 128);
            cuiSeparator1.Location = new Point(21, 92);
            cuiSeparator1.Margin = new Padding(4, 3, 4, 3);
            cuiSeparator1.Name = "cuiSeparator1";
            cuiSeparator1.SeparatorMargin = 8;
            cuiSeparator1.Size = new Size(959, 47);
            cuiSeparator1.TabIndex = 0;
            cuiSeparator1.Thickness = 0.5F;
            cuiSeparator1.Vertical = false;
            // 
            // cuiButton1
            // 
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "Contact Us";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Segoe UI Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiButton1.ForeColor = Color.Black;
            cuiButton1.HoverBackground = Color.FromArgb(227, 200, 150);
            cuiButton1.HoverForeColor = Color.Black;
            cuiButton1.HoverImageTint = Color.White;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.ImageOffset = new Point(0, 0);
            cuiButton1.Location = new Point(879, 12);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.FromArgb(212, 175, 55);
            cuiButton1.NormalForeColor = Color.Black;
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.PressedBackground = Color.FromArgb(247, 180, 111);
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(153, 45);
            cuiButton1.TabIndex = 2;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 0);
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Home";
            cuiLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cuiLabel1.ForeColor = Color.FromArgb(212, 175, 55);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(712, 15);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(154, 37);
            cuiLabel1.TabIndex = 1;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            cuiLabel1.Load += cuiLabel1_Load;
            // 
            // cuiLabel4
            // 
            cuiLabel4.Content = "Car\\ Listing";
            cuiLabel4.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cuiLabel4.ForeColor = Color.FromArgb(212, 175, 55);
            cuiLabel4.HorizontalAlignment = StringAlignment.Center;
            cuiLabel4.Location = new Point(28, 456);
            cuiLabel4.Margin = new Padding(4, 3, 4, 3);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(181, 54);
            cuiLabel4.TabIndex = 3;
            cuiLabel4.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiButton2
            // 
            cuiButton2.CheckButton = false;
            cuiButton2.Checked = false;
            cuiButton2.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton2.CheckedForeColor = Color.White;
            cuiButton2.CheckedImageTint = Color.White;
            cuiButton2.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton2.Content = "Add New Car";
            cuiButton2.DialogResult = DialogResult.None;
            cuiButton2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cuiButton2.ForeColor = Color.FromArgb(212, 175, 55);
            cuiButton2.HoverBackground = Color.White;
            cuiButton2.HoverForeColor = Color.Black;
            cuiButton2.HoverImageTint = Color.White;
            cuiButton2.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton2.Image = null;
            cuiButton2.ImageAutoCenter = true;
            cuiButton2.ImageExpand = new Point(0, 0);
            cuiButton2.ImageOffset = new Point(0, 0);
            cuiButton2.Location = new Point(891, 462);
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
            cuiButton2.Rounding = new Padding(8);
            cuiButton2.Size = new Size(141, 45);
            cuiButton2.TabIndex = 4;
            cuiButton2.TextAlignment = StringAlignment.Center;
            cuiButton2.TextOffset = new Point(0, 0);
            cuiButton2.Click += cuiButton2_Click;
            // 
            // btnAddBrand
            // 
            btnAddBrand.CheckButton = false;
            btnAddBrand.Checked = false;
            btnAddBrand.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnAddBrand.CheckedForeColor = Color.White;
            btnAddBrand.CheckedImageTint = Color.White;
            btnAddBrand.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnAddBrand.Content = "Add New Brand";
            btnAddBrand.DialogResult = DialogResult.None;
            btnAddBrand.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddBrand.ForeColor = Color.FromArgb(212, 175, 55);
            btnAddBrand.HoverBackground = Color.White;
            btnAddBrand.HoverForeColor = Color.Black;
            btnAddBrand.HoverImageTint = Color.White;
            btnAddBrand.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnAddBrand.Image = null;
            btnAddBrand.ImageAutoCenter = true;
            btnAddBrand.ImageExpand = new Point(0, 0);
            btnAddBrand.ImageOffset = new Point(0, 0);
            btnAddBrand.Location = new Point(712, 462);
            btnAddBrand.Name = "btnAddBrand";
            btnAddBrand.NormalBackground = Color.FromArgb(2, 4, 2);
            btnAddBrand.NormalForeColor = Color.FromArgb(212, 175, 55);
            btnAddBrand.NormalImageTint = Color.White;
            btnAddBrand.NormalOutline = Color.FromArgb(212, 175, 55);
            btnAddBrand.OutlineThickness = 1F;
            btnAddBrand.PressedBackground = Color.WhiteSmoke;
            btnAddBrand.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnAddBrand.PressedImageTint = Color.White;
            btnAddBrand.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnAddBrand.Rounding = new Padding(8);
            btnAddBrand.Size = new Size(154, 45);
            btnAddBrand.TabIndex = 5;
            btnAddBrand.TextAlignment = StringAlignment.Center;
            btnAddBrand.TextOffset = new Point(0, 0);
            btnAddBrand.Click += btnAddBrand_Click;
            // 
            // flPanel
            // 
            flPanel.Location = new Point(28, 531);
            flPanel.Margin = new Padding(0);
            flPanel.Name = "flPanel";
            flPanel.Padding = new Padding(8);
            flPanel.Size = new Size(1004, 391);
            flPanel.TabIndex = 6;
            // 
            // CarList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 27, 32);
            ClientSize = new Size(1062, 938);
            Controls.Add(flPanel);
            Controls.Add(btnAddBrand);
            Controls.Add(cuiButton2);
            Controls.Add(cuiLabel4);
            Controls.Add(panelTop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CarList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Imperial Auto";
            Load += CarList_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTop.ResumeLayout(false);
            cuiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private CuoreUI.Controls.cuiPanel panelTop;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiSeparator cuiSeparator1;
        private CuoreUI.Controls.cuiComboBox cbBrand;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private CuoreUI.Controls.cuiButton btnAddBrand;
        private FlowLayoutPanel flPanel;
    }
}