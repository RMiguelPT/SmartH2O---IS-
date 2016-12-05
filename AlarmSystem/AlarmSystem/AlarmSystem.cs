using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.Globalization;
using System.IO;

using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Diagnostics;

namespace AlarmSystem
{
    public partial class AlarmSystem : Form
    {

        string xmlRulesPath = Application.StartupPath + @"\trigger-rules.xml";
        string xsdRulesPath = Application.StartupPath + @"\trigger-rules.xsd";
        static CultureInfo ptPT = CultureInfo.InvariantCulture;

        string _host = "192.168.237.200";
        string[] _topics = { "PH", "NH3", "CI2" };

        bool phAlarmGenerated = false;
        bool nh3AlarmGenerated = false;
        bool ci2AlarmGenerated = false;

        bool phAlarmEnabled = true;
        bool nh3AlarmEnabled = true;
        bool ci2AlarmEnabled = true;

        private mqttPublisher publisher;

        public AlarmSystem()
        {


            InitializeComponent();

            updateRulesList(xmlRulesPath);

            //Prevent users to write to comboboxes
            this.cmbBoxCondition_PH.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBoxCondition_NH3.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBoxCondition_CI2.DropDownStyle = ComboBoxStyle.DropDownList;

            disableAlarms("all");

            //Timer Configuration

            timer1.Tick += new EventHandler(timer_Tick);
            timer1.Interval = 100;
            timer1.Enabled = true;
            timer1.Start();

            //Subsribe to a mosquitto channel
            // subscribeMQTT(_topics);


            //txtBox_XmlPreviewer.Lines = File.ReadAllLines(xmlRulesPath);
            rdBtn_AlarmPhON.Select();
            rdBtn_AlarmNH3ON.Select();
            rdBtn_AlarmCI2ON.Select();
        }




        private void createXmlRulesFile(string path)
        {
            XmlDocument doc = new XmlDocument();

            //XML Declaration
            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", null, null);
            declaration.Encoding = "UTF-8";
            doc.AppendChild(declaration);

            //XML Root Element
            XmlElement rootElem = doc.CreateElement("rules");
            doc.AppendChild(rootElem);

            //Default Values
            decimal ph = 7;
            decimal nh3 = 7;
            decimal ci2 = 7;

            XmlElement phRule = addRule(doc, "PH", "Greater Than", ph.ToString(".0", ptPT), "0");
            XmlElement nh3Rule = addRule(doc, "NH3", "Greater Than", nh3.ToString(".0", ptPT), "0");
            XmlElement ci2Rule = addRule(doc, "CI2", "Greater Than", ci2.ToString(".0", ptPT), "0");

            rootElem.AppendChild(phRule);
            rootElem.AppendChild(nh3Rule);
            rootElem.AppendChild(ci2Rule);

            doc.Save(path);

        }

        private XmlElement addRule(XmlDocument doc, string waterParameter, string condition, string minValue, string maxValue)
        {
            XmlElement rule = doc.CreateElement("rule");
            XmlElement type = doc.CreateElement("type");
            type.InnerText = waterParameter;
            XmlElement cond = doc.CreateElement("condition");
            cond.InnerText = condition;
            XmlElement minVal = doc.CreateElement("minValue");
            minVal.InnerText = minValue;
            XmlElement maxVal = doc.CreateElement("maxValue");
            maxVal.InnerText = maxValue;

            //Append all childs to temperature rule
            rule.AppendChild(type);
            rule.AppendChild(cond);
            rule.AppendChild(minVal);
            rule.AppendChild(maxVal);

            return rule;
        }


