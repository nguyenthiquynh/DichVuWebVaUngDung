﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebForm.DonHangService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DonDH", Namespace="http://schemas.datacontract.org/2004/07/WcfUngDungWeb")]
    [System.SerializableAttribute()]
    public partial class DonDH : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DiaChiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DienThoaiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DonDH_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GhiChuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HoTenKHField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_NguoiDungField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaDonDHField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime NgayDatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime NgayGiaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TinhTrangField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float TongTienField;
        
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
        public string DiaChi {
            get {
                return this.DiaChiField;
            }
            set {
                if ((object.ReferenceEquals(this.DiaChiField, value) != true)) {
                    this.DiaChiField = value;
                    this.RaisePropertyChanged("DiaChi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DienThoai {
            get {
                return this.DienThoaiField;
            }
            set {
                if ((object.ReferenceEquals(this.DienThoaiField, value) != true)) {
                    this.DienThoaiField = value;
                    this.RaisePropertyChanged("DienThoai");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DonDH_ID {
            get {
                return this.DonDH_IDField;
            }
            set {
                if ((this.DonDH_IDField.Equals(value) != true)) {
                    this.DonDH_IDField = value;
                    this.RaisePropertyChanged("DonDH_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GhiChu {
            get {
                return this.GhiChuField;
            }
            set {
                if ((object.ReferenceEquals(this.GhiChuField, value) != true)) {
                    this.GhiChuField = value;
                    this.RaisePropertyChanged("GhiChu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HoTenKH {
            get {
                return this.HoTenKHField;
            }
            set {
                if ((object.ReferenceEquals(this.HoTenKHField, value) != true)) {
                    this.HoTenKHField = value;
                    this.RaisePropertyChanged("HoTenKH");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_NguoiDung {
            get {
                return this.ID_NguoiDungField;
            }
            set {
                if ((this.ID_NguoiDungField.Equals(value) != true)) {
                    this.ID_NguoiDungField = value;
                    this.RaisePropertyChanged("ID_NguoiDung");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MaDonDH {
            get {
                return this.MaDonDHField;
            }
            set {
                if ((object.ReferenceEquals(this.MaDonDHField, value) != true)) {
                    this.MaDonDHField = value;
                    this.RaisePropertyChanged("MaDonDH");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime NgayDat {
            get {
                return this.NgayDatField;
            }
            set {
                if ((this.NgayDatField.Equals(value) != true)) {
                    this.NgayDatField = value;
                    this.RaisePropertyChanged("NgayDat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime NgayGiao {
            get {
                return this.NgayGiaoField;
            }
            set {
                if ((this.NgayGiaoField.Equals(value) != true)) {
                    this.NgayGiaoField = value;
                    this.RaisePropertyChanged("NgayGiao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TinhTrang {
            get {
                return this.TinhTrangField;
            }
            set {
                if ((object.ReferenceEquals(this.TinhTrangField, value) != true)) {
                    this.TinhTrangField = value;
                    this.RaisePropertyChanged("TinhTrang");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float TongTien {
            get {
                return this.TongTienField;
            }
            set {
                if ((this.TongTienField.Equals(value) != true)) {
                    this.TongTienField = value;
                    this.RaisePropertyChanged("TongTien");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DonHangService.IDonDHService1")]
    public interface IDonDHService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDonDHService1/HienThiDonDH", ReplyAction="http://tempuri.org/IDonDHService1/HienThiDonDHResponse")]
        WebForm.DonHangService.DonDH[] HienThiDonDH();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDonDHService1/HienThiDonDH", ReplyAction="http://tempuri.org/IDonDHService1/HienThiDonDHResponse")]
        System.Threading.Tasks.Task<WebForm.DonHangService.DonDH[]> HienThiDonDHAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDonDHService1/TimKiem", ReplyAction="http://tempuri.org/IDonDHService1/TimKiemResponse")]
        WebForm.DonHangService.DonDH[] TimKiem(string madondh, System.DateTime ngaydat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDonDHService1/TimKiem", ReplyAction="http://tempuri.org/IDonDHService1/TimKiemResponse")]
        System.Threading.Tasks.Task<WebForm.DonHangService.DonDH[]> TimKiemAsync(string madondh, System.DateTime ngaydat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDonDHService1/TimKiem_TinhTrang", ReplyAction="http://tempuri.org/IDonDHService1/TimKiem_TinhTrangResponse")]
        WebForm.DonHangService.DonDH[] TimKiem_TinhTrang(string tinhtrang);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDonDHService1/TimKiem_TinhTrang", ReplyAction="http://tempuri.org/IDonDHService1/TimKiem_TinhTrangResponse")]
        System.Threading.Tasks.Task<WebForm.DonHangService.DonDH[]> TimKiem_TinhTrangAsync(string tinhtrang);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDonDHService1/Them", ReplyAction="http://tempuri.org/IDonDHService1/ThemResponse")]
        void Them(WebForm.DonHangService.DonDH ddh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDonDHService1/Them", ReplyAction="http://tempuri.org/IDonDHService1/ThemResponse")]
        System.Threading.Tasks.Task ThemAsync(WebForm.DonHangService.DonDH ddh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDonDHService1/SuaTongTien", ReplyAction="http://tempuri.org/IDonDHService1/SuaTongTienResponse")]
        void SuaTongTien(WebForm.DonHangService.DonDH ddh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDonDHService1/SuaTongTien", ReplyAction="http://tempuri.org/IDonDHService1/SuaTongTienResponse")]
        System.Threading.Tasks.Task SuaTongTienAsync(WebForm.DonHangService.DonDH ddh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDonDHService1/SuaTinhTrang", ReplyAction="http://tempuri.org/IDonDHService1/SuaTinhTrangResponse")]
        void SuaTinhTrang(WebForm.DonHangService.DonDH ddh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDonDHService1/SuaTinhTrang", ReplyAction="http://tempuri.org/IDonDHService1/SuaTinhTrangResponse")]
        System.Threading.Tasks.Task SuaTinhTrangAsync(WebForm.DonHangService.DonDH ddh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDonDHService1/Xoa", ReplyAction="http://tempuri.org/IDonDHService1/XoaResponse")]
        void Xoa(WebForm.DonHangService.DonDH ddh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDonDHService1/Xoa", ReplyAction="http://tempuri.org/IDonDHService1/XoaResponse")]
        System.Threading.Tasks.Task XoaAsync(WebForm.DonHangService.DonDH ddh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDonDHService1/Searid", ReplyAction="http://tempuri.org/IDonDHService1/SearidResponse")]
        WebForm.DonHangService.DonDH Searid(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDonDHService1/Searid", ReplyAction="http://tempuri.org/IDonDHService1/SearidResponse")]
        System.Threading.Tasks.Task<WebForm.DonHangService.DonDH> SearidAsync(int ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDonDHService1Channel : WebForm.DonHangService.IDonDHService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DonDHService1Client : System.ServiceModel.ClientBase<WebForm.DonHangService.IDonDHService1>, WebForm.DonHangService.IDonDHService1 {
        
        public DonDHService1Client() {
        }
        
        public DonDHService1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DonDHService1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DonDHService1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DonDHService1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebForm.DonHangService.DonDH[] HienThiDonDH() {
            return base.Channel.HienThiDonDH();
        }
        
        public System.Threading.Tasks.Task<WebForm.DonHangService.DonDH[]> HienThiDonDHAsync() {
            return base.Channel.HienThiDonDHAsync();
        }
        
        public WebForm.DonHangService.DonDH[] TimKiem(string madondh, System.DateTime ngaydat) {
            return base.Channel.TimKiem(madondh, ngaydat);
        }
        
        public System.Threading.Tasks.Task<WebForm.DonHangService.DonDH[]> TimKiemAsync(string madondh, System.DateTime ngaydat) {
            return base.Channel.TimKiemAsync(madondh, ngaydat);
        }
        
        public WebForm.DonHangService.DonDH[] TimKiem_TinhTrang(string tinhtrang) {
            return base.Channel.TimKiem_TinhTrang(tinhtrang);
        }
        
        public System.Threading.Tasks.Task<WebForm.DonHangService.DonDH[]> TimKiem_TinhTrangAsync(string tinhtrang) {
            return base.Channel.TimKiem_TinhTrangAsync(tinhtrang);
        }
        
        public void Them(WebForm.DonHangService.DonDH ddh) {
            base.Channel.Them(ddh);
        }
        
        public System.Threading.Tasks.Task ThemAsync(WebForm.DonHangService.DonDH ddh) {
            return base.Channel.ThemAsync(ddh);
        }
        
        public void SuaTongTien(WebForm.DonHangService.DonDH ddh) {
            base.Channel.SuaTongTien(ddh);
        }
        
        public System.Threading.Tasks.Task SuaTongTienAsync(WebForm.DonHangService.DonDH ddh) {
            return base.Channel.SuaTongTienAsync(ddh);
        }
        
        public void SuaTinhTrang(WebForm.DonHangService.DonDH ddh) {
            base.Channel.SuaTinhTrang(ddh);
        }
        
        public System.Threading.Tasks.Task SuaTinhTrangAsync(WebForm.DonHangService.DonDH ddh) {
            return base.Channel.SuaTinhTrangAsync(ddh);
        }
        
        public void Xoa(WebForm.DonHangService.DonDH ddh) {
            base.Channel.Xoa(ddh);
        }
        
        public System.Threading.Tasks.Task XoaAsync(WebForm.DonHangService.DonDH ddh) {
            return base.Channel.XoaAsync(ddh);
        }
        
        public WebForm.DonHangService.DonDH Searid(int ID) {
            return base.Channel.Searid(ID);
        }
        
        public System.Threading.Tasks.Task<WebForm.DonHangService.DonDH> SearidAsync(int ID) {
            return base.Channel.SearidAsync(ID);
        }
    }
}
