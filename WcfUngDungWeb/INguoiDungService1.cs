using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfUngDungWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INguoiDungService1" in both code and config file together.
    [ServiceContract]
    public interface INguoiDungService1
    {
        [OperationContract]
        List<NguoiDung> listuser();

        [OperationContract]
        bool Register(NguoiDung u);

        [OperationContract]
        NguoiDung Authentication(string Username, string Password);

        [OperationContract]
        NguoiDung Searchuser (string username);

        [OperationContract]
        NguoiDung Searchid(int ID);

        [OperationContract]
        bool Create(NguoiDung u);

        [OperationContract]
        bool Edit(NguoiDung u, int ID);

        [OperationContract]
        bool Delete(int ID);

        [OperationContract]
        bool Lock(int ID);

        [OperationContract]
        bool Unlock(int ID);
    }
    [Serializable]
    [DataContract]
    public class NguoiDung
    {
        private int id;
        [DataMember]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string ten;
        [DataMember]
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        private string tdn;
        [DataMember]
        public string TenDangNhap
        {
            get { return tdn; }
            set { tdn = value; }
        }

        private string mk;
        [DataMember]
        public string MatKhau
        {
            get { return mk; }
            set { mk = value; }
        }

        private string email;
        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private int quyen;
        [DataMember]
        public int Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }

        private string diachi;
        [DataMember]
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        private string sdt;
        [DataMember]
        public string SoDienThoai
        {
            get { return sdt; }
            set { sdt = value; }
        }

        private int status;
        [DataMember]
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
    }
    
}
