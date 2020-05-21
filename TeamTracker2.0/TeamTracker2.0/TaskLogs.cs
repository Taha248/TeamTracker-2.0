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
        public TaskLogs()
        {
            InitializeComponent();
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
    }
}
