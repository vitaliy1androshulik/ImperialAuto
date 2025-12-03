using CuoreUI.Controls;
using ImperialAuto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace ImperialAuto.WindowsForms
{
    public partial class CarGallery : UserControl
    {
        private List<string> _images = new List<string>();
        private int currentIndex = 0;

        public CarGallery()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            SetupLayout();
        }
        private cuiPictureBox mainImage;
        private FlowLayoutPanel previewPanel;
        private void SetupLayout()
        {
            

            mainImage = new cuiPictureBox();
            mainImage.Dock = DockStyle.Top;
            mainImage.Width = 650;
            mainImage.Height = 350;
            mainImage.BackColor = Color.Transparent;
            mainImage.OutlineThickness = 3;
            mainImage.PanelOutlineColor = Color.FromArgb(255, 192, 128);


            previewPanel = new FlowLayoutPanel();
            previewPanel.Dock = DockStyle.Top;
            previewPanel.AutoScroll = true;
            previewPanel.WrapContents = false;
            previewPanel.FlowDirection = FlowDirection.LeftToRight;
            previewPanel.Height = 120;
            previewPanel.Padding = new Padding(10);
            previewPanel.BackColor = Color.FromArgb(42, 46, 48);

            this.Controls.Add(previewPanel);
            this.Controls.Add(mainImage);
        }
        public void LoadCar(Car car)
        {
            _images.Clear();
            previewPanel.Controls.Clear();

            if (car == null || car.ImageUrls == null || car.ImageUrls.Count == 0)
            {
                mainImage.Content = null;
                return;
            }

            foreach (var img in car.ImageUrls)
            {
                string path = img.ImageUrl;
                if (File.Exists(path))
                    _images.Add(path);
            }

            if (_images.Count == 0)
            {
                mainImage.Content = null;
                return;
            }

            currentIndex = 0;
            SetMainImage(_images[currentIndex]);

            foreach (var path in _images)
            {
                cuiPictureBox pb = new cuiPictureBox();
                pb.Width = 140;
                pb.Height = 100;
                pb.Margin = new Padding(5);
                pb.Cursor = Cursors.Hand;
                pb.OutlineThickness = 3;
                pb.PanelOutlineColor = Color.FromArgb(255, 192, 128);

                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    pb.Content = Image.FromStream(fs);

                pb.Tag = path;
                pb.Click += Thumbnail_Click;

                previewPanel.Controls.Add(pb);
            }
            CenterItemsInFlowLayoutPanel(previewPanel);
        }
        private void SetMainImage(string path)
        {
            if (!File.Exists(path))
            {
                mainImage.Content = null;
                return;
            }

            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                mainImage.Content = Image.FromStream(fs);
        }
        private void Thumbnail_Click(object sender, EventArgs e)
        {
            if (sender is cuiPictureBox pb && pb.Tag is string path)
            {
                currentIndex = _images.IndexOf(path);
                SetMainImage(path);
            }
        }
        private void Preview_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pb && pb.Tag is string path)
            {
                SetMainImage(path);
            }
        }
        private void CenterItemsInFlowLayoutPanel(FlowLayoutPanel panel)
        {
            if (panel.Controls.Count == 0)
                return;

            int totalWidth = 0;
            foreach (Control ctrl in panel.Controls)
                totalWidth += ctrl.Width + ctrl.Margin.Horizontal;

            int emptySpace = panel.ClientSize.Width - totalWidth;
            int margin = Math.Max(0, emptySpace / 2);

            panel.Padding = new Padding(margin, panel.Padding.Top, panel.Padding.Right, panel.Padding.Bottom);
        }
    }
}
