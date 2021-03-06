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
    public partial class SmartH2O_Alarms_View : Form
    {
        public SmartH2O_Alarms_View()
        {
            InitializeComponent();
            alarmsChart.Series[0].XValueType = ChartValueType.DateTime;
            alarmsChart.Series[1].XValueType = ChartValueType.DateTime;
            alarmsChart.Series[2].XValueType = ChartValueType.DateTime;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            clearAlamsFormData();

        }


        public void addAlarmData(string param, string value, string hour, string data)
        {
            
            string alarm = param + "\t\t\t\t" + value + "\t\t\t\t" + hour + "\t\t\t\t" + data;

            lstBox_ALARMS.Items.Add(alarm);
            

        }



        public void updateAlarmGraphic(string param, string hour, double value)
        {

            alarmsChart.Series[param].Points.AddXY(hour, value);
        }
        public void updateAlarmGraphic2(string param, DateTime date, string value)
        {


            alarmsChart.Series[param].Points.AddXY(date, value);


        }



        public void clearAlamsFormData()
        {

            this.lstBox_ALARMS.Items.Clear();

            alarmsChart.Series["NH3"].Points.Clear();
            alarmsChart.Series["CI2"].Points.Clear();
            alarmsChart.Series["PH"].Points.Clear();


        }




        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SmartH2O_Alarms_View_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
