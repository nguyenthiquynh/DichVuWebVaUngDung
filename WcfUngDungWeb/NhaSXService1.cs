using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace WcfUngDungWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NhaSXService1" in both code and config file together.
    public class NhaSXService1 : INhaSXService1
    {
        public List<NhaSX> HienThiNhaSX()
        {
            List<NhaSX> ListNSX = new List<NhaSX>();
            string sql = "Select * from NhaSX";
            SqlDataReader rd = SqlDatabase.ExecuteQueryWithDataReader(sql, CommandType.Text);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    NhaSX nsx = new NhaSX()
                    {
                        NhaSX_ID = int.Parse(rd[0].ToString()),
                        TenNhaSX = rd[1].ToString(),
                    };
                    ListNSX.Add(nsx);
                }
            }
            return ListNSX;
        }
        //Thêm Nhà sản xuất
        public void ThemNSX(NhaSX nsx)
        {
            string sql = "insert into NhaSX values(@TenNhaSX)";
            SqlParameter tennhasx = new SqlParameter("@TenNhaSX", nsx.TenNhaSX);
            SqlDatabase.ExecuteNonQuery(sql, CommandType.Text, tennhasx);
        }
        //Sửa nhà sản xuất
        public void SuaNSX(NhaSX nsx)
        {
            string sql = "update NhaSX set TenNhaSX=@TenNhaSX where NhaSX_ID=@NhaSX_ID";
            SqlParameter nsxid = new SqlParameter("@NhaSX_ID", nsx.NhaSX_ID);
            SqlParameter tennsx = new SqlParameter("@TenNhaSX", nsx.TenNhaSX);
            SqlDatabase.ExecuteNonQuery(sql, CommandType.Text, nsxid, tennsx);
        }
        //Xóa nhà sản xuất
        public void XoaNSX(NhaSX nsx)
        {
            string sql = "delete NhaSX where NhaSX_ID=@NhaSX_ID";
            SqlParameter nsxid = new SqlParameter("@NhaSX_ID", nsx.NhaSX_ID);
            SqlDatabase.ExecuteNonQuery(sql, CommandType.Text, nsxid);              
        }
    }
}
