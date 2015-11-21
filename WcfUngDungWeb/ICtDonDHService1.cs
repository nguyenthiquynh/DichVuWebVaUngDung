using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfUngDungWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICtDonDHService1" in both code and config file together.
    [ServiceContract]
    public interface ICtDonDHService1
    {
        [OperationContract]
        void DoWork();
    }
}
