using GridViewExample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TeamTracker2._0
{
    public partial class MainBoard : Form
    {
        public static string username = "zee";
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        public MainBoard()
        {
            InitializeComponent();
            DB_Initialization.initializeDB();
            lbl_cross.BackColor = Color.Transparent;
            dashboard_panel.Controls.Add(new UC_Dashboard(this));
            
            initUI();
        }

        private void initUI()
        {
            //label12.Text = "welcome : " + username;
            //label10.Text = "Time In";
            bunifuiOSSwitch1.Value = false;

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
            dashboard_panel.Controls.Add(new UC_ManageTask(this));
            panel_managetask.BackColor = Color.FromArgb(27, 194, 203);
            ChangeProfile();

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Image = Properties.Resources.editprofie;
            pictureBox12.BringToFront();
            dashboard_panel.Controls.Add(new UC_EditProfile());
            clearSelection();
        }

        private void panel_session_log_Click(object sender, EventArgs e)
        {

            clearSelection();
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(new UC_SessionLogs(this));
            panel_session_log.BackColor = Color.FromArgb(27, 194, 203);
            ChangeProfile();
        }

        private void panel_user_statistics_Click(object sender, EventArgs e)
        {

            clearSelection();
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(new UC_UserStatistics());
            panel_user_statistics.BackColor = Color.FromArgb(27, 194, 203);
            ChangeProfile();
        }

        private void panel_user_monitoring_Click(object sender, EventArgs e)
        {
            clearSelection();
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(new UC_UserMonitoring());
            panel_user_monitoring.BackColor = Color.FromArgb(27, 194, 203);
            ChangeProfile();

        }

        private void panel_user_account_Click(object sender, EventArgs e)
        {
            clearSelection();
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(new UC_UserAccounts(this));
            panel_user_account.BackColor = Color.FromArgb(27, 194, 203);
            ChangeProfile();
        }

        private void panel_configuration_Click(object sender, EventArgs e)
        {

            clearSelection();
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(new UC_Configuration());
            panel_configuration.BackColor = Color.FromArgb(27, 194, 203);
            ChangeProfile();
        }

        private void panel_settings_Click(object sender, EventArgs e)
        {
            clearSelection();
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(new UC_Settings());
            panel_settings.BackColor = Color.FromArgb(27, 194, 203);
            ChangeProfile();
        }

        private void panel_dashboard_Click(object sender, EventArgs e)
        {
            clearSelection();

            label10.BringToFront();
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(new UC_Dashboard(this));
            panel_dashboard.BackColor = Color.FromArgb(27, 194, 203);
            GenerateNotification("Saved", messageType.Success);
            ChangeProfile();

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

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        public static string getUserID()
        {
            string userid = "";

            DataTable getuser = GridViewExample.ManData.getDataReader("*", "user", " Username='" + username + "'");
            foreach (DataRow row in getuser.Rows)
            {
                userid = row["UserID"].ToString();
            }
            return userid;
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value == true)
            {
                //label10.Text = "Time In";
            }
            else
            {
                //label10.Text = "Time Out";
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log out sucessfully!");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Profile!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dropShadow(object sender, PaintEventArgs e)
        {
            //panel1.Container += dropShadow;
            Panel panel = (Panel)sender;
            Color[] shadow = new Color[3];
            shadow[0] = Color.FromArgb(181, 181, 181);
            shadow[1] = Color.FromArgb(195, 195, 195);
            shadow[2] = Color.FromArgb(211, 211, 211);
            Pen pen = new Pen(shadow[0]);
            using (pen)
            {
                foreach (Panel p in panel.Controls.OfType<Panel>())
                {
                    Point pt = p.Location;
                    pt.Y += p.Height;
                    for (var sp = 0; sp < 3; sp++)
                    {
                        pen.Color = shadow[sp];
                        e.Graphics.DrawLine(pen, pt.X, pt.Y, pt.X + p.Width - 1, pt.Y);
                        pt.Y++;
                    }
                }
            }
        }
        System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();

        void timer1_Tick(object sender, System.EventArgs e)
        {
            timer1.Stop();
            messageBox.SendToBack();
        }
        public void GenerateNotification(string message,messageType msgType)
        {
            messageType result;
            if (Enum.TryParse(msgType.ToString(),out result))
            {
                switch (result)
                {
                    case messageType.Success:
                        messageBox.BringToFront();
                        panel1.BackColor = Color.FromArgb(0,200,81); 
                        label10.Text = message + " Successfully!";
                        success.BringToFront();
                        error.Hide();
                        //custom.Hide();
                        timer1.Interval = 3000; // here time in milliseconds
                        timer1.Tick += timer1_Tick;
                        timer1.Start();
                        break;

                    case messageType.Error:
                        messageBox.BringToFront();
                        panel1.BackColor = Color.FromArgb(255, 136, 0);
                        label10.Text = message + " Successfully!";
                        error.BringToFront();
                        success.Hide();
                        //custom.Hide();
                        timer1.Interval = 3000; // here time in milliseconds
                        timer1.Tick += timer1_Tick;
                        timer1.Start();
                        break;

                    case messageType.Custom:
                        panel1.BackColor = Color.FromArgb(255, 136, 0);
                        messageBox.BringToFront();
                        error.BringToFront();
                        success.Hide();
                        //custom.Hide();
                        timer1.Interval = 3000; // here time in milliseconds
                        timer1.Tick += timer1_Tick;
                        timer1.Start();
                        label10.Text = "Please Enter Email In Right Format";
                        if(label10.Text.Length>20)
                            label10.Font = new Font("Montserrat", 7, FontStyle.Regular);
                        break;

                    default:
                        break;
                }
            }
        }

        private void messageBox_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            //pictureBox12.Image = Properties.Resources.prohover29;
        }

        private void ChangeProfile()
        {
            pictureBox12.Image = Properties.Resources.icons8_rounded_square_27__1_;
            pictureBox9.BringToFront();
        }

    }
}

public enum messageType
{
    Success,
    Error,
    Custom
}