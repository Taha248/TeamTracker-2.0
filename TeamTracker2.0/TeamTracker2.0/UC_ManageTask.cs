﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GridViewExample;
using System.Drawing.Drawing2D;

namespace TeamTracker2._0
{
    public partial class UC_ManageTask : UserControl 
    {
        public static GridViewHelper gridViewHelper = null;
        Form prevForm = null;
        GlassyPanel panel = new GlassyPanel();
        F_EDIT_TASK dm = null;
        Color TransparencyKey = Color.Fuchsia;

        public UC_ManageTask(Form form)
        {
            prevForm = form;
            InitializeComponent();

            gridViewHelper.Form = this;
            gridViewHelper.BunifuCustomDataGrid = bunifuCustomDataGrid1;
  

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

        private void bunifuCustomDataGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


            if (gridViewHelper.IsEditEnable && e.ColumnIndex == bunifuCustomDataGrid1.ColumnCount - 2)
            {
                dm = new F_EDIT_TASK(prevForm , gridViewHelper);
                panel.BringToFront();
                string value = this.bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();

                DataTable reader = ManData.getDataReader(" * ", "task", " taskID=" + value);
                DataSet ds_status= null , ds_AssignTo = null;


                // Filling Combo Boxs


                ds_status = ManData.getDataSet("TaskStatus", "task", "1=1  GROUP BY TaskStatus");
                dm.TaskStatus1.DisplayMember = "TaskStatus";
                dm.TaskStatus1.ValueMember = "TaskStatus";
                dm.TaskStatus1.DataSource = ds_status.Tables[0];

                ds_AssignTo = ManData.getDataSet("UserID,Name", "USER", "1=1  GROUP BY UserID");
                dm.AssignedTo1.DisplayMember = "Name";
                dm.AssignedTo1.ValueMember = "UserID";
                dm.AssignedTo1.DataSource = ds_AssignTo.Tables[0];


                dm.AssignedTo1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                dm.AssignedTo1.AutoCompleteSource = AutoCompleteSource.ListItems;

                foreach (DataRow row in reader.Rows)
                {
                    dm.Taskid.Text = row["TaskId"].ToString();
                    dm.TaskTitle1.Text = row["TaskTitle"].ToString();
                    dm.TaskDesc1.Text = row["TaskDesc"].ToString();
                    dm.TxtProgress.Text = row["Progress"].ToString();
                    dm.TaskStatus1.SelectedValue = row["TaskStatus"].ToString();
                    dm.AssignedTo1.SelectedValue = row["AssignedTo"].ToString();
                    dm.LastDate1.Value = Convert.ToDateTime(row["LastDate"]);
                    dm.Extension_reason1.Text = row["Extension_reason"].ToString();

                }


                if (!String.IsNullOrEmpty(dm.Extension_reason1.Text))
                {
                    dm.Extension_reason1.Visible = true;
                    dm.ChkboxExtend.Checked = true;
                    dm.Lbl_text1.Visible = true;
                    dm.LastDate1.Enabled = true;
                }

             


                dm.ShowDialog();


            }
            else if (gridViewHelper.IsDeleteEnable && e.ColumnIndex == bunifuCustomDataGrid1.ColumnCount - 1)
            {
                string value =
                this.bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                ManData.executeDeleteQuery("task", "taskID='" + value + "'");
                gridViewHelper.reloadGridView();
            }
    }

        private void UC_ManageTask_Paint(object sender, PaintEventArgs e)
        {
            var hb = new HatchBrush(HatchStyle.Percent50, this.TransparencyKey);

            e.Graphics.FillRectangle(hb, this.DisplayRectangle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds_status = null, ds_AssignTo = null;
            F_ADD_TASK addTask = new F_ADD_TASK(prevForm,gridViewHelper);
            addTask.Taskid.Text = ManData.getNewId("Task","taskID");
            ds_status = ManData.getDataSet("TaskStatus", "task", "1=1  GROUP BY TaskStatus");
            addTask.TaskStatus1.DisplayMember = "TaskStatus";
            addTask.TaskStatus1.ValueMember = "TaskStatus";
            addTask.TaskStatus1.DataSource = ds_status.Tables[0];
            addTask.TaskStatus1.SelectedIndex = 1;
            addTask.TaskStatus1.Enabled = false;

            addTask.TxtProgress.Text = "0%";
            addTask.TxtProgress.Enabled = false;


            ds_AssignTo = ManData.getDataSet("UserID,Name", "USER", "1=1  GROUP BY UserID");
            addTask.AssignedTo1.DisplayMember = "Name";
            addTask.AssignedTo1.ValueMember = "UserID";
            addTask.AssignedTo1.DataSource = ds_AssignTo.Tables[0];

            addTask.AssignedTo1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            addTask.AssignedTo1.AutoCompleteSource = AutoCompleteSource.ListItems;
            addTask.Show();



        }
    }
}
