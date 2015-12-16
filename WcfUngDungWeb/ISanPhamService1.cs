using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data;


namespace WcfUngDungWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISanPhamService" in both code and config file together.
    [ServiceContract]
    public interface ISanPhamService1
    {
        //[OperationContract]
        //DataSet LaySP_ID();
        [OperationContract]
        List<SanPham> HienThiSanPhamFull();
        [OperationContract]
        List<SanPham> HienThiSPMoi();
        [OperationContract]
        List<SanPham> HienThiSanPhamCungLoai(SanPham sp);
        [OperationContract]
        List<SanPham> HienThiSanPhamNhaSX(SanPham sp);
        [OperationContract]
        List<SanPham> TimKiemSanPham(string tensp, int nhasxid, decimal dongiatu, decimal dongiaden);
        [OperationContract]
        DataSet ChiTietSanPham(SanPham sp);
        [OperationContract]
         DataSet ThongTinNhapSP(PhieuNhap pn);
        [OperationContract]
        void ThemSanPham(SanPham sp);
        [OperationContract]
        void SuaSanPham(SanPham sp);
        [OperationContract]
        //void Sua_DonGia(SanPham sp);
        //[OperationContract]
        void XoaSanPham(SanPham sp);

        [OperationContract]
        List<SanPham> Spnew();

        [OperationContract]
        List<SanPham> Spfea();

        [OperationContract]
        List<SanPham> Sprun();

        [OperationContract]
        List<SanPham> SpAcer();

        [OperationContract]
        List<SanPham> SpSam();

        [OperationContract]
        List<SanPham> SpHP();

        [OperationContract]
        List<SanPham> SpDell();

        [OperationContract]
        List<SanPham> SpApple();

        [OperationContract]
        List<SanPham> Category(int ID);

        [OperationContract]
        SanPham Detail(int ID);

        [OperationContract]
        SanPham Searchid (int ID);
        
        [OperationContract]
        bool Create(SanPham sp);

        [OperationContract]
        bool Edit(SanPham sp,int ID);

        [OperationContract]
        bool Delete(int ID);

        [OperationContract]
        List<SanPham> listpro();
    }
    [DataContract]
    public class SanPham
    {
        private int sp_id;
        [DataMember]
        public int SP_ID
        {
            get { return sp_id; }
            set { sp_id = value; }
        }

        private string tensp;
        [DataMember]
        public string TenSP
        {
            get { return tensp; }
            set { tensp = value; }
        }

        private int nhasx_id;
        [DataMember]
        public int NhaSX_ID
        {
            get { return nhasx_id; }
            set { nhasx_id = value; }
        }

        private string cpu;
        [DataMember]
        public string CPU
        {
            get { return cpu; }
            set { cpu = value; }
        }

        private string ram;
        [DataMember]
        public string RAM
        {
            get { return ram; }
            set { ram = value; }
        }

        private string hdd;
        [DataMember]
        public string HDD
        {
            get { return hdd; }
            set { hdd = value; }
        }

        private string baohanh;
        [DataMember]
        public string BaoHanh
        {
            get { return baohanh; }
            set { baohanh = value; }
        }

        private float dongia;
        [DataMember]
        public float DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }

        private string hinh;
        [DataMember]
        public string Hinh
        {
            get { return hinh; }
            set { hinh = value; }
        }

        private string mota;
        [DataMember]
        public string MoTa
        {
            get { return mota; }
            set { mota = value; }
        }

        private string tennsx;
        [DataMember]
        public string TenNhaSX
        {
            get { return tennsx; }
            set { tennsx = value; }
        }


    }
}
