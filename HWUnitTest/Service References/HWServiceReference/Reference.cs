﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HWUnitTest.HWServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HWServiceReference.IHWService")]
    public interface IHWService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHWService/GetMessage", ReplyAction="http://tempuri.org/IHWService/GetMessageResponse")]
        string GetMessage();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHWService/GetMessage", ReplyAction="http://tempuri.org/IHWService/GetMessageResponse")]
        System.Threading.Tasks.Task<string> GetMessageAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHWService/HWDBUpdate", ReplyAction="http://tempuri.org/IHWService/HWDBUpdateResponse")]
        bool HWDBUpdate();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHWService/HWDBUpdate", ReplyAction="http://tempuri.org/IHWService/HWDBUpdateResponse")]
        System.Threading.Tasks.Task<bool> HWDBUpdateAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHWServiceChannel : HWUnitTest.HWServiceReference.IHWService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HWServiceClient : System.ServiceModel.ClientBase<HWUnitTest.HWServiceReference.IHWService>, HWUnitTest.HWServiceReference.IHWService {
        
        public HWServiceClient() {
        }
        
        public HWServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HWServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HWServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HWServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetMessage() {
            return base.Channel.GetMessage();
        }
        
        public System.Threading.Tasks.Task<string> GetMessageAsync() {
            return base.Channel.GetMessageAsync();
        }
        
        public bool HWDBUpdate() {
            return base.Channel.HWDBUpdate();
        }
        
        public System.Threading.Tasks.Task<bool> HWDBUpdateAsync() {
            return base.Channel.HWDBUpdateAsync();
        }
    }
}