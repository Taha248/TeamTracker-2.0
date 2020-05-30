using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker2._0
{
    public partial class UC_EditProfile : UserControl
    {
        MainBoard mainBoard = new MainBoard();
        public UC_EditProfile()
        {
            InitializeComponent();
        }
        
        private void UC_EditProfile_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
          //  pictureBox2.BringToFront();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
           // pictureBox2.SendToBack();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
        }

        private void label17_MouseHover(object sender, EventArgs e)
        {
            label17.BackColor = Color.RoyalBlue;
        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            label17.BackColor = Color.DodgerBlue;
        }

        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            linkLabel1.ForeColor = Color.Red;
        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.ForeColor = Color.DodgerBlue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
