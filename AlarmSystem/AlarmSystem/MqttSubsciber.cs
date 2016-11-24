using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;


namespace AlarmSystem
{
    class MqttSubsciber
    {
        string _host = "";
        string[] topics = { };

        public MqttSubsciber(string host)
        {
            _host = host;
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
            //m_cClient.Subscribe(m_strTopicsInfo, qosLevels);
        }

        static void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            Console.WriteLine("Received = " + Encoding.UTF8.GetString(e.Message) + " on topic " + e.Topic);
            //readRules(e.Topic, Encoding.UTF8.GetString(e.Message));
        }
    }
}
