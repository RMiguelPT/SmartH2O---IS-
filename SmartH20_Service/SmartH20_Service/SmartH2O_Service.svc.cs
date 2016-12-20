using System;
using System.Collections.Generic;
using System.Globalization;
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

        static CultureInfo ptPT = CultureInfo.InvariantCulture;
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

        public string getHourlySummarizedInformation(string parameter, string date)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(AppDomain.CurrentDomain.BaseDirectory.ToString() + "App_Data/param-data.xml");
            XmlDocument docAux = new XmlDocument();

            XmlElement r = docAux.CreateElement("PARAM-DATA");
            docAux.AppendChild(r);
            List<double> vals = new List<double>();
            //List<string> hours = new List<string>();
            int hour = 0;

            if (doc != null)
            {
                parameter = parameter.ToUpper();
                XmlNodeList nodeList = doc.SelectNodes("/PARAM-DATA/PARAM/" + parameter + "[DATE='" + date + "']");

                //XmlElement pname = docAux.CreateElement(parameter.ToUpper());
            while(hour <= 24) {
                    foreach (XmlNode node in nodeList)
                    {
                        string[] words =node.SelectSingleNode("HOUR").InnerText.Split(':');
                        if(words[0] == hour.ToString())
                        {
                            vals.Add(Convert.ToDouble(node.SelectSingleNode("SENSOR-VALUE").InnerText.Replace(".", ",")));
                            //hours.Add(node.SelectSingleNode("HOUR").InnerText);
                        }
                    }
                    if (vals.Count != 0)
                    {
                    XmlElement root = docAux.CreateElement("PARAM");
                    XmlElement h = docAux.CreateElement("HOUR");
                    h.InnerText = hour.ToString();
                    XmlElement min = docAux.CreateElement("MIN");
                    min.InnerText = vals.Min().ToString();
                    XmlElement med = docAux.CreateElement("MED");
                    med.InnerText = vals.Average().ToString();
                    XmlElement max = docAux.CreateElement("MAX");
                    max.InnerText = vals.Max().ToString();

                    root.AppendChild(h);
                    root.AppendChild(min);
                    root.AppendChild(med);
                    root.AppendChild(max);
                    r.AppendChild(root);

                    vals = new List<double>();
                    //hours = new List<string>();

                    }
                    hour++;
              }
                return docAux.OuterXml;
            }
            else return null;
        }

     /*   public string getDailySummarizedInformation(string parameter, string date)
        {
            XmlDocument doc = readDocument(xmlDocPath);
            XmlDocument docAux = new XmlDocument();

            DateTime dateD = DateTime.ParseExact(date, "dd-MM-yyyy", ptPT);

            if (doc != null)
            {
                parameter = parameter.ToUpper();
                XmlNodeList nodeList = doc.SelectNodes("/PARAM-DATA/PARAM/" + parameter + "[DATE=" + dateD + "]");

                //docAux.AppendChild(root);

                foreach (XmlNode node in nodeList)
                {
                    docAux.AppendChild(node);
                }


            }
            return docAux.OuterXml;
        }

    */

        public string getPeriodSummarizedInformation(string parameter, string StartDate, string EndDate)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load(AppDomain.CurrentDomain.BaseDirectory.ToString() + "App_Data/param-data.xml");
            XmlDocument docAux = new XmlDocument();

            XmlElement r = docAux.CreateElement("PARAM-DATA");
            docAux.AppendChild(r);

            DateTime sDate = DateTime.ParseExact(StartDate, "dd-MM-yyyy", ptPT);
            DateTime eDate = DateTime.ParseExact(EndDate, "dd-MM-yyyy", ptPT);
            parameter = parameter.ToUpper();
            List<double> vals = new List<double>();

            while (sDate <= eDate)
            {
                if (doc != null)
                {

                    XmlNodeList nodeList = doc.SelectNodes("/PARAM-DATA/PARAM/" + parameter + "[DATE='" + sDate.Date.ToString("dd-MM-yyyy") + "']");

                    //docAux.AppendChild(root);
                    
                    foreach (XmlNode node in nodeList)
                    {
                        System.Diagnostics.Debug.WriteLine(node.SelectSingleNode("SENSOR-VALUE").InnerText.Replace(".", ","));
                        vals.Add(Convert.ToDouble(node.SelectSingleNode("SENSOR-VALUE").InnerText.Replace(".", ",")));
                    }
                    if (vals.Count != 0)
                    {
                        XmlElement root = docAux.CreateElement("PARAM");
                        XmlElement date = docAux.CreateElement("DATE");
                        date.InnerText = sDate.ToString();
                        XmlElement min = docAux.CreateElement("MIN");
                        min.InnerText = vals.Min().ToString();
                        XmlElement med = docAux.CreateElement("MED");
                        med.InnerText = vals.Average().ToString();
                        XmlElement max = docAux.CreateElement("MAX");
                        max.InnerText = vals.Max().ToString();

                        root.AppendChild(date);
                        root.AppendChild(min);
                        root.AppendChild(med);
                        root.AppendChild(max);
                        r.AppendChild(root);

                        vals = new List<double>();

                    }
                }
                sDate = sDate.AddDays(1);
            }
            return docAux.OuterXml;
        }

        public string getDailyAlarmsInformation(string parameter, string date)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(AppDomain.CurrentDomain.BaseDirectory.ToString() + "App_Data/alarm-data.xml");
            XmlDocument docAux = new XmlDocument();
            XmlElement r = docAux.CreateElement("ALARM-DATA");
            docAux.AppendChild(r);
            //DateTime dateD = DateTime.ParseExact(date, "dd-MM-yyyy", ptPT);

            if (doc != null)
            {

                parameter = parameter.ToUpper();
                XmlNodeList nodeList = doc.SelectNodes("/ALARM-DATA/ALARM/" + parameter + "[DATE = '" + date + "']");
                //XmlNodeList nodeList = doc.SelectNodes("//*");
                // +parameter + "[DATE='" + date + "']"
                foreach (XmlNode node in nodeList)
                {
                    System.Diagnostics.Debug.WriteLine(node.OuterXml + "gregwrgrwgw");
                    XmlElement el = docAux.CreateElement("ALARM");
                    XmlNode n = docAux.ImportNode(node, true);
                    el.AppendChild(n);
                    r.AppendChild(el);

                }
            }

            return docAux.OuterXml;

        }

        public string getAlarmsInformation(string parameter, string StartDate, string EndDate)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(AppDomain.CurrentDomain.BaseDirectory.ToString() + "App_Data/alarm-data.xml");
            XmlDocument docAux = new XmlDocument();
            XmlElement r = docAux.CreateElement("ALARM-DATA");
            docAux.AppendChild(r);

            DateTime sDate = DateTime.ParseExact(StartDate, "dd-MM-yyyy", ptPT);
            DateTime eDate = DateTime.ParseExact(EndDate, "dd-MM-yyyy", ptPT);

            parameter = parameter.ToUpper();
            while (sDate.Date <= eDate.Date)
            {

                if (doc != null)
                {

                    XmlNodeList nodeList = doc.SelectNodes("/ALARM-DATA/ALARM/" + parameter + "[DATE='" + sDate.Date.ToString("dd-MM-yyyy") + "']");
                    System.Diagnostics.Debug.WriteLine(sDate.Date.ToString("dd-MM-yyyy"));
                    //docAux.AppendChild(root);

                    foreach (XmlNode node in nodeList)
                    {
                        System.Diagnostics.Debug.WriteLine(node.OuterXml);
                        XmlElement el = docAux.CreateElement("ALARM");
                        XmlNode n = docAux.ImportNode(node, true);
                        el.AppendChild(n);
                        r.AppendChild(el);
                    }
                    //  System.Diagnostics.Debug.WriteLine(sDate);
                    //sDate = sDate.Date.AddDays(1);
                }
                else
                {
                    return null;
                }
                sDate = sDate.AddDays(1);

            }

            return docAux.OuterXml;
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
