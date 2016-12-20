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

        private void generateAlarmsView()
        {

            //################## ALARMS ###########################

            ServiceData.SmartH2O_ServiceClient servData = new ServiceData.SmartH2O_ServiceClient();
            XmlDocument doc = new XmlDocument();

            


            //################## DAILY-ALARMS ###########################

            if (dailyAlarms.Checked)
            {
                int day = dailyAlarmsPick.Value.Day;
                int month = dailyAlarmsPick.Value.Month;
                int year = dailyAlarmsPick.Value.Year;

                DateTime pickDate = new DateTime(year, month, day);

                string ph = servData.getDailyAlarmsInformation("PH", pickDate.ToString("dd-MM-yyyy"));
            
                string nh3 = servData.getDailyAlarmsInformation("NH3", pickDate.ToString("dd-MM-yyyy"));

                string ci2 = servData.getDailyAlarmsInformation("CI2", pickDate.ToString("dd-MM-yyyy"));


                string[] allAlarms = new String[] { ph, nh3, ci2 };

                sh2OAlarm.clearAlamsFormData();

                //Combine and remove duplicates
               



                foreach (string alarm in allAlarms)
                {
                    Console.WriteLine(alarm);
                }



                foreach (string alarm in allAlarms)
                {
                    doc.LoadXml(alarm);
                    XmlNodeList list = doc.SelectNodes("/ALARM-DATA/ALARM");

                    foreach (XmlNode n in list)
                    {
                        foreach (XmlNode c in n.ChildNodes)
                        {

                            string[] nodeSplitDate = c.ChildNodes[2].InnerText.Split('-');
                            int nodeDay = Int32.Parse(nodeSplitDate[0]);
                            int nodeMonth = Int32.Parse(nodeSplitDate[1]);
                            int nodeYear = Int32.Parse(nodeSplitDate[2]);

                            DateTime nodeDate = new DateTime(nodeYear, nodeMonth, nodeDay);

                            sh2OAlarm.addAlarmData(c.Name, c.ChildNodes[0].InnerText, c.ChildNodes[1].InnerText, c.ChildNodes[2].InnerText);
                            sh2OAlarm.updateAlarmGraphic(c.Name, c.ChildNodes[1].InnerText, Convert.ToDouble(c.ChildNodes[0].InnerText.Replace(".", ",")));

                           
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
                else
                {

                    int initDay = periodAlarmsPickInit.Value.Day;
                    int initMonth = periodAlarmsPickInit.Value.Month;
                    int initYear = periodAlarmsPickInit.Value.Year;

                    DateTime alarmPickInit = new DateTime(initYear, initMonth, initDay);


                    int endDay = periodAlarmsPickEnd.Value.Day;
                    int endMonth = periodAlarmsPickEnd.Value.Month;
                    int endYear = periodAlarmsPickEnd.Value.Year;

                    DateTime alarmPickEnd = new DateTime(endYear, endMonth, endDay);


                    string ph = servData.getAlarmsInformation("ph", alarmPickInit.Date.ToString("dd-MM-yyyy"), alarmPickEnd.Date.ToString("dd-MM-yyyy"));
                 
                    string ci2 = servData.getAlarmsInformation("ci2", alarmPickInit.Date.ToString("dd-MM-yyyy"), alarmPickEnd.Date.ToString("dd-MM-yyyy"));
                  
                    string nh3 = servData.getAlarmsInformation("nh3", alarmPickInit.Date.ToString("dd-MM-yyyy"), alarmPickEnd.Date.ToString("dd-MM-yyyy"));
                   


                    string[] allAlarms = new String[] { ph, nh3, ci2 };

                   

                    foreach (string alarm in allAlarms)
                    {
                        doc.LoadXml(alarm);
                       
                        XmlNodeList list = doc.SelectNodes("/ALARM-DATA/ALARM");

                        foreach (XmlNode n in list)
                        {
                            foreach (XmlNode c in n.ChildNodes)
                            {


                                string[] nodeSplitDate = c.ChildNodes[2].InnerText.Split('-');
                                int nodeDay = Int32.Parse(nodeSplitDate[0]);
                                int nodeMonth = Int32.Parse(nodeSplitDate[1]);
                                int nodeYear = Int32.Parse(nodeSplitDate[2]);

                                DateTime nodeDate = new DateTime(nodeYear, nodeMonth, nodeDay);
                                List<DateTime> d = new List<DateTime>();
                         
                                if (nodeDate >= alarmPickInit && nodeDate <= alarmPickEnd)

                                {
                                    sh2OAlarm.addAlarmData(c.Name, c.ChildNodes[0].InnerText, c.ChildNodes[1].InnerText, c.ChildNodes[2].InnerText);
                              
                                    sh2OAlarm.updateAlarmGraphic2(c.Name, nodeDate, c.ChildNodes[0].InnerText);


                                }
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

                sh2OGraph.changeHeaders(0);


                if (chkCi2.Checked)
                {

                    string xmlDataCi2 = servData.getHourlySummarizedInformation("CI2", hourlyDatePick.Value.ToString("dd-MM-yyyy"));
                    
                    createGraphfromXml(xmlDataCi2, "CI2", "dailyParam");
                }

                if (chkNh3.Checked)
                {
                    string xmlDataNh3 = servData.getHourlySummarizedInformation("NH3", hourlyDatePick.Value.ToString("dd-MM-yyyy"));
                    
                    createGraphfromXml(xmlDataNh3, "NH3", "dailyParam");
                }
                if (chkPh.Checked)
                {
                    string xmlDataPh = servData.getHourlySummarizedInformation("PH", hourlyDatePick.Value.ToString("dd-MM-yyyy"));

                    createGraphfromXml(xmlDataPh, "PH", "dailyParam");
                }

            }
            //################## PERIOD-PARAMS ###########################
            else if (periodParam.Checked)
            {
                sh2OGraph.changeHeaders(1);

                if (chkCi2.Checked)
                {

                    string xmlPdataCi2 = servData.getPeriodSummarizedInformation("CI2", paramPeriodPickInit.Value.ToString("dd-MM-yyyy"), paramPeriodPickEnd.Value.ToString("dd-MM-yyyy"));
                    createGraphfromXml(xmlPdataCi2, "CI2", "periodParam");

                }

                if (chkNh3.Checked)
                {
                    string xmlPdataNh3 = servData.getPeriodSummarizedInformation("NH3", paramPeriodPickInit.Value.ToString("dd-MM-yyyy"), paramPeriodPickEnd.Value.ToString("dd-MM-yyyy"));
                    createGraphfromXml(xmlPdataNh3, "NH3", "periodParam");


                }
                if (chkPh.Checked)
                {
                    string xmlPdataPh = servData.getPeriodSummarizedInformation("PH", paramPeriodPickInit.Value.ToString("dd-MM-yyyy"), paramPeriodPickEnd.Value.ToString("dd-MM-yyyy"));
                    createGraphfromXml(xmlPdataPh, "PH", "periodParam");
                }

            }
            else if (weakParam.Checked)
            {
                sh2OGraph.changeHeaders(2);

                DateTime weeKdate = paramWeekPick.Value;
                DayOfWeek fdow = CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
                int offset = fdow - weeKdate.DayOfWeek;
                DateTime fisrtDayofWeek = weeKdate.AddDays(offset);
                DateTime lastDayofWeek = fisrtDayofWeek.AddDays(6);

                if (chkCi2.Checked)
                {
                    string xmlPdataCi2 = servData.getPeriodSummarizedInformation("CI2", fisrtDayofWeek.Date.ToString("dd-MM-yyyy"), lastDayofWeek.Date.ToString("dd-MM-yyyy"));
                    createGraphfromXml(xmlPdataCi2, "CI2", "periodParam");

                }

                if (chkNh3.Checked)
                {
                    string xmlPdataNh3 = servData.getPeriodSummarizedInformation("NH3", fisrtDayofWeek.Date.ToString("dd-MM-yyyy"), lastDayofWeek.Date.ToString("dd-MM-yyyy"));
                    createGraphfromXml(xmlPdataNh3, "NH3", "periodParam");


                }
                if (chkPh.Checked)
                {
                    string xmlPdataPh = servData.getPeriodSummarizedInformation("PH", fisrtDayofWeek.Date.ToString("dd-MM-yyyy"), lastDayofWeek.Date.ToString("dd-MM-yyyy"));
                    createGraphfromXml(xmlPdataPh, "PH", "periodParam");

                }

            }
            else MessageBox.Show("Tem de selecionar pelo menos uma opção de visualização!");
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
                    sh2OGraph.updateHourlyGraphic(param, c.ChildNodes[1].InnerText, c.ChildNodes[2].InnerText, c.ChildNodes[3].InnerText, c.ChildNodes[0].InnerText);
                }
                if (String.Equals(viewType, "periodParam"))
                {

                    string[] words = c.ChildNodes[0].InnerText.Split(' ');
                    string[] nodeSplitDate = words[0].Split('/');
                    int nodeMonth = Int32.Parse(nodeSplitDate[0]);
                    int  nodeDay = Int32.Parse(nodeSplitDate[1]);
                    int nodeYear = Int32.Parse(nodeSplitDate[2]);

                    
                    DateTime nodeDate = new DateTime(nodeYear,nodeMonth , nodeDay);
                    sh2OGraph.updatePeriodGraphic(param, c.ChildNodes[1].InnerText, c.ChildNodes[2].InnerText, c.ChildNodes[3].InnerText, nodeDate);

                }
            }

            sh2OGraph.Show();
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

        private void recentAlarms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
