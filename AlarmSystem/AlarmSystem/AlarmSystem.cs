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

namespace AlarmSystem
{
    public partial class AlarmSystem : Form
    {

        static string xmlRulesPath = Application.StartupPath + @"\rules.xml";
        string xsdRulesPath = Application.StartupPath + @"\rules.xsd";
        static CultureInfo ptPT = CultureInfo.InvariantCulture;

        string _host = "127.0.0.1";
        string[] _topics = { "PH", "NH3", "CI2" };

        public AlarmSystem()
        {


            InitializeComponent();

            updateRulesList(xmlRulesPath);


            //Prevent users to write to comboboxes
            this.cmbBoxCondition_PH.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBoxCondition_NH3.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBoxCondition_CI2.DropDownStyle = ComboBoxStyle.DropDownList;

            //Subsribe to a mosquitto channel
            subscribeMQTT(_topics);

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

            XmlElement phRule = addRule(doc, "PH", "Greater Than", ph.ToString(".0", ptPT));
            XmlElement nh3Rule = addRule(doc, "NH3", "Greater Than", nh3.ToString(".0", ptPT));
            XmlElement ci2Rule = addRule(doc, "CI2", "Greater Than", ci2.ToString(".0", ptPT));

            rootElem.AppendChild(phRule);
            rootElem.AppendChild(nh3Rule);
            rootElem.AppendChild(ci2Rule);

            doc.Save(path);

        }

        private XmlElement addRule(XmlDocument doc, string waterParameter, string condition, string value)
        {
            XmlElement rule = doc.CreateElement("rule");
            XmlElement type = doc.CreateElement("type");
            type.InnerText = waterParameter;
            XmlElement cond = doc.CreateElement("condition");
            cond.InnerText = condition;
            XmlElement val = doc.CreateElement("value");
            val.InnerText = value;

            //Append all childs to temperature rule
            rule.AppendChild(type);
            rule.AppendChild(cond);
            rule.AppendChild(val);

            return rule;
        }


