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
    public partial class UC_UserAccounts : UserControl
    {
        public static GridViewHelper gridViewHelper = null;

        public UC_UserAccounts()
        {
            InitializeComponent();
            gridViewHelper.Form = this;
            gridViewHelper.BunifuCustomDataGrid = bunifuCustomDataGrid1;
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

            }

        }
    }
}
