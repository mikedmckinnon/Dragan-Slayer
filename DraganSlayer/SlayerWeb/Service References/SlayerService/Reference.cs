﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SlayerWeb.SlayerService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SlayerService.ISlayerService")]
    public interface ISlayerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISlayerService/FireMissle", ReplyAction="http://tempuri.org/ISlayerService/FireMissleResponse")]
        void FireMissle();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISlayerService/FireMissle", ReplyAction="http://tempuri.org/ISlayerService/FireMissleResponse")]
        System.Threading.Tasks.Task FireMissleAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISlayerServiceChannel : SlayerWeb.SlayerService.ISlayerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SlayerServiceClient : System.ServiceModel.ClientBase<SlayerWeb.SlayerService.ISlayerService>, SlayerWeb.SlayerService.ISlayerService {
        
        public SlayerServiceClient() {
        }
        
        public SlayerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SlayerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SlayerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SlayerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void FireMissle() {
            base.Channel.FireMissle();
        }
        
        public System.Threading.Tasks.Task FireMissleAsync() {
            return base.Channel.FireMissleAsync();
        }
    }
}
