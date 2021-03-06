﻿using System;
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
            ci2Chart.Series[0].XValueType = ChartValueType.DateTime;
            ci2Chart.Visible = false;
            nh3Chart.Visible = false;
            phChart.Visible = false;
        }

        public void changeHeaders(int header)
        {
            //0 - daily; 1 - period; 2 - Weekly 

            ci2Chart.Titles[0].Visible = (header == 0);
            ci2Chart.Titles[1].Visible = (header == 1);
            ci2Chart.Titles[2].Visible = (header == 2);

            phChart.Titles[0].Visible = (header == 0);
            phChart.Titles[1].Visible = (header == 1);
            phChart.Titles[2].Visible = (header == 2);

            nh3Chart.Titles[0].Visible = (header == 0);
            nh3Chart.Titles[1].Visible = (header == 1);
            nh3Chart.Titles[2].Visible = (header == 2);
        }



        public void updateHourlyGraphic(string param, string min, string med, string max, string hour)
        {


            if (param == "CI2")
            {
                ci2Chart.Series["MIN"].Points.AddXY(hour + "H", min);
                ci2Chart.Series["MED"].Points.AddXY(hour + "H", med);
                ci2Chart.Series["MAX"].Points.AddXY(hour + "H", max);                
                ci2Chart.Visible = true;
            }

            if (param == "NH3")
            {
                nh3Chart.Series["MIN"].Points.AddXY(hour + "H", min);
                nh3Chart.Series["MED"].Points.AddXY(hour + "H", med);
                nh3Chart.Series["MAX"].Points.AddXY(hour + "H", max);
                nh3Chart.Visible = true;
            }

            if (param == "PH")
            {
                phChart.Series["MIN"].Points.AddXY(hour + "H", min);
                phChart.Series["MED"].Points.AddXY(hour + "H", med);
                phChart.Series["MAX"].Points.AddXY(hour + "H", max);
                phChart.Visible = true;
            }

        }

        public void updatePeriodGraphic(string param, string min, string med, string max, DateTime date)
        {

            
            if (param == "CI2")
            {
                ci2Chart.Series["MIN"].Points.AddXY(date.ToShortDateString(), min);
                ci2Chart.Series["MED"].Points.AddXY(date.ToShortDateString(), med);
                ci2Chart.Series["MAX"].Points.AddXY(date.ToShortDateString(), max);
                ci2Chart.Visible = true;

            }
            if (param == "NH3")
            {
                nh3Chart.Series["MIN"].Points.AddXY(date.ToShortDateString(), min);
                nh3Chart.Series["MED"].Points.AddXY(date.ToShortDateString(), med);
                nh3Chart.Series["MAX"].Points.AddXY(date.ToShortDateString(), max);
                nh3Chart.Visible = true;
            }
            if (param == "PH")
            {
                phChart.Series["MIN"].Points.AddXY(date.ToShortDateString(), min);
                phChart.Series["MED"].Points.AddXY(date.ToShortDateString(), med);
                phChart.Series["MAX"].Points.AddXY(date.ToShortDateString(), max);
                phChart.Visible = true;
            }


        }




        private void phChart_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearParamsFormData();
            this.Hide();


        }

        public void clearParamsFormData()
        {
            phChart.Series["MIN"].Points.Clear();
            phChart.Series["MED"].Points.Clear();
            phChart.Series["MAX"].Points.Clear();
            phChart.Visible = false;

            ci2Chart.Series["MIN"].Points.Clear();
            ci2Chart.Series["MED"].Points.Clear();
            ci2Chart.Series["MAX"].Points.Clear();
            ci2Chart.Visible = false;


            nh3Chart.Series["MIN"].Points.Clear();
            nh3Chart.Series["MED"].Points.Clear();
            nh3Chart.Series["MAX"].Points.Clear();
            nh3Chart.Visible = false;

        }

    }
}
