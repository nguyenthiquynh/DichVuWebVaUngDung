﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinForm.SanPhamServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SanPham", Namespace="http://schemas.datacontract.org/2004/07/WcfUngDungWeb")]
    [System.SerializableAttribute()]
    public partial class SanPham : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BaoHanhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CPUField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float DonGiaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HDDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HinhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MoTaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NhaSX_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RAMField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SP_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenSPField;
        
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
        public string BaoHanh {
            get {
                return this.BaoHanhField;
            }
            set {
                if ((object.ReferenceEquals(this.BaoHanhField, value) != true)) {
                    this.BaoHanhField = value;
                    this.RaisePropertyChanged("BaoHanh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CPU {
            get {
                return this.CPUField;
            }
            set {
                if ((object.ReferenceEquals(this.CPUField, value) != true)) {
                    this.CPUField = value;
                    this.RaisePropertyChanged("CPU");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float DonGia {
            get {
                return this.DonGiaField;
            }
            set {
                if ((this.DonGiaField.Equals(value) != true)) {
                    this.DonGiaField = value;
                    this.RaisePropertyChanged("DonGia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HDD {
            get {
                return this.HDDField;
            }
            set {
                if ((object.ReferenceEquals(this.HDDField, value) != true)) {
                    this.HDDField = value;
                    this.RaisePropertyChanged("HDD");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Hinh {
            get {
                return this.HinhField;
            }
            set {
                if ((object.ReferenceEquals(this.HinhField, value) != true)) {
                    this.HinhField = value;
                    this.RaisePropertyChanged("Hinh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MoTa {
            get {
                return this.MoTaField;
            }
            set {
                if ((object.ReferenceEquals(this.MoTaField, value) != true)) {
                    this.MoTaField = value;
                    this.RaisePropertyChanged("MoTa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NhaSX_ID {
            get {
                return this.NhaSX_IDField;
            }
            set {
                if ((this.NhaSX_IDField.Equals(value) != true)) {
                    this.NhaSX_IDField = value;
                    this.RaisePropertyChanged("NhaSX_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RAM {
            get {
                return this.RAMField;
            }
            set {
                if ((object.ReferenceEquals(this.RAMField, value) != true)) {
                    this.RAMField = value;
                    this.RaisePropertyChanged("RAM");
                }
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SanPhamServiceReference.ISanPhamService1")]
    public interface ISanPhamService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISanPhamService1/HienThiSanPhamFull", ReplyAction="http://tempuri.org/ISanPhamService1/HienThiSanPhamFullResponse")]
        WinForm.SanPhamServiceReference.SanPham[] HienThiSanPhamFull();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISanPhamService1/HienThiSanPhamFull", ReplyAction="http://tempuri.org/ISanPhamService1/HienThiSanPhamFullResponse")]
        System.Threading.Tasks.Task<WinForm.SanPhamServiceReference.SanPham[]> HienThiSanPhamFullAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISanPhamService1/HienThiSPMoi", ReplyAction="http://tempuri.org/ISanPhamService1/HienThiSPMoiResponse")]
        WinForm.SanPhamServiceReference.SanPham[] HienThiSPMoi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISanPhamService1/HienThiSPMoi", ReplyAction="http://tempuri.org/ISanPhamService1/HienThiSPMoiResponse")]
        System.Threading.Tasks.Task<WinForm.SanPhamServiceReference.SanPham[]> HienThiSPMoiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISanPhamService1/HienThiSanPhamCungLoai", ReplyAction="http://tempuri.org/ISanPhamService1/HienThiSanPhamCungLoaiResponse")]
        WinForm.SanPhamServiceReference.SanPham[] HienThiSanPhamCungLoai(WinForm.SanPhamServiceReference.SanPham sp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISanPhamService1/HienThiSanPhamCungLoai", ReplyAction="http://tempuri.org/ISanPhamService1/HienThiSanPhamCungLoaiResponse")]
        System.Threading.Tasks.Task<WinForm.SanPhamServiceReference.SanPham[]> HienThiSanPhamCungLoaiAsync(WinForm.SanPhamServiceReference.SanPham sp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISanPhamService1/HienThiSanPhamNhaSX", ReplyAction="http://tempuri.org/ISanPhamService1/HienThiSanPhamNhaSXResponse")]
        WinForm.SanPhamServiceReference.SanPham[] HienThiSanPhamNhaSX(WinForm.SanPhamServiceReference.SanPham sp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISanPhamService1/HienThiSanPhamNhaSX", ReplyAction="http://tempuri.org/ISanPhamService1/HienThiSanPhamNhaSXResponse")]
        System.Threading.Tasks.Task<WinForm.SanPhamServiceReference.SanPham[]> HienThiSanPhamNhaSXAsync(WinForm.SanPhamServiceReference.SanPham sp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISanPhamService1/TimKiemSanPham", ReplyAction="http://tempuri.org/ISanPhamService1/TimKiemSanPhamResponse")]
        WinForm.SanPhamServiceReference.SanPham[] TimKiemSanPham(string tensp, int nhasxid, decimal dongiatu, decimal dongiaden);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISanPhamService1/TimKiemSanPham", ReplyAction="http://tempuri.org/ISanPhamService1/TimKiemSanPhamResponse")]
        System.Threading.Tasks.Task<WinForm.SanPhamServiceReference.SanPham[]> TimKiemSanPhamAsync(string tensp, int nhasxid, decimal dongiatu, decimal dongiaden);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISanPhamService1/ChiTietSanPham", ReplyAction="http://tempuri.org/ISanPhamService1/ChiTietSanPhamResponse")]
        System.Data.DataSet ChiTietSanPham(WinForm.SanPhamServiceReference.SanPham sp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISanPhamService1/ChiTietSanPham", ReplyAction="http://tempuri.org/ISanPhamService1/ChiTietSanPhamResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ChiTietSanPhamAsync(WinForm.SanPhamServiceReference.SanPham sp);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISanPhamService1Channel : WinForm.SanPhamServiceReference.ISanPhamService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SanPhamService1Client : System.ServiceModel.ClientBase<WinForm.SanPhamServiceReference.ISanPhamService1>, WinForm.SanPhamServiceReference.ISanPhamService1 {
        
        public SanPhamService1Client() {
        }
        
        public SanPhamService1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SanPhamService1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SanPhamService1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SanPhamService1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WinForm.SanPhamServiceReference.SanPham[] HienThiSanPhamFull() {
            return base.Channel.HienThiSanPhamFull();
        }
        
        public System.Threading.Tasks.Task<WinForm.SanPhamServiceReference.SanPham[]> HienThiSanPhamFullAsync() {
            return base.Channel.HienThiSanPhamFullAsync();
        }
        
        public WinForm.SanPhamServiceReference.SanPham[] HienThiSPMoi() {
            return base.Channel.HienThiSPMoi();
        }
        
        public System.Threading.Tasks.Task<WinForm.SanPhamServiceReference.SanPham[]> HienThiSPMoiAsync() {
            return base.Channel.HienThiSPMoiAsync();
        }
        
        public WinForm.SanPhamServiceReference.SanPham[] HienThiSanPhamCungLoai(WinForm.SanPhamServiceReference.SanPham sp) {
            return base.Channel.HienThiSanPhamCungLoai(sp);
        }
        
        public System.Threading.Tasks.Task<WinForm.SanPhamServiceReference.SanPham[]> HienThiSanPhamCungLoaiAsync(WinForm.SanPhamServiceReference.SanPham sp) {
            return base.Channel.HienThiSanPhamCungLoaiAsync(sp);
        }
        
        public WinForm.SanPhamServiceReference.SanPham[] HienThiSanPhamNhaSX(WinForm.SanPhamServiceReference.SanPham sp) {
            return base.Channel.HienThiSanPhamNhaSX(sp);
        }
        
        public System.Threading.Tasks.Task<WinForm.SanPhamServiceReference.SanPham[]> HienThiSanPhamNhaSXAsync(WinForm.SanPhamServiceReference.SanPham sp) {
            return base.Channel.HienThiSanPhamNhaSXAsync(sp);
        }
        
        public WinForm.SanPhamServiceReference.SanPham[] TimKiemSanPham(string tensp, int nhasxid, decimal dongiatu, decimal dongiaden) {
            return base.Channel.TimKiemSanPham(tensp, nhasxid, dongiatu, dongiaden);
        }
        
        public System.Threading.Tasks.Task<WinForm.SanPhamServiceReference.SanPham[]> TimKiemSanPhamAsync(string tensp, int nhasxid, decimal dongiatu, decimal dongiaden) {
            return base.Channel.TimKiemSanPhamAsync(tensp, nhasxid, dongiatu, dongiaden);
        }
        
        public System.Data.DataSet ChiTietSanPham(WinForm.SanPhamServiceReference.SanPham sp) {
            return base.Channel.ChiTietSanPham(sp);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ChiTietSanPhamAsync(WinForm.SanPhamServiceReference.SanPham sp) {
            return base.Channel.ChiTietSanPhamAsync(sp);
        }
    }
}
