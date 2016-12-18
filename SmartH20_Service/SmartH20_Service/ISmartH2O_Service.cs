using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace SmartH20_Service
{
    [ServiceContract]
    public interface ISmartH2O_Service
    {

        [OperationContract]
        void writeParams(string dados);

        [OperationContract]
        void writeAlarms(string dados);

        [OperationContract]
        string getHourlySummarizedInformation(string parameter, string date);

        [OperationContract]
        string getDailySummarizedInformation(string parameter, DateTime StartDate, DateTime EndDate);

        [OperationContract]
        string getWeeklySummarizedInformation(string parameter, DateTime date);

        [OperationContract]
        string getDailyAlarmsInformation(string parameter, DateTime date);

        [OperationContract]
        string getAlarmsInformation(string parameter, DateTime StartDate, DateTime EndDate);

    }



   
}
