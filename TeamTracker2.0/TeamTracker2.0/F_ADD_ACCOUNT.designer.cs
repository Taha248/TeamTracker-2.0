using Bunifu.Framework.UI;
using System;

namespace GridViewExample
{
    partial class F_ADD_ACCOUNT
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_cross = new System.Windows.Forms.Panel();
            this.lbl_cross = new System.Windows.Forms.Label();
            this.lbl_taskdtl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_Role = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_taskid = new System.Windows.Forms.TextBox();
            this.Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_cross.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 522);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel_cross);
            this.panel2.Controls.Add(this.lbl_taskdtl);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(142, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 331);
            this.panel2.TabIndex = 3;
            // 
            // panel_cross
            // 
            this.panel_cross.Controls.Add(this.lbl_cross);
            this.panel_cross.ForeColor = System.Drawing.Color.Transparent;
            this.panel_cross.Location = new System.Drawing.Point(465, 0);
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
            this.panel3.Controls.Add(this.txt_Role);
            this.panel3.Controls.Add(this.bunifuCustomLabel2);
            this.panel3.Controls.Add(this.btn_update);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_Name);
            this.panel3.Controls.Add(this.bunifuCustomLabel6);
            this.panel3.Controls.Add(this.bunifuCustomLabel5);
            this.panel3.Controls.Add(this.txt_Username);
            this.panel3.Controls.Add(this.txt_taskid);
            this.panel3.Controls.Add(this.Title);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(5, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 319);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // txt_Role
            // 
            this.txt_Role.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Role.Location = new System.Drawing.Point(211, 180);
            this.txt_Role.Name = "txt_Role";
            this.txt_Role.Size = new System.Drawing.Size(185, 24);
            this.txt_Role.TabIndex = 31;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Quicksand", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(59, 186);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(31, 16);
            this.bunifuCustomLabel2.TabIndex = 30;
            this.bunifuCustomLabel2.Text = "Role";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(389, 279);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(77, 23);
            this.btn_update.TabIndex = 29;
            this.btn_update.Text = "Next";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(18, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Reset password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(212, 100);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(185, 24);
            this.txt_Name.TabIndex = 25;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Quicksand", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(57, 106);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(42, 16);
            this.bunifuCustomLabel6.TabIndex = 24;
            this.bunifuCustomLabel6.Text = " Name";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Quicksand", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(61, 66);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(45, 16);
            this.bunifuCustomLabel5.TabIndex = 21;
            this.bunifuCustomLabel5.Text = "User ID";
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(211, 140);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(185, 24);
            this.txt_Username.TabIndex = 9;
            // 
            // txt_taskid
            // 
            this.txt_taskid.Enabled = false;
            this.txt_taskid.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taskid.Location = new System.Drawing.Point(212, 60);
            this.txt_taskid.Name = "txt_taskid";
            this.txt_taskid.Size = new System.Drawing.Size(48, 24);
            this.txt_taskid.TabIndex = 8;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Quicksand", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(59, 146);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(60, 16);
            this.Title.TabIndex = 1;
            this.Title.Text = "Username";
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Location = new System.Drawing.Point(6, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(460, 297);
            this.panel4.TabIndex = 32;
            // 
            // F_ADD_ACOUNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(783, 522);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_ADD_ACOUNT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ADD_ACOUNT";
            this.Load += new System.EventHandler(this.F_ADD_ACOUNT_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.F_ADD_ACOUNT_Paint);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_cross.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_taskid;
        private BunifuCustomLabel Title;
        private BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.TextBox txt_Name;
        private BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Role;
        private BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel panel4;
    }
}