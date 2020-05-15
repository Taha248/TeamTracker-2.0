using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace TeamTracker2._0
{
    public partial class UC_Dashboard : UserControl
    {
        int totalHeight = 0;
        public UC_Dashboard()
        {
            InitializeComponent();
            LoadPieChart();
            LoadReputationGraph();
            this.flowLayoutPanel1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseWheel);
        }
        private void panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (pictureBox6.Top > 4)
                {
                    pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y - 20);

                }
            }
            else if (pictureBox6.Bottom < 155)
            {
                pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y + 20);
            }
        }
        private void LoadReputationGraph()
        {
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Reputation",
                    Values = new ChartValues<double> {4, 6, 5, 2, 7,6,9,4,6,3,2,6}
                }
            };
            cartesianChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void LoadPieChart()
        {
            pieChart1.InnerRadius = 23;
            pieChart1.LegendLocation = LegendLocation.Bottom;

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Complete",
                    Values = new ChartValues<double> {67},
                   // PushOut = 15,
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Incomplete",
                    Values = new ChartValues<double> {33},
                    DataLabels = true
                }
            };
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            pieChart1.Visible = true;
            cartesianChart1.Visible = true;
            List<MessageFormat> msgList = new List<MessageFormat>();
            msgList.Add(new MessageFormat { Subject = "Meeting For Planning", Body = "Taha & Zeeshan Please Come On Time,Please Come On Time  ", MsgRecTime=DateTime.Now });
            msgList.Add(new MessageFormat { Subject = "Meeting For Next Step", Body = "Mr Taha & Zeeshan You have to come bcz you both are the seniors and important pillar of our company",MsgRecTime = DateTime.Now });
            msgList.Add(new MessageFormat { Subject = "Eid Mubarak", Body = "Mr Taha & Zeeshan We Have Sent the Eidi in your accounts BTE Eid Mubarak!!", MsgRecTime = DateTime.Now });
            msgList.Add(new MessageFormat { Subject = "Eid Mubarak", Body = "Mr Taha & Zeeshan We Have Sent the Eidi in your accounts BTE Eid Mubarak!!", MsgRecTime = DateTime.Now });
            msgList.Add(new MessageFormat { Subject = "Hello Mere Bhaiyoon ASsalam-o-Alikum", Body = "Mr Taha & Zeeshan apky biwi bachien kese hain sb theek hain? Hello Mere Bhaiyoon ASsalam-o-Alikum.... Hello Mere Bhaiyoon ASsalam-o-Alikum", MsgRecTime = DateTime.Now });
            msgList.Add(new MessageFormat { Subject = "test", Body = "test", MsgRecTime = DateTime.Now });
            LoadNotification(msgList);

            // -0.15119X + 164.48074
            double val = 0;
            val = (-0.15119 * totalHeight)+ 178.48074;
            pictureBox6.Height = (int)val;

            if (totalHeight < 145)
                panel9.Hide();
        }

        private void LoadNotification(List<MessageFormat> Messages)
        {
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.AutoScroll = true;
            Label bottom_ = new Label();
            bottom_.Width = 208;
            bottom_.Height = 2;
            totalHeight += 2;
            bottom_.BackColor = Color.White;
            Label top = new Label();
            top.Width = 208;
            top.Height = 2; totalHeight += 2;
            top.BackColor = Color.SkyBlue;
            flowLayoutPanel1.Controls.Add(bottom_);
            flowLayoutPanel1.Controls.Add(top);
            for (int i = 0; i < Messages.Count; i++)
            { 
                Label subject = new Label();
                subject.Text = Messages[i].Subject;
                subject.Font = new Font("Raavi", 9, FontStyle.Bold);
                subject.TextAlign = ContentAlignment.BottomLeft;
                subject.ForeColor = Color.Black;
                subject.BackColor = Color.White;
                subject.Padding = new Padding(3);
                subject.Width = 208;

                    int height = getNotificationLabelHeight(Messages[i].Subject);
                subject.Height = height;
                totalHeight += height;

                Label messages = new Label();
                messages.Font = new Font("Raavi", 7, FontStyle.Regular);
                messages.ForeColor = Color.Gray;
                messages.BackColor = Color.White;
                messages.TextAlign = ContentAlignment.TopLeft;
                messages.AutoEllipsis = true;
                messages.Padding = new Padding(3);
                messages.Width = 208;
                if ((Messages[i].Body.Length) > 30)
                { 
                    height = getNotificationLabelHeight(Messages[i].Body);
                    messages.Height = height;
                    totalHeight += height;
                }
                else { messages.Height = 17; totalHeight += height; }
                messages.Text = Messages[i].Body;

                Label date = new Label();
                date.Width = 208;
                date.Height = 17;
                totalHeight += 17;
                date.Font = new Font("Raavi", 6, FontStyle.Regular);
                date.Text = msgTime(Messages[i].MsgRecTime);
                date.TextAlign = ContentAlignment.TopRight;
                date.BackColor = Color.White;
                date.ForeColor = Color.DarkGray;

                Label bottom = new Label();
                bottom.Width = 208;
                bottom.Height = 2;
                totalHeight += 2;
                bottom.BackColor = Color.SkyBlue;
                flowLayoutPanel1.Controls.Add(subject);
                flowLayoutPanel1.Controls.Add(messages);
                flowLayoutPanel1.Controls.Add(date);
                flowLayoutPanel1.Controls.Add(bottom);

                subject.MouseHover += new System.EventHandler(this.flowLayoutPanel1_MouseHover);
                messages.MouseHover += new System.EventHandler(this.flowLayoutPanel1_MouseHover);
                date.MouseHover += new System.EventHandler(this.flowLayoutPanel1_MouseHover);
                bottom.MouseHover += new System.EventHandler(this.flowLayoutPanel1_MouseHover);

            }
            Label top_ = new Label();
            top_.Width = 208;
            top_.Height = 2;
            top_.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(top_);

        }

        private int getNotificationLabelHeight(string body)
        {
            int textLen = body.Length;
            int temp = textLen / 30;
            if (textLen % 30 > 0 && temp>0) { if (temp > 1) { temp = ((temp + 1) * 13); } else { temp = ((temp + 1) * 17); } }
            else if(temp==0) { temp =20; }
            else { temp = (temp * 16); }
            return temp;
        }

        private string msgTime(DateTime recTime)
        {
            DateTime currTime = DateTime.Now;
            TimeSpan span = recTime.Subtract(currTime);

            int hours = Convert.ToInt32(Math.Abs(span.TotalHours));
            int days = Convert.ToInt32(Math.Abs(span.TotalDays));
            int minutes = Convert.ToInt32(Math.Abs(span.TotalMinutes));
            if (hours >= 1 && days <= 1 && hours < 24)
                return hours == 1 ? hours + " Hour Ago" : hours + " Hours Ago";
            else if (minutes > 0 && minutes < 60 && days == 0 && hours == 0)
                return minutes == 1 ? minutes + " Minute Ago" : minutes + " Minutes Ago";
            else if (days >= 1 && hours >= 24)
                return days == 1 ? " Day Ago" : days + " Days Ago";
            else if (days >= 365) { 
               int yearCount = days / 365;
               return days == 365 ? " Year Ago" : yearCount + " Years Ago"; }
            else
                return "Just Received...";
        }
        //public string msg(string msg)
        //{
        //    int len = msg.Length;
        //    int looping = len / 16;
        //    string temp = "";
        //    for (int i = 0; i <= looping; i++)
        //    {
        //        if (len > 15)
        //        {
        //            string tempString = msg.Substring(0, 15);
        //            string a = msg.Substring(15, 1);
        //            if (!a.Equals(" ") && msg.Substring(0,15).Contains(" "))
        //            {
        //                string[] words = tempString.Split(' ');
        //                for(int j =0; j < words.Length; j++)
        //                {
        //                    if (j!=(words.Length-1)) { temp += words[j]+" "; }
        //                    else { temp+= Environment.NewLine; }
        //                }
        //                char[] lstwordlen = words[words.Length-1].ToCharArray();
        //                int cou = 15 - lstwordlen.Length;
        //                msg = msg.Remove(0,cou );
        //                len = len - cou;
        //                //char[] getChars = msg.ToCharArray();
        //                //for (int j = 14; j >= 0; j--)
        //                //{
        //                //    if (getChars[j].Equals(""))
        //                //    {
        //                //        temp += new String(getChars, 0, j) + Environment.NewLine;
        //                //        msg = msg.Remove(0, j);
        //                //        break;
        //                //    }
        //                //}
        //            }
        //            //else if(!msg.Substring(0, 15).Contains(" "))
        //            //{
        //            //
        //            //}
        //            else
        //            {
        //                temp += msg.Substring(0, 15) + Environment.NewLine;
        //                msg = msg.Remove(0, 15);
        //                len = len - 15;
        //            }
        //        }
        //        else if (len > 0)
        //        {
        //            temp += msg;
        //        }
        //    }
        //    return temp;
        //}
        
        private void xuiGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
          OnlineUsers online =   new OnlineUsers();
            online.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            TotalUsers online = new TotalUsers();
            online.ShowDialog();

        }

        private void flowLayoutPanel1_MouseHover(object sender, EventArgs e)
        {
            flowLayoutPanel1.Focus();
        }
    }
    public class MessageFormat
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime MsgRecTime { get; set; } 
    }
}