﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinForm.TonKhoServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TonKho", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class TonKho : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SP_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SoLuongTonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenSPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ThoiGianField;
        
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
        public int SoLuongTon {
            get {
                return this.SoLuongTonField;
            }
            set {
                if ((this.SoLuongTonField.Equals(value) != true)) {
                    this.SoLuongTonField = value;
                    this.RaisePropertyChanged("SoLuongTon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenSP {
            get {
                return this.TenSPField;
            }
            set {
                if ((object.ReferenceEquals(this.TenSPField, value) != true)) {
                    this.TenSPField = value;
                    this.RaisePropertyChanged("TenSP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ThoiGian {
            get {
                return this.ThoiGianField;
            }
            set {
                if ((this.ThoiGianField.Equals(value) != true)) {
                    this.ThoiGianField = value;
                    this.RaisePropertyChanged("ThoiGian");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TonKhoServiceReference.ITonKhoService1")]
    public interface ITonKhoService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService1/SoLuongTonKho_SPID", ReplyAction="http://tempuri.org/ITonKhoService1/SoLuongTonKho_SPIDResponse")]
        int SoLuongTonKho_SPID(int spid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService1/SoLuongTonKho_SPID", ReplyAction="http://tempuri.org/ITonKhoService1/SoLuongTonKho_SPIDResponse")]
        System.Threading.Tasks.Task<int> SoLuongTonKho_SPIDAsync(int spid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService1/HienThiTonKho", ReplyAction="http://tempuri.org/ITonKhoService1/HienThiTonKhoResponse")]
        WinForm.TonKhoServiceReference.TonKho[] HienThiTonKho();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService1/HienThiTonKho", ReplyAction="http://tempuri.org/ITonKhoService1/HienThiTonKhoResponse")]
        System.Threading.Tasks.Task<WinForm.TonKhoServiceReference.TonKho[]> HienThiTonKhoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService1/TimKiemTonKho_SPID", ReplyAction="http://tempuri.org/ITonKhoService1/TimKiemTonKho_SPIDResponse")]
        WinForm.TonKhoServiceReference.TonKho[] TimKiemTonKho_SPID(WinForm.TonKhoServiceReference.TonKho tk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService1/TimKiemTonKho_SPID", ReplyAction="http://tempuri.org/ITonKhoService1/TimKiemTonKho_SPIDResponse")]
        System.Threading.Tasks.Task<WinForm.TonKhoServiceReference.TonKho[]> TimKiemTonKho_SPIDAsync(WinForm.TonKhoServiceReference.TonKho tk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService1/TimKiemTonKhoTheoTG", ReplyAction="http://tempuri.org/ITonKhoService1/TimKiemTonKhoTheoTGResponse")]
        WinForm.TonKhoServiceReference.TonKho[] TimKiemTonKhoTheoTG(int thang, int nam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService1/TimKiemTonKhoTheoTG", ReplyAction="http://tempuri.org/ITonKhoService1/TimKiemTonKhoTheoTGResponse")]
        System.Threading.Tasks.Task<WinForm.TonKhoServiceReference.TonKho[]> TimKiemTonKhoTheoTGAsync(int thang, int nam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService1/TimKiemTonKhoTheoKhoangTG", ReplyAction="http://tempuri.org/ITonKhoService1/TimKiemTonKhoTheoKhoangTGResponse")]
        WinForm.TonKhoServiceReference.TonKho[] TimKiemTonKhoTheoKhoangTG(System.DateTime ngaytu, System.DateTime ngayden);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService1/TimKiemTonKhoTheoKhoangTG", ReplyAction="http://tempuri.org/ITonKhoService1/TimKiemTonKhoTheoKhoangTGResponse")]
        System.Threading.Tasks.Task<WinForm.TonKhoServiceReference.TonKho[]> TimKiemTonKhoTheoKhoangTGAsync(System.DateTime ngaytu, System.DateTime ngayden);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService1/TimKiemTonKhoTheoSoLuong", ReplyAction="http://tempuri.org/ITonKhoService1/TimKiemTonKhoTheoSoLuongResponse")]
        WinForm.TonKhoServiceReference.TonKho[] TimKiemTonKhoTheoSoLuong(int k);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService1/TimKiemTonKhoTheoSoLuong", ReplyAction="http://tempuri.org/ITonKhoService1/TimKiemTonKhoTheoSoLuongResponse")]
        System.Threading.Tasks.Task<WinForm.TonKhoServiceReference.TonKho[]> TimKiemTonKhoTheoSoLuongAsync(int k);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService1/ThemMoi", ReplyAction="http://tempuri.org/ITonKhoService1/ThemMoiResponse")]
        void ThemMoi(WinForm.TonKhoServiceReference.TonKho tk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService1/ThemMoi", ReplyAction="http://tempuri.org/ITonKhoService1/ThemMoiResponse")]
        System.Threading.Tasks.Task ThemMoiAsync(WinForm.TonKhoServiceReference.TonKho tk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService1/NhapKho", ReplyAction="http://tempuri.org/ITonKhoService1/NhapKhoResponse")]
        void NhapKho(WinForm.TonKhoServiceReference.TonKho tk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService1/NhapKho", ReplyAction="http://tempuri.org/ITonKhoService1/NhapKhoResponse")]
        System.Threading.Tasks.Task NhapKhoAsync(WinForm.TonKhoServiceReference.TonKho tk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService1/XuatKho", ReplyAction="http://tempuri.org/ITonKhoService1/XuatKhoResponse")]
        void XuatKho(WinForm.TonKhoServiceReference.TonKho tk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService1/XuatKho", ReplyAction="http://tempuri.org/ITonKhoService1/XuatKhoResponse")]
        System.Threading.Tasks.Task XuatKhoAsync(WinForm.TonKhoServiceReference.TonKho tk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService1/XoaTonKho", ReplyAction="http://tempuri.org/ITonKhoService1/XoaTonKhoResponse")]
        void XoaTonKho(WinForm.TonKhoServiceReference.TonKho tk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService1/XoaTonKho", ReplyAction="http://tempuri.org/ITonKhoService1/XoaTonKhoResponse")]
        System.Threading.Tasks.Task XoaTonKhoAsync(WinForm.TonKhoServiceReference.TonKho tk);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITonKhoService1Channel : WinForm.TonKhoServiceReference.ITonKhoService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TonKhoService1Client : System.ServiceModel.ClientBase<WinForm.TonKhoServiceReference.ITonKhoService1>, WinForm.TonKhoServiceReference.ITonKhoService1 {
        
        public TonKhoService1Client() {
        }
        
        public TonKhoService1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TonKhoService1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TonKhoService1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TonKhoService1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int SoLuongTonKho_SPID(int spid) {
            return base.Channel.SoLuongTonKho_SPID(spid);
        }
        
        public System.Threading.Tasks.Task<int> SoLuongTonKho_SPIDAsync(int spid) {
            return base.Channel.SoLuongTonKho_SPIDAsync(spid);
        }
        
        public WinForm.TonKhoServiceReference.TonKho[] HienThiTonKho() {
            return base.Channel.HienThiTonKho();
        }
        
        public System.Threading.Tasks.Task<WinForm.TonKhoServiceReference.TonKho[]> HienThiTonKhoAsync() {
            return base.Channel.HienThiTonKhoAsync();
        }
        
        public WinForm.TonKhoServiceReference.TonKho[] TimKiemTonKho_SPID(WinForm.TonKhoServiceReference.TonKho tk) {
            return base.Channel.TimKiemTonKho_SPID(tk);
        }
        
        public System.Threading.Tasks.Task<WinForm.TonKhoServiceReference.TonKho[]> TimKiemTonKho_SPIDAsync(WinForm.TonKhoServiceReference.TonKho tk) {
            return base.Channel.TimKiemTonKho_SPIDAsync(tk);
        }
        
        public WinForm.TonKhoServiceReference.TonKho[] TimKiemTonKhoTheoTG(int thang, int nam) {
            return base.Channel.TimKiemTonKhoTheoTG(thang, nam);
        }
        
        public System.Threading.Tasks.Task<WinForm.TonKhoServiceReference.TonKho[]> TimKiemTonKhoTheoTGAsync(int thang, int nam) {
            return base.Channel.TimKiemTonKhoTheoTGAsync(thang, nam);
        }
        
        public WinForm.TonKhoServiceReference.TonKho[] TimKiemTonKhoTheoKhoangTG(System.DateTime ngaytu, System.DateTime ngayden) {
            return base.Channel.TimKiemTonKhoTheoKhoangTG(ngaytu, ngayden);
        }
        
        public System.Threading.Tasks.Task<WinForm.TonKhoServiceReference.TonKho[]> TimKiemTonKhoTheoKhoangTGAsync(System.DateTime ngaytu, System.DateTime ngayden) {
            return base.Channel.TimKiemTonKhoTheoKhoangTGAsync(ngaytu, ngayden);
        }
        
        public WinForm.TonKhoServiceReference.TonKho[] TimKiemTonKhoTheoSoLuong(int k) {
            return base.Channel.TimKiemTonKhoTheoSoLuong(k);
        }
        
        public System.Threading.Tasks.Task<WinForm.TonKhoServiceReference.TonKho[]> TimKiemTonKhoTheoSoLuongAsync(int k) {
            return base.Channel.TimKiemTonKhoTheoSoLuongAsync(k);
        }
        
        public void ThemMoi(WinForm.TonKhoServiceReference.TonKho tk) {
            base.Channel.ThemMoi(tk);
        }
        
        public System.Threading.Tasks.Task ThemMoiAsync(WinForm.TonKhoServiceReference.TonKho tk) {
            return base.Channel.ThemMoiAsync(tk);
        }
        
        public void NhapKho(WinForm.TonKhoServiceReference.TonKho tk) {
            base.Channel.NhapKho(tk);
        }
        
        public System.Threading.Tasks.Task NhapKhoAsync(WinForm.TonKhoServiceReference.TonKho tk) {
            return base.Channel.NhapKhoAsync(tk);
        }
        
        public void XuatKho(WinForm.TonKhoServiceReference.TonKho tk) {
            base.Channel.XuatKho(tk);
        }
        
        public System.Threading.Tasks.Task XuatKhoAsync(WinForm.TonKhoServiceReference.TonKho tk) {
            return base.Channel.XuatKhoAsync(tk);
        }
        
        public void XoaTonKho(WinForm.TonKhoServiceReference.TonKho tk) {
            base.Channel.XoaTonKho(tk);
        }
        
        public System.Threading.Tasks.Task XoaTonKhoAsync(WinForm.TonKhoServiceReference.TonKho tk) {
            return base.Channel.XoaTonKhoAsync(tk);
        }
    }
}
