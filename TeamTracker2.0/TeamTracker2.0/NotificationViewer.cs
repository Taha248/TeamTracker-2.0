using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker2._0
{
    public partial class NotificationViewer : Form
    {
        public NotificationViewer()
        {
            InitializeComponent();
            messageBody.Text = "Itg established fact that a reader will It is a long ed fact that a reader will It is a long Itg established fact that a reader will It is a long ed fact that a reader will It is a long";
            messageBody.Height = getNotificationPopupHeight(messageBody.Text);
            notiCard.Height = messageBody.Height + 82;
            panel2.Height = messageBody.Height + 94;
            messageBody.Height = getNotificationPopupHeight(messageBody.Text);
            notiCard.Height = messageBody.Height + 82;
            panel2.Height = messageBody.Height + 94;
        }

        private void NotificationViewer_Load(object sender, EventArgs e)
        {
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            var sb = new SolidBrush(Color.FromArgb(100, 100, 100, 100));
            e.Graphics.FillRectangle(sb, this.DisplayRectangle);
        }

        private void notiCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void notiCross_MouseHover(object sender, EventArgs e)
        {
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#DD3F34");
            notiCross.BackColor = col;
            notiCross.ForeColor = Color.White;
        }

        private void notiCross_MouseLeave(object sender, EventArgs e)
        {
            notiCross.ForeColor = Color.LightGray;
            notiCross.BackColor = Color.Transparent;
        }
        protected override void OnResize(EventArgs e)
        {
            panel2.Location = new Point()
            {
                X = panel1.Width / 2 - panel2.Width / 2,
                Y = panel1.Height / 2 - panel2.Height / 2
            };
            base.OnResize(e);
        }
        private int getNotificationPopupHeight(string body)
        {

            int textLen = body.Length;
            if (textLen > 0)
            {
                int temp = textLen / 53;
                if (textLen % 53 > 0 && temp > 0) { if (temp > 1) { temp = ((temp + 1) * 15); } else { temp = ((temp + 1) * 18); } }
                else if (temp == 0) { temp = 22; }
                else if (temp > 0 && textLen % 53 == 0)
                {
                    if (temp > 1) { temp = temp * 15; } else { temp = temp * 18; }
                }
                else { temp = (temp * 16); }

                return temp;
            }
            return 0;
        }
    }
}
