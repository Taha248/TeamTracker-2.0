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
    public partial class ChangePassword : Form
    {
        MainBoard mainBoard = new MainBoard();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void notiCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void notiCross_MouseHover(object sender, EventArgs e)
        {
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#DD3F34");
            changepassCross.BackColor = col;
            changepassCross.ForeColor = Color.White;
        }

        private void notiCross_MouseLeave(object sender, EventArgs e)
        {
            changepassCross.ForeColor = Color.LightGray;
            changepassCross.BackColor = Color.Transparent;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            var sb = new SolidBrush(Color.FromArgb(100, 100, 100, 100));
            e.Graphics.FillRectangle(sb, this.DisplayRectangle);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            comparePassword();
        }

        private void comparePassword()
        {
            if (textBox1.Text.Equals(textBox2.Text)) { mainBoard.GenerateNotification("Password Saved", messageType.Success); }
            else { mainBoard.GenerateNotification("Passwords Don Not Match!", messageType.Custom); }
        }
    }
}
