namespace TeamTracker2._0
{
    partial class NotificationViewer
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_cross = new System.Windows.Forms.Label();
            this.notiHeader = new System.Windows.Forms.Label();
            this.panel_cross = new System.Windows.Forms.Panel();
            this.notiCross = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.messageBody = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notiCard = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel_cross.SuspendLayout();
            this.notiCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.notiCard);
            this.panel2.Location = new System.Drawing.Point(242, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 94);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 522);
            this.panel1.TabIndex = 7;
            // 
            // lbl_cross
            // 
            this.lbl_cross.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cross.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lbl_cross.ForeColor = System.Drawing.Color.Silver;
            this.lbl_cross.Location = new System.Drawing.Point(489, 1);
            this.lbl_cross.Name = "lbl_cross";
            this.lbl_cross.Size = new System.Drawing.Size(20, 18);
            this.lbl_cross.TabIndex = 4;
            this.lbl_cross.Text = "x";
            this.lbl_cross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notiHeader
            // 
            this.notiHeader.AutoSize = true;
            this.notiHeader.BackColor = System.Drawing.Color.Transparent;
            this.notiHeader.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notiHeader.Location = new System.Drawing.Point(93, -2);
            this.notiHeader.Name = "notiHeader";
            this.notiHeader.Size = new System.Drawing.Size(102, 19);
            this.notiHeader.TabIndex = 2;
            this.notiHeader.Text = "Notification";
            // 
            // panel_cross
            // 
            this.panel_cross.Controls.Add(this.notiCross);
            this.panel_cross.Location = new System.Drawing.Point(272, 2);
            this.panel_cross.Name = "panel_cross";
            this.panel_cross.Size = new System.Drawing.Size(20, 20);
            this.panel_cross.TabIndex = 7;
            // 
            // notiCross
            // 
            this.notiCross.BackColor = System.Drawing.Color.Transparent;
            this.notiCross.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.notiCross.ForeColor = System.Drawing.Color.Silver;
            this.notiCross.Location = new System.Drawing.Point(1, 0);
            this.notiCross.Name = "notiCross";
            this.notiCross.Size = new System.Drawing.Size(20, 18);
            this.notiCross.TabIndex = 3;
            this.notiCross.Text = "x";
            this.notiCross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.notiCross.Click += new System.EventHandler(this.notiCross_Click);
            this.notiCross.MouseLeave += new System.EventHandler(this.notiCross_MouseLeave);
            this.notiCross.MouseHover += new System.EventHandler(this.notiCross_MouseHover);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Length shoudn\'t be greater than 40 chara";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // messageBody
            // 
            this.messageBody.BackColor = System.Drawing.Color.Transparent;
            this.messageBody.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBody.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.messageBody.Location = new System.Drawing.Point(4, 52);
            this.messageBody.Name = "messageBody";
            this.messageBody.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.messageBody.Size = new System.Drawing.Size(285, 10);
            this.messageBody.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.label3.Size = new System.Drawing.Size(279, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Just Recieved....";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notiCard
            // 
            this.notiCard.AllowDrop = true;
            this.notiCard.BackColor = System.Drawing.Color.White;
            this.notiCard.Controls.Add(this.label3);
            this.notiCard.Controls.Add(this.messageBody);
            this.notiCard.Controls.Add(this.label1);
            this.notiCard.Controls.Add(this.panel_cross);
            this.notiCard.Controls.Add(this.notiHeader);
            this.notiCard.Controls.Add(this.lbl_cross);
            this.notiCard.Location = new System.Drawing.Point(5, 5);
            this.notiCard.Name = "notiCard";
            this.notiCard.Size = new System.Drawing.Size(294, 82);
            this.notiCard.TabIndex = 1;
            // 
            // NotificationViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 524);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificationViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotificationViewer";
            this.Load += new System.EventHandler(this.NotificationViewer_Load);
            this.panel2.ResumeLayout(false);
            this.panel_cross.ResumeLayout(false);
            this.notiCard.ResumeLayout(false);
            this.notiCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel notiCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label messageBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_cross;
        private System.Windows.Forms.Label notiCross;
        private System.Windows.Forms.Label notiHeader;
        private System.Windows.Forms.Label lbl_cross;
    }
}