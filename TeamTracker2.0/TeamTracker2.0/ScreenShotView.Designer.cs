namespace TeamTracker2._0
{
    partial class ScreenShotView
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
            this.picbox_ScreenShot = new System.Windows.Forms.PictureBox();
            this.screenShotCross = new System.Windows.Forms.Label();
            this.panel_cross = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_ScreenShot)).BeginInit();
            this.panel_cross.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.picbox_ScreenShot);
            this.panel1.Controls.Add(this.panel_cross);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 501);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picbox_ScreenShot
            // 
            this.picbox_ScreenShot.BackColor = System.Drawing.Color.White;
            this.picbox_ScreenShot.Location = new System.Drawing.Point(19, 23);
            this.picbox_ScreenShot.Name = "picbox_ScreenShot";
            this.picbox_ScreenShot.Size = new System.Drawing.Size(723, 459);
            this.picbox_ScreenShot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_ScreenShot.TabIndex = 9;
            this.picbox_ScreenShot.TabStop = false;
            this.picbox_ScreenShot.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // screenShotCross
            // 
            this.screenShotCross.BackColor = System.Drawing.Color.Transparent;
            this.screenShotCross.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.screenShotCross.ForeColor = System.Drawing.Color.Silver;
            this.screenShotCross.Location = new System.Drawing.Point(2, -1);
            this.screenShotCross.Name = "screenShotCross";
            this.screenShotCross.Size = new System.Drawing.Size(20, 18);
            this.screenShotCross.TabIndex = 3;
            this.screenShotCross.Text = "x";
            this.screenShotCross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.screenShotCross.ClientSizeChanged += new System.EventHandler(this.screenShotCross_ClientSizeChanged);
            this.screenShotCross.Click += new System.EventHandler(this.screenShotCross_Click);
            this.screenShotCross.MouseLeave += new System.EventHandler(this.screenShotCross_MouseLeave);
            this.screenShotCross.MouseHover += new System.EventHandler(this.screenShotCross_MouseHover);
            // 
            // panel_cross
            // 
            this.panel_cross.Controls.Add(this.screenShotCross);
            this.panel_cross.Location = new System.Drawing.Point(742, 1);
            this.panel_cross.Name = "panel_cross";
            this.panel_cross.Size = new System.Drawing.Size(20, 20);
            this.panel_cross.TabIndex = 8;
            // 
            // ScreenShotView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 522);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenShotView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScreenShotView";
            this.Load += new System.EventHandler(this.ScreenShotView_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_ScreenShot)).EndInit();
            this.panel_cross.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picbox_ScreenShot;
        private System.Windows.Forms.Panel panel_cross;
        private System.Windows.Forms.Label screenShotCross;
    }
}