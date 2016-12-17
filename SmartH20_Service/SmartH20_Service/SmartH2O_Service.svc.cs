using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using System.Xml;

namespace SmartH20_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class SmartH2O_Service : ISmartH2O_Service
    {


        private string xmlDocPath = AppDomain.CurrentDomain.BaseDirectory.ToString() + "App_Data/param-data.xml";

        public void writeParams(string dados)
        {
            XmlDocument doc = new XmlDocument();
            XmlDocument strData = new XmlDocument();

            string[] elementData = dados.Split(';');

            string filepath = AppDomain.CurrentDomain.BaseDirectory.ToString() + "App_Data/param-data.xml";

            if (!File.Exists(filepath))
            {
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
                doc.AppendChild(dec);
                XmlElement root = doc.CreateElement("PARAM-DATA");
                doc.AppendChild(root);

                doc.Save(filepath);
            }
            else
            {


                doc.Load(filepath);
            }




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

            doc.Save(filepath);
        }

        public void writeAlarms(string dados)
        {
            XmlDocument doc = new XmlDocument();
            XmlDocument strData = new XmlDocument();

            string[] elementData = dados.Split(';');

            string filepath = AppDomain.CurrentDomain.BaseDirectory.ToString() + "App_Data/alarm-data.xml";

            if (!File.Exists(filepath))
            {
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
                doc.AppendChild(dec);
                XmlElement root = doc.CreateElement("ALARM-DATA");
                doc.AppendChild(root);

                doc.Save(filepath);
            }
            else
            {


                doc.Load(filepath);
            }

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

            doc.Save(filepath);
        }

        public string getHourlySummarizedInformation(string parameter, DateTime date)
        {
            XmlDocument doc = readDocument(xmlDocPath);
            XmlDocument docAux = new XmlDocument();

            if (doc != null)
            {
                parameter = parameter.ToUpper();
                XmlNodeList nodeList = doc.SelectNodes("/PARAM-DATA/PARAM/" + parameter);



                XmlDeclaration dec = docAux.CreateXmlDeclaration("1.0", null, null);
                docAux.AppendChild(dec);
                XmlElement root = docAux.CreateElement("PARAM-DATA");
                docAux.AppendChild(root);

                foreach (XmlNode node in nodeList)
                {


                    if (DateTime.Parse(node.SelectSingleNode("DATE").InnerText).Date.Equals(date.Date))
                    {

                        XmlElement p = docAux.CreateElement("PARAM");
                        XmlElement pname = docAux.CreateElement(parameter.ToUpper());
                        XmlElement sid = docAux.CreateElement("SENSOR-ID");
                        sid.InnerText = node.SelectSingleNode("SENSOR-ID").InnerText;
                        XmlElement sval = docAux.CreateElement("SENSOR-VALUE");
                        sval.InnerText = node.SelectSingleNode("SENSOR-VALUE").InnerText;
                        XmlElement h = docAux.CreateElement("HOUR");
                        h.InnerText = node.SelectSingleNode("HOUR").InnerText;

                        pname.AppendChild(sid);
                        pname.AppendChild(sval);
                        pname.AppendChild(h);

                        p.AppendChild(pname);

                        root.AppendChild(p);
                    }

                }
                //docAux.Save(AppDomain.CurrentDomain.BaseDirectory.ToString() + "App_Data/teste.xml");
                return docAux.OuterXml;

            }
            else return null;
        }

        public string getDailySummarizedInformation(string parameter, DateTime StartDate, DateTime EndDate)
        {
            return null;
        }

        public string getWeeklySummarizedInformation(string parameter, DateTime date)
        {
            return null;
        }

        public string getDailyAlarmsInformation(string parameter, DateTime date)
        {
            return null;
        }

        public string getAlarmsInformation(string parameter, DateTime StartDate, DateTime EndDate)
        {
            return null;
        }


        private XmlDocument readDocument(string xmlDocumentPath)
        {
            if (File.Exists(xmlDocPath))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlDocPath);
                return doc;
            }
            else
            {
                return null;
            }
        }

    }
}
