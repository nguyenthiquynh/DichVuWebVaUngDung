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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PhieuNhapService1" in both code and config file together.
    public class PhieuNhapService1 : IPhieuNhapService1
    {

        public List<PhieuNhap> HienThiPhieuNhap()
        {
            List<PhieuNhap> data = new List<PhieuNhap>();
            string sql = "select PhieuNhap_ID,MaPhieuNhap,pn.NhaSX_ID,TenNhaSX,NgayNhap,pn.TongTien from PhieuNhap pn,NhaSX nsx where pn.NhaSX_ID=nsx.NhaSX_ID";
            SqlDataReader rd = SqlDatabase.ExecuteQueryWithDataReader(sql, CommandType.Text);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    PhieuNhap pn = new PhieuNhap()
                    {
                        PhieuNhap_ID = int.Parse(rd[0].ToString()),
                        MaPhieuNhap = rd[1].ToString(),
                        NhaSX_ID = int.Parse(rd[2].ToString()),
                        TenNhaSX = rd[3].ToString(),
                        NgayNhap = DateTime.Parse(rd[4].ToString()),
                        TongTien = float.Parse(rd[5].ToString())
                    };
                    data.Add(pn);
                }
            }
            return data;
        }

        public List<PhieuNhap> TimKiem(PhieuNhap pn)
        {
            List<PhieuNhap> data = new List<PhieuNhap>();
            string sql = "select PhieuNhap_ID,MaPhieuNhap,pn.NhaSX_ID,TenNhaSX,NgayNhap,pn.TongTien"
                       + " from PhieuNhap pn,NhaSX nsx where pn.NhaSX_ID=nsx.NhaSX_ID"
                       + " and (MaPhieuNhap=@MaPhieuNhap or pn.NhaSX_ID=@NhaSX_ID or NgayNhap=@NgayNhap)";

            SqlParameter maphieunhap = new SqlParameter("@MaPhieuNhap", pn.MaPhieuNhap);
            SqlParameter nhasxid = new SqlParameter("@NhaSX_ID", pn.NhaSX_ID);
            SqlParameter ngaynhap = new SqlParameter("@NgayNhap", pn.NgayNhap);
            SqlDataReader rd = SqlDatabase.ExecuteQueryWithDataReader(sql, CommandType.Text, maphieunhap, nhasxid, ngaynhap);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    pn = new PhieuNhap()
                    {
                        PhieuNhap_ID = int.Parse(rd[0].ToString()),
                        MaPhieuNhap = rd[1].ToString(),
                        NhaSX_ID = int.Parse(rd[2].ToString()),
                        TenNhaSX = rd[3].ToString(),
                        NgayNhap = DateTime.Parse(rd[4].ToString()),
                        TongTien = float.Parse(rd[5].ToString())
                    };
                    data.Add(pn);
                }
            }
            return data;
        }

        public void Them(PhieuNhap pn)
        {
            string sql = "insert into PhieuNhap values(@MaPhieuNhap,@NhaSX_ID,@NgayNhap,@TongTien)";
            SqlParameter maphieunhap = new SqlParameter("@MaPhieuNhap", pn.MaPhieuNhap);
            SqlParameter nhasxid = new SqlParameter("@NhaSX_ID", pn.NhaSX_ID);
            SqlParameter ngaynhap = new SqlParameter("@NgayNhap", pn.NgayNhap);
            SqlParameter tongtien = new SqlParameter("@TongTien", pn.TongTien);
            SqlDatabase.ExecuteNonQuery(sql, CommandType.Text, maphieunhap, nhasxid, ngaynhap, tongtien);
        }

        public void Sua_TongTien(PhieuNhap pn)
        {
            string sql = "update PhieuNhap set TongTien=@TongTien where MaPhieuNhap=@MaPhieuNhap";
            SqlParameter maphieunhap = new SqlParameter("@MaPhieuNhap", pn.MaPhieuNhap);
            SqlParameter tongtien = new SqlParameter("@TongTien", pn.TongTien);
            SqlDatabase.ExecuteNonQuery(sql, CommandType.Text, maphieunhap, tongtien);
        }
    }
}
