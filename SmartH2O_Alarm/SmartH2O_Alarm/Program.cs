using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace SmartH2O_Alarm
{
    class Program
    {

        static string filepath = AppDomain.CurrentDomain.BaseDirectory.ToString() + "App_Data/trigger_rules.xml";
        
        
        static void Main(string[] args)
        {

            MqttClient m_cClient = new MqttClient(IPAddress.Parse("192.168.237.226"));
            string[] m_strTopicsInfo = { "PH", "NH3", "CI2"};
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
            m_cClient.Subscribe(m_strTopicsInfo, qosLevels);

            Console.ReadKey();
            if (m_cClient.IsConnected)
            {
                m_cClient.Unsubscribe(m_strTopicsInfo); //Put this in a button to see notif!
                m_cClient.Disconnect(); //Free process and process's resources
            }
        }


        static void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            Console.WriteLine("Received = " + Encoding.UTF8.GetString(e.Message) + " on topic " + e.Topic);
            readRules(e.Topic, Encoding.UTF8.GetString(e.Message));
        }

       static private void readRules(string topic, string message)
        {
            XmlDocument rulesDoc = new XmlDocument();
            rulesDoc.Load(filepath);

            XmlNodeList nodeList = rulesDoc.SelectNodes("/trigger-rules/" + topic + "/rule");
           foreach(XmlNode node in nodeList)
            {
                Console.WriteLine(node.InnerText);
            }
        }

    }
}
