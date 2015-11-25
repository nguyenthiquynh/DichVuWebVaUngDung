using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfUngDungWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPhieuNhap1Service1" in both code and config file together.
    [ServiceContract]
    public interface IPhieuNhap1Service1
    {
        [OperationContract]
        List<PhieuNhap> HienThiPhieuNhap();
        [OperationContract]
        List<PhieuNhap> TimKiemPN(PhieuNhap pn);
        [OperationContract]
        void ThemPN(PhieuNhap pn);
        [OperationContract]
        void Sua_TongTien(PhieuNhap pn);
    }
    public class PhieuNhap
    {
        private int phieunhap_id;
        [DataMember]
        public int PhieuNhap_ID
        {
            get { return phieunhap_id; }
            set { phieunhap_id = value; }
        }

        private string maphieunhap;
        [DataMember]
        public string MaPhieuNhap
        {
            get { return maphieunhap; }
            set { maphieunhap = value; }
        }


        private int nhasx_id;
        [DataMember]
        public int NhaSX_ID
        {
            get { return nhasx_id; }
            set { nhasx_id = value; }
        }

        private DateTime ngaynhap;
        [DataMember]
        public DateTime NgayNhap
        {
            get { return ngaynhap; }
            set { ngaynhap = value; }
        }

        private string tennsx;
        [DataMember]
        public string TenNhaSX
        {
            get { return tennsx; }
            set { tennsx = value; }
        }

        private float tongtien;
        [DataMember]
        public float TongTien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }

    }
}