        private void updateRulesList(string xmlFilePath)
        {
            //lstBox_Rules.Items.Clear();
            this.lstBox_PHRules.Items.Clear();
            this.lstBox_NH3Rules.Items.Clear();
            this.lstBox_CI2Rules.Items.Clear();

            if (File.Exists(xmlFilePath))
            {
                XmlValidator xmlValidator = new XmlValidator(xmlRulesPath, xsdRulesPath);
                var msg = xmlValidator.validateXMLDocument();
                Console.WriteLine(msg.ToString());
                if (msg)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(xmlRulesPath);
                    XmlNodeList nodeList = doc.SelectNodes("/rules/rule");

                    if (nodeList.Count != 0)
                    {
                        foreach (XmlNode node in nodeList)
                        {
                            if (node.SelectSingleNode("type").InnerText == "PH")
                            {
                                this.lstBox_PHRules.Items.Add(node.SelectSingleNode("type").InnerText + " " + node.SelectSingleNode("condition").InnerText + " " + node.SelectSingleNode("minValue").InnerText);
                            }
                            if (node.SelectSingleNode("type").InnerText == "NH3")
                            {
                                this.lstBox_NH3Rules.Items.Add(node.SelectSingleNode("type").InnerText + " " + node.SelectSingleNode("condition").InnerText + " " + node.SelectSingleNode("minValue").InnerText);
                            }
                            if (node.SelectSingleNode("type").InnerText == "CI2")
                            {
                                this.lstBox_CI2Rules.Items.Add(node.SelectSingleNode("type").InnerText + " " + node.SelectSingleNode("condition").InnerText + " " + node.SelectSingleNode("minValue").InnerText);
                            }
                            //this.lstBox_Rules.Items.Add(node.SelectSingleNode("type").InnerText + " " + node.SelectSingleNode("condition").InnerText + " " + node.SelectSingleNode("minValue").InnerText);
                        }
                    }
                    else
                    {
                        lstBox_PHRules.Items.Add("No rules in XML Document");
                        lstBox_NH3Rules.Items.Add("No rules in XML Document");
                        lstBox_CI2Rules.Items.Add("No rules in XML Document");
                    }
                }

                else
                {
                    MessageBox.Show("INVALID rules.xml File!!", "ALARM SYSTEM [ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                txtBox_XmlPreviewer.Text = ("No XML Document Found. Press \"Generate XML\" Button ");
            }
        }



        private void subscribeMQTT(string[] topics)
        {
            MqttClient m_cClient = new MqttClient(IPAddress.Parse(_host));
            try
            {
                m_cClient.Connect(Guid.NewGuid().ToString());
            }
            catch
            {
                MessageBox.Show("Error connecting to message broker...");

                return;
            }

            //Specify events we are interest on
            //New Msg Arrived
            m_cClient.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
            //Subscribe to topics
            byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE,
            MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE};//QoS
            m_cClient.Subscribe(topics, qosLevels);

        }


        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {

            if (File.Exists(xmlRulesPath))
            {
                XmlValidator xmlValidator = new XmlValidator(xmlRulesPath, xsdRulesPath);
                var msg = xmlValidator.validateXMLDocument();
                if (msg)
                {
                    verifyAlarms(e.Topic, Encoding.UTF8.GetString(e.Message));
                }
            }


        }

        private void btnDefaultRules_Click(object sender, EventArgs e)
        {
            createXmlRulesFile(xmlRulesPath);
            updateRulesList(xmlRulesPath);
        }

