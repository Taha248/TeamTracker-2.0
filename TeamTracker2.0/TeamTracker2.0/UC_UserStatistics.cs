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
    public partial class UC_UserStatistics : UserControl
    {
        public UC_UserStatistics()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel10_Click(object sender, EventArgs e)
        {
            flowLayoutPanel10.BackColor = Color.MediumTurquoise;
        }

        private void flowLayoutPanel10_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(10);
        }

        public void selectedRowChange(int panelNumber)
        {
            for(int i = 1; i <= 10; i++)
            {
                if (i == panelNumber)
                {
                    FlowLayoutPanel row = this.Controls.Find("flowLayoutPanel" + panelNumber, true).FirstOrDefault() as FlowLayoutPanel;
                    row.BackColor = Color.Gold;
                    Label rank = this.Controls.Find("rank" + panelNumber, true).FirstOrDefault() as Label;
                    rank.ForeColor = Color.White;
                    Label name = this.Controls.Find("name" + panelNumber, true).FirstOrDefault() as Label;
                    name.ForeColor = Color.White;
                    Label rep = this.Controls.Find("rep" + panelNumber, true).FirstOrDefault() as Label;
                    rep.ForeColor = Color.White;
                    Label time = this.Controls.Find("time" + panelNumber, true).FirstOrDefault() as Label;
                    time.ForeColor = Color.White;
                    Label task = this.Controls.Find("task" + panelNumber, true).FirstOrDefault() as Label;
                    task.ForeColor = Color.White;
                }
                else if(panelNumber!=i)
                {
                    FlowLayoutPanel row = this.Controls.Find("flowLayoutPanel" + panelNumber, true).FirstOrDefault() as FlowLayoutPanel;
                    row.BackColor = Color.FromArgb(243, 246, 249);
                    Label rank = this.Controls.Find("rank" + panelNumber, true).FirstOrDefault() as Label;
                    rank.ForeColor = Color.Black;
                    Label name = this.Controls.Find("name" + panelNumber, true).FirstOrDefault() as Label;
                    name.ForeColor = Color.Black;
                    Label rep = this.Controls.Find("rep" + panelNumber, true).FirstOrDefault() as Label;
                    rep.ForeColor = Color.Black;
                    Label time = this.Controls.Find("time" + panelNumber, true).FirstOrDefault() as Label;
                    time.ForeColor = Color.Black;
                    Label task = this.Controls.Find("task" + panelNumber, true).FirstOrDefault() as Label;
                    task.ForeColor = Color.Black;
                }
            }
            //if (panelNumber == 10)
            //{
            //    flowLayoutPanel10.BackColor = Color.Gold;
            //    name10.ForeColor = Color.White;
            //    rank10.ForeColor = Color.White;
            //    rep10.ForeColor = Color.White;
            //    task10.ForeColor = Color.White;
            //    time10.ForeColor = Color.White;
            //}
            //else
            //{
            //    flowLayoutPanel10.BackColor = Color.FromArgb(243, 246, 249 );
            //    name10.ForeColor = Color.Black;
            //    rank10.ForeColor = Color.Black;
            //    rep10.ForeColor = Color.Black;
            //    task10.ForeColor = Color.Black;
            //    time10.ForeColor = Color.Black;
            //}
            //if (panelNumber == 9)
            //{
            //    flowLayoutPanel9.BackColor = Color.Gold;
            //    name9.ForeColor = Color.White;
            //    rank9.ForeColor = Color.White;
            //    rep9.ForeColor = Color.White;
            //    task9.ForeColor = Color.White;
            //    time9.ForeColor = Color.White;
            //}
            //else
            //{
            //    flowLayoutPanel9.BackColor = Color.FromArgb(243, 246, 249);
            //    name9.ForeColor = Color.Black;
            //    rank9.ForeColor = Color.Black;
            //    rep9.ForeColor = Color.Black;
            //    task9.ForeColor = Color.Black;
            //    time9.ForeColor = Color.Black;
            //}
            //if (panelNumber == 8)
            //{
            //    flowLayoutPanel8.BackColor = Color.Gold;
            //    name8.ForeColor = Color.White;
            //    rank8.ForeColor = Color.White;
            //    rep8.ForeColor = Color.White;
            //    task8.ForeColor = Color.White;
            //    time8.ForeColor = Color.White;
            //}
            //else
            //{
            //    flowLayoutPanel8.BackColor = Color.FromArgb(243, 246, 249);
            //    name8.ForeColor = Color.Black;
            //    rank8.ForeColor = Color.Black;
            //    rep8.ForeColor = Color.Black;
            //    task8.ForeColor = Color.Black;
            //    time8.ForeColor = Color.Black;
            //}
            //if (panelNumber == 7)
            //{
            //    flowLayoutPanel7.BackColor = Color.Gold;
            //    name7.ForeColor = Color.White;
            //    rank7.ForeColor = Color.White;
            //    rep7.ForeColor = Color.White;
            //    task7.ForeColor = Color.White;
            //    time7.ForeColor = Color.White;
            //}
            //else
            //{
            //    flowLayoutPanel7.BackColor = Color.FromArgb(243, 246, 249);
            //    name7.ForeColor = Color.Black;
            //    rank7.ForeColor = Color.Black;
            //    rep7.ForeColor = Color.Black;
            //    task7.ForeColor = Color.Black;
            //    time7.ForeColor = Color.Black;
            //}
            //if (panelNumber == 6)
            //{
            //    flowLayoutPanel6.BackColor = Color.Gold;
            //    name6.ForeColor = Color.White;
            //    rank6.ForeColor = Color.White;
            //    rep6.ForeColor = Color.White;
            //    task6.ForeColor = Color.White;
            //    time6.ForeColor = Color.White;
            //}
            //else
            //{
            //    int a = 1;
            //    FlowLayoutPanel c = this.Controls["flowLayoutPanel" + a.ToString()] as FlowLayoutPanel;

            //    c.ForeColor = Color.FromArgb(243, 246, 249);
            //   // flowLayoutPanel(a).ForeColor = Color.Black;
            //    rank5.ForeColor = Color.Black;
            //    rep5.ForeColor = Color.Black;
            //    task5.ForeColor = Color.Black;
            //    time5.ForeColor = Color.Black;
            //}
            //if (panelNumber == 5)
            //{
            //    flowLayoutPanel5.BackColor = Color.Gold;
            //    name5.ForeColor = Color.White;
            //    rank5.ForeColor = Color.White;
            //    rep5.ForeColor = Color.White;
            //    task5.ForeColor = Color.White;
            //    time5.ForeColor = Color.White;
            //}
            //else if (panelNumber == 4)
            //{
            //    flowLayoutPanel4.BackColor = Color.Gold;
            //    name4.ForeColor = Color.White;
            //    rank4.ForeColor = Color.White;
            //    rep4.ForeColor = Color.White;
            //    task4.ForeColor = Color.White;
            //    time4.ForeColor = Color.White;
            //}
            //else if (panelNumber == 3)
            //{
            //    flowLayoutPanel3.BackColor = Color.Gold;
            //    name3.ForeColor = Color.White;
            //    rank3.ForeColor = Color.White;
            //    rep3.ForeColor = Color.White;
            //    task3.ForeColor = Color.White;
            //    time3.ForeColor = Color.White;
            //}
            //else if (panelNumber == 2)
            //{
            //    flowLayoutPanel2.BackColor = Color.Gold;
            //    name2.ForeColor = Color.White;
            //    rank2.ForeColor = Color.White;
            //    rep2.ForeColor = Color.White;
            //    task2.ForeColor = Color.White;
            //    time2.ForeColor = Color.White;
            //}
            //else if (panelNumber == 1)
            //{
            //    flowLayoutPanel1.BackColor = Color.Gold;
            //    name1.ForeColor = Color.White;
            //    rank1.ForeColor = Color.White;
            //    rep1.ForeColor = Color.White;
            //    task1.ForeColor = Color.White;
            //    time1.ForeColor = Color.White;
            //}
        }

        

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel41_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel46_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel36_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel31_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel26_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel21_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel9_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(9);

        }

        private void rank10_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(10);
        }

        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(10);
        }

        private void name10_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(10);
        }

        private void task10_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(10);
        }

        private void time10_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(10);
        }

        private void rep10_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(10);
        }

        private void UC_UserStatistics_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(1);
        }

        private void rep1_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(1);
        }

        private void time1_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(1);
        }

        private void task1_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(1);
        }

        private void name1_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(1);
        }

        private void rank1_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(1);
        }

        private void profile1_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(1);
        }
    }
}
