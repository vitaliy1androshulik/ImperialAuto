namespace ImperialAuto.WindowsForms
{
    partial class CarCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cuiPbImage = new CuoreUI.Controls.cuiPictureBox();
            lbName = new Label();
            lbYear = new CuoreUI.Controls.cuiLabel();
            lbPrice = new CuoreUI.Controls.cuiLabel();
            btnEdit = new CuoreUI.Controls.cuiButton();
            btnDelete = new CuoreUI.Controls.cuiButton();
            lbModel = new CuoreUI.Controls.cuiLabel();
            SuspendLayout();
            // 
            // cuiPbImage
            // 
            cuiPbImage.AllowDrop = true;
            cuiPbImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cuiPbImage.AutoSize = true;
            cuiPbImage.BackgroundImageLayout = ImageLayout.Zoom;
            cuiPbImage.Content = null;
            cuiPbImage.Cursor = Cursors.Hand;
            cuiPbImage.ImageTint = Color.White;
            cuiPbImage.Location = new Point(10, 10);
            cuiPbImage.Margin = new Padding(4, 3, 4, 3);
            cuiPbImage.Name = "cuiPbImage";
            cuiPbImage.OutlineThickness = 2F;
            cuiPbImage.Padding = new Padding(2);
            cuiPbImage.PanelOutlineColor = Color.FromArgb(255, 192, 128);
            cuiPbImage.Rotation = 0;
            cuiPbImage.Rounding = new Padding(8);
            cuiPbImage.Size = new Size(183, 146);
            cuiPbImage.TabIndex = 0;
            cuiPbImage.Click += cuiPbImage_Click;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Cursor = Cursors.Hand;
            lbName.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbName.ForeColor = Color.FromArgb(212, 175, 55);
            lbName.Location = new Point(7, 159);
            lbName.Name = "lbName";
            lbName.Size = new Size(159, 30);
            lbName.TabIndex = 1;
            lbName.Text = "Mercedes-Benz";
            lbName.Click += lbName_Click_1;
            // 
            // lbYear
            // 
            lbYear.Content = "2023";
            lbYear.Cursor = Cursors.Hand;
            lbYear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbYear.ForeColor = Color.FromArgb(212, 175, 55);
            lbYear.HorizontalAlignment = StringAlignment.Near;
            lbYear.Location = new Point(9, 223);
            lbYear.Margin = new Padding(4, 3, 4, 3);
            lbYear.Name = "lbYear";
            lbYear.Size = new Size(157, 25);
            lbYear.TabIndex = 2;
            lbYear.VerticalAlignment = StringAlignment.Near;
            lbYear.Click += lbName_Click_1;
            // 
            // lbPrice
            // 
            lbPrice.Content = "\\$123,000";
            lbPrice.Cursor = Cursors.Hand;
            lbPrice.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbPrice.ForeColor = Color.FromArgb(212, 175, 55);
            lbPrice.HorizontalAlignment = StringAlignment.Near;
            lbPrice.Location = new Point(9, 254);
            lbPrice.Margin = new Padding(4, 3, 4, 3);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(159, 35);
            lbPrice.TabIndex = 3;
            lbPrice.VerticalAlignment = StringAlignment.Near;
            lbPrice.Click += lbName_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.CheckButton = false;
            btnEdit.Checked = false;
            btnEdit.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnEdit.CheckedForeColor = Color.White;
            btnEdit.CheckedImageTint = Color.White;
            btnEdit.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnEdit.Content = "Edit";
            btnEdit.DialogResult = DialogResult.None;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEdit.ForeColor = Color.FromArgb(212, 175, 55);
            btnEdit.HoverBackground = Color.White;
            btnEdit.HoverForeColor = Color.Black;
            btnEdit.HoverImageTint = Color.White;
            btnEdit.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnEdit.Image = null;
            btnEdit.ImageAutoCenter = true;
            btnEdit.ImageExpand = new Point(0, 0);
            btnEdit.ImageOffset = new Point(0, 0);
            btnEdit.Location = new Point(37, 291);
            btnEdit.Name = "btnEdit";
            btnEdit.NormalBackground = Color.FromArgb(2, 4, 2);
            btnEdit.NormalForeColor = Color.FromArgb(212, 175, 55);
            btnEdit.NormalImageTint = Color.White;
            btnEdit.NormalOutline = Color.FromArgb(212, 175, 55);
            btnEdit.OutlineThickness = 1F;
            btnEdit.PressedBackground = Color.WhiteSmoke;
            btnEdit.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnEdit.PressedImageTint = Color.White;
            btnEdit.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnEdit.Rounding = new Padding(12);
            btnEdit.Size = new Size(63, 34);
            btnEdit.TabIndex = 25;
            btnEdit.TextAlignment = StringAlignment.Center;
            btnEdit.TextOffset = new Point(0, 0);
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.CheckButton = false;
            btnDelete.Checked = false;
            btnDelete.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnDelete.CheckedForeColor = Color.White;
            btnDelete.CheckedImageTint = Color.White;
            btnDelete.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnDelete.Content = "Delete";
            btnDelete.DialogResult = DialogResult.None;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDelete.ForeColor = Color.FromArgb(212, 175, 55);
            btnDelete.HoverBackground = Color.White;
            btnDelete.HoverForeColor = Color.Black;
            btnDelete.HoverImageTint = Color.White;
            btnDelete.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnDelete.Image = null;
            btnDelete.ImageAutoCenter = true;
            btnDelete.ImageExpand = new Point(0, 0);
            btnDelete.ImageOffset = new Point(0, 0);
            btnDelete.Location = new Point(106, 291);
            btnDelete.Name = "btnDelete";
            btnDelete.NormalBackground = Color.FromArgb(2, 4, 2);
            btnDelete.NormalForeColor = Color.FromArgb(212, 175, 55);
            btnDelete.NormalImageTint = Color.White;
            btnDelete.NormalOutline = Color.FromArgb(212, 175, 55);
            btnDelete.OutlineThickness = 1F;
            btnDelete.PressedBackground = Color.WhiteSmoke;
            btnDelete.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnDelete.PressedImageTint = Color.White;
            btnDelete.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnDelete.Rounding = new Padding(12);
            btnDelete.Size = new Size(63, 34);
            btnDelete.TabIndex = 26;
            btnDelete.TextAlignment = StringAlignment.Center;
            btnDelete.TextOffset = new Point(0, 0);
            btnDelete.Click += btnDelete_Click;
            // 
            // lbModel
            // 
            lbModel.Content = "model";
            lbModel.Cursor = Cursors.Hand;
            lbModel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbModel.ForeColor = Color.FromArgb(212, 175, 55);
            lbModel.HorizontalAlignment = StringAlignment.Near;
            lbModel.Location = new Point(10, 193);
            lbModel.Margin = new Padding(4, 3, 4, 3);
            lbModel.Name = "lbModel";
            lbModel.RightToLeft = RightToLeft.No;
            lbModel.Size = new Size(157, 25);
            lbModel.TabIndex = 27;
            lbModel.VerticalAlignment = StringAlignment.Center;
            lbModel.Click += lbName_Click_1;
            // 
            // CarCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 46, 48);
            Controls.Add(lbModel);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(lbPrice);
            Controls.Add(lbYear);
            Controls.Add(lbName);
            Controls.Add(cuiPbImage);
            Cursor = Cursors.Hand;
            Name = "CarCard";
            Size = new Size(203, 334);
            Click += CarCard_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lbName;
        private CuoreUI.Controls.cuiLabel lbYear;
        private CuoreUI.Controls.cuiLabel lbPrice;
        private CuoreUI.Controls.cuiButton btnEdit;
        private CuoreUI.Controls.cuiButton btnDelete;
        private CuoreUI.Controls.cuiLabel lbModel;
        public CuoreUI.Controls.cuiPictureBox cuiPbImage;
    }
}
