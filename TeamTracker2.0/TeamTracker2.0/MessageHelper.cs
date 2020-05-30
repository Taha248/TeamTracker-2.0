using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker2._0
{
    class MessageHelper
    {
        public System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        public System.Windows.Forms.Panel messageBox = null;
        private int Height = 0;
        private int Width = 0;
        private int LocationX = 0;
        private int LocationY = 0;

        public MessageHelper() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.success = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.PictureBox();
            this.messageBox = new System.Windows.Forms.Panel();
        }
        public void GenerateNotification(string message, messageType msgType, Form form)
        {
            GenerateNotification(message, msgType, form, null, null);
        }
        public void GenerateNotification(string message, messageType msgType, Panel panel)
        {
            GenerateNotification(message, msgType, null, panel, null);
        }
        public void GenerateNotification(string message, messageType msgType, UserControl uc)
        {
            GenerateNotification(message, msgType, null, null, uc);
        }

        public void GenerateNotification(string message, messageType msgType, Form form,Panel panel , UserControl uc)
        {
            // 
            // success
            // 
            this.success.Image = global::TeamTracker2._0.Properties.Resources.icons8_double_tick_22;
            this.success.Location = new System.Drawing.Point(7, 6);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(22, 22);
            this.success.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.success.TabIndex = 9;
            this.success.TabStop = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(28, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 35);
            this.label10.TabIndex = 0;
            this.label10.Text = "Saved Succesfully";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // error
            // 
            this.error.Image = global::TeamTracker2._0.Properties.Resources.icons8_error_20;
            this.error.Location = new System.Drawing.Point(8, 7);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(20, 20);
            this.error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.error.TabIndex = 10;
            this.error.TabStop = false;

            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.error);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.success);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 36);
            this.panel1.TabIndex = 8;
            // 
            // messageBox
            // 
            this.messageBox.BackgroundImage = global::TeamTracker2._0.Properties.Resources.msg32;
            this.messageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            this.messageBox.Controls.Add(this.panel1);
            this.messageBox.Location = new System.Drawing.Point(45, 35);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(164, 38);
            this.messageBox.TabIndex = 12;


            this.messageBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.success)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();


            messageType result;
            if (Enum.TryParse(msgType.ToString(), out result))
            {
                this.messageBox.BringToFront();
                switch (result)
                {
                    case messageType.Success:
                        panel1.BackColor = Color.FromArgb(0, 200, 81);
                        label10.Text = message + " Successfully!";
                        success.BringToFront();
                        error.Hide();
                        break;

                    case messageType.Error:
                        panel1.BackColor = Color.FromArgb(255, 136, 0);
                        label10.Text = message + " Successfully!";
                        error.BringToFront();
                        success.Hide();
                        break;

                    case messageType.Custom:
                        panel1.BackColor = Color.FromArgb(255, 136, 0);
                        error.BringToFront();
                        success.Hide();
                        label10.Text = "Please Enter Email In Right Format";
                            label10.Font = label10.Text.Length >20 ? new Font("Montserrat", 7, FontStyle.Regular):Label.DefaultFont;
                        break;

                    default:
                        break;
                }

                timer1.Interval = 3000; // here time in milliseconds
                timer1.Tick += timer1_Tick;
                timer1.Start();
            }
            if (form != null)
                form.Controls.Add(this.messageBox);
            if (panel != null)
                panel.Controls.Add(this.messageBox);
            if (uc != null)
                uc.Controls.Add(this.messageBox);
        }

        public  void timer1_Tick(object sender, System.EventArgs e)
        {
           timer1.Stop();
            this.messageBox.SendToBack();
        }
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox error;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox success;
        private System.Windows.Forms.Panel panel_main;

        public int Height1
        {
            get
            {
                return Height;
            }

            set
            {
                Height = value;
            }
        }

        public int Width1
        {
            get
            {
                return Width;
            }

            set
            {
                Width = value;
            }
        }

        public int LocationX1
        {
            get
            {
                return LocationX;
            }

            set
            {
                LocationX = value;
            }
        }

        public int LocationY1
        {
            get
            {
                return LocationY;
            }

            set
            {
                LocationY = value;
            }
        }
    }
    public enum messageType
    {
        Success,
        Error,
        Custom
    }
    public class CustomForm : Form {

    }
    public class CustomPanel : Panel
    {

    }
}
