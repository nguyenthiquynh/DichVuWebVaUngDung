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
        public bool CheckOut(string hoten, string diachi, string sdt, string email, string total, string id, List<CartItem> cart)
        {
            try
            {
                if (id != null)
                {
                    string sql = "insert into DonDH(HoTenKH,DiaChi,DienThoai,Email,NgayDat,TinhTrang,TongTien,ID_NguoiDung)values(@hoten,@diachi,@sdt,@email,@ngaydat,N'Chưa giao hàng',@total,@id)";
                    SqlParameter name = new SqlParameter("@hoten", hoten);
                    SqlParameter addr = new SqlParameter("@diachi", diachi);
                    SqlParameter phone = new SqlParameter("@sdt", sdt);
                    SqlParameter mail = new SqlParameter("@email", email);
                    SqlParameter date = new SqlParameter("@ngaydat", DateTime.Now.ToString("yyyy-MM-dd"));
                    SqlParameter tong = new SqlParameter("@total", float.Parse(total));
                    SqlParameter idKh = new SqlParameter("@id", int.Parse(id));
                    SqlDatabase.ExecuteNonQuery(sql, CommandType.Text, name, addr,phone, mail, date, tong, idKh);
                }
                else
                {
                    string sql = "insert into DonDH(HoTenKH,DiaChi,DienThoai,Email,NgayDat,TinhTrang,TongTien) values(@hoten,@diachi,@sdt,@email,@ngaydat,N'Chưa giao hàng',@total)";
                    SqlParameter name = new SqlParameter("@hoten", hoten);
                    SqlParameter addr = new SqlParameter("@diachi", diachi);
                    SqlParameter phone = new SqlParameter("@sdt", sdt);
                    SqlParameter mail = new SqlParameter("@email", email);
                    SqlParameter date = new SqlParameter("@ngaydat", DateTime.Now.ToString("yyyy-MM-dd"));
                    SqlParameter tong = new SqlParameter("@total", float.Parse(total));
                    SqlDatabase.ExecuteNonQuery(sql, CommandType.Text, name, addr,phone, mail, date, tong);
                }

                foreach (var item in cart)
                {
                    string sql = "insert into CT_DonDH values ((select max(MaDonDH) from DonDH),@SP_ID,@DonGiaDat,@Soluong); insert into TonKho values(@SP_ID,@ThoiGian,(select top 1 SoLuongTon  from TonKho where SP_ID=@SP_ID order by SoLuongTon desc)-@soluong)";
                    SqlParameter sp_id = new SqlParameter("@SP_ID", item.Product.SP_ID);
                    SqlParameter dongia = new SqlParameter("@DonGiaDat", item.Product.DonGia);
                    SqlParameter soluong = new SqlParameter("@SoLuong", item.Quantity);
                    SqlParameter thoigian = new SqlParameter("@ThoiGian", DateTime.Now.ToString("yyyy-MM-dd"));
                    SqlDatabase.ExecuteNonQuery(sql, CommandType.Text, sp_id, dongia, soluong, thoigian);
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
