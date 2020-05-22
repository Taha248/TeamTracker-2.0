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
        GridViewHelper gridViewHelper = null;

        public UC_UserAccounts()
        {
            InitializeComponent();
            gridViewHelper = new GridViewHelper("NAME as Name,Username as UserName,PASSWORD as Password", "user",null, this, bunifuCustomDataGrid1);

        }

        private void UC_UserAccounts_Load(object sender, EventArgs e)
        {

        }

        bool isPainted = false;
        private void bunifuCustomDataGrid1_Paint(object sender, PaintEventArgs e)
        {
            if (!isPainted)
            {
            //    //gridViewHelper.addProgressBarColumn("Progress", gridViewHelper.getColumnValues("Progress"), Color.LightGreen, 5);
                gridViewHelper.addEditColumn();
                gridViewHelper.addDeleteColumn();
                gridViewHelper.enableSearchEngine(new String[] { "Name"});

            //    //gridViewHelper.addColumnWidth(3, 120);
            //        gridViewHelper.addColumnWidth(4, 70);
            //        gridViewHelper.addColumnWidth(5, 81);
            //    //gridViewHelper.addColumnWidth(6, 50);
            //    gridViewHelper.addColumnWidth(7, 53);
            //    gridViewHelper.addColumnWidth(8, 33);
            //    //    gridViewHelper.adjustWidth();
            //    //gridViewHelper.hideColumn(0);
            //    //gridViewHelper.hideColumn(1);
            //    //gridViewHelper.hideColumn(2);

            //    panel1.SendToBack();
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
    }
}
