﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfUngDungWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICtPhieuNhapService1" in both code and config file together.
    [ServiceContract]
    public interface ICtPhieuNhapService1
    {
        [OperationContract]
        List<CtPhieuNhap> HienThiCtPhieuNhap(CtPhieuNhap ct);
        [OperationContract]
        bool KiemTraMaPhieuNhap(string ma);
        [OperationContract]
        void Them(CtPhieuNhap ct);
    }
    
}