        private void updateRulesList(string xmlFilePath)
        {
            lstBox_Rules.Items.Clear();
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
                            this.lstBox_Rules.Items.Add(node.SelectSingleNode("type").InnerText + " " + node.SelectSingleNode("condition").InnerText + " " + node.SelectSingleNode("value").InnerText);
                        }
                    }
                    else { lstBox_Rules.Items.Add("No rules in XML Document"); }
                }

                else
                {
                    MessageBox.Show("INVALID rules.xml File!!", "ALARM SYSTEM [ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }




            }
            else { lstBox_Rules.Items.Add("No XML Document Found. Press \"Generate XML\" Button "); }




        }



        private void subscribeMQTT(string[] topics)
        {
            MqttClient m_cClient = new MqttClient(IPAddress.Parse(_host));
            m_cClient.Connect(Guid.NewGuid().ToString());

            if (!m_cClient.IsConnected)
            {
                Console.WriteLine("Error connecting to message broker...");
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


        static void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            //Console.WriteLine("Received = " + Encoding.UTF8.GetString(e.Message) + " on topic " + e.Topic);
            verifyAlarms(e.Topic, Encoding.UTF8.GetString(e.Message));
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
        *                                 Call functions to verify each one of Sensor Types
        ********************************************************************************************************************/
        static private void verifyAlarms(string topic, string message)
        {

            if (topic == "PH")
            {
                verifyPhAlarm(message);
            }
            if (topic == "NH3")
            {
                verifyHN3Alarm(message);
            }
            if (topic == "CI2")
            {
                verifyCI2Alarm(message);
            }

        }


        /*********************************************************************************************************************
        *                                  Verify if PH Matches with conditions specified in rules.xml file
        ********************************************************************************************************************/
        static private void verifyPhAlarm(string message)
        {
            XmlDocument rulesDoc = new XmlDocument();
            rulesDoc.Load(xmlRulesPath);
            XmlNodeList nodeList = rulesDoc.SelectNodes("/rules/rule[type ='PH']");


            foreach (XmlNode node in nodeList)
            {
                decimal ruleValue = Convert.ToDecimal(node.SelectSingleNode("value").InnerText, ptPT);
                if (node.SelectSingleNode("condition").InnerText == "Greater Than")
                {
                    if (Convert.ToDecimal(message, ptPT) > ruleValue)
                    {
                        Console.WriteLine("ALARM ON PH !!!!!!!!!");
                        //TODO call function to activate alarms on ph
                    }
                }
                if (node.SelectSingleNode("condition").InnerText == "Less Than")
                {
                    if (Convert.ToDecimal(message, ptPT) < ruleValue)
                    {
                        //TODO call function to activate alarms on ph
                    }
                }
                if (node.SelectSingleNode("condition").InnerText == "Equal")
                {
                    if (Convert.ToDecimal(message, ptPT) == ruleValue)
                    {
                        //TODO call function to activate alarms on ph
                    }
                }

                if (node.SelectSingleNode("condition").InnerText == "Between")
                {
                    if (Convert.ToDecimal(message, ptPT) < ruleValue && Convert.ToDecimal(message, ptPT) > ruleValue)
                    {
                        //TODO call function to activate alarms on ph
                    }
                }
            }
        }

        /*********************************************************************************************************************
        *                                  Verify if NH3 Matches with conditions specified in rules.xml file
        ********************************************************************************************************************/

        static private void verifyHN3Alarm(string message)
        {
            XmlDocument rulesDoc = new XmlDocument();
            rulesDoc.Load(xmlRulesPath);
            XmlNodeList nodeList = rulesDoc.SelectNodes("/rules/rule[type ='NH3']");


            foreach (XmlNode node in nodeList)
            {
                decimal ruleValue = Convert.ToDecimal(node.SelectSingleNode("value").InnerText, ptPT);
                if (node.SelectSingleNode("condition").InnerText == "Greater Than")
                {
                    if (Convert.ToDecimal(message, ptPT) > ruleValue)
                    {
                        Console.WriteLine("ALARM ON NH3 !!!!!!!!!");
                        //TODO call function to activate alarms on ph
                    }
                }
                if (node.SelectSingleNode("condition").InnerText == "Less Than")
                {
                    if (Convert.ToDecimal(message, ptPT) < ruleValue)
                    {
                        //TODO call function to activate alarms on ph
                    }
                }
                if (node.SelectSingleNode("condition").InnerText == "Equal")
                {
                    if (Convert.ToDecimal(message, ptPT) == ruleValue)
                    {
                        //TODO call function to activate alarms on ph
                    }
                }

                if (node.SelectSingleNode("condition").InnerText == "Between")
                {
                    if (Convert.ToDecimal(message, ptPT) < ruleValue && Convert.ToDecimal(message, ptPT) > ruleValue)
                    {
                        //TODO call function to activate alarms on ph
                    }
                }
            }
        }
        /*********************************************************************************************************************
         *                                  Verify if CI2 Matches with conditions specified in rules.xml file
         ********************************************************************************************************************/
        static private void verifyCI2Alarm(string message)
        {
            XmlDocument rulesDoc = new XmlDocument();
            rulesDoc.Load(xmlRulesPath);
            XmlNodeList nodeList = rulesDoc.SelectNodes("/rules/rule[type ='CI2']");


            foreach (XmlNode node in nodeList)
            {
                decimal ruleValue = Convert.ToDecimal(node.SelectSingleNode("value").InnerText, ptPT);
                if (node.SelectSingleNode("condition").InnerText == "Greater Than")
                {
                    if (Convert.ToDecimal(message, ptPT) > ruleValue)
                    {
                        Console.WriteLine("ALARM ON CI2 !!!!!!!!!");
                        //TODO call function to activate alarms on ph
                    }
                }
                if (node.SelectSingleNode("condition").InnerText == "Less Than")
                {
                    if (Convert.ToDecimal(message, ptPT) < ruleValue)
                    {
                        //TODO call function to activate alarms on ph
                    }
                }
                if (node.SelectSingleNode("condition").InnerText == "Equal")
                {
                    if (Convert.ToDecimal(message, ptPT) == ruleValue)
                    {
                        //TODO call function to activate alarms on ph
                    }
                }

                if (node.SelectSingleNode("condition").InnerText == "Between")
                {
                    if (Convert.ToDecimal(message, ptPT) < ruleValue && Convert.ToDecimal(message, ptPT) > ruleValue)
                    {
                        //TODO call function to activate alarms on ph
                    }
                }
            }
        }




    }
}
