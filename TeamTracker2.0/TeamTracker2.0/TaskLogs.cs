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
    public partial class TaskLogs : Form
    {
        GridViewHelper gridViewHelper = null;
        public static int userID=2;
        public TaskLogs()
        {
            InitializeComponent();

            gridViewHelper = new GridViewHelper("taskTitle as Task,taskstatus as Status ,progress as Progress,lastdate as Deadline, DeadlineCrossed as DeadlineCrossed", "task", "AssignedTo = '"+userID+"' ORDER BY lastdate DESC ", null, bunifuCustomDataGrid1);

        }

        private void TaskLogs_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            var sb = new SolidBrush(Color.FromArgb(100, 100, 100, 100));
            e.Graphics.FillRectangle(sb, this.DisplayRectangle);
        }

        private void lbl_cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_cross_MouseHover(object sender, EventArgs e)
        {
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#DD3F34");
            lbl_cross.BackColor = col;
            lbl_cross.ForeColor = Color.White;
        }

        private void lbl_cross_MouseLeave(object sender, EventArgs e)
        {
            lbl_cross.ForeColor = Color.LightGray;
            lbl_cross.BackColor = Color.Transparent;
        }

        private void lbl_cross_Click_1(object sender, EventArgs e)
        {

        }

        private void taskLog_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, Color.LightGray, ButtonBorderStyle.Dashed);
        }
        bool isPainted;
        private void bunifuCustomDataGrid1_Paint(object sender, PaintEventArgs e)
        {
            if (!isPainted)
            {
                //gridViewHelper.addProgressBarColumn("Progress", gridViewHelper.getColumnValues("Progress"), Color.LightGreen, 5);
                //gridViewHelper.addEditColumn();
                //gridViewHelper.addDeleteColumn();
                //gridViewHelper.enableSearchEngine(new String[] { "Status", "Task" });

                //   gridViewHelper.addColumnWidth(3, 120);
                //   gridViewHelper.addColumnWidth(4, 70);
                //    gridViewHelper.addColumnWidth(5, 81);
                //gridViewHelper.addColumnWidth(6, 50);
                gridViewHelper.addColumnWidth(1, 80);
                gridViewHelper.addColumnWidth(2, 80);
                gridViewHelper.addColumnWidth(3, 110);
                gridViewHelper.adjustWidth();
                //gridViewHelper.hideColumn(0);
                //gridViewHelper.hideColumn(1);
                //gridViewHelper.hideColumn(2);

                panel1.SendToBack();
                isPainted = true;
            }
        }
    }
}
