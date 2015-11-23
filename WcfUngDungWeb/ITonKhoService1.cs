using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfUngDungWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITonKhoService1" in both code and config file together.
    [ServiceContract]
    public interface ITonKhoService1
    {
        [OperationContract]
        int SoLuongTonKho_SPID(int spid);
        [OperationContract]
        List<TonKho> HienThiTonKho();
        [OperationContract]
        List<TonKho> TimKiemTonKho_SPID(TonKho tk);
        [OperationContract]
        List<TonKho> TimKiemTonKhoTheoTG(int thang, int nam);
        [OperationContract]
        List<TonKho> TimKiemTonKhoTheoKhoangTG(DateTime ngaytu, DateTime ngayden);
        [OperationContract]
        List<TonKho> TimKiemTonKhoTheoSoLuong(int k);
        [OperationContract]
        void ThemMoi(TonKho tk);
        [OperationContract]
        void NhapKho(TonKho tk);
        [OperationContract]
        void XuatKho(TonKho tk);
        [OperationContract]
        void Xoa(TonKho tk);
    }
    }
    [DataContract]
    public class TonKho
    {
        private int sp_id;
        [DataMember]
        public int SP_ID
        {
            get { return sp_id; }
            set { sp_id = value; }
        }

        private DateTime thoigian;
        [DataMember]
        public DateTime ThoiGian
        {
            get { return thoigian; }
            set { thoigian = value; }
        }

        private int soluongton;
        [DataMember]
        public int SoLuongTon
        {
            get { return soluongton; }
            set { soluongton = value; }
        }

        private string tensp;
        [DataMember]
        public string TenSP
        {
            get { return tensp; }
            set { tensp = value; }
        }
    }
