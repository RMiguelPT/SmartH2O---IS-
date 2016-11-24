using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace AlarmSystem
{
    class XmlValidator
    {
        private bool _isValidXML;
        private string _validateMsg = "";

        private string _xmlPath = "";
        private string _xsdPath = "";

        public string ValidateMsg { get { return _validateMsg; } }

        public XmlValidator(string xmlPath, string xsdPath)
        {
            this._xmlPath = xmlPath;
            this._xsdPath = xsdPath;
            this._isValidXML = true;
            Console.WriteLine(_xsdPath);
        }

        public bool validateXMLDocument()
        {
            XmlDocument doc = new XmlDocument();
            _isValidXML = true;

            try
            {
                doc.Load(_xmlPath);

                doc.Schemas.Add(null, _xsdPath);
                ValidationEventHandler eventHandler = new ValidationEventHandler(validateHandler);
                Console.WriteLine(_xsdPath);
                
                doc.Validate(eventHandler);
            }
            catch (XmlException e)
            {
                _isValidXML = false;
                _validateMsg = string.Format("[ERROR]: {0}", e.ToString());
            }

            return _isValidXML;
        }

        private void validateHandler(object sender, ValidationEventArgs args)
        {
            _isValidXML = false;
            switch (args.Severity)
            {
                case XmlSeverityType.Error:
                    _validateMsg += string.Format("[ERROR]: {0}", args.Message);
                    break;
                case XmlSeverityType.Warning:
                    _validateMsg += string.Format("[ERROR]: {0}", args.Message);
                    break;
            }
        }


        public bool isXmlValid()
        {
            return _isValidXML;
        }
    }
}
