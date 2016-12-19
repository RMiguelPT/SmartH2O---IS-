﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.ServiceData {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceData.ISmartH2O_Service")]
    public interface ISmartH2O_Service {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartH2O_Service/writeParams", ReplyAction="http://tempuri.org/ISmartH2O_Service/writeParamsResponse")]
        void writeParams(string dados);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartH2O_Service/writeParams", ReplyAction="http://tempuri.org/ISmartH2O_Service/writeParamsResponse")]
        System.Threading.Tasks.Task writeParamsAsync(string dados);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartH2O_Service/writeAlarms", ReplyAction="http://tempuri.org/ISmartH2O_Service/writeAlarmsResponse")]
        void writeAlarms(string dados);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartH2O_Service/writeAlarms", ReplyAction="http://tempuri.org/ISmartH2O_Service/writeAlarmsResponse")]
        System.Threading.Tasks.Task writeAlarmsAsync(string dados);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartH2O_Service/getHourlySummarizedInformation", ReplyAction="http://tempuri.org/ISmartH2O_Service/getHourlySummarizedInformationResponse")]
        string getHourlySummarizedInformation(string parameter, string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartH2O_Service/getHourlySummarizedInformation", ReplyAction="http://tempuri.org/ISmartH2O_Service/getHourlySummarizedInformationResponse")]
        System.Threading.Tasks.Task<string> getHourlySummarizedInformationAsync(string parameter, string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartH2O_Service/getDailySummarizedInformation", ReplyAction="http://tempuri.org/ISmartH2O_Service/getDailySummarizedInformationResponse")]
        string getDailySummarizedInformation(string parameter, string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartH2O_Service/getDailySummarizedInformation", ReplyAction="http://tempuri.org/ISmartH2O_Service/getDailySummarizedInformationResponse")]
        System.Threading.Tasks.Task<string> getDailySummarizedInformationAsync(string parameter, string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartH2O_Service/getPeriodSummarizedInformation", ReplyAction="http://tempuri.org/ISmartH2O_Service/getPeriodSummarizedInformationResponse")]
        string getPeriodSummarizedInformation(string parameter, string StartDate, string EndDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartH2O_Service/getPeriodSummarizedInformation", ReplyAction="http://tempuri.org/ISmartH2O_Service/getPeriodSummarizedInformationResponse")]
        System.Threading.Tasks.Task<string> getPeriodSummarizedInformationAsync(string parameter, string StartDate, string EndDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartH2O_Service/getDailyAlarmsInformation", ReplyAction="http://tempuri.org/ISmartH2O_Service/getDailyAlarmsInformationResponse")]
        string getDailyAlarmsInformation(string parameter, string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartH2O_Service/getDailyAlarmsInformation", ReplyAction="http://tempuri.org/ISmartH2O_Service/getDailyAlarmsInformationResponse")]
        System.Threading.Tasks.Task<string> getDailyAlarmsInformationAsync(string parameter, string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartH2O_Service/getAlarmsInformation", ReplyAction="http://tempuri.org/ISmartH2O_Service/getAlarmsInformationResponse")]
        string getAlarmsInformation(string parameter, string StartDate, string EndDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartH2O_Service/getAlarmsInformation", ReplyAction="http://tempuri.org/ISmartH2O_Service/getAlarmsInformationResponse")]
        System.Threading.Tasks.Task<string> getAlarmsInformationAsync(string parameter, string StartDate, string EndDate);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISmartH2O_ServiceChannel : WindowsFormsApplication1.ServiceData.ISmartH2O_Service, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SmartH2O_ServiceClient : System.ServiceModel.ClientBase<WindowsFormsApplication1.ServiceData.ISmartH2O_Service>, WindowsFormsApplication1.ServiceData.ISmartH2O_Service {
        
        public SmartH2O_ServiceClient() {
        }
        
        public SmartH2O_ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SmartH2O_ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SmartH2O_ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SmartH2O_ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void writeParams(string dados) {
            base.Channel.writeParams(dados);
        }
        
        public System.Threading.Tasks.Task writeParamsAsync(string dados) {
            return base.Channel.writeParamsAsync(dados);
        }
        
        public void writeAlarms(string dados) {
            base.Channel.writeAlarms(dados);
        }
        
        public System.Threading.Tasks.Task writeAlarmsAsync(string dados) {
            return base.Channel.writeAlarmsAsync(dados);
        }
        
        public string getHourlySummarizedInformation(string parameter, string date) {
            return base.Channel.getHourlySummarizedInformation(parameter, date);
        }
        
        public System.Threading.Tasks.Task<string> getHourlySummarizedInformationAsync(string parameter, string date) {
            return base.Channel.getHourlySummarizedInformationAsync(parameter, date);
        }
        
        public string getDailySummarizedInformation(string parameter, string date) {
            return base.Channel.getDailySummarizedInformation(parameter, date);
        }
        
        public System.Threading.Tasks.Task<string> getDailySummarizedInformationAsync(string parameter, string date) {
            return base.Channel.getDailySummarizedInformationAsync(parameter, date);
        }
        
        public string getPeriodSummarizedInformation(string parameter, string StartDate, string EndDate) {
            return base.Channel.getPeriodSummarizedInformation(parameter, StartDate, EndDate);
        }
        
        public System.Threading.Tasks.Task<string> getPeriodSummarizedInformationAsync(string parameter, string StartDate, string EndDate) {
            return base.Channel.getPeriodSummarizedInformationAsync(parameter, StartDate, EndDate);
        }
        
        public string getDailyAlarmsInformation(string parameter, string date) {
            return base.Channel.getDailyAlarmsInformation(parameter, date);
        }
        
        public System.Threading.Tasks.Task<string> getDailyAlarmsInformationAsync(string parameter, string date) {
            return base.Channel.getDailyAlarmsInformationAsync(parameter, date);
        }
        
        public string getAlarmsInformation(string parameter, string StartDate, string EndDate) {
            return base.Channel.getAlarmsInformation(parameter, StartDate, EndDate);
        }
        
        public System.Threading.Tasks.Task<string> getAlarmsInformationAsync(string parameter, string StartDate, string EndDate) {
            return base.Channel.getAlarmsInformationAsync(parameter, StartDate, EndDate);
        }
    }
}
