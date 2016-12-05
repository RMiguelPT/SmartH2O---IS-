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
using System.Xml.Schema;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        bool isValid = true;
        string strValidateMessage = "";

        public Form1()
        {
            InitializeComponent();
            listBoxParam.Enabled = false;

            listBoxParam.Items.Add("PH");
            listBoxParam.Items.Add("NH3");
            listBoxParam.Items.Add("CI2");
            listBoxParam.Items.Add("TODOS");
        }

     


        public void ValidateXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Bookstore.xml");

            doc.Schemas.Add(null, "Bookstore.xsd");

            ValidationEventHandler handler = new ValidationEventHandler(ValidationMethod);
            doc.Validate(handler);

            if (isValid)
            {
                MessageBox.Show("OK!" + strValidateMessage);
            }
            else
            {
                MessageBox.Show("Invalid" + strValidateMessage);
            }
        }

        private void ValidationMethod(object sender, ValidationEventArgs e)
        {
            isValid = false;
            switch (e.Severity)
            {
                case XmlSeverityType.Error: strValidateMessage = "Error: " + e.Message;
                    break;
                case XmlSeverityType.Warning: strValidateMessage = "Warning" + e.Message;
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ValidateXML();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listSid.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();



            string teste = textBox1.Text;
            bool check1 = Alarms.Checked;
            bool check2 = Param.Checked;


            XmlDocument doc = new XmlDocument();

            if (Alarms.Checked) {


                doc.Load("alarm-data.xml");
                XmlNodeList list = doc.SelectNodes("/ALARM-DATA/ALARM");

                foreach (XmlNode n in list)
                {
                    foreach (XmlNode c in n.ChildNodes)
                    {
                        listBox1.Items.Add(c.Name);
                        listBox3.Items.Add(c.ChildNodes[0].InnerText);
                        listBox4.Items.Add(c.ChildNodes[1].InnerText);
                        listBox5.Items.Add(c.ChildNodes[2].InnerText);
                    }


                }


            }
            else if (Param.Checked)
            {

                doc.Load("param-data.xml");
                string listval = listBoxParam.SelectedItem.ToString();


                if(listval != "TODOS")
                {
                    XmlNodeList list = doc.SelectNodes("/PARAM-DATA/PARAM/" + listval);

                  
                    foreach (XmlNode c in list)
                    {


                        listBox1.Items.Add(c.Name);
                        listSid.Items.Add(c.ChildNodes[0].InnerText);
                        listBox3.Items.Add(c.ChildNodes[1].InnerText);
                        listBox4.Items.Add(c.ChildNodes[2].InnerText);
                        listBox5.Items.Add(c.ChildNodes[3].InnerText);





                    }




                }
                else
                {
                    XmlNodeList list = doc.SelectNodes("/PARAM-DATA/PARAM");

                     foreach (XmlNode n in list)
                     {

                        foreach (XmlNode c in n.ChildNodes)
                        {
                            listBox1.Items.Add(c.Name);
                            listSid.Items.Add(c.ChildNodes[0].InnerText);
                            listBox3.Items.Add(c.ChildNodes[1].InnerText);
                            listBox4.Items.Add(c.ChildNodes[2].InnerText);
                            listBox5.Items.Add(c.ChildNodes[3].InnerText);
                        }

                    }


                }





            }
        }


        private void writeParam(string xmlData) {

            

            XmlDocument doc = new XmlDocument();
            XmlDocument strData = new XmlDocument();

            string[] elementData = xmlData.Split(';'); 
            
            doc.Load("param-data.xml");

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

            doc.Save("param-data.xml");

      }

        private void writeAlarm(string xmlData)
        {



            XmlDocument doc = new XmlDocument();
            XmlDocument strData = new XmlDocument();

            string[] elementData = xmlData.Split(';');

            doc.Load("alarm-data.xml");

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

            doc.Save("alarm-data.xml");

        }






        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

        private void label1_Click(object sender, EventArgs e)
        {

        }

  

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }


        public int countCategory(string cat)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("bookstore.xml");
            XmlNodeList books = doc.SelectNodes("/bookstore/book[@category='" + cat + "']");

            MessageBox.Show(books.Count.ToString()+" " + cat);

            return books.Count;
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            listBoxParam.Enabled = false;
            labelSid.Enabled = false;
            listSid.Enabled = false;
        }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBoxParam.Enabled = true;
            listBoxParam.SelectedIndex = 0;
            labelSid.Enabled = true;
            listSid.Enabled = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rateTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeParam(paramTxt.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            writeAlarm(alarmTxt.Text);
        }
    }


}
