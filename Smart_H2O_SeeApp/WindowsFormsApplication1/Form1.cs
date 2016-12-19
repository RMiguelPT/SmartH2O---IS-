using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {


      public Form1()
        {
            InitializeComponent();


        }

        public SmartH2O_Graph_View sh2OGraph = new SmartH2O_Graph_View();
        public SmartH2O_Alarms_View sh2OAlarm = new SmartH2O_Alarms_View();


        private void button2_Click(object sender, EventArgs e)
        {

        }







        private void generateAlarmsView()
        {

            //################## ALARMS ###########################

            ServiceData.SmartH2O_ServiceClient servData = new ServiceData.SmartH2O_ServiceClient();
            XmlDocument doc = new XmlDocument();

            //doc.Load("alarm-data.xml");
           //XmlNodeList list = doc.SelectNodes("/ALARM-DATA/ALARM");


            //################## DAILY-ALARMS ###########################

            if (dailyAlarms.Checked)
            {
                int day = dailyAlarmsPick.Value.Day;
                int month = dailyAlarmsPick.Value.Month;
                int year = dailyAlarmsPick.Value.Year;

                DateTime pickDate = new DateTime(year, month, day);

                string ph = servData.getDailyAlarmsInformation("ph",pickDate.ToString());
                doc.LoadXml(ph);
                string ci2 = servData.getDailyAlarmsInformation("ci2", pickDate.ToString());
                doc.LoadXml(ci2);
                string nh3 = servData.getDailyAlarmsInformation("ci2", pickDate.ToString());
                doc.LoadXml(nh3);

                XmlNodeList list = doc.SelectNodes("//*");

                foreach (XmlNode n in list)
                {
                    foreach (XmlNode c in n.ChildNodes)
                    {

                        string[] nodeSplitDate = c.ChildNodes[2].InnerText.Split('-');
                        int nodeDay = Int32.Parse(nodeSplitDate[0]);
                        int nodeMonth = Int32.Parse(nodeSplitDate[1]);
                        int nodeYear = Int32.Parse(nodeSplitDate[2]);

                        DateTime nodeDate = new DateTime(nodeYear, nodeMonth, nodeDay);


                        if (nodeDate == pickDate)
                        {

                            sh2OAlarm.addAlarmData(c.Name, c.ChildNodes[0].InnerText, c.ChildNodes[1].InnerText, c.ChildNodes[2].InnerText);
                            //sh2OAlarm.updateAlarmGraphic(c.Name, nodeDate, Convert.ToInt32(c.ChildNodes[1].InnerText));
                        }
                    }
                }
                sh2OAlarm.Show();

            }



            //################## ALARMS-PERIOD ###########################

            else if (periodAlarms.Checked)
            {



                if (periodAlarms.Checked && periodAlarmsPickEnd.Value < periodAlarmsPickInit.Value)
                {

                    MessageBox.Show("Data de Fim tem de ser superior a Data de inicio");
                }
                else {

                    int initDay = periodAlarmsPickInit.Value.Day;
                    int initMonth = periodAlarmsPickInit.Value.Month;
                    int initYear = periodAlarmsPickInit.Value.Year;

                    DateTime alarmPickInit = new DateTime(initYear, initMonth, initDay);


                    int endDay = periodAlarmsPickEnd.Value.Day;
                    int endMonth = periodAlarmsPickEnd.Value.Month;
                    int endYear = periodAlarmsPickEnd.Value.Year;

                    DateTime alarmPickEnd = new DateTime(endYear, endMonth, endDay);


                    int nh3PieCont = 0;
                    int ci2PieCont = 0;
                    int phPieCont = 0;

                    string ph = servData.getAlarmsInformation("ph", alarmPickInit.ToString(), alarmPickEnd.ToString());
                    doc.LoadXml(ph);
                    string ci2 = servData.getAlarmsInformation("ci2", alarmPickInit.ToString(), alarmPickEnd.ToString());
                    doc.LoadXml(ci2);
                    string nh3 = servData.getAlarmsInformation("ci2", alarmPickInit.ToString(), alarmPickEnd.ToString());
                    doc.LoadXml(nh3);

                    XmlNodeList list = doc.SelectNodes("//*");

                    foreach (XmlNode n in list)
                    {
                        foreach (XmlNode c in n.ChildNodes)
                        {


                            string[] nodeSplitDate = c.ChildNodes[2].InnerText.Split('-');
                            int nodeDay = Int32.Parse(nodeSplitDate[0]);
                            int nodeMonth = Int32.Parse(nodeSplitDate[1]);
                            int nodeYear = Int32.Parse(nodeSplitDate[2]);

                            DateTime nodeDate = new DateTime(nodeYear, nodeMonth, nodeDay);

                            if (nodeDate >= alarmPickInit && nodeDate <= alarmPickEnd)

                            {
                                sh2OAlarm.addAlarmData(c.Name, c.ChildNodes[0].InnerText, c.ChildNodes[1].InnerText, c.ChildNodes[2].InnerText);
                                // sh2OAlarm.updateAlarmGraphic(c.Name, nodeDate, Convert.ToInt32(c.ChildNodes[1].InnerText));

                                //
                                sh2OAlarm.updateAlarmGraphic(c.Name, nodeDate, c.ChildNodes[0].InnerText);
                                sh2OAlarm.updateAlarmPieGraphic(c.Name);



/*
                                pieChart.Series.Add(series1);
                                series1.Points.Add(70000);
                                series1.Points.Add(30000);
                                var p1 = series1.Points[0];
                                p1.AxisLabel = "70000";
                                p1.LegendText = "Hiren Khirsaria";
                                var p2 = series1.Points[1];
                                p2.AxisLabel = "30000";
                                p2.LegendText = "ABC XYZ";
                                pieChart.Invalidate();
                                pnlPie.Controls.Add(pieChart)


            */




                            }
                       }

                        
                    }


                }


                sh2OAlarm.Show();


            }
        }


        //################## PARAMS ###########################

        private void generateParamsView()
        {

            ServiceData.SmartH2O_ServiceClient servData = new ServiceData.SmartH2O_ServiceClient();

            //################## DAILY-PARAMS ###########################

            if (dailyParam.Checked)
            {

                //sh2OGraph.changeHeaders(0);


                if (chkCi2.Checked)
                {

                    //string xmlHdataCi2 = "<PARAM-DATA><PARAM><HOUR>02:00</HOUR><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><HOUR>03:00</HOUR><MIN>2.0</MIN><MED>4.0</MED><MAX>5.0</MAX></PARAM><PARAM><HOUR>04:00</HOUR><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><HOUR>05:00</HOUR><MIN>2.0</MIN><MED>4.0</MED><MAX>5.0</MAX></PARAM><PARAM><HOUR>06:00</HOUR><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><HOUR>07:00</HOUR><MIN>2.0</MIN><MED>4.0</MED><MAX>5.0</MAX></PARAM><PARAM><HOUR>8:00</HOUR><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><HOUR>09:00</HOUR><MIN>2.0</MIN><MED>4.0</MED><MAX>5.0</MAX></PARAM><PARAM><HOUR>10:00</HOUR><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><HOUR>10:00</HOUR><MIN>2.0</MIN><MED>4.0</MED><MAX>5.0</MAX></PARAM><PARAM><HOUR>11:00</HOUR><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><HOUR>12:00</HOUR><MIN>2.0</MIN><MED>4.0</MED><MAX>5.0</MAX></PARAM></PARAM-DATA>";
                    string xmlDataCi2 = servData.getHourlySummarizedInformation("CI2", hourlyDatePick.Value.ToString());
                    createGraphfromXml(xmlDataCi2, "CI2", "dailyParam");
                }

                if (chkNh3.Checked)
                {
                   // string xmlHdataNh3 = "<PARAM-DATA><PARAM><HOUR>02:00</HOUR><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><HOUR>03:00</HOUR><MIN>2.0</MIN><MED>4.0</MED><MAX>5.0</MAX></PARAM><PARAM><HOUR>04:00</HOUR><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><HOUR>05:00</HOUR><MIN>2.0</MIN><MED>4.0</MED><MAX>5.0</MAX></PARAM><PARAM><HOUR>06:00</HOUR><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><HOUR>07:00</HOUR><MIN>2.0</MIN><MED>4.0</MED><MAX>5.0</MAX></PARAM><PARAM><HOUR>8:00</HOUR><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><HOUR>09:00</HOUR><MIN>2.0</MIN><MED>4.0</MED><MAX>5.0</MAX></PARAM><PARAM><HOUR>10:00</HOUR><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><HOUR>10:00</HOUR><MIN>2.0</MIN><MED>4.0</MED><MAX>5.0</MAX></PARAM><PARAM><HOUR>11:00</HOUR><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><HOUR>12:00</HOUR><MIN>2.0</MIN><MED>4.0</MED><MAX>5.0</MAX></PARAM></PARAM-DATA>";
                    string xmlDataNh3 = servData.getHourlySummarizedInformation("NH3", hourlyDatePick.Value.ToString());
                    createGraphfromXml(xmlDataNh3, "NH3", "dailyParam");


                }
                if (chkPh.Checked)
                {
                   // string xmlHdataPh = "<PARAM-DATA><PARAM><HOUR>02:00</HOUR><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><HOUR>03:00</HOUR><MIN>2.0</MIN><MED>4.0</MED><MAX>5.0</MAX></PARAM><PARAM><HOUR>04:00</HOUR><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><HOUR>05:00</HOUR><MIN>2.0</MIN><MED>4.0</MED><MAX>5.0</MAX></PARAM><PARAM><HOUR>06:00</HOUR><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><HOUR>07:00</HOUR><MIN>2.0</MIN><MED>4.0</MED><MAX>5.0</MAX></PARAM><PARAM><HOUR>8:00</HOUR><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><HOUR>09:00</HOUR><MIN>2.0</MIN><MED>4.0</MED><MAX>5.0</MAX></PARAM><PARAM><HOUR>10:00</HOUR><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><HOUR>10:00</HOUR><MIN>2.0</MIN><MED>4.0</MED><MAX>5.0</MAX></PARAM><PARAM><HOUR>11:00</HOUR><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><HOUR>12:00</HOUR><MIN>2.0</MIN><MED>4.0</MED><MAX>5.0</MAX></PARAM></PARAM-DATA>";
                    string xmlDataPh = servData.getHourlySummarizedInformation("PH", hourlyDatePick.Value.ToString());
                    createGraphfromXml(xmlDataPh, "PH", "dailyParam");

                }

            }


            //################## PERIOD-PARAMS ###########################


            else if (periodParam.Checked)
            {
                //sh2OGraph.changeHeaders(1);

                if (chkCi2.Checked)
                {
                    //string xmlPdataCi2 = "<PARAM-DATA><PARAM><DATE>02-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><DATE>03-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><DATE>04-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><DATE>05-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM></PARAM-DATA>";
                    string xmlPdataCi2 = servData.getPeriodSummarizedInformation("CI2", paramPeriodPickInit.ToString(), paramPeriodPickEnd.ToString());
                    createGraphfromXml(xmlPdataCi2, "CI2", "periodParam");

                }

                if (chkNh3.Checked)
                {
                   // string xmlPdataNh3 = "<PARAM-DATA><PARAM><DATE>02-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><DATE>03-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><DATE>04-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><DATE>05-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM></PARAM-DATA>";
                    string xmlPdataNh3 = servData.getPeriodSummarizedInformation("NH3", paramPeriodPickInit.ToString(), paramPeriodPickEnd.ToString());
                    createGraphfromXml(xmlPdataNh3, "NH3", "periodParam");


                }
                if (chkPh.Checked)
                {
                    //string xmlPdataPh = "<PARAM-DATA><PARAM><DATE>02-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><DATE>03-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><DATE>04-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><DATE>05-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM></PARAM-DATA>";
                    string xmlPdataPh = servData.getPeriodSummarizedInformation("PH", paramPeriodPickInit.ToString(), paramPeriodPickEnd.ToString());
                    createGraphfromXml(xmlPdataPh, "PH", "periodParam");

                }
            }

            else if (weakParam.Checked)
            {


               // sh2OGraph.changeHeaders(2);

                DateTime weeKdate = paramWeekPick.Value;
                DayOfWeek fdow = CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
                int offset = fdow - weeKdate.DayOfWeek;
                DateTime fisrtDayofWeek = weeKdate.AddDays(offset);
                DateTime lastDayofWeek = fisrtDayofWeek.AddDays(6);

                if (chkCi2.Checked)
                {
                    //string xmlPdataCi2 = "<PARAM-DATA><PARAM><DATE>02-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><DATE>03-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><DATE>04-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><DATE>05-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM></PARAM-DATA>";
                    string xmlPdataCi2 = servData.getPeriodSummarizedInformation("CI2", fisrtDayofWeek.ToString(), lastDayofWeek.ToString());
                    createGraphfromXml(xmlPdataCi2, "CI2", "periodParam");

                }

                if (chkNh3.Checked)
                {
                    //string xmlPdataNh3 = "<PARAM-DATA><PARAM><DATE>02-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><DATE>03-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><DATE>04-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><DATE>05-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM></PARAM-DATA>";
                    string xmlPdataNh3 = servData.getPeriodSummarizedInformation("NH3", fisrtDayofWeek.ToString(), lastDayofWeek.ToString());
                    createGraphfromXml(xmlPdataNh3, "NH3", "periodParam");


                }
                if (chkPh.Checked)
                {
                   // string xmlPdataPh = "<PARAM-DATA><PARAM><DATE>02-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><DATE>03-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><DATE>04-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM><PARAM><DATE>05-12-2016</DATE><MIN>5.0</MIN><MED>6.0</MED><MAX>7.0</MAX></PARAM></PARAM-DATA>";
                    string xmlPdataPh = servData.getPeriodSummarizedInformation("PH", fisrtDayofWeek.ToString(), lastDayofWeek.ToString());
                    createGraphfromXml(xmlPdataPh, "PH", "periodParam");

                }





            }else MessageBox.Show("Tem de selecionar pelo menos uma opção de visualização!");




        }



    private void createGraphfromXml(string xmlString, string param, string viewType)
    {


        XmlDocument xmlData = new XmlDocument();

        xmlData.LoadXml(xmlString);

        XmlNodeList list = xmlData.SelectNodes("/PARAM-DATA/PARAM");



        foreach (XmlNode c in list)
        {

            if (String.ReferenceEquals(viewType, "dailyParam"))
            {

                //sh2OGraph.AccessibilityObject.Equals(graphPos)
                sh2OGraph.updateHourlyGraphic(param, c.ChildNodes[1].InnerText, c.ChildNodes[2].InnerText, c.ChildNodes[3].InnerText, c.ChildNodes[0].InnerText);


            }
            if (String.Equals(viewType, "periodParam"))
            {

                string[] nodeSplitDate = c.ChildNodes[0].InnerText.Split('-');
                int nodeDay = Int32.Parse(nodeSplitDate[0]);
                int nodeMonth = Int32.Parse(nodeSplitDate[1]);
                int nodeYear = Int32.Parse(nodeSplitDate[2]);

                DateTime nodeDate = new DateTime(nodeYear, nodeMonth, nodeDay);
                sh2OGraph.updatePeriodGraphic(param, c.ChildNodes[1].InnerText, c.ChildNodes[2].InnerText, c.ChildNodes[3].InnerText, nodeDate);

            }
        }

        sh2OGraph.Show();


    }



/*
    string getHourySummmarizedInformation(string param, DateTime date)
    {

        String xmlStringResult = "";

        XmlDocument doc = new XmlDocument();
        doc.Load("param-data.xml");

        XmlNodeList list = doc.SelectNodes("/PARAM-DATA/PARAM/" + param);


        foreach (XmlNode c in list)
        {


            listBox1.Items.Add(c.Name);
            listSid.Items.Add(c.ChildNodes[0].InnerText);
            listBox3.Items.Add(c.ChildNodes[1].InnerText);
            listBox4.Items.Add(c.ChildNodes[2].InnerText);
            listBox5.Items.Add(c.ChildNodes[3].InnerText);

        }


        return xmlStringResult;
    }


*/



/*
    private void writeParam(string xmlData)
    {



        XmlDocument doc = new XmlDocument();
        XmlDocument strData = new XmlDocument();

        string[] elementData = xmlData.Split(';');

        doc.Load("param-data.xml");

        XmlElement p = doc.CreateElement("PARAM");
        XmlElement pname = doc.CreateElement(elementData[0]);
        XmlElement sid = doc.CreateElement("SENSOR-ID");
        sid.InnerText = elementData[1];
        XmlElement sval = doc.CreateElement("SENSOR-VALUE");
        sval.InnerText = elementData[2];
        XmlElement h = doc.CreateElement("HOUR");
        h.InnerText = elementData[3];
        XmlElement date = doc.CreateElement("DATE");
        date.InnerText = elementData[4];

        XmlNode pData = doc.SelectSingleNode("/PARAM-DATA");

        pname.AppendChild(sid);
        pname.AppendChild(sval);
        pname.AppendChild(h);
        pname.AppendChild(date);

        p.AppendChild(pname);

        pData.AppendChild(p);

        doc.Save("param-data.xml");




    }


        private void writeAlarm(string xmlData)
        {



            XmlDocument doc = new XmlDocument();
            XmlDocument strData = new XmlDocument();

            string[] elementData = xmlData.Split(';');

            doc.Load("alarm-data.xml");

            XmlElement p = doc.CreateElement("ALARM");
            XmlElement pname = doc.CreateElement(elementData[0]);
            XmlElement sid = doc.CreateElement("ALARM-VALUE");
            sid.InnerText = elementData[1];
            XmlElement h = doc.CreateElement("HOUR");
            h.InnerText = elementData[2];
            XmlElement date = doc.CreateElement("DATE");
            date.InnerText = elementData[3];

            XmlNode pData = doc.SelectSingleNode("/ALARM-DATA");

            pname.AppendChild(sid);
            pname.AppendChild(h);
            pname.AppendChild(date);

            p.AppendChild(pname);

            pData.AppendChild(p);

            doc.Save("alarm-data.xml");

        }

    */

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }



    private void label1_Click(object sender, EventArgs e)
    {

    }



    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }



    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged_1(object sender, EventArgs e)
    {

    }




   
    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void rateTxt_TextChanged(object sender, EventArgs e)
    {

    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void label7_Click(object sender, EventArgs e)
    {

    }

    private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        //writeParam(paramTxt.Text);
    }

    private void button4_Click(object sender, EventArgs e)
    {
        // writeAlarm(alarmTxt.Text);
    }

    private void listSid_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void alarmTxt_TextChanged(object sender, EventArgs e)
    {

    }

    private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void label9_Click(object sender, EventArgs e)
    {

    }

    private void label8_Click(object sender, EventArgs e)
    {

    }

    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void viewAlarms_Click(object sender, EventArgs e)
    {
        generateAlarmsView();
        sh2OAlarm.Show();


    }

    private void viewParam_Click(object sender, EventArgs e)
    {
        generateParamsView();
    }

    private void groupBox5_Enter(object sender, EventArgs e)
    {

    }
}


}
