﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartH2O_DLog.WriteService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WriteService.ISmartH2O_Service")]
    public interface ISmartH2O_Service {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartH2O_Service/writeParams", ReplyAction="http://tempuri.org/ISmartH2O_Service/writeParamsResponse")]
        void writeParams(string dados);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartH2O_Service/writeParams", ReplyAction="http://tempuri.org/ISmartH2O_Service/writeParamsResponse")]
        System.Threading.Tasks.Task writeParamsAsync(string dados);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartH2O_Service/writeAlarms", ReplyAction="http://tempuri.org/ISmartH2O_Service/writeAlarmsResponse")]
        void writeAlarms(string dados);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISmartH2O_Service/writeAlarms", ReplyAction="http://tempuri.org/ISmartH2O_Service/writeAlarmsResponse")]
        System.Threading.Tasks.Task writeAlarmsAsync(string dados);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISmartH2O_ServiceChannel : SmartH2O_DLog.WriteService.ISmartH2O_Service, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SmartH2O_ServiceClient : System.ServiceModel.ClientBase<SmartH2O_DLog.WriteService.ISmartH2O_Service>, SmartH2O_DLog.WriteService.ISmartH2O_Service {
        
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
    }
}
