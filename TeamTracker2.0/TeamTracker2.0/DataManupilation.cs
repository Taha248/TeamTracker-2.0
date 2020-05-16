using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridViewExample
{
    public partial class DataManupilation : EditScreenGeneral
    {
        private GlassyPanel prevPanel;
        private TextBox taskid = null;
        private TextBox TaskTitle = null;
        private RichTextBox TaskDesc = null;
        private TextBox txtProgress = null;
        private BunifuDropdown TaskStatus = null;
        private BunifuDropdown AssignedTo = null;
        private DateTimePicker LastDate = null;
        private DateTimePicker LastTime = null;
        private TextBox Extension_reason = null;

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

        public BunifuDropdown TaskStatus1
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

        public BunifuDropdown AssignedTo1
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

        // TaskId,TaskTitle,TaskDesc,Progress,TaskStatus,AssignedTo,LastDate,DateOfCreation,LastUpdated,Extension_reason
        public DataManupilation()
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

        }

        public DataManupilation(GlassyPanel prevPanel)
        {
            this.prevPanel = prevPanel;

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
        }

        private void lbl_cross_Click(object sender, EventArgs e)
        {
            this.Close();
            prevPanel.Hide();
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
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);

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
    }
}
