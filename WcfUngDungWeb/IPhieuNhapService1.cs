﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfUngDungWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPhieuNhapService1" in both code and config file together.
    [ServiceContract]
    public interface IPhieuNhapService1
    {
        [OperationContract]
        List<PhieuNhap> HienThiPhieuNhap();
        [OperationContract]
        List<PhieuNhap> TimKiem(PhieuNhap pn);
        [OperationContract]
        void Them(PhieuNhap pn);
        [OperationContract]
        void Sua_TongTien(PhieuNhap pn);
    }
}
