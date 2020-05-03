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
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        public MainBoard()
        {
            InitializeComponent();
            lbl_cross.BackColor = Color.Transparent;
            dashboard_panel.Controls.Add(new UC_Dashboard());
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
            lbl_cross.ForeColor = Color.LightGray;
        }

        private void lbl_cross_MouseHover(object sender, EventArgs e)
        {
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#DD3F34");
            panel_cross.BackColor = col;
            lbl_cross.ForeColor = Color.White;
        }

        private void lbl_cross_MouseLeave(object sender, EventArgs e)
        {
            panel_cross.BackColor = Color.Transparent;
            lbl_cross.BackColor = Color.Transparent;
            lbl_cross.ForeColor = Color.LightGray;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            System.Drawing.Color col = Color.LightGray;
            panel2.BackColor = col;
            panel_minimum.BackColor = col;
            lbl_cross.ForeColor = Color.White;
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

        private void panel_managetask_Click(object sender, EventArgs e)
        {
            clearSelection();
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(new UC_ManageTask());
            panel_managetask.BackColor = Color.FromArgb(27, 194, 203);

        }



        private void panel_session_log_Click(object sender, EventArgs e)
        {

            clearSelection();
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(new UC_SessionLogs());
            panel_session_log.BackColor = Color.FromArgb(27, 194, 203);
        }

        private void panel_user_statistics_Click(object sender, EventArgs e)
        {

            clearSelection();
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(new UC_UserStatistics());
            panel_user_statistics.BackColor = Color.FromArgb(27, 194, 203);
        }

        private void panel_user_monitoring_Click(object sender, EventArgs e)
        {
            clearSelection();
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(new UC_UserMonitoring());
            panel_user_monitoring.BackColor = Color.FromArgb(27, 194, 203);

        }

        private void panel_user_account_Click(object sender, EventArgs e)
        {

            clearSelection();
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(new UC_UserAccounts());
            panel_user_account.BackColor = Color.FromArgb(27, 194, 203);
        }

        private void panel_configuration_Click(object sender, EventArgs e)
        {

            clearSelection();
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(new UC_Configuration());
            panel_configuration.BackColor = Color.FromArgb(27, 194, 203);
        }

        private void panel_settings_Click(object sender, EventArgs e)
        {

            clearSelection();
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(new UC_Settings());
            panel_settings.BackColor = Color.FromArgb(27, 194, 203);
        }

        private void panel_dashboard_Click(object sender, EventArgs e)
        {
            clearSelection();
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(new UC_Dashboard());
            panel_dashboard.BackColor = Color.FromArgb(27, 194, 203);

        }

        private void clearSelection()
        {
            panel_dashboard.BackColor = Color.FromArgb(42, 64, 84);
            panel_managetask.BackColor = Color.FromArgb(42, 64, 84);
            panel_settings.BackColor = Color.FromArgb(42, 64, 84);
            panel_configuration.BackColor = Color.FromArgb(42, 64, 84);
            panel_user_statistics.BackColor = Color.FromArgb(42, 64, 84);
            panel_user_account.BackColor = Color.FromArgb(42, 64, 84);
            panel_user_monitoring.BackColor = Color.FromArgb(42, 64, 84);
            panel_session_log.BackColor = Color.FromArgb(42, 64, 84);
            panel_dashboard.BackColor = Color.FromArgb(42, 64, 84);
            panel_dashboard.BackColor = Color.FromArgb(42, 64, 84);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Clicked Logout");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Clicked Profile");
        }

      
    }
}

