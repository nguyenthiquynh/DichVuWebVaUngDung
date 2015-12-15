using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfUngDungWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICartService" in both code and config file together.
    [ServiceContract]
    public interface ICartService
    {
        [OperationContract]
        bool CheckOut(string hoten, string diachi, string sdt, string email, string total, string id, List<CartItem> cart);
    }

    [DataContract]
    public class CartItem
    {
        private SanPham product;
        [DataMember]
        public SanPham Product
        {
            get { return product; }
            set { product = value; }
        }

        private int quantity;
        [DataMember]
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}