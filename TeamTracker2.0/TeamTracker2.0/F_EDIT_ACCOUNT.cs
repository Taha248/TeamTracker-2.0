using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker2._0;

namespace GridViewExample
{
    public partial class F_EDIT_ACCOUNT : EditScreenGeneral
    {
        private TextBox userID = null;
        private TextBox userName = null;
        private TextBox fullName = null;
        private TextBox role = null;
        private String permission = null;
        private Form prevForm = null;
        private GridViewHelper gridView = null;

        public TextBox UserID
        {
            get
            {
                return userID;
            }

            set
            {
                userID = value;
            }
        }

        public TextBox UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public TextBox FullName
        {
            get
            {
                return fullName;
            }

            set
            {
                fullName = value;
            }
        }

        public TextBox Role
        {
            get
            {
                return role;
            }

            set
            {
                role = value;
            }
        }

        public string Permission
        {
            get
            {
                return permission;
            }

            set
            {
                permission = value;
            }
        }


        // TaskId,TaskTitle,TaskDesc,Progress,TaskStatus,AssignedTo,LastDate,DateOfCreation,LastUpdated,Extension_reason
        public F_EDIT_ACCOUNT()
        {
            InitializeComponent();
            //txt_date.Format = DateTimePickerFormat.Custom;
            //txt_date.CustomFormat = "MM/dd/yyyy   hh:mm:ss";

            //this.Taskid = txt_taskid;
            //this.TaskTitle1 = txt_Username;
            //this.TxtProgress = txt_progress;
            //this.TaskStatus1 = dropdownSts;
            //this.AssignedTo1 = dropDownAssTo;
            //this.LastDate1 = txt_date;
            //this.Extension_reason1 = txtExtension;
            //this.ChkboxExtend = chkbox_extend;
            //this.Lbl_text1 = bunifuCustomLabel4;



        }

        public F_EDIT_ACCOUNT(Form prevForm , GridViewHelper gridView )
        {
            this.gridView = gridView;
            this.prevForm = prevForm;

            InitializeComponent();

            this.userID = txt_taskid;
            this.userName = txt_Username;
            this.fullName = txt_Name;
            this.role = txt_Role;


        }

        private void lbl_cross_Click(object sender, EventArgs e)
        {
            this.Close();
          //  prevPanel.Hide();
        }


        private void lbl_cross_MouseHover(object sender, EventArgs e)
        {
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#DD3F34");
            panel_cross.BackColor = col;
            lbl_cross.BackColor = col;
            lbl_cross.ForeColor = Color.White;
        }
        private void panel_cross_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel_cross_MouseLeave(object sender, EventArgs e)
        {
            panel_cross.BackColor = Color.Transparent;
            lbl_cross.ForeColor = Color.LightGray;
            lbl_cross.BackColor = Color.Transparent;
        }

        private void lbl_cross_MouseLeave(object sender, EventArgs e)
        {
            panel_cross.BackColor = Color.Transparent;
            lbl_cross.BackColor = Color.Transparent;
            lbl_cross.ForeColor = Color.LightGray;
        }

        private void lbl_cross_MoauseHover(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
       //     ControlPaint.DrawBorder(e.Graphics, this.dropdownSts.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel3.ClientRectangle, Color.LightGray, ButtonBorderStyle.Dashed);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void F_EDIT_ACCOUNT_Paint(object sender, PaintEventArgs e)
        {
            var hb = new HatchBrush(HatchStyle.Percent50, this.TransparencyKey);
            e.Graphics.FillRectangle(hb, this.DisplayRectangle);
        }

        private void F_EDIT_ACCOUNT_Load(object sender, EventArgs e)
        {

            this.Height = prevForm.Height;
            this.Width = prevForm.Width;
            this.Location = prevForm.Location;


        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            var sb = new SolidBrush(Color.FromArgb(100, 100, 100, 100));
            e.Graphics.FillRectangle(sb, this.DisplayRectangle);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> updateList = new Dictionary<string, string>();

             updateList.Add("USERNAME", txt_Username.Text);
             updateList.Add("NAME", txt_Name.Text);
             updateList.Add("ROLE", txt_Role.Text);


            ManData.executeUpdateQuery(updateList, "task", " taskID = '" + userID.Text + "'");
            gridView.reloadGridView();
            this.Close();
        }

        private void btn_Previllages_Click(object sender, EventArgs e)
        {
            UC_Permissions permissions = new UC_Permissions();
            panel4.Controls.Add(permissions);
            panel4.BringToFront();

        }
    }
}
