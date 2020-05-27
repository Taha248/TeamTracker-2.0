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
    public partial class UC_UserAccounts : UserControl
    {
        public static GridViewHelper gridViewHelper = null;
        public static F_EDIT_ACCOUNT dm = null;
        public static Form prevForm = null;
        private string userid = null;

        public UC_UserAccounts(Form form)
        {
            InitializeComponent();
            prevForm = form;
            gridViewHelper.Form = this;
            gridViewHelper.BunifuCustomDataGrid = bunifuCustomDataGrid1;
            gridViewHelper.hideColumn(0);
        }

        private void UC_UserAccounts_Load(object sender, EventArgs e)
        {

        }

        bool isPainted = false;
        private void bunifuCustomDataGrid1_Paint(object sender, PaintEventArgs e)
        {
            if (!isPainted)
            {
                gridViewHelper.addEditColumn();
                gridViewHelper.addDeleteColumn();
                gridViewHelper.enableSearchEngine(new String[] { "Name"});
                isPainted = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridViewHelper.IsEditEnable && e.ColumnIndex == bunifuCustomDataGrid1.ColumnCount - 2)
            {
                dm = new F_EDIT_ACCOUNT(prevForm,gridViewHelper);
                //panel.BringToFront();
                string value = this.bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();

                DataTable reader = ManData.getDataReader("*","user"," USERID = '"+value+"'");

                foreach (DataRow row in reader.Rows)
                {
                    dm.UserID.Text = row["USERID"].ToString();
                    dm.UserName.Text = row["USERNAME"].ToString();
                    dm.FullName.Text = row["NAME"].ToString();
                    dm.Role.Text = row["ROLE"].ToString();
                    dm.Permission = row["PERMISSIONS"].ToString();
                }
                dm.ShowDialog();
            }
            if (gridViewHelper.IsEditEnable && e.ColumnIndex == bunifuCustomDataGrid1.ColumnCount - 1)
            {
                string value =
                this.bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                ManData.executeDeleteQuery("task", "taskID='" + value + "'");
                gridViewHelper.reloadGridView();

            }

        }
    }
}
