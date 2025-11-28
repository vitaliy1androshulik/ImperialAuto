namespace ImperialAuto.WindowsForms
{
    partial class CarAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarAddEdit));
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            btnImage = new CuoreUI.Controls.cuiButton();
            flPanel = new FlowLayoutPanel();
            btnSave = new CuoreUI.Controls.cuiButton();
            btnCancel = new CuoreUI.Controls.cuiButton();
            cuiLabel8 = new CuoreUI.Controls.cuiLabel();
            cbColor = new CuoreUI.Controls.cuiComboBox();
            cbEnginetype = new CuoreUI.Controls.cuiComboBox();
            tbVolume = new CuoreUI.Controls.cuiTextBox();
            cuiLabel6 = new CuoreUI.Controls.cuiLabel();
            cuiLabel7 = new CuoreUI.Controls.cuiLabel();
            cuiLabel5 = new CuoreUI.Controls.cuiLabel();
            tbPrice = new CuoreUI.Controls.cuiTextBox();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            tbYear = new CuoreUI.Controls.cuiTextBox();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            tbModel = new CuoreUI.Controls.cuiTextBox();
            cbBrand = new CuoreUI.Controls.cuiComboBox();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(btnImage);
            cuiPanel1.Controls.Add(flPanel);
            cuiPanel1.Controls.Add(btnSave);
            cuiPanel1.Controls.Add(btnCancel);
            cuiPanel1.Controls.Add(cuiLabel8);
            cuiPanel1.Controls.Add(cbColor);
            cuiPanel1.Controls.Add(cbEnginetype);
            cuiPanel1.Controls.Add(tbVolume);
            cuiPanel1.Controls.Add(cuiLabel6);
            cuiPanel1.Controls.Add(cuiLabel7);
            cuiPanel1.Controls.Add(cuiLabel5);
            cuiPanel1.Controls.Add(tbPrice);
            cuiPanel1.Controls.Add(cuiLabel4);
            cuiPanel1.Controls.Add(tbYear);
            cuiPanel1.Controls.Add(cuiLabel3);
            cuiPanel1.Controls.Add(tbModel);
            cuiPanel1.Controls.Add(cbBrand);
            cuiPanel1.Controls.Add(cuiLabel2);
            cuiPanel1.Controls.Add(cuiLabel1);
            cuiPanel1.Location = new Point(12, 12);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 2F;
            cuiPanel1.PanelColor = Color.FromArgb(42, 46, 48);
            cuiPanel1.PanelOutlineColor = Color.FromArgb(212, 175, 55);
            cuiPanel1.Rounding = new Padding(12);
            cuiPanel1.Size = new Size(466, 713);
            cuiPanel1.TabIndex = 0;
            // 
            // btnImage
            // 
            btnImage.BackColor = Color.Transparent;
            btnImage.CheckButton = false;
            btnImage.Checked = false;
            btnImage.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnImage.CheckedForeColor = Color.White;
            btnImage.CheckedImageTint = Color.White;
            btnImage.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnImage.Content = "Image Upload";
            btnImage.DialogResult = DialogResult.None;
            btnImage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnImage.ForeColor = Color.FromArgb(212, 175, 55);
            btnImage.HoverBackground = Color.White;
            btnImage.HoverForeColor = Color.Black;
            btnImage.HoverImageTint = Color.White;
            btnImage.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnImage.Image = null;
            btnImage.ImageAutoCenter = true;
            btnImage.ImageExpand = new Point(0, 0);
            btnImage.ImageOffset = new Point(0, 0);
            btnImage.Location = new Point(19, 421);
            btnImage.Name = "btnImage";
            btnImage.NormalBackground = Color.FromArgb(2, 4, 2);
            btnImage.NormalForeColor = Color.FromArgb(212, 175, 55);
            btnImage.NormalImageTint = Color.White;
            btnImage.NormalOutline = Color.FromArgb(212, 175, 55);
            btnImage.OutlineThickness = 1F;
            btnImage.PressedBackground = Color.WhiteSmoke;
            btnImage.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnImage.PressedImageTint = Color.White;
            btnImage.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnImage.Rounding = new Padding(12);
            btnImage.Size = new Size(193, 41);
            btnImage.TabIndex = 24;
            btnImage.TextAlignment = StringAlignment.Center;
            btnImage.TextOffset = new Point(0, 0);
            btnImage.Click += cuiButton3_Click;
            // 
            // flPanel
            // 
            flPanel.AutoScroll = true;
            flPanel.BackColor = Color.Transparent;
            flPanel.ForeColor = SystemColors.ControlDarkDark;
            flPanel.Location = new Point(19, 468);
            flPanel.Margin = new Padding(0);
            flPanel.Name = "flPanel";
            flPanel.Size = new Size(417, 167);
            flPanel.TabIndex = 23;
            flPanel.WrapContents = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.CheckButton = false;
            btnSave.Checked = false;
            btnSave.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnSave.CheckedForeColor = Color.White;
            btnSave.CheckedImageTint = Color.White;
            btnSave.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnSave.Content = "Save";
            btnSave.DialogResult = DialogResult.None;
            btnSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSave.ForeColor = Color.FromArgb(2, 4, 2);
            btnSave.HoverBackground = Color.White;
            btnSave.HoverForeColor = Color.Black;
            btnSave.HoverImageTint = Color.White;
            btnSave.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnSave.Image = null;
            btnSave.ImageAutoCenter = true;
            btnSave.ImageExpand = new Point(0, 0);
            btnSave.ImageOffset = new Point(0, 0);
            btnSave.Location = new Point(75, 655);
            btnSave.Name = "btnSave";
            btnSave.NormalBackground = Color.FromArgb(212, 175, 55);
            btnSave.NormalForeColor = Color.FromArgb(2, 4, 2);
            btnSave.NormalImageTint = Color.White;
            btnSave.NormalOutline = Color.FromArgb(212, 175, 55);
            btnSave.OutlineThickness = 1F;
            btnSave.PressedBackground = Color.WhiteSmoke;
            btnSave.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnSave.PressedImageTint = Color.White;
            btnSave.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnSave.Rounding = new Padding(12);
            btnSave.Size = new Size(149, 45);
            btnSave.TabIndex = 22;
            btnSave.TextAlignment = StringAlignment.Center;
            btnSave.TextOffset = new Point(0, 0);
            btnSave.Click += cuiButton1_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.CheckButton = false;
            btnCancel.Checked = false;
            btnCancel.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnCancel.CheckedForeColor = Color.White;
            btnCancel.CheckedImageTint = Color.White;
            btnCancel.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnCancel.Content = "Cancel";
            btnCancel.DialogResult = DialogResult.None;
            btnCancel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCancel.ForeColor = Color.FromArgb(212, 175, 55);
            btnCancel.HoverBackground = Color.White;
            btnCancel.HoverForeColor = Color.Black;
            btnCancel.HoverImageTint = Color.White;
            btnCancel.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnCancel.Image = null;
            btnCancel.ImageAutoCenter = true;
            btnCancel.ImageExpand = new Point(0, 0);
            btnCancel.ImageOffset = new Point(0, 0);
            btnCancel.Location = new Point(263, 655);
            btnCancel.Name = "btnCancel";
            btnCancel.NormalBackground = Color.FromArgb(2, 4, 2);
            btnCancel.NormalForeColor = Color.FromArgb(212, 175, 55);
            btnCancel.NormalImageTint = Color.White;
            btnCancel.NormalOutline = Color.FromArgb(212, 175, 55);
            btnCancel.OutlineThickness = 1F;
            btnCancel.PressedBackground = Color.WhiteSmoke;
            btnCancel.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnCancel.PressedImageTint = Color.White;
            btnCancel.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnCancel.Rounding = new Padding(12);
            btnCancel.Size = new Size(143, 45);
            btnCancel.TabIndex = 21;
            btnCancel.TextAlignment = StringAlignment.Center;
            btnCancel.TextOffset = new Point(0, 0);
            btnCancel.Click += cuiButton2_Click;
            // 
            // cuiLabel8
            // 
            cuiLabel8.BackColor = Color.Transparent;
            cuiLabel8.Content = "Color";
            cuiLabel8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cuiLabel8.ForeColor = Color.FromArgb(212, 175, 55);
            cuiLabel8.HorizontalAlignment = StringAlignment.Center;
            cuiLabel8.Location = new Point(19, 328);
            cuiLabel8.Margin = new Padding(4, 3, 4, 3);
            cuiLabel8.Name = "cuiLabel8";
            cuiLabel8.Size = new Size(59, 25);
            cuiLabel8.TabIndex = 19;
            cuiLabel8.VerticalAlignment = StringAlignment.Near;
            // 
            // cbColor
            // 
            cbColor.BackColor = Color.Transparent;
            cbColor.BackgroundColor = Color.FromArgb(28, 29, 32);
            cbColor.DropDownBackgroundColor = Color.FromArgb(28, 29, 32);
            cbColor.DropDownForeColor = Color.FromArgb(212, 175, 55);
            cbColor.ExpandArrowColor = Color.Gray;
            cbColor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbColor.ForeColor = Color.FromArgb(212, 175, 55);
            cbColor.Items = new string[]
    {
    "Item 1",
    "Item 2",
    "Item 3"
    };
            cbColor.Location = new Point(19, 360);
            cbColor.Margin = new Padding(5, 4, 5, 4);
            cbColor.Name = "cbColor";
            cbColor.NoSelectionText = "Color";
            cbColor.OutlineColor = Color.FromArgb(212, 175, 55);
            cbColor.OutlineThickness = 1F;
            cbColor.RightToLeft = RightToLeft.No;
            cbColor.Rounding = 15;
            cbColor.SelectedIndex = -1;
            cbColor.SelectedItem = "";
            cbColor.Size = new Size(193, 41);
            cbColor.SortAlphabetically = true;
            cbColor.TabIndex = 18;
            // 
            // cbEnginetype
            // 
            cbEnginetype.BackColor = Color.Transparent;
            cbEnginetype.BackgroundColor = Color.FromArgb(28, 29, 32);
            cbEnginetype.DropDownBackgroundColor = Color.FromArgb(28, 29, 32);
            cbEnginetype.DropDownForeColor = Color.FromArgb(212, 175, 55);
            cbEnginetype.ExpandArrowColor = Color.Gray;
            cbEnginetype.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbEnginetype.ForeColor = Color.FromArgb(212, 175, 55);
            cbEnginetype.Items = new string[]
    {
    "Item 1",
    "Item 2",
    "Item 3"
    };
            cbEnginetype.Location = new Point(240, 280);
            cbEnginetype.Margin = new Padding(5, 4, 5, 4);
            cbEnginetype.Name = "cbEnginetype";
            cbEnginetype.NoSelectionText = "Engine Type";
            cbEnginetype.OutlineColor = Color.FromArgb(212, 175, 55);
            cbEnginetype.OutlineThickness = 1F;
            cbEnginetype.RightToLeft = RightToLeft.No;
            cbEnginetype.Rounding = 15;
            cbEnginetype.SelectedIndex = -1;
            cbEnginetype.SelectedItem = "";
            cbEnginetype.Size = new Size(196, 41);
            cbEnginetype.SortAlphabetically = true;
            cbEnginetype.TabIndex = 17;
            // 
            // tbVolume
            // 
            tbVolume.BackColor = Color.Transparent;
            tbVolume.BackgroundColor = Color.FromArgb(28, 29, 32);
            tbVolume.Content = "";
            tbVolume.FocusBackgroundColor = Color.White;
            tbVolume.FocusImageTint = Color.White;
            tbVolume.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            tbVolume.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbVolume.ForeColor = Color.DimGray;
            tbVolume.Image = null;
            tbVolume.ImageExpand = new Point(0, 0);
            tbVolume.ImageOffset = new Point(0, 0);
            tbVolume.Location = new Point(19, 280);
            tbVolume.Margin = new Padding(4);
            tbVolume.Multiline = false;
            tbVolume.Name = "tbVolume";
            tbVolume.NormalImageTint = Color.White;
            tbVolume.OutlineColor = Color.FromArgb(212, 175, 55);
            tbVolume.Padding = new Padding(22, 9, 22, 0);
            tbVolume.PasswordChar = false;
            tbVolume.PlaceholderColor = Color.Gray;
            tbVolume.PlaceholderText = "Volume";
            tbVolume.Rounding = new Padding(15);
            tbVolume.Size = new Size(193, 41);
            tbVolume.TabIndex = 16;
            tbVolume.TextOffset = new Size(0, 0);
            tbVolume.UnderlinedStyle = true;
            // 
            // cuiLabel6
            // 
            cuiLabel6.BackColor = Color.Transparent;
            cuiLabel6.Content = "Engine\\ Type";
            cuiLabel6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cuiLabel6.ForeColor = Color.FromArgb(212, 175, 55);
            cuiLabel6.HorizontalAlignment = StringAlignment.Center;
            cuiLabel6.Location = new Point(240, 244);
            cuiLabel6.Margin = new Padding(4, 3, 4, 3);
            cuiLabel6.Name = "cuiLabel6";
            cuiLabel6.Size = new Size(114, 29);
            cuiLabel6.TabIndex = 15;
            cuiLabel6.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel7
            // 
            cuiLabel7.BackColor = Color.Transparent;
            cuiLabel7.Content = "Volume";
            cuiLabel7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cuiLabel7.ForeColor = Color.FromArgb(212, 175, 55);
            cuiLabel7.HorizontalAlignment = StringAlignment.Center;
            cuiLabel7.Location = new Point(19, 244);
            cuiLabel7.Margin = new Padding(4, 3, 4, 3);
            cuiLabel7.Name = "cuiLabel7";
            cuiLabel7.Size = new Size(73, 29);
            cuiLabel7.TabIndex = 13;
            cuiLabel7.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel5
            // 
            cuiLabel5.BackColor = Color.Transparent;
            cuiLabel5.Content = "Price";
            cuiLabel5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cuiLabel5.ForeColor = Color.FromArgb(212, 175, 55);
            cuiLabel5.HorizontalAlignment = StringAlignment.Center;
            cuiLabel5.Location = new Point(240, 160);
            cuiLabel5.Margin = new Padding(4, 3, 4, 3);
            cuiLabel5.Name = "cuiLabel5";
            cuiLabel5.Size = new Size(54, 29);
            cuiLabel5.TabIndex = 11;
            cuiLabel5.VerticalAlignment = StringAlignment.Near;
            // 
            // tbPrice
            // 
            tbPrice.BackColor = Color.Transparent;
            tbPrice.BackgroundColor = Color.FromArgb(28, 29, 32);
            tbPrice.Content = "";
            tbPrice.FocusBackgroundColor = Color.White;
            tbPrice.FocusImageTint = Color.White;
            tbPrice.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            tbPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbPrice.ForeColor = Color.DimGray;
            tbPrice.Image = null;
            tbPrice.ImageExpand = new Point(0, 0);
            tbPrice.ImageOffset = new Point(0, 0);
            tbPrice.Location = new Point(240, 196);
            tbPrice.Margin = new Padding(4);
            tbPrice.Multiline = false;
            tbPrice.Name = "tbPrice";
            tbPrice.NormalImageTint = Color.White;
            tbPrice.OutlineColor = Color.FromArgb(212, 175, 55);
            tbPrice.Padding = new Padding(22, 9, 22, 0);
            tbPrice.PasswordChar = false;
            tbPrice.PlaceholderColor = Color.Gray;
            tbPrice.PlaceholderText = "Price";
            tbPrice.Rounding = new Padding(15);
            tbPrice.Size = new Size(196, 41);
            tbPrice.TabIndex = 10;
            tbPrice.TextOffset = new Size(0, 0);
            tbPrice.UnderlinedStyle = true;
            // 
            // cuiLabel4
            // 
            cuiLabel4.BackColor = Color.Transparent;
            cuiLabel4.Content = "Year";
            cuiLabel4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cuiLabel4.ForeColor = Color.FromArgb(212, 175, 55);
            cuiLabel4.HorizontalAlignment = StringAlignment.Center;
            cuiLabel4.Location = new Point(19, 160);
            cuiLabel4.Margin = new Padding(4, 3, 4, 3);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(50, 29);
            cuiLabel4.TabIndex = 9;
            cuiLabel4.VerticalAlignment = StringAlignment.Near;
            // 
            // tbYear
            // 
            tbYear.BackColor = Color.Transparent;
            tbYear.BackgroundColor = Color.FromArgb(28, 29, 32);
            tbYear.Content = "";
            tbYear.FocusBackgroundColor = Color.White;
            tbYear.FocusImageTint = Color.White;
            tbYear.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            tbYear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbYear.ForeColor = Color.DimGray;
            tbYear.Image = null;
            tbYear.ImageExpand = new Point(0, 0);
            tbYear.ImageOffset = new Point(0, 0);
            tbYear.Location = new Point(19, 196);
            tbYear.Margin = new Padding(4);
            tbYear.Multiline = false;
            tbYear.Name = "tbYear";
            tbYear.NormalImageTint = Color.White;
            tbYear.OutlineColor = Color.FromArgb(212, 175, 55);
            tbYear.Padding = new Padding(22, 9, 22, 0);
            tbYear.PasswordChar = false;
            tbYear.PlaceholderColor = Color.Gray;
            tbYear.PlaceholderText = "Year";
            tbYear.Rounding = new Padding(15);
            tbYear.Size = new Size(193, 41);
            tbYear.TabIndex = 8;
            tbYear.TextOffset = new Size(0, 0);
            tbYear.UnderlinedStyle = true;
            // 
            // cuiLabel3
            // 
            cuiLabel3.BackColor = Color.Transparent;
            cuiLabel3.Content = "Model";
            cuiLabel3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cuiLabel3.ForeColor = Color.FromArgb(212, 175, 55);
            cuiLabel3.HorizontalAlignment = StringAlignment.Center;
            cuiLabel3.Location = new Point(240, 76);
            cuiLabel3.Margin = new Padding(4, 3, 4, 3);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(80, 29);
            cuiLabel3.TabIndex = 7;
            cuiLabel3.VerticalAlignment = StringAlignment.Near;
            // 
            // tbModel
            // 
            tbModel.BackColor = Color.Transparent;
            tbModel.BackgroundColor = Color.FromArgb(28, 29, 32);
            tbModel.Content = "";
            tbModel.FocusBackgroundColor = Color.White;
            tbModel.FocusImageTint = Color.White;
            tbModel.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            tbModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbModel.ForeColor = Color.DimGray;
            tbModel.Image = null;
            tbModel.ImageExpand = new Point(0, 0);
            tbModel.ImageOffset = new Point(0, 0);
            tbModel.Location = new Point(240, 112);
            tbModel.Margin = new Padding(4);
            tbModel.Multiline = false;
            tbModel.Name = "tbModel";
            tbModel.NormalImageTint = Color.White;
            tbModel.OutlineColor = Color.FromArgb(212, 175, 55);
            tbModel.Padding = new Padding(22, 9, 22, 0);
            tbModel.PasswordChar = false;
            tbModel.PlaceholderColor = Color.Gray;
            tbModel.PlaceholderText = "Model";
            tbModel.Rounding = new Padding(15);
            tbModel.Size = new Size(196, 41);
            tbModel.TabIndex = 6;
            tbModel.TextOffset = new Size(0, 0);
            tbModel.UnderlinedStyle = true;
            // 
            // cbBrand
            // 
            cbBrand.BackColor = Color.Transparent;
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
            cbBrand.Location = new Point(19, 112);
            cbBrand.Margin = new Padding(5, 4, 5, 4);
            cbBrand.Name = "cbBrand";
            cbBrand.NoSelectionText = "Brand";
            cbBrand.OutlineColor = Color.FromArgb(212, 175, 55);
            cbBrand.OutlineThickness = 1F;
            cbBrand.RightToLeft = RightToLeft.No;
            cbBrand.Rounding = 15;
            cbBrand.SelectedIndex = -1;
            cbBrand.SelectedItem = "";
            cbBrand.Size = new Size(193, 41);
            cbBrand.SortAlphabetically = true;
            cbBrand.TabIndex = 5;
            // 
            // cuiLabel2
            // 
            cuiLabel2.BackColor = Color.Transparent;
            cuiLabel2.Content = "Brand";
            cuiLabel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cuiLabel2.ForeColor = Color.FromArgb(212, 175, 55);
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(19, 71);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(73, 34);
            cuiLabel2.TabIndex = 1;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Add/Edit\\ Car\\ Details";
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
            // CarAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 4, 5);
            ClientSize = new Size(490, 737);
            Controls.Add(cuiPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CarAddEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add new Car";
            Load += CarAddEdit_Load;
            cuiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiComboBox cbBrand;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiTextBox tbYear;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiTextBox tbModel;
        private CuoreUI.Controls.cuiLabel cuiLabel6;
        private CuoreUI.Controls.cuiLabel cuiLabel7;
        private CuoreUI.Controls.cuiLabel cuiLabel5;
        private CuoreUI.Controls.cuiTextBox tbPrice;
        private CuoreUI.Controls.cuiTextBox tbVolume;
        private CuoreUI.Controls.cuiComboBox cbEnginetype;
        private CuoreUI.Controls.cuiLabel cuiLabel8;
        private CuoreUI.Controls.cuiComboBox cbColor;
        private CuoreUI.Controls.cuiButton btnCancel;
        private FlowLayoutPanel flPanel;
        private CuoreUI.Controls.cuiButton btnSave;
        private CuoreUI.Controls.cuiButton btnImage;
    }
}