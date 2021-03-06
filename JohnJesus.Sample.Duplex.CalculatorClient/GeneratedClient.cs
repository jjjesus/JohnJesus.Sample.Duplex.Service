﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JohnJesus.Sample.Duplex.CalculatorClient
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://JohnJesus.Sample.Duplex", ConfigurationName="JohnJesus.Sample.Duplex.CalculatorClient.ICalculatorDuplex", CallbackContract=typeof(JohnJesus.Sample.Duplex.CalculatorClient.ICalculatorDuplexCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface ICalculatorDuplex
    {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://JohnJesus.Sample.Duplex/ICalculatorDuplex/Clear")]
        void Clear();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://JohnJesus.Sample.Duplex/ICalculatorDuplex/AddTo")]
        void AddTo(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://JohnJesus.Sample.Duplex/ICalculatorDuplex/SubtractFrom")]
        void SubtractFrom(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://JohnJesus.Sample.Duplex/ICalculatorDuplex/MultiplyBy")]
        void MultiplyBy(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://JohnJesus.Sample.Duplex/ICalculatorDuplex/DivideBy")]
        void DivideBy(double n);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorDuplexCallback
    {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://JohnJesus.Sample.Duplex/ICalculatorDuplex/Result")]
        void Result([System.ServiceModel.MessageParameterAttribute(Name="result")] double result1);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://JohnJesus.Sample.Duplex/ICalculatorDuplex/Equation")]
        void Equation(string eqn);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorDuplexChannel : JohnJesus.Sample.Duplex.CalculatorClient.ICalculatorDuplex, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorDuplexClient : System.ServiceModel.DuplexClientBase<JohnJesus.Sample.Duplex.CalculatorClient.ICalculatorDuplex>, JohnJesus.Sample.Duplex.CalculatorClient.ICalculatorDuplex
    {
        
        public CalculatorDuplexClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance)
        {
        }
        
        public CalculatorDuplexClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName)
        {
        }
        
        public CalculatorDuplexClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress)
        {
        }
        
        public CalculatorDuplexClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress)
        {
        }
        
        public CalculatorDuplexClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress)
        {
        }
        
        public void Clear()
        {
            base.Channel.Clear();
        }
        
        public void AddTo(double n)
        {
            base.Channel.AddTo(n);
        }
        
        public void SubtractFrom(double n)
        {
            base.Channel.SubtractFrom(n);
        }
        
        public void MultiplyBy(double n)
        {
            base.Channel.MultiplyBy(n);
        }
        
        public void DivideBy(double n)
        {
            base.Channel.DivideBy(n);
        }
    }
}
