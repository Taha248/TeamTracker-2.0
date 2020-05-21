using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using TeamTracker2._0;

namespace GridViewExample
{
    public partial class Form1 : Form
    {
        BindingSource bs = new BindingSource();
        BindingList<DataTable> tables = new BindingList<DataTable>();
        GridViewHelper gridViewHelper = null;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            generateGridView();
        }

        private void generateGridView()
        {
            // Implementation 
            
            //gridViewHelper = new GridViewHelper(" Progress,taskID AS TaskID, TaskDesc , TaskTitle AS TaskName," +
            //                                    "TaskStatus AS Status,LastDate AS LastDate", "task", null, this, bunifuCustomDataGrid1);

            //gridViewHelper.addProgressBarColumn("Progress", gridViewHelper.getColumnValues("Progress"),  Color.LightGreen, 5);

            //gridViewHelper.addEditColumn();
            //gridViewHelper.addDeleteColumn();

            //gridViewHelper.hideColumn(0);
            //gridViewHelper.hideColumn(1);
            //gridViewHelper.hideColumn(2);

            //gridViewHelper.enableSearchEngine(new String[]{ "Status", "TaskName"});

            //gridViewHelper.addColumnWidth(3, 168);
            //gridViewHelper.addColumnWidth(4, 100);
            //gridViewHelper.addColumnWidth(5, 81);
            //gridViewHelper.addColumnWidth(6, 50);
            //gridViewHelper.addColumnWidth(7, 53);
            //gridViewHelper.addColumnWidth(8, 53);
            //gridViewHelper.adjustWidth();

            //gridViewHelper.addContentClickEvent(bunifuCustomDataGrid_CellContentClick);

        }

        private void bunifuCustomDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GlassyPanel panel = new GlassyPanel();

            if (gridViewHelper.IsEditEnable && e.ColumnIndex == bunifuCustomDataGrid1.ColumnCount - 2)
            {
                string value = this.bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                //        MessageBox.Show(value);
                panel.Height = this.Height;
                panel.Width = this.Width;
                this.Controls.Add(panel);
                panel.BringToFront();
                DataManupilation dm = null;

             //   var c = GetAll(dm, typeof(TextBox));

                DataTable reader = ManData.getDataReader(" * ", "task", " taskID=" + value);
                foreach (DataRow row in reader.Rows) {
                    dm.Taskid.Text = row["TaskId"].ToString();
                    dm.TaskTitle1.Text = row["TaskTitle"].ToString();
                    dm.TaskDesc1.Text = row["TaskDesc"].ToString();
                    dm.TxtProgress.Text = row["Progress"].ToString();
                    dm.TaskStatus1.Text = row["TaskStatus"].ToString();
                    dm.TaskStatus1.Text = row["AssignedTo"].ToString();
                    dm.LastDate1.Text = row["LastDate"].ToString();
                    dm.Extension_reason1.Text = row["Extension_reason"].ToString();

                }

                /*
                 
SELECT TaskStatus FROM task GROUP BY TaskStatus

SELECT UserID,NAME FROM USER GROUP BY UserID
                 */
                DataTable dt_Task = ManData.getDataReader("TaskStatus", "task", "1=1  GROUP BY TaskStatus");

                //foreach (DataRow row in dt_Task.Rows)
                //{
                //    ComboboxItem item = new ComboboxItem();
                //    item.Text = "Item text1";
                //    item.Value = 12;

                //    dm.TaskStatus1.Items.ad

                //    comboBox1.SelectedIndex = 0;

                //    MessageBox.Show((comboBox1.SelectedItem as ComboboxItem).Value.ToString());
                //    dm.TaskStatus1.Text = row["TaskStatus"].ToString();
                
                //}

                DataTable dt_User = ManData.getDataReader("UserID,Name", "USER", "1=1  GROUP BY UserID");

                // TaskId,TaskTitle,TaskDesc,Progress,TaskStatus,AssignedTo,LastDate,DateOfCreation,LastUpdated,Extension_reason
                try
                {
                    //using (var conn = ManData.getConnection())
                    //{
                    //    conn.Open();
                    //    while (reader.Read())
                    //    {
                    //        dm.Taskid.Text = reader["TaskId"].ToString();
                    //        dm.TaskTitle1.Text = reader["TaskTitle"].ToString();
                    //        dm.TaskDesc1.Text = reader["TaskDesc"].ToString();
                    //        dm.TxtProgress.Text = reader["Progress"].ToString();
                    //        dm.TaskStatus1.Text = reader["TaskStatus"].ToString();
                    //        dm.TaskStatus1.Text = reader["AssignedTo"].ToString();
                    //        dm.LastDate1.Text = reader["LastDate"].ToString();
                    //        dm.Extension_reason1.Text = reader["Extension_reason"].ToString();

                    //    }
                    //}

                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                dm.Show();


            }
            else if (gridViewHelper.IsDeleteEnable && e.ColumnIndex == bunifuCustomDataGrid1.ColumnCount - 1)
            {
                string value =
                this.bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                //          MessageBox.Show(value);
            }
        }
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridViewHelper.reloadGridView();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
