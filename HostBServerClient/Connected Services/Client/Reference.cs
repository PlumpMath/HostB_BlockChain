﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HostBServerClient.Client {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuditProofDetails", Namespace="http://schemas.datacontract.org/2004/07/HostA")]
    [System.SerializableAttribute()]
    public partial class AuditProofDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DirectionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] HashField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direction {
            get {
                return this.DirectionField;
            }
            set {
                if ((object.ReferenceEquals(this.DirectionField, value) != true)) {
                    this.DirectionField = value;
                    this.RaisePropertyChanged("Direction");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Hash {
            get {
                return this.HashField;
            }
            set {
                if ((object.ReferenceEquals(this.HashField, value) != true)) {
                    this.HashField = value;
                    this.RaisePropertyChanged("Hash");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Client.IHostAServices")]
    public interface IHostAServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHostAServices/CreateTreeNode", ReplyAction="http://tempuri.org/IHostAServices/CreateTreeNodeResponse")]
        byte[] CreateTreeNode(string nodeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHostAServices/CreateTreeNode", ReplyAction="http://tempuri.org/IHostAServices/CreateTreeNodeResponse")]
        System.Threading.Tasks.Task<byte[]> CreateTreeNodeAsync(string nodeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHostAServices/CheckAuditProof", ReplyAction="http://tempuri.org/IHostAServices/CheckAuditProofResponse")]
        HostBServerClient.Client.AuditProofDetails[] CheckAuditProof(string toProof);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHostAServices/CheckAuditProof", ReplyAction="http://tempuri.org/IHostAServices/CheckAuditProofResponse")]
        System.Threading.Tasks.Task<HostBServerClient.Client.AuditProofDetails[]> CheckAuditProofAsync(string toProof);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHostAServicesChannel : HostBServerClient.Client.IHostAServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HostAServicesClient : System.ServiceModel.ClientBase<HostBServerClient.Client.IHostAServices>, HostBServerClient.Client.IHostAServices {
        
        public HostAServicesClient() {
        }
        
        public HostAServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HostAServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HostAServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HostAServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public byte[] CreateTreeNode(string nodeName) {
            return base.Channel.CreateTreeNode(nodeName);
        }
        
        public System.Threading.Tasks.Task<byte[]> CreateTreeNodeAsync(string nodeName) {
            return base.Channel.CreateTreeNodeAsync(nodeName);
        }
        
        public HostBServerClient.Client.AuditProofDetails[] CheckAuditProof(string toProof) {
            return base.Channel.CheckAuditProof(toProof);
        }
        
        public System.Threading.Tasks.Task<HostBServerClient.Client.AuditProofDetails[]> CheckAuditProofAsync(string toProof) {
            return base.Channel.CheckAuditProofAsync(toProof);
        }
    }
}
