using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        private Point MouseDownLocation;
        int totalHeight = 0;
        public Form1()
        {
            InitializeComponent();
            this.panel1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseWheel);
            this.flowLayoutPanel1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseWheel);
      
            double val = 0;
            flowLayoutPanel1.AutoSize = true;
            totalHeight = flowLayoutPanel1.Height;
            flowLayoutPanel1.AutoSize = false;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoScrollPosition = new Point(panel1.AutoScrollPosition.X, 0);
            flowLayoutPanel1.VerticalScroll.Value = 0;
            val = 207.76 - (0.08 * totalHeight);
              pictureBox1.Height = (int) val;
            

        }

        private void panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 )
            {
                if (pictureBox1.Top > 4)
                {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 20);

                }
            }
            else if(pictureBox1.Bottom < 210)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 20);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<MessageFormat> msgList = new List<MessageFormat>();
            msgList.Add(new MessageFormat { Subject = "Hello hello hello hello", Body = "Mr Taha & Zeeshan" });
            LoadNotification(msgList);
            double val = 207.76 - (0.08 * totalHeight);
            pictureBox1.Height = (int)val;
        }

        private void LoadNotification(List<MessageFormat> Messages)
        {
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.AutoScroll = true;
            for (int i = 0; i < Messages.Count; i++)
            {
                int height = 0;
                Label subject = new Label();
                subject.Text = Messages[i].Subject;
                subject.Font = new Font("Copperplate Gothic", 9, FontStyle.Bold);
                subject.TextAlign = ContentAlignment.MiddleCenter;
                subject.ForeColor = Color.White;
                subject.BackColor = Color.LightSlateGray;
                subject.Padding = new Padding(5);
                subject.Left = 2;
                subject.Width = 168;
                height = getLabelHeight(Messages[i].Subject);
                subject.Height = height;
                totalHeight += height;

                Label messages = new Label();
                messages.Font = new Font("Copperplate Gothic", 9, FontStyle.Regular);
                messages.ForeColor = Color.White;
                messages.BackColor = Color.LightSlateGray;
                messages.Left = 12;
                messages.AutoEllipsis = true;
                messages.Padding = new Padding(5);
                messages.Width = 168;
                height = 0;
                if ((Messages[i].Subject.Length) > 25)
                    height = getLabelHeight(Messages[i].Body);
                else { height = 55; }
                messages.Height = height;
                totalHeight += height;
                messages.Text = Messages[i].Body;

                Label space = new Label();
                space.Width = 168;
                space.Height = 5;
                totalHeight += 5;
                flowLayoutPanel1.Controls.Add(space);
                flowLayoutPanel1.Controls.Add(messages);
                flowLayoutPanel1.Controls.Add(subject);

                space.MouseHover += new System.EventHandler(this.panel1_MouseHover_1);
                messages.MouseHover += new System.EventHandler(this.panel1_MouseHover_1);
                subject.MouseHover += new System.EventHandler(this.panel1_MouseHover_1);
                //flowLayoutPanel1.Controls.OfType<HScrollBar>().First().Width = 10;

            }
        }

        private int getLabelHeight(string body)
        {
            int textLen = body.Length;
            int temp = textLen / 25;
            if (textLen % 25 > 0) { temp = ((temp + 1) * 25); }
            else { temp = (temp * 25); }
            return temp;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == System.Windows.Forms.MouseButtons.Left )
            {
                if (e.Y + pictureBox1.Top - MouseDownLocation.Y < 163 && e.Y + pictureBox1.Top - MouseDownLocation.Y >= 0)
                    pictureBox1.Top = e.Y + pictureBox1.Top - MouseDownLocation.Y;
            }
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y+50);
        }

        private void panel1_MouseHover_1(object sender, EventArgs e)
        {
            panel1.Focus();
            flowLayoutPanel1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var drives = DriveInfo.GetDrives()
       .Where(drive => drive.IsReady && drive.DriveType == DriveType.Removable);

            MessageBox.Show(""+drives);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    public sealed class Native
    {
        public static Int32 GetVerticalScrollbarWidth()
        {
            return GetSystemMetrics(SM_CXVSCROLL);
        }

        public Int32 GetHorizontalScrollbarHeight()
        {
            return GetSystemMetrics(SM_CYHSCROLL);
        }

        [DllImport("coredll.dll", SetLastError = true)]
        public static extern Int32 GetSystemMetrics(Int32 index);

        public const Int32
            SM_CXVSCROLL = 2,
            SM_CYHSCROLL = 3;
    }

    public class MessageFormat
    {
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
