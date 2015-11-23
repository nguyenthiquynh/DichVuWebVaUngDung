using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfUngDungWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INhaSXService1" in both code and config file together.
    [ServiceContract]
    public interface INhaSXService1
    {
        [OperationContract]
        List<NhaSX> HienThiNhaSX();
        [OperationContract]
        void ThemNSX(NhaSX nsx);
        [OperationContract]
        void SuaNSX(NhaSX nsx);
        [OperationContract]
        void XoaNSX(NhaSX nsx);
    }
    public class NhaSX
    {
        private int nhasx_id;
        [DataMember]
        public int NhaSX_ID
        {
            get { return nhasx_id; }
            set { nhasx_id = value; }
        }

        private string tennhasx;
        [DataMember]
        public string TenNhaSX
        {
            get { return tennhasx; }
            set { tennhasx = value; }
        }
    }
}
