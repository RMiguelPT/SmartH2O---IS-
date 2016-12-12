using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace SmartH2O_DLog
{
    class Program
    {

        static void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string msg = Encoding.UTF8.GetString(e.Message);

           if (e.Topic == "PH" || e.Topic == "NH3" || e.Topic == "CI2")
            {
                SendInfoParam(e.Topic, msg);
            }
           else if(e.Topic == "alarmNH3")
            {
                string info = "NH3;"+msg+";"+ DateTime.Now.ToString("HH: mm") +";" + DateTime.Now.ToString("dd-MM-yyyy");
            }
            else if (e.Topic == "alarmCI2")
            {
                string info = "CI2;" + msg + ";" + DateTime.Now.ToString("HH: mm") + ";" + DateTime.Now.ToString("dd-MM-yyyy");
            }
            else if (e.Topic == "alarmPH")
            {
                string info = "PH;" + msg + ";" + DateTime.Now.ToString("HH: mm") + ";" + DateTime.Now.ToString("dd-MM-yyyy");
            }
        }

        private static void SendInfoParam(string topic,string message)
        {
            
            string[] words = message.Split(';');
            string info = words[0] + ";" + words[1] + ";" + DateTime.Now.ToString("HH:mm") + ";" + DateTime.Now.ToString("dd-MM-yyyy");
        }

        static void Main(string[] args)
        {

            MqttClient m_cClient = new MqttClient(IPAddress.Parse("192.168.237.155"));
            string[] m_strTopicsInfo = { "PH", "NH3", "CI2", "alarmNH3", "alarmCI2", "alarmPH" };
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
            MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE};//QoS
            m_cClient.Subscribe(m_strTopicsInfo, qosLevels);

            Console.ReadKey();
            if (
            m_cClient.IsConnected)
            {
                m_cClient.Unsubscribe(m_strTopicsInfo); //Put this in a button to see notif!
                m_cClient.Disconnect(); //Free process and process's resources
            }

        }


    }