﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinForm.CtPhieuNhapServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CtPhieuNhap", Namespace="http://schemas.datacontract.org/2004/07/WcfUngDungWeb")]
    [System.SerializableAttribute()]
    public partial class CtPhieuNhap : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SP_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float dongianhapField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string maphieunhapField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int soluongnhapField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tenspField;
        
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
        public int SP_ID {
            get {
                return this.SP_IDField;
            }
            set {
                if ((this.SP_IDField.Equals(value) != true)) {
                    this.SP_IDField = value;
                    this.RaisePropertyChanged("SP_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float dongianhap {
            get {
                return this.dongianhapField;
            }
            set {
                if ((this.dongianhapField.Equals(value) != true)) {
                    this.dongianhapField = value;
                    this.RaisePropertyChanged("dongianhap");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string maphieunhap {
            get {
                return this.maphieunhapField;
            }
            set {
                if ((object.ReferenceEquals(this.maphieunhapField, value) != true)) {
                    this.maphieunhapField = value;
                    this.RaisePropertyChanged("maphieunhap");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int soluongnhap {
            get {
                return this.soluongnhapField;
            }
            set {
                if ((this.soluongnhapField.Equals(value) != true)) {
                    this.soluongnhapField = value;
                    this.RaisePropertyChanged("soluongnhap");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tensp {
            get {
                return this.tenspField;
            }
            set {
                if ((object.ReferenceEquals(this.tenspField, value) != true)) {
                    this.tenspField = value;
                    this.RaisePropertyChanged("tensp");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CtPhieuNhapServiceReference.ICtPhieuNhapService1")]
    public interface ICtPhieuNhapService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICtPhieuNhapService1/HienThiCtPhieuNhap", ReplyAction="http://tempuri.org/ICtPhieuNhapService1/HienThiCtPhieuNhapResponse")]
        WinForm.CtPhieuNhapServiceReference.CtPhieuNhap[] HienThiCtPhieuNhap(WinForm.CtPhieuNhapServiceReference.CtPhieuNhap ct);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICtPhieuNhapService1/HienThiCtPhieuNhap", ReplyAction="http://tempuri.org/ICtPhieuNhapService1/HienThiCtPhieuNhapResponse")]
        System.Threading.Tasks.Task<WinForm.CtPhieuNhapServiceReference.CtPhieuNhap[]> HienThiCtPhieuNhapAsync(WinForm.CtPhieuNhapServiceReference.CtPhieuNhap ct);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICtPhieuNhapService1/KiemTraMaPhieuNhap", ReplyAction="http://tempuri.org/ICtPhieuNhapService1/KiemTraMaPhieuNhapResponse")]
        bool KiemTraMaPhieuNhap(string ma);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICtPhieuNhapService1/KiemTraMaPhieuNhap", ReplyAction="http://tempuri.org/ICtPhieuNhapService1/KiemTraMaPhieuNhapResponse")]
        System.Threading.Tasks.Task<bool> KiemTraMaPhieuNhapAsync(string ma);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICtPhieuNhapService1/Them", ReplyAction="http://tempuri.org/ICtPhieuNhapService1/ThemResponse")]
        void Them(WinForm.CtPhieuNhapServiceReference.CtPhieuNhap ct);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICtPhieuNhapService1/Them", ReplyAction="http://tempuri.org/ICtPhieuNhapService1/ThemResponse")]
        System.Threading.Tasks.Task ThemAsync(WinForm.CtPhieuNhapServiceReference.CtPhieuNhap ct);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICtPhieuNhapService1Channel : WinForm.CtPhieuNhapServiceReference.ICtPhieuNhapService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CtPhieuNhapService1Client : System.ServiceModel.ClientBase<WinForm.CtPhieuNhapServiceReference.ICtPhieuNhapService1>, WinForm.CtPhieuNhapServiceReference.ICtPhieuNhapService1 {
        
        public CtPhieuNhapService1Client() {
        }
        
        public CtPhieuNhapService1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CtPhieuNhapService1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CtPhieuNhapService1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CtPhieuNhapService1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WinForm.CtPhieuNhapServiceReference.CtPhieuNhap[] HienThiCtPhieuNhap(WinForm.CtPhieuNhapServiceReference.CtPhieuNhap ct) {
            return base.Channel.HienThiCtPhieuNhap(ct);
        }
        
        public System.Threading.Tasks.Task<WinForm.CtPhieuNhapServiceReference.CtPhieuNhap[]> HienThiCtPhieuNhapAsync(WinForm.CtPhieuNhapServiceReference.CtPhieuNhap ct) {
            return base.Channel.HienThiCtPhieuNhapAsync(ct);
        }
        
        public bool KiemTraMaPhieuNhap(string ma) {
            return base.Channel.KiemTraMaPhieuNhap(ma);
        }
        
        public System.Threading.Tasks.Task<bool> KiemTraMaPhieuNhapAsync(string ma) {
            return base.Channel.KiemTraMaPhieuNhapAsync(ma);
        }
        
        public void Them(WinForm.CtPhieuNhapServiceReference.CtPhieuNhap ct) {
            base.Channel.Them(ct);
        }
        
        public System.Threading.Tasks.Task ThemAsync(WinForm.CtPhieuNhapServiceReference.CtPhieuNhap ct) {
            return base.Channel.ThemAsync(ct);
        }
    }
}
