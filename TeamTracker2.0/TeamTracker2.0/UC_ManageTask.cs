using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GridViewExample;

namespace TeamTracker2._0
{
    public partial class UC_ManageTask : UserControl 
    {
        GridViewHelper gridViewHelper = null;
        Form prevForm = null;
        public UC_ManageTask(Form form)
        {
            prevForm = form;
            InitializeComponent();
            gridViewHelper = new GridViewHelper(" Progress,taskID AS TaskID, TaskDesc , TaskTitle AS TaskName," +
                                      "TaskStatus AS Status,LastDate AS LastDate", "task", null, this, bunifuCustomDataGrid1);

        }

        private void UC_ManageTask_Load(object sender, EventArgs e)
        {
            generateGridView();

        }
        private void generateGridView()
        {
            // Implementation 
            //
    


            //     gridViewHelper.addContentClickEvent(bunifuCustomDataGrid_CellContentClick);
            //    gridViewHelper.addContentClickEvent(bunifuCustomDataGrid_CellContentClick);

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //bunifuCustomDataGrid1.Rows[0].Cells[8].Value = TeamTracker2._0.Properties.Resources.bbb;

        }
        bool isPainted = false;
        private void bunifuCustomDataGrid1_Paint(object sender, PaintEventArgs e)
        {
            if (!isPainted)
            {
                gridViewHelper.addProgressBarColumn("Progress", gridViewHelper.getColumnValues("Progress"), Color.LightGreen, 5);
                gridViewHelper.addEditColumn();
                gridViewHelper.addDeleteColumn();
                gridViewHelper.enableSearchEngine(new String[] { "Status", "TaskName" });

                gridViewHelper.addColumnWidth(3, 120);
                gridViewHelper.addColumnWidth(4, 70);
                gridViewHelper.addColumnWidth(5, 81);
                gridViewHelper.addColumnWidth(6, 50);
                gridViewHelper.addColumnWidth(7, 53);
                gridViewHelper.addColumnWidth(8, 33);
                gridViewHelper.adjustWidth();
                gridViewHelper.hideColumn(0);
                gridViewHelper.hideColumn(1);
                gridViewHelper.hideColumn(2);

                panel1.SendToBack();
                isPainted = true;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
