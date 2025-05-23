﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker2._0
{
    public partial class ScreenShotView : Form
    {
        public ScreenShotView()
        {
            InitializeComponent();
        }
        
        private void ScreenShotView_Load(object sender, EventArgs e)
        {
            picbox_ScreenShot.Image = Base64ToImage();
        }

        public System.Drawing.Image Base64ToImage()
        {
            byte[] imageBytes = Convert.FromBase64String(UC_UserMonitoring.ssv_Base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            var sb = new SolidBrush(Color.FromArgb(100, 100, 100, 100));
            e.Graphics.FillRectangle(sb, this.DisplayRectangle);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void notiCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void screenShotCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void screenShotCross_MouseHover(object sender, EventArgs e)
        {
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#DD3F34");
            screenShotCross.BackColor = col;
            screenShotCross.ForeColor = Color.White;
        }

        private void screenShotCross_ClientSizeChanged(object sender, EventArgs e)
        {
            this.screenShotCross.BackColor = Color.Transparent;
        }

        private void screenShotCross_MouseLeave(object sender, EventArgs e)
        {
            this.screenShotCross.ForeColor = Color.LightGray;
            this.screenShotCross.BackColor = Color.Transparent;
        }
    }
}
