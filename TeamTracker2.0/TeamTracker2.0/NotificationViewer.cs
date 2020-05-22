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
    public partial class NotificationViewer : Form
    {
        public NotificationViewer()
        {
            InitializeComponent();
        }

        private void NotificationViewer_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            var sb = new SolidBrush(Color.FromArgb(100, 100, 100, 100));
            e.Graphics.FillRectangle(sb, this.DisplayRectangle);
        }

        private void notiCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void notiCross_MouseHover(object sender, EventArgs e)
        {
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#DD3F34");
            notiCross.BackColor = col;
            notiCross.ForeColor = Color.White;
        }

        private void notiCross_MouseLeave(object sender, EventArgs e)
        {
            notiCross.ForeColor = Color.LightGray;
            notiCross.BackColor = Color.Transparent;
        }
    }
}
