using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfUngDungWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CartService" in both code and config file together.
    public class CartService : ICartService
    {
        public bool CheckOut(string hoten, string diachi, string sdt, string email, DateTime ngaydat, string total, string id, List<CartItem> cart)
        {
            try
            {
                if(id!=null)
                {
                    string sql = "insert into DonDH values(@hoten,@diachi,@sdt,@email,@ngaydat,TinhTrang=N'Chưa giao',@total,@id)";
                    SqlParameter name = new SqlParameter("@hoten", hoten);
                    SqlParameter addr = new SqlParameter("@diachi", diachi);
                    SqlParameter phone = new SqlParameter("@sdt", sdt);
                    SqlParameter mail = new SqlParameter("@email", email);
                    SqlParameter date = new SqlParameter("@hngaydat", ngaydat);
                    SqlParameter tong = new SqlParameter("@total",float.Parse(total));
                    SqlParameter idKh = new SqlParameter("@id", int.Parse(id));
                    SqlDatabase.ExecuteNonQuery(sql, CommandType.Text, name,addr,mail,date,tong,idKh);
                }
                else
                {
                    string sql = "insert into DonDH values(@hoten,@diachi,@sdt,@email,@ngaydat,TinhTrang=N'Chưa giao',@total)";
                    SqlParameter name = new SqlParameter("@hoten", hoten);
                    SqlParameter addr = new SqlParameter("@diachi", diachi);
                    SqlParameter phone = new SqlParameter("@sdt", sdt);
                    SqlParameter mail = new SqlParameter("@email", email);
                    SqlParameter date = new SqlParameter("@hngaydat", ngaydat);
                    SqlParameter tong = new SqlParameter("@total",float.Parse(total));
                    SqlDatabase.ExecuteNonQuery(sql, CommandType.Text, name,addr,mail,date,tong);
                }

                foreach(var item in cart)
                {
                    
                }


                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
