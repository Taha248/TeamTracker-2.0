using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker2._0
{
    public partial class MainBoard : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainBoard()
        {
            InitializeComponent();
        }
        
        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel_minimum_MouseHover(object sender, EventArgs e)
        {

            System.Drawing.Color col = Color.LightGray;
            panel2.BackColor = col;
            panel_minimum.BackColor = col;
        }

        private void panel_minimum_MouseLeave(object sender, EventArgs e)
        {
            System.Drawing.Color col = Color.Transparent;
            panel2.BackColor = col;
            panel_minimum.BackColor = col;
        }

        private void panel_cross_MouseHover(object sender, EventArgs e)
        {

            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#DD3F34");
            panel_cross.BackColor = col;
        }

        private void panel_cross_MouseLeave(object sender, EventArgs e)
        {
            panel_cross.BackColor = Color.Transparent;
        }

        private void lbl_cross_MouseHover(object sender, EventArgs e)
        {
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#DD3F34");
            panel_cross.BackColor = col;
            lbl_cross.ForeColor = Color.Transparent;
            lbl_cross.BackColor = col;
        }

        private void lbl_cross_MouseLeave(object sender, EventArgs e)
        {
            panel_cross.BackColor = Color.Transparent;
            lbl_cross.BackColor = Color.Transparent;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            System.Drawing.Color col = Color.LightGray;
            panel2.BackColor = col;
            panel_minimum.BackColor = col;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            System.Drawing.Color col = Color.Transparent;
            panel2.BackColor = col;
            panel_minimum.BackColor = col;
        }

        private void lbl_cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void panel_minimum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void header_panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
