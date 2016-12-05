using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;

namespace SmartH2O_DU
{
    class Program
    {
        public static MqttClient m_cClient;
        static void Main(string[] args)
        {

            SensorNodeDll.SensorNodeDll dll = new SensorNodeDll.SensorNodeDll();


            // m_cClient = new MqttClient(IPAddress.Parse("192.168.237.200"));
            m_cClient = new MqttClient(IPAddress.Parse("127.0.0.1"));



            m_cClient.Connect(Guid.NewGuid().ToString());
            if (!m_cClient.IsConnected)
            {
                Console.WriteLine("Error connecting to message broker...");
                return;
            }

            dll.Initialize(recebeDados, 1500);
            
            Console.ReadKey();
            if (m_cClient.IsConnected)
            {
                // m_cClient.Unsubscribe(m_strTopicsInfo);
                m_cClient.Disconnect();


            }
            dll.Stop();

        }
        static public void recebeDados(string str)
        {

            
            string[] words = str.Split(';');
            string topic = words[1];
            string value = words[0]+";"+words[2];
            Console.WriteLine(topic);
            
            //string[] m_strTopicsInfo = { "news", "complaints" };
           
            m_cClient.Publish(topic, Encoding.UTF8.GetBytes(value));
            //;
           

        }
        }
    
}