        private void cmbBoxCondition_PH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cmbBoxCondition_PH.SelectedItem != "Between")
            {
                lblAnd_PH.Hide();
                lblValue2_PH.Hide();
                txtBoxValue2_PH.Hide();
            }
            else
            {
                lblAnd_PH.Show();
                lblValue2_PH.Show();
                txtBoxValue2_PH.Show();
            }
        }

        private void cmbBoxCondition_NH3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cmbBoxCondition_NH3.SelectedItem != "Between")
            {
                lblAnd_NH3.Hide();
                lblValue2_NH3.Hide();
                txtBoxValue2_NH3.Hide();
            }
            else
            {
                lblAnd_NH3.Show();
                lblValue2_NH3.Show();
                txtBoxValue2_NH3.Show();
            }
        }

        private void cmbBoxCondition_CI2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cmbBoxCondition_CI2.SelectedItem != "Between")
            {
                lblAnd_CI2.Hide();
                lblValue2_CI2.Hide();
                txtBoxValue2_CI2.Hide();
            }
            else
            {
                lblAnd_CI2.Show();
                lblValue2_CI2.Show();
                txtBoxValue2_CI2.Show();
            }
        }
        /*********************************************************************************************************************
        *                                 Disable specific alarms or all if "all" string is given
        ********************************************************************************************************************/
        private void disableAlarms(string alarm)
        {
            if (alarm == "ph")
            {
                lbl_phWarning.Visible = false;
            }
            if (alarm == "nh3")
            {
                lbl_nh3Warning.Visible = false;
            }
            if (alarm == "ci2")
            {
                lbl_ci2Warning.Visible = false;
            }
            if (alarm == "all")
            {
                lbl_phWarning.Visible = false;
                lbl_nh3Warning.Visible = false;
                lbl_ci2Warning.Visible = false;
            }



        }

        void timer_Tick(object sender, EventArgs e)
        {
            triggerAlarms();
        }

        /*********************************************************************************************************************
       *                                Trigger a specific alarm
       ********************************************************************************************************************/
        private void triggerAlarms()
        {
            if (phAlarmEnabled)
            {
                lbl_phWarning.Visible = phAlarmGenerated ? true : false;
            }
            if (nh3AlarmEnabled)
            {
                lbl_nh3Warning.Visible = nh3AlarmGenerated ? true : false;
            }
            if (ci2AlarmEnabled)
            {
                lbl_ci2Warning.Visible = ci2AlarmGenerated ? true : false;
            }

        }

        /*********************************************************************************************************************
        *                                 Call functions to verify each one of Sensor Types
        ********************************************************************************************************************/
        private void verifyAlarms(string topic, string message)
        {

            if (topic == "PH")
            {
                verifyPhAlarm(splitMessage(message));
            }
            if (topic == "NH3")
            {
                verifyHN3Alarm(splitMessage(message));
            }
            if (topic == "CI2")
            {
                verifyCI2Alarm(splitMessage(message));
            }

        }

        /*********************************************************************************************************************
        *                                  Verify if PH Matches with conditions specified in rules.xml file
        ********************************************************************************************************************/
        private void verifyPhAlarm(string actualPhValue)
        {
            XmlDocument rulesDoc = new XmlDocument();
            rulesDoc.Load(xmlRulesPath);
            XmlNodeList nodeList = rulesDoc.SelectNodes("/rules/rule[type ='PH']");


            foreach (XmlNode node in nodeList)
            {
                decimal ruleValue = Convert.ToDecimal(node.SelectSingleNode("minValue").InnerText, ptPT);
                if (node.SelectSingleNode("condition").InnerText == "Greater Than")
                {
                    if (Convert.ToDecimal(actualPhValue, ptPT) > ruleValue)
                    {
                        Debug.WriteLine("ALARM ON PH !!!!!!!!!");
                        phAlarmGenerated = true;
                        publisher.publishData("alarmPH;" + actualPhValue);

                    }
                    else
                    {
                        phAlarmGenerated = false;
                    }
                }
                if (node.SelectSingleNode("condition").InnerText == "Less Than")
                {
                    if (Convert.ToDecimal(actualPhValue, ptPT) < ruleValue)
                    {
                        //TODO call function to activate alarms on ph
                        phAlarmGenerated = true;
                        publisher.publishData("alarmPH;" + actualPhValue);
                    }
                    else
                    {
                        phAlarmGenerated = false;
                    }
                }
                if (node.SelectSingleNode("condition").InnerText == "Equal")
                {
                    if (Convert.ToDecimal(actualPhValue, ptPT) == ruleValue)
                    {
                        //TODO call function to activate alarms on ph
                        phAlarmGenerated = true;
                        publisher.publishData("alarmPH;" + actualPhValue);
                    }
                    else
                    {
                        phAlarmGenerated = false;
                    }
                }

                if (node.SelectSingleNode("condition").InnerText == "Between")
                {
                    if (Convert.ToDecimal(actualPhValue, ptPT) < ruleValue && Convert.ToDecimal(actualPhValue, ptPT) > ruleValue)
                    {
                        //TODO call function to activate alarms on ph
                        phAlarmGenerated = true;
                        publisher.publishData("alarmPH;" + actualPhValue);
                    }
                    else
                    {
                        phAlarmGenerated = false;
                    }
                }

            }
        }

        /*********************************************************************************************************************
        *                                  Verify if NH3 Matches with conditions specified in rules.xml file
        ********************************************************************************************************************/

        private void verifyHN3Alarm(string actualNH3Value)
        {
            XmlDocument rulesDoc = new XmlDocument();
            rulesDoc.Load(xmlRulesPath);
            XmlNodeList nodeList = rulesDoc.SelectNodes("/rules/rule[type ='NH3']");


            foreach (XmlNode node in nodeList)
            {
                decimal ruleValue = Convert.ToDecimal(node.SelectSingleNode("minValue").InnerText, ptPT);
                if (node.SelectSingleNode("condition").InnerText == "Greater Than")
                {
                    if (Convert.ToDecimal(actualNH3Value, ptPT) > ruleValue)
                    {
                        Debug.WriteLine("ALARM ON NH3 !!!!!!!!!");
                        nh3AlarmGenerated = true;
                        publisher.publishData("alarmNH3;" + actualNH3Value);
                    }
                    else
                    {
                        nh3AlarmGenerated = false;
                    }
                }
                if (node.SelectSingleNode("condition").InnerText == "Less Than")
                {
                    if (Convert.ToDecimal(actualNH3Value, ptPT) < ruleValue)
                    {
                        //TODO call function to activate alarms on ph
                        nh3AlarmGenerated = true;
                        publisher.publishData("alarmNH3;" + actualNH3Value);
                    }
                    else
                    {
                        nh3AlarmGenerated = false;
                    }
                }
                if (node.SelectSingleNode("condition").InnerText == "Equal")
                {
                    if (Convert.ToDecimal(actualNH3Value, ptPT) == ruleValue)
                    {
                        //TODO call function to activate alarms on ph
                        nh3AlarmGenerated = true;
                        publisher.publishData("alarmNH3;" + actualNH3Value);
                    }
                    else
                    {
                        nh3AlarmGenerated = false;
                    }
                }

                if (node.SelectSingleNode("condition").InnerText == "Between")
                {
                    if (Convert.ToDecimal(actualNH3Value, ptPT) < ruleValue && Convert.ToDecimal(actualNH3Value, ptPT) > ruleValue)
                    {
                        //TODO call function to activate alarms on ph
                        nh3AlarmGenerated = true;
                        publisher.publishData("alarmNH3;" + actualNH3Value);
                    }
                    else
                    {
                        nh3AlarmGenerated = false;
                    }
                }

            }
        }
        /*********************************************************************************************************************
         *                                  Verify if CI2 Matches with conditions specified in rules.xml file
         ********************************************************************************************************************/
        private void verifyCI2Alarm(string actualCI2Value)
        {
            XmlDocument rulesDoc = new XmlDocument();
            rulesDoc.Load(xmlRulesPath);
            XmlNodeList nodeList = rulesDoc.SelectNodes("/rules/rule[type ='CI2']");


            foreach (XmlNode node in nodeList)
            {
                decimal ruleValue = Convert.ToDecimal(node.SelectSingleNode("minValue").InnerText, ptPT);
                if (node.SelectSingleNode("condition").InnerText == "Greater Than")
                {
                    if (Convert.ToDecimal(actualCI2Value, ptPT) > ruleValue)
                    {
                        Debug.WriteLine("ALARM ON CI2 !!!!!!!!!");
                        ci2AlarmGenerated = true;
                        publisher.publishData("alarmCI2;" + actualCI2Value);
                    }
                    else
                    {
                        ci2AlarmGenerated = false;
                    }
                }
                if (node.SelectSingleNode("condition").InnerText == "Less Than")
                {
                    if (Convert.ToDecimal(actualCI2Value, ptPT) < ruleValue)
                    {
                        //TODO call function to activate alarms on ph
                        ci2AlarmGenerated = true;
                        publisher.publishData("alarmCI2;" + actualCI2Value);
                    }
                    else
                    {
                        ci2AlarmGenerated = false;
                    }
                }
                if (node.SelectSingleNode("condition").InnerText == "Equal")
                {
                    if (Convert.ToDecimal(actualCI2Value, ptPT) == ruleValue)
                    {
                        //TODO call function to activate alarms on ph
                        ci2AlarmGenerated = true;
                        publisher.publishData("alarmCI2;" + actualCI2Value);
                    }
                    else
                    {
                        ci2AlarmGenerated = false;
                    }
                }

                if (node.SelectSingleNode("condition").InnerText == "Between")
                {
                    if (Convert.ToDecimal(actualCI2Value, ptPT) < ruleValue && Convert.ToDecimal(actualCI2Value, ptPT) > ruleValue)
                    {
                        //TODO call function to activate alarms on ph
                        ci2AlarmGenerated = true;
                        publisher.publishData("alarmCI2;" + actualCI2Value);
                    }
                    else
                    {
                        ci2AlarmGenerated = false;
                    }
                }

            }
        }

        private void btnSetRule_PH_Click(object sender, EventArgs e)
        {
            if (this.cmbBoxCondition_PH.SelectedIndex > -1)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlRulesPath);
                XmlNode rootElem = doc.SelectSingleNode("rules");

                if ((string)this.cmbBoxCondition_PH.SelectedItem != "Between")
                {
                    if (string.IsNullOrWhiteSpace(this.txtBoxValue1_PH.Text))
                    {
                        MessageBox.Show("You have selected the \"" + (string)this.cmbBoxCondition_PH.SelectedItem + "\" condition. Please insert the one value.");
                        return;
                    }
                    XmlElement rule = addRule(doc, "PH", (string)cmbBoxCondition_PH.SelectedItem, txtBoxValue1_PH.Text.ToString(), "0");
                    rootElem.AppendChild(rule);

                }
                else
                {
                    if (string.IsNullOrWhiteSpace(this.txtBoxValue1_PH.Text) || (string.IsNullOrWhiteSpace(this.txtBoxValue2_PH.Text)))
                    {
                        MessageBox.Show("You have selected the \"Between\" condition. Please insert the minimum and the maximum values.");
                        return;
                    }
                    else
                    {
                        int[] values = new int[2];
                        values[0] = int.Parse(txtBoxValue1_PH.Text.ToString());
                        values[1] = int.Parse(txtBoxValue2_PH.Text.ToString());

                        XmlElement rule = addRule(doc, "PH", (string)cmbBoxCondition_PH.SelectedItem, values[0].ToString(), values[1].ToString());
                        rootElem.AppendChild(rule);
                    }
                }
                doc.Save(xmlRulesPath);

                updateRulesList(xmlRulesPath);
            }
            else
            {
                MessageBox.Show("Please Select one condition.");
                return;
            }
        }

        private string splitMessage(string originalMessage)
        {
            string[] words = originalMessage.Split(';');
            return words[1];
        }

        private void deleteRules(string topic)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlRulesPath);

            XmlNodeList nodes = doc.SelectNodes("/rules/rule");
            foreach (XmlNode node in nodes)
            {
                if (node.SelectSingleNode("type").InnerText == topic)
                {
                    node.ParentNode.RemoveChild(node);
                    Console.WriteLine("deleted node");
                }
            }

            doc.Save(xmlRulesPath);
        }

        private void AlarmSystem_Shown(object sender, EventArgs e)
        {
            subscribeMQTT(_topics);
            publisher = new mqttPublisher(_host);
        }

        private void btn_DelPhRules_Click(object sender, EventArgs e)
        {
            deleteRules("PH");
            updateRulesList(xmlRulesPath);
        }

        private void btn_DelNH3Rules_Click(object sender, EventArgs e)
        {
            deleteRules("NH3");
            updateRulesList(xmlRulesPath);
        }

        private void btn_DelCI2Rules_Click(object sender, EventArgs e)
        {
            deleteRules("CI2");
            updateRulesList(xmlRulesPath);
        }

        private void rdBtn_AlarmPhON_CheckedChanged(object sender, EventArgs e)
        {
            if (!phAlarmEnabled)
            {
                phAlarmEnabled = true;
            }
        }

        private void rdBtn_AlarmPhOFF_CheckedChanged(object sender, EventArgs e)
        {
            if (phAlarmEnabled)
            {
                phAlarmEnabled = false;
                disableAlarms("ph");
                phAlarmGenerated = false;
            }
        }

        private void rdBtn_AlarmNH3ON_CheckedChanged(object sender, EventArgs e)
        {
            if (!nh3AlarmEnabled)
            {
                nh3AlarmEnabled = true;
            }
        }

        private void rdBtn_AlarmNH3OFF_CheckedChanged(object sender, EventArgs e)
        {
            if (nh3AlarmEnabled)
            {
                nh3AlarmEnabled = false;
                disableAlarms("nh3");
                nh3AlarmGenerated = false;
            }
        }

        private void rdBtn_AlarmCI2ON_CheckedChanged(object sender, EventArgs e)
        {
            if (!ci2AlarmEnabled)
            {
                ci2AlarmEnabled = false;
            }
        }

        private void rdBtn_AlarmCI2OFF_CheckedChanged(object sender, EventArgs e)
        {
            if (ci2AlarmEnabled)
            {
                ci2AlarmEnabled = false;
                disableAlarms("ci2");
                ci2AlarmGenerated = false;
            }
        }
    }
}
