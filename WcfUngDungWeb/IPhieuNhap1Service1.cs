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
   
}
