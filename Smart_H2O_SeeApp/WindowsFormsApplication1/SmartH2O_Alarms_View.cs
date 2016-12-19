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
    public partial class SmartH2O_Alarms_View : Form
    {
        public SmartH2O_Alarms_View()
        {
            InitializeComponent();
            alarmsChart.Series[0].XValueType = ChartValueType.DateTime;
            alarmsChart.Series[1].XValueType = ChartValueType.DateTime;
            alarmsChart.Series[2].XValueType = ChartValueType.DateTime;
           // alarmsChart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "yyyy-MM-dd";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            clearAlamsFormData();
            
            
               
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void addAlarmData(string param, string value, string hour, string data) {

            listboxAlarmParam.Items.Add(param);
            listboxAlarmValue.Items.Add(value);
            listboxAlarmHour.Items.Add(hour);
            listboxAlarmData.Items.Add(data);

        }

        public void updateAlarmGraphic(string param, DateTime  date, string value){
       
                alarmsChart.Series[param].Points.AddXY(date, value);



        }

        public void updateAlarmPieGraphic(string param)
        {

            alarmsPieChart.Series["NH3"].Points.Add(500);
            alarmsPieChart.Series["CI2"].Points.Add(250);
            alarmsPieChart.Series["PH"].Points.Add(250);



        }

        public void clearAlamsFormData() {

            listboxAlarmParam.Items.Clear();
            listboxAlarmData.Items.Clear();
            listboxAlarmHour.Items.Clear();
            listboxAlarmValue.Items.Clear();


            alarmsPieChart.Series["NH3"].Points.Clear();
            alarmsPieChart.Series["CI2"].Points.Clear();
            alarmsPieChart.Series["PH"].Points.Clear();

            //alarmsPieChart.Series.Clear();

        }

















    }
}
