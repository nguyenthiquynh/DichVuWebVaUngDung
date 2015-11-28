using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfUngDungWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDonDHService1" in both code and config file together.
    [ServiceContract]
    public interface IDonDHService1
    {
        [OperationContract]
        List<DonDH> HienThiDonDH();
        [OperationContract]
        List<DonDH> TimKiem(string madondh, DateTime ngaydat);
        [OperationContract]
        List<DonDH> TimKiem_TinhTrang(string tinhtrang);
        [OperationContract]
        void Them(DonDH ddh);
        [OperationContract]
        void SuaTongTien(DonDH ddh);
        [OperationContract]
        void SuaTinhTrang(DonDH ddh);
        [OperationContract]
        void Xoa(DonDH ddh);
    }
    
}
