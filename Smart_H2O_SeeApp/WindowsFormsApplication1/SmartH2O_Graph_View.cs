using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    public partial class SmartH2O_Graph_View : Form
    {
        public bool firstRun = true;
        public int graphPos = 0;
        public SmartH2O_Graph_View()
        {
            InitializeComponent();

            ci2Chart.ChartAreas[0].AxisX.LabelStyle.Format = "h : tt";

            // ci2Chart.Series[0].XValueType = ChartValueType.DateTime;

        }

        public void changeHeaders(int header)
        {

                ci2Chart.Titles[0].Visible = header == 0;
                ci2Chart.Titles[1].Visible = header == 1;
                ci2Chart.Titles[2].Visible = header == 2;

                phChart.Titles[0].Visible = header == 0;
                phChart.Titles[1].Visible = header == 1;
                phChart.Titles[2].Visible = header == 2;

                nh3Chart.Titles[0].Visible = header == 0;
                nh3Chart.Titles[1].Visible = header == 1;
                nh3Chart.Titles[2].Visible = header == 2;
            }



        public void updateHourlyGraphic(string param, string min, string med, string max, string hour)
        {


            if (param == "CI2")
            {
                ci2Chart.Series["MIN"].Points.AddXY(hour, min);
                ci2Chart.Series["MED"].Points.AddXY(hour, med);
                ci2Chart.Series["MAX"].Points.AddXY(hour, max);

            }
            if (param == "NH3")
            {
                nh3Chart.Series["MIN"].Points.AddXY(hour, min);
                nh3Chart.Series["MED"].Points.AddXY(hour, med);
                nh3Chart.Series["MAX"].Points.AddXY(hour, max);
            }
            if (param == "PH")
            {
                phChart.Series["MIN"].Points.AddXY(hour, min);
                phChart.Series["MED"].Points.AddXY(hour, med);
                phChart.Series["MAX"].Points.AddXY(hour, max);
            }


        }

        public void updatePeriodGraphic(string param, string min, string med, string max, DateTime date)
        {


            ci2Chart.Titles[0].Visible = true;
            ci2Chart.Titles[1].Visible = false;
            ci2Chart.Titles[2].Visible = false;

            phChart.Titles[0].Visible = true;
            phChart.Titles[1].Visible = false;
            phChart.Titles[2].Visible = false;

            nh3Chart.Titles[0].Visible = true;
            nh3Chart.Titles[1].Visible = false;
            nh3Chart.Titles[2].Visible = false;

            if (param == "CI2")
            {
                ci2Chart.Series["MIN"].Points.AddXY(date.ToShortDateString(), min);
                ci2Chart.Series["MED"].Points.AddXY(date.ToShortDateString(), med);
                ci2Chart.Series["MAX"].Points.AddXY(date.ToShortDateString(), max);

            }
            if (param == "NH3")
            {
                nh3Chart.Series["MIN"].Points.AddXY(date.ToShortDateString(), min);
                nh3Chart.Series["MED"].Points.AddXY(date.ToShortDateString(), med);
                nh3Chart.Series["MAX"].Points.AddXY(date.ToShortDateString(), max);
            }
            if (param == "PH")
            {
                phChart.Series["MIN"].Points.AddXY(date.ToShortDateString(), min);
                phChart.Series["MED"].Points.AddXY(date.ToShortDateString(), med);
                phChart.Series["MAX"].Points.AddXY(date.ToShortDateString(), max);
            }


        }




        private void phChart_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (var series in ci2Chart.Series)
            {
                series.Points.Clear();
            }
            ci2Chart.Series[0].Points.Clear();
            ci2Chart.Series[1].Points.Clear();
            ci2Chart.Series[2].Points.Clear();

            this.Close();

        }
    }
}
