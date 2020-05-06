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
        public UC_Dashboard()
        {
            InitializeComponent();
            LoadPieChart();
            LoadReputationGraph();
        }

        private void LoadReputationGraph()
        {
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May","June","July","Aug","Sep","Oct","Nov","Dec" }
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
            pieChart1.LegendLocation = LegendLocation.Right;

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
            for (int i = 0; i < 2; i++)
            {
                Label l1 = new Label();
                l1.Text = "hamza"+i;
                l1.BackColor = Color.Black;
                l1.Width = 30;
                l1.AutoSize = true;
                panel9.Controls.Add(l1);
            }
        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xuiGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
