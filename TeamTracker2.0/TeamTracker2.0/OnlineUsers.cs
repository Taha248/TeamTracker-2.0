using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker2._0
{
    public partial class OnlineUsers : Form
    {
        Form prevForm = null;
        public OnlineUsers()
        {
            InitializeComponent();
        }

        public OnlineUsers(Form form)
        {
            this.prevForm = form;
            InitializeComponent();
        }

        private void OnlineUsers_Load(object sender, EventArgs e)
        {
            //      BackColor = Color.Fuchsia;
            //    TransparencyKey = Color.Fuchsia;
            this.Height = prevForm.Height;
            this.Width = prevForm.Width;
            this.Location = prevForm.Location;

            panel1.Location = new Point(
            this.ClientSize.Width / 2 - panel1.Size.Width / 2,
            this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, Color.LightGray, ButtonBorderStyle.Dashed);

        }

        private void lbl_cross_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void panel_cross_MouseHover(object sender, EventArgs e)
        {

        }

        private void lbl_cross_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void lbl_cross_MouseHover(object sender, EventArgs e)
        {
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#DD3F34");
            panel_cross.BackColor = col;
            lbl_cross.BackColor = col;
            lbl_cross.ForeColor = Color.White;
        }

        private void lbl_cross_MouseLeave(object sender, EventArgs e)
        {
            panel_cross.BackColor = Color.Transparent;
            lbl_cross.ForeColor = Color.LightGray;
            lbl_cross.BackColor = Color.Transparent;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Region = new Region(path);

            path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Region = new Region(path);

            ControlPaint.DrawBorder(e.Graphics, this.panel3.ClientRectangle, Color.FromArgb(220, 220, 220), ButtonBorderStyle.Solid);
        

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel4.ClientRectangle, Color.FromArgb(220, 220, 220), ButtonBorderStyle.Solid);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pictureBox3.Width, pictureBox3.Height);
            pictureBox3.Region = new Region(path);

            path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pictureBox4.Width, pictureBox4.Height);
            pictureBox4.Region = new Region(path);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel5.ClientRectangle, Color.FromArgb(220, 220, 220), ButtonBorderStyle.Solid);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pictureBox5.Width, pictureBox5.Height);
            pictureBox5.Region = new Region(path);

            path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pictureBox6.Width, pictureBox6.Height);
            pictureBox6.Region = new Region(path);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            var sb = new SolidBrush(Color.FromArgb(100, 100, 100, 100));
            e.Graphics.FillRectangle(sb, this.DisplayRectangle);
        }

        private void OnlineUsers_Paint(object sender, PaintEventArgs e)
        {

            var hb = new HatchBrush(HatchStyle.Percent50, this.TransparencyKey);

            e.Graphics.FillRectangle(hb, this.DisplayRectangle);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel6.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);

        }
    }
}
