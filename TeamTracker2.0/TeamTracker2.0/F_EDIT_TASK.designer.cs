using Bunifu.Framework.UI;
using System;

namespace GridViewExample
{
    partial class F_EDIT_TASK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_EDIT_TASK));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_cross = new System.Windows.Forms.Panel();
            this.lbl_cross = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_taskdtl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkbox_extend = new System.Windows.Forms.CheckBox();
            this.dropDownAssTo = new System.Windows.Forms.ComboBox();
            this.dropdownSts = new System.Windows.Forms.ComboBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.txt_progress = new System.Windows.Forms.TextBox();
            this.txt_taskDTL = new System.Windows.Forms.RichTextBox();
            this.txt_tasktitle = new System.Windows.Forms.TextBox();
            this.txt_taskid = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Progress = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Detail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.panel_cross.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel_cross);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 522);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_cross
            // 
            this.panel_cross.Controls.Add(this.lbl_cross);
            this.panel_cross.ForeColor = System.Drawing.Color.Transparent;
            this.panel_cross.Location = new System.Drawing.Point(595, 37);
            this.panel_cross.Name = "panel_cross";
            this.panel_cross.Size = new System.Drawing.Size(26, 19);
            this.panel_cross.TabIndex = 2;
            this.panel_cross.Click += new System.EventHandler(this.lbl_cross_Click);
            this.panel_cross.MouseLeave += new System.EventHandler(this.lbl_cross_MouseLeave);
            this.panel_cross.MouseHover += new System.EventHandler(this.lbl_cross_MouseHover);
            // 
            // lbl_cross
            // 
            this.lbl_cross.BackColor = System.Drawing.Color.White;
            this.lbl_cross.ForeColor = System.Drawing.Color.Silver;
            this.lbl_cross.Location = new System.Drawing.Point(-1, 1);
            this.lbl_cross.Name = "lbl_cross";
            this.lbl_cross.Size = new System.Drawing.Size(26, 19);
            this.lbl_cross.TabIndex = 3;
            this.lbl_cross.Text = "x";
            this.lbl_cross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_cross.Click += new System.EventHandler(this.lbl_cross_Click);
            this.lbl_cross.MouseLeave += new System.EventHandler(this.lbl_cross_MouseLeave);
            this.lbl_cross.MouseHover += new System.EventHandler(this.lbl_cross_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbl_taskdtl);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(130, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 403);
            this.panel2.TabIndex = 3;
            // 
            // lbl_taskdtl
            // 
            this.lbl_taskdtl.AutoSize = true;
            this.lbl_taskdtl.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_taskdtl.Location = new System.Drawing.Point(15, 0);
            this.lbl_taskdtl.Name = "lbl_taskdtl";
            this.lbl_taskdtl.Size = new System.Drawing.Size(79, 16);
            this.lbl_taskdtl.TabIndex = 1;
            this.lbl_taskdtl.Text = "Task Details";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bunifuCustomLabel5);
            this.panel3.Controls.Add(this.chkbox_extend);
            this.panel3.Controls.Add(this.dropDownAssTo);
            this.panel3.Controls.Add(this.dropdownSts);
            this.panel3.Controls.Add(this.bunifuThinButton21);
            this.panel3.Controls.Add(this.txt_date);
            this.panel3.Controls.Add(this.txtExtension);
            this.panel3.Controls.Add(this.txt_progress);
            this.panel3.Controls.Add(this.txt_taskDTL);
            this.panel3.Controls.Add(this.txt_tasktitle);
            this.panel3.Controls.Add(this.txt_taskid);
            this.panel3.Controls.Add(this.bunifuCustomLabel4);
            this.panel3.Controls.Add(this.bunifuCustomLabel3);
            this.panel3.Controls.Add(this.bunifuCustomLabel2);
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.panel3.Controls.Add(this.Progress);
            this.panel3.Controls.Add(this.Detail);
            this.panel3.Controls.Add(this.Title);
            this.panel3.Location = new System.Drawing.Point(5, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 391);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // chkbox_extend
            // 
            this.chkbox_extend.AutoSize = true;
            this.chkbox_extend.Location = new System.Drawing.Point(379, 241);
            this.chkbox_extend.Name = "chkbox_extend";
            this.chkbox_extend.Size = new System.Drawing.Size(15, 14);
            this.chkbox_extend.TabIndex = 20;
            this.chkbox_extend.UseVisualStyleBackColor = true;
            this.chkbox_extend.CheckedChanged += new System.EventHandler(this.chkbox_extend_CheckedChanged);
            // 
            // dropDownAssTo
            // 
            this.dropDownAssTo.FormattingEnabled = true;
            this.dropDownAssTo.Location = new System.Drawing.Point(210, 268);
            this.dropDownAssTo.Name = "dropDownAssTo";
            this.dropDownAssTo.Size = new System.Drawing.Size(185, 21);
            this.dropDownAssTo.TabIndex = 19;
            // 
            // dropdownSts
            // 
            this.dropdownSts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownSts.FormattingEnabled = true;
            this.dropdownSts.Location = new System.Drawing.Point(209, 207);
            this.dropdownSts.Name = "dropdownSts";
            this.dropdownSts.Size = new System.Drawing.Size(185, 21);
            this.dropdownSts.TabIndex = 19;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Update";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Quicksand", 8.25F);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(202, 340);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(58, 34);
            this.bunifuThinButton21.TabIndex = 18;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // txt_date
            // 
            this.txt_date.Enabled = false;
            this.txt_date.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_date.Location = new System.Drawing.Point(209, 237);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(164, 21);
            this.txt_date.TabIndex = 17;
            // 
            // txtExtension
            // 
            this.txtExtension.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtension.Location = new System.Drawing.Point(209, 299);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(185, 24);
            this.txtExtension.TabIndex = 15;
            this.txtExtension.Visible = false;
            // 
            // txt_progress
            // 
            this.txt_progress.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_progress.Location = new System.Drawing.Point(209, 175);
            this.txt_progress.Name = "txt_progress";
            this.txt_progress.Size = new System.Drawing.Size(51, 24);
            this.txt_progress.TabIndex = 11;
            // 
            // txt_taskDTL
            // 
            this.txt_taskDTL.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taskDTL.Location = new System.Drawing.Point(209, 96);
            this.txt_taskDTL.Name = "txt_taskDTL";
            this.txt_taskDTL.Size = new System.Drawing.Size(185, 72);
            this.txt_taskDTL.TabIndex = 10;
            this.txt_taskDTL.Text = "";
            // 
            // txt_tasktitle
            // 
            this.txt_tasktitle.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tasktitle.Location = new System.Drawing.Point(210, 62);
            this.txt_tasktitle.Name = "txt_tasktitle";
            this.txt_tasktitle.Size = new System.Drawing.Size(185, 24);
            this.txt_tasktitle.TabIndex = 9;
            // 
            // txt_taskid
            // 
            this.txt_taskid.Enabled = false;
            this.txt_taskid.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taskid.Location = new System.Drawing.Point(212, 29);
            this.txt_taskid.Name = "txt_taskid";
            this.txt_taskid.Size = new System.Drawing.Size(48, 24);
            this.txt_taskid.TabIndex = 8;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Quicksand", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(59, 302);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(97, 16);
            this.bunifuCustomLabel4.TabIndex = 7;
            this.bunifuCustomLabel4.Text = "Extension Reason";
            this.bunifuCustomLabel4.Visible = false;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Quicksand", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(59, 269);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(67, 16);
            this.bunifuCustomLabel3.TabIndex = 6;
            this.bunifuCustomLabel3.Text = "Assigned to";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Quicksand", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(59, 237);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(58, 16);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Last Date";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Quicksand", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(59, 208);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(40, 16);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Status";
            // 
            // Progress
            // 
            this.Progress.AutoSize = true;
            this.Progress.Font = new System.Drawing.Font("Quicksand", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Progress.Location = new System.Drawing.Point(59, 176);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(53, 16);
            this.Progress.TabIndex = 3;
            this.Progress.Text = "Progress";
            // 
            // Detail
            // 
            this.Detail.AutoSize = true;
            this.Detail.Font = new System.Drawing.Font("Quicksand", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detail.Location = new System.Drawing.Point(59, 93);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(65, 16);
            this.Detail.TabIndex = 2;
            this.Detail.Text = "Task Detail";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Quicksand", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(59, 63);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(60, 16);
            this.Title.TabIndex = 1;
            this.Title.Text = "Task Title ";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Quicksand", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(63, 33);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(46, 16);
            this.bunifuCustomLabel5.TabIndex = 21;
            this.bunifuCustomLabel5.Text = "Task ID";
            // 
            // F_EDIT_TASK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(783, 522);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_EDIT_TASK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_EDIT_TASK";
            this.Load += new System.EventHandler(this.F_EDIT_TASK_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.F_EDIT_TASK_Paint);
            this.panel1.ResumeLayout(false);
            this.panel_cross.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_cross;
        private System.Windows.Forms.Label lbl_cross;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_taskdtl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkbox_extend;
        private System.Windows.Forms.ComboBox dropDownAssTo;
        private System.Windows.Forms.ComboBox dropdownSts;
        private BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.TextBox txt_progress;
        private System.Windows.Forms.RichTextBox txt_taskDTL;
        private System.Windows.Forms.TextBox txt_tasktitle;
        private System.Windows.Forms.TextBox txt_taskid;
        private BunifuCustomLabel bunifuCustomLabel4;
        private BunifuCustomLabel bunifuCustomLabel3;
        private BunifuCustomLabel bunifuCustomLabel2;
        private BunifuCustomLabel bunifuCustomLabel1;
        private BunifuCustomLabel Progress;
        private BunifuCustomLabel Detail;
        private BunifuCustomLabel Title;
        private BunifuCustomLabel bunifuCustomLabel5;
    }
}