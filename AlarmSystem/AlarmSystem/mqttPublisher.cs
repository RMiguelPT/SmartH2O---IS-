using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;


namespace AlarmSystem
{
    class mqttPublisher
    {
        public static MqttClient m_cClient;


        public mqttPublisher(string host)
        {
            m_cClient = new MqttClient(IPAddress.Parse(host));

            try
            {
                m_cClient.Connect(Guid.NewGuid().ToString());
            }
            catch
            {
                MessageBox.Show("Error connecting to message publisher broker");
            }
           
        }


        public void publishData(string topic, string message, string timestamp)
        {

            string messageToSend = message + ";" + timestamp;

            //Console.WriteLine("PUBLISH ALARM: " + topic);

            m_cClient.Publish(topic, Encoding.UTF8.GetBytes(messageToSend));
        }
    }
}
