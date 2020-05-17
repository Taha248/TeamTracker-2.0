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
                    row.BackColor = ColorTranslator.FromHtml("#FFCC00");//Color.FromArgb(27,194,230);
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
                    row.BackColor = Color.White;
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
            if (panelNumber == 10)
            {
                flowLayoutPanel10.BackColor = ColorTranslator.FromHtml("#FFCC00");//Color.FromArgb(27,194,230);
                name10.ForeColor = Color.White;
                rank10.ForeColor = Color.White;
                rep10.ForeColor = Color.White;
                task10.ForeColor = Color.White;
                time10.ForeColor = Color.White;
            }
            else
            {
                flowLayoutPanel10.BackColor = Color.White;
                name10.ForeColor = Color.Black;
                rank10.ForeColor = Color.Black;
                rep10.ForeColor = Color.Black;
                task10.ForeColor = Color.Black;
                time10.ForeColor = Color.Black;
            }
            if (panelNumber == 9)
            {
                flowLayoutPanel9.BackColor = ColorTranslator.FromHtml("#FFCC00");//Color.FromArgb(27,194,230);
                name9.ForeColor = Color.White;
                rank9.ForeColor = Color.White;
                rep9.ForeColor = Color.White;
                task9.ForeColor = Color.White;
                time9.ForeColor = Color.White;
            }
            else
            {
                flowLayoutPanel9.BackColor = Color.White;
                name9.ForeColor = Color.Black;
                rank9.ForeColor = Color.Black;
                rep9.ForeColor = Color.Black;
                task9.ForeColor = Color.Black;
                time9.ForeColor = Color.Black;
            }
            if (panelNumber == 8)
            {
                flowLayoutPanel8.BackColor = ColorTranslator.FromHtml("#FFCC00");//Color.FromArgb(27,194,230);
                name8.ForeColor = Color.White;
                rank8.ForeColor = Color.White;
                rep8.ForeColor = Color.White;
                task8.ForeColor = Color.White;
                time8.ForeColor = Color.White;
            }
            else
            {
                flowLayoutPanel8.BackColor = Color.White;
                name8.ForeColor = Color.Black;
                rank8.ForeColor = Color.Black;
                rep8.ForeColor = Color.Black;
                task8.ForeColor = Color.Black;
                time8.ForeColor = Color.Black;
            }
            if (panelNumber == 7)
            {
                flowLayoutPanel7.BackColor = ColorTranslator.FromHtml("#FFCC00");//Color.FromArgb(27,194,230);
                name7.ForeColor = Color.White;
                rank7.ForeColor = Color.White;
                rep7.ForeColor = Color.White;
                task7.ForeColor = Color.White;
                time7.ForeColor = Color.White;
            }
            else
            {
                flowLayoutPanel7.BackColor = Color.White;
                name7.ForeColor = Color.Black;
                rank7.ForeColor = Color.Black;
                rep7.ForeColor = Color.Black;
                task7.ForeColor = Color.Black;
                time7.ForeColor = Color.Black;
            }
            if (panelNumber == 6)
            {
                flowLayoutPanel6.BackColor = ColorTranslator.FromHtml("#FFCC00");//Color.FromArgb(27,194,230);
                name6.ForeColor = Color.White;
                rank6.ForeColor = Color.White;
                rep6.ForeColor = Color.White;
                task6.ForeColor = Color.White;
                time6.ForeColor = Color.White;
            }
            else
            {
                flowLayoutPanel6.BackColor = Color.White;
                name6.ForeColor = Color.Black;
                rank6.ForeColor = Color.Black;
                rep6.ForeColor = Color.Black;
                task6.ForeColor = Color.Black;
                time6.ForeColor = Color.Black;
            }
            if (panelNumber == 5)
            {
                flowLayoutPanel5.BackColor = ColorTranslator.FromHtml("#FFCC00");//Color.FromArgb(27,194,230);
                name5.ForeColor = Color.White;
                rank5.ForeColor = Color.White;
                rep5.ForeColor = Color.White;
                task5.ForeColor = Color.White;
                time5.ForeColor = Color.White;
            }
            else
            {
                flowLayoutPanel5.BackColor = Color.White;
                name5.ForeColor = Color.Black;
                rank5.ForeColor = Color.Black;
                rep5.ForeColor = Color.Black;
                task5.ForeColor = Color.Black;
                time5.ForeColor = Color.Black;
            }
            if (panelNumber == 4)
            {
                flowLayoutPanel4.BackColor = ColorTranslator.FromHtml("#FFCC00");//Color.FromArgb(27,194,230);
                name4.ForeColor = Color.White;
                rank4.ForeColor = Color.White;
                rep4.ForeColor = Color.White;
                task4.ForeColor = Color.White;
                time4.ForeColor = Color.White;
            }
            else
            {
                flowLayoutPanel4.BackColor = Color.White;
                name4.ForeColor = Color.Black;
                rank4.ForeColor = Color.Black;
                rep4.ForeColor = Color.Black;
                task4.ForeColor = Color.Black;
                time4.ForeColor = Color.Black;
            }
            if (panelNumber == 3)
            {
                flowLayoutPanel3.BackColor = ColorTranslator.FromHtml("#FFCC00");//Color.FromArgb(27,194,230);
                name3.ForeColor = Color.White;
                rank3.ForeColor = Color.White;
                rep3.ForeColor = Color.White;
                task3.ForeColor = Color.White;
                time3.ForeColor = Color.White;
            }
            else
            {
                flowLayoutPanel3.BackColor = Color.White;
                name3.ForeColor = Color.Black;
                rank3.ForeColor = Color.Black;
                rep3.ForeColor = Color.Black;
                task3.ForeColor = Color.Black;
                time3.ForeColor = Color.Black;
            }
            if (panelNumber == 2)
            {
                flowLayoutPanel2.BackColor = ColorTranslator.FromHtml("#FFCC00");//Color.FromArgb(27,194,230);
                name2.ForeColor = Color.White;
                rank2.ForeColor = Color.White;
                rep2.ForeColor = Color.White;
                task2.ForeColor = Color.White;
                time2.ForeColor = Color.White;
            }
            else
            {
                flowLayoutPanel2.BackColor = Color.White;
                name2.ForeColor = Color.Black;
                rank2.ForeColor = Color.Black;
                rep2.ForeColor = Color.Black;
                task2.ForeColor = Color.Black;
                time2.ForeColor = Color.Black;
            }
            if (panelNumber == 1)
            {
                flowLayoutPanel1.BackColor = ColorTranslator.FromHtml("#FFCC00");//Color.FromArgb(27,194,230);
                name1.ForeColor = Color.White;
                rank1.ForeColor = Color.White;
                rep1.ForeColor = Color.White;
                task1.ForeColor = Color.White;
                time1.ForeColor = Color.White;
            }
            else
            {
                flowLayoutPanel1.BackColor = Color.White;
                name1.ForeColor = Color.Black;
                rank1.ForeColor = Color.Black;
                rep1.ForeColor = Color.Black;
                task1.ForeColor = Color.Black;
                time1.ForeColor = Color.Black;
            }
        }

        

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel41_Click(object sender, EventArgs e)
        {
            selectedRowChange(9);
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

        private void time9_Click(object sender, EventArgs e)
        {

        }

        private void time9_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(9);
        }

        private void rep9_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(9);
        }

        private void task9_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(9);
        }

        private void name9_MouseHover(object sender, EventArgs e)
        {
            selectedRowChange(9);
        }

        private void name9_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(9);
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(9);
        }

        private void rank9_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(9);
        }

        private void flowLayoutPanel2_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(2);
        }

        private void flowLayoutPanel3_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(3);
        }

        private void flowLayoutPanel4_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(4);
        }

        private void flowLayoutPanel5_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(5);
        }

        private void flowLayoutPanel6_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(6);
        }

        private void flowLayoutPanel7_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(7);
        }

        private void flowLayoutPanel8_MouseHover(object sender, EventArgs e)
        {
            selectedRowChange(8);
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click_1(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click_1(object sender, EventArgs e)
        {

        }

        private void name1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rank2_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(2);
        }

        private void profile2_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(2);
        }

        private void name2_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(2);
        }

        private void task2_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(2);
        }
        private void time2_MouseClick_1(object sender, MouseEventArgs e)
        {
            selectedRowChange(2);
        }

        private void rep2_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(2);
        }

        private void name3_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(3);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(3);
        }

        private void rank3_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(3);
        }

        private void task3_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(3);
        }

        private void time3_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(3);
        }

        private void rep3_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(3);
        }

        private void rank4_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(4);
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(4);
        }

        private void name4_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(4);
        }

        private void task4_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(4);
        }

        private void time4_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(4);
        }

        private void rep4_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(4);
        }

        private void rank5_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(5);
        }

        private void rank5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void name5_Click(object sender, EventArgs e)
        {

        }

        private void task5_Click(object sender, EventArgs e)
        {

        }

        private void time5_Click(object sender, EventArgs e)
        {

        }

        private void rank5_MouseClick_1(object sender, MouseEventArgs e)
        {
            selectedRowChange(5);
        }

        private void rank6_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(6);
        }

        private void rank7_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(7);
        }

        private void rank8_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRowChange(8);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
