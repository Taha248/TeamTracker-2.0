﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TeamTracker2._0
{
    public partial class UC_UserMonitoring : UserControl
    {
        //public static ScreenShot
        public UC_UserMonitoring()
        {
            InitializeComponent();
        }

        private void loadEmployeeDropDown()
        {
            List<Employee> employeeList = new List<Employee>();

            employeeList.Add(new Employee { EmployeeID = 1, Name = "Taha" });
            employeeList.Add(new Employee { EmployeeID = 2, Name = "Zeeshan" });
            employeeList.Add(new Employee { EmployeeID = 3, Name = "Hamza" });
            employeeList.Add(new Employee { EmployeeID = 4, Name = "New Comer" });

            //string[] empName = { "Taha", "Zeeshan", "Hamza", "New Comer" };
            //bunifuDropdown1.Items = empName;

            metroComboBox1.DataSource = employeeList;

            metroComboBox1.DisplayMember = "Name";
            metroComboBox1.ValueMember = "EmployeeID";
        }

        private void UC_UserMonitoring_Load(object sender, EventArgs e)
        {
            //   panel6.BackColor = Color.Transparent; //
            // panel6.BackColor= Color.FromArgb(0, 153, 204);
            //panel6.BackColor = ColorTranslator.FromHtml("#8eacbb");
            //panel6.ForeColor = Color.DeepSkyBlue;
            panel5.BackColor = Color.FromArgb(1, 55, 91); 
            loadEmployeeDropDown();
            loadProcessList();
            loadScreenShot();
        }

        private void loadScreenShot()
        {
            pictureBox1.Image = Properties.Resources.Dashboard3;
        }

        private void loadProcessList()
        {
            List<ProcessList> pro = new List<ProcessList>();
            pro.Add(new ProcessList { processName = "Chrome" });
            pro.Add(new ProcessList { processName = "Counter Strike" });
            pro.Add(new ProcessList { processName = "Visual Studio" });
            pro.Add(new ProcessList { processName = "MySQl" });
            pro.Add(new ProcessList { processName = "Paint" });
            pro.Add(new ProcessList { processName = "Notepad" });
            pro.Add(new ProcessList { processName = "TeamViewer" });
            pro.Add(new ProcessList { processName = "Snipping Tool" });
            pro.Add(new ProcessList { processName = "Snipping Tool" });
            this.flowLayoutPanel8.WrapContents = false;
            this.flowLayoutPanel8.AutoScroll = true;

            Label top = new Label();
            top.Width = 150;
            top.Height = 5;
            top.BackColor = Color.White;

            //flowLayoutPanel8.Controls.Add(bottom_);
            flowLayoutPanel8.Controls.Add(top);
            for (int i = 0; i < pro.Count; i++)
            {
                Label process = new Label();
                process.Text = pro[i].processName;
                process.Font = new Font("Montserrat", 8, FontStyle.Regular);
                process.TextAlign = ContentAlignment.MiddleCenter;
                process.ForeColor = Color.Black;//229,244,255//135,206, 250
                process.BackColor = Color.FromArgb(229, 244, 255);//Color.FromArgb(237,140,120);//Color.SkyBlue; //ColorTranslator.FromHtml("#FFD197");

                process.Padding = new Padding(3);
                process.Width = 162;
                process.Height = 23;
                Label bottom = new Label();
                bottom.Width = 162;
                bottom.Height = 3;
                bottom.BackColor = Color.White;

                flowLayoutPanel8.Controls.Add(process);
                flowLayoutPanel8.Controls.Add(bottom);
            }
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string loc = @"C:\Users\Hamza Saleem\Desktop\Hamza\New folder\old\LAstest\TeamTracker-\TeamTracker2.0\TeamTracker2.0\Resources\Dashboard.png";
            ImageToBase64(loc);
            ScreenShotView ssv = new ScreenShotView();
            ssv.ShowDialog();
        }
        

        public static string ssv_Base64String = null;
        public void ImageToBase64(string picLoc)
        {
            using (System.Drawing.Image image = System.Drawing.Image.FromFile(picLoc))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    ssv_Base64String = Convert.ToBase64String(imageBytes);
                }
            }
        }
    }

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }

    }
    public class ProcessList
    {
        public string processName { get; set; }
    }
}
