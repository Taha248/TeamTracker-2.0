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
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();
       //     customizeElements();
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {

        }

        //     private void customizeElements()
        //   {
        //label2.AutoSize = false;

        // //Total User 
        //lbl_TotalUser.AutoSize = false;
        //lbl_TotalUser.TextAlign = ContentAlignment.MiddleCenter;
        //pictureBox4.Parent = pictureBox1;
        //lbl_TotalUser.Parent = pictureBox1;
        //pictureBox4.BackColor = lbl_TotalUser.BackColor = Color.Transparent;

        ////Active User
        //label2.AutoSize = false;
        //label2.Parent = pictureBox5;
        //label2.TextAlign = ContentAlignment.MiddleCenter;
        //label2.BackColor = Color.Transparent;
        //pictureBox5.Parent = picBox_TotalUser;
        //pictureBox5.BackColor  = Color.Transparent;

        ////Task in Progress
        //pictureBox6.Parent = pictureBox2;
        //pictureBox6.BackColor = Color.Transparent;

        ////Task Completed
        //pictureBox7.Parent = pictureBox3;
        //pictureBox7.BackColor = Color.Transparent;
        //pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
        //label3.Parent = pictureBox3;
        //label3.TextAlign = ContentAlignment.MiddleCenter;
        //label3.BackColor = Color.Transparent;

        ///        }
    }
}
