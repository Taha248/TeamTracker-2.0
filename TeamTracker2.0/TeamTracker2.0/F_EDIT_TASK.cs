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
    public partial class F_EDIT_TASK : EditScreenGeneral
    {
        private GlassyPanel prevPanel;
        private TextBox taskid = null;
        private TextBox TaskTitle = null;
        private RichTextBox TaskDesc = null;
        private TextBox txtProgress = null;
        private ComboBox TaskStatus = null;
        private ComboBox AssignedTo = null;
        private DateTimePicker LastDate = null;
        private DateTimePicker LastTime = null;
        private TextBox Extension_reason = null;
        private BunifuCustomLabel lbl_text = null;
        private CheckBox chkboxExtend = null;
        private Form prevForm = null;
        private GridViewHelper gridView = null;


        public TextBox Taskid
        {
            get
            {
                return taskid;
            }

            set
            {
                taskid = value;
            }
        }

        public TextBox TaskTitle1
        {
            get
            {
                return TaskTitle;
            }

            set
            {
                TaskTitle = value;
            }
        }

        public RichTextBox TaskDesc1
        {
            get
            {
                return TaskDesc;
            }

            set
            {
                TaskDesc = value;
            }
        }

        public TextBox TxtProgress
        {
            get
            {
                return txtProgress;
            }

            set
            {
                txtProgress = value;
            }
        }

        public ComboBox TaskStatus1
        {
            get
            {
                return TaskStatus;
            }

            set
            {
                TaskStatus = value;
            }
        }

        public ComboBox AssignedTo1
        {
            get
            {
                return AssignedTo;
            }

            set
            {
                AssignedTo = value;
            }
        }

        public DateTimePicker LastDate1
        {
            get
            {
                return LastDate;
            }

            set
            {
                LastDate = value;
            }
        }

        public DateTimePicker LastTime1
        {
            get
            {
                return LastTime;
            }

            set
            {
                LastTime = value;
            }
        }

        public TextBox Extension_reason1
        {
            get
            {
                return Extension_reason;
            }

            set
            {
                Extension_reason = value;
            }
        }

        public BunifuCustomLabel Lbl_text
        {
            get
            {
                return Lbl_text1;
            }

            set
            {
                Lbl_text1 = value;
            }
        }

        public BunifuCustomLabel Lbl_text1
        {
            get
            {
                return lbl_text;
            }

            set
            {
                lbl_text = value;
            }
        }

        public CheckBox ChkboxExtend
        {
            get
            {
                return chkboxExtend;
            }

            set
            {
                chkboxExtend = value;
            }
        }

        // TaskId,TaskTitle,TaskDesc,Progress,TaskStatus,AssignedTo,LastDate,DateOfCreation,LastUpdated,Extension_reason
        public F_EDIT_TASK()
        {
            InitializeComponent();
            txt_date.Format = DateTimePickerFormat.Custom;
            txt_date.CustomFormat = "MM/dd/yyyy   hh:mm:ss";

            this.Taskid = txt_taskid;
            this.TaskTitle1 = txt_tasktitle;
            this.TaskDesc1 = txt_taskDTL;
            this.TxtProgress = txt_progress;
            this.TaskStatus1 = dropdownSts;
            this.AssignedTo1 = dropDownAssTo;
            this.LastDate1 = txt_date;
            this.Extension_reason1 = txtExtension;
            this.ChkboxExtend = chkbox_extend;
            this.Lbl_text1 = bunifuCustomLabel4;



        }

        public F_EDIT_TASK(Form prevForm , GridViewHelper gridView )
        {
            this.gridView = gridView;
            this.prevForm = prevForm;

            InitializeComponent();
            txt_date.Format = DateTimePickerFormat.Custom;
            txt_date.CustomFormat = "MM/dd/yyyy   hh:mm:ss";

            this.Taskid = txt_taskid;
            this.TaskTitle1 = txt_tasktitle;
            this.TaskDesc1 = txt_taskDTL;
            this.TxtProgress = txt_progress;
            this.TaskStatus1 = dropdownSts;
            this.AssignedTo1 = dropDownAssTo;
            this.LastDate1 = txt_date;
            this.Extension_reason1 = txtExtension;
            this.ChkboxExtend = chkbox_extend;
            this.Lbl_text1 = bunifuCustomLabel4;


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
            Dictionary<string, string> updateList = new Dictionary<string, string>();

            updateList.Add("TaskTitle", txt_tasktitle.Text);
            updateList.Add("TaskDesc", txt_taskDTL.Text);
            updateList.Add("Progress", txt_progress.Text);
            updateList.Add("TaskStatus", dropdownSts.Text);
            updateList.Add("AssignedTo", dropDownAssTo.SelectedValue.ToString());
            //6/2/2019 3:32:29 AM

            if (chkbox_extend.Checked) { 
                updateList.Add("LastDate",  LastDate.Value.Date.ToString("yyyy-MM-dd h:mm:ss tt"));
                updateList.Add("Extension_Reason", Extension_reason.Text);
            }

            ManData.executeUpdateQuery(updateList,"task"," taskID = '"+taskid.Text+"'");
            gridView.reloadGridView();
            this.Close();
        }

        private void F_EDIT_TASK_Paint(object sender, PaintEventArgs e)
        {
            var hb = new HatchBrush(HatchStyle.Percent50, this.TransparencyKey);
            e.Graphics.FillRectangle(hb, this.DisplayRectangle);
        }

        private void F_EDIT_TASK_Load(object sender, EventArgs e)
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

        private void chkbox_extend_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_extend.Checked)
            {
                txtExtension.Visible = true;
                bunifuCustomLabel4.Visible = true;
                txt_date.Enabled = true;
            }
            else {

                txtExtension.Visible = false;
                bunifuCustomLabel4.Visible = false;
                txt_date.Enabled = false;
            }
        }
    }
}
