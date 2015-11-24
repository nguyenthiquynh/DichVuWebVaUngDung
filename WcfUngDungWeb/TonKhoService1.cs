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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TonKhoService1" in both code and config file together.
    public class TonKhoService1 : ITonKhoService1
    {
        public int SoLuongTonKho_SPID(int spid)
        {
            string sql = "select SoLuongTon from SanPham sp, TonKho tk"
                        + " where sp.SP_ID=tk.SP_ID and tk.SP_ID=@SP_ID and ThoiGian = all"
                        + " (select max(thoigian) from tonkho tk1 where tk1.SP_ID=sp.SP_ID group by SP_ID)";
            SqlParameter sp_id = new SqlParameter("SP_ID", spid);
            DataTable dt = SqlDatabase.ExecuteQueryWithDataTable(sql, CommandType.Text, sp_id);
            int soluong = int.Parse(dt.Rows[0][0].ToString());
            return soluong;
        }
        // Hiển thị toàn bộ tồn kho theo thời gian lớn nhất theo SP_ID
        public List<TonKho> HienThiTonKho()
        {
            List<TonKho> ListTK = new List<TonKho>();
            string sql = "select sp.SP_ID,TenSP,SoLuongTon,ThoiGian from SanPham sp, TonKho tk"
                        + " where sp.SP_ID=tk.SP_ID and ThoiGian = all"
                        + " (select max(thoigian) from tonkho tk1 where tk1.SP_ID=sp.SP_ID group by SP_ID) order by tk.SP_ID";
            SqlDataReader rd = SqlDatabase.ExecuteQueryWithDataReader(sql, CommandType.Text);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    TonKho tk = new TonKho()
                    {
                        SP_ID = int.Parse(rd[0].ToString()),
                        TenSP = rd[1].ToString(),
                        SoLuongTon = int.Parse(rd[2].ToString()),
                        ThoiGian = DateTime.Parse(rd[3].ToString())
                    };
                    ListTK.Add(tk);
                }
            }
            return ListTK;
        }
        // Tìm kiếm sản phẩm trong bảng tồn kho theo SP_ID
        public List<TonKho> TimKiemTonKho_SPID(TonKho tk)
        {
            List<TonKho> ListTK = new List<TonKho>();
            string sql = "select sp.SP_ID,TenSP,SoLuongTon,ThoiGian from SanPham sp, TonKho tk"
                        + " where sp.SP_ID=tk.SP_ID and tk.SP_ID=@SP_ID and ThoiGian = all"
                        + " (select max(thoigian) from tonkho tk1 where tk1.SP_ID=sp.SP_ID group by SP_ID) order by tk.SP_ID";
            SqlParameter sp_id = new SqlParameter("@SP_ID", tk.SP_ID);
            SqlDataReader rd = SqlDatabase.ExecuteQueryWithDataReader(sql, CommandType.Text, sp_id);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    tk = new TonKho()
                    {
                        SP_ID = int.Parse(rd[0].ToString()),
                        TenSP = rd[1].ToString(),
                        SoLuongTon = int.Parse(rd[2].ToString()),
                        ThoiGian = DateTime.Parse(rd[3].ToString())
                    };
                    ListTK.Add(tk);
                }
            }
            return ListTK;
        }
        // Tìm kiếm tồn kho theo thời gian (năm - tháng)
         public List<TonKho> TimKiemTonKhoTheoTG(int thang, int nam)
        {
            List<TonKho> ListTK = new List<TonKho>();
            string sql = "select sp.SP_ID,TenSP,SoLuongTon,ThoiGian from SanPham sp, TonKho tk"
                        + " where sp.SP_ID=tk.SP_ID and (Month(ThoiGian) = @Thang and YEAR(ThoiGian)= @Nam) and ThoiGian = all"
                        + " (select max(thoigian) from tonkho tk1 where tk1.SP_ID=sp.SP_ID group by SP_ID) order by tk.SP_ID";
            SqlParameter Thang = new SqlParameter("@Thang", thang);
            SqlParameter Nam = new SqlParameter("@Nam", nam);
            SqlDataReader rd = SqlDatabase.ExecuteQueryWithDataReader(sql, CommandType.Text, Nam, Thang);
             if (rd.HasRows)
            {
                while (rd.Read())
                {
                    TonKho tk = new TonKho()
                    {
                        SP_ID = int.Parse(rd[0].ToString()),
                        TenSP = rd[1].ToString(),
                        SoLuongTon = int.Parse(rd[2].ToString()),
                        ThoiGian = DateTime.Parse(rd[3].ToString())
                    };
                    ListTK.Add(tk);
                }
            }
             return ListTK;       
        }
        // Tìm kiếm tồn kho theo khoảng thời gian
        public List<TonKho> TimKiemTonKhoTheoKhoangTG(DateTime tungay, DateTime denngay)
         {
             List<TonKho> ListTK = new List<TonKho>();
             string sql = "select sp.SP_ID,TenSP,SoLuongTon,ThoiGian from SanPham sp, TonKho tk"
                         + " where sp.SP_ID=tk.SP_ID and (ThoiGian >=@NgayTu and ThoiGian<=@NgayDen) and ThoiGian = all"
                         + " (select max(thoigian) from tonkho tk1 where tk1.SP_ID=sp.SP_ID group by SP_ID) order by tk.SP_ID";
             SqlParameter TuNgay = new SqlParameter("@NgayTu", tungay);
             SqlParameter DenNgay = new SqlParameter("@NgayDen", denngay);
             SqlDataReader rd = SqlDatabase.ExecuteQueryWithDataReader(sql, CommandType.Text, TuNgay, DenNgay);
             {
                while (rd.Read())
                {
                    TonKho tk = new TonKho()
                    {
                        SP_ID = int.Parse(rd[0].ToString()),
                        TenSP = rd[1].ToString(),
                        SoLuongTon = int.Parse(rd[2].ToString()),
                        ThoiGian = DateTime.Parse(rd[3].ToString())
                    };
                    ListTK.Add(tk);
                }
            }
             return ListTK;           
         }
        // Tìm kiếm tồn kho theo số lượng tồn
        // k: so luong ton tang - giam
        public List<TonKho> TimKiemTonKhoTheoSoLuong(int k)
        {
            List<TonKho> ListTK = new List<TonKho>();
            string sql = "";
            if (k == 0)
            {
                sql = "select sp.SP_ID,TenSP,SoLuongTon,ThoiGian from SanPham sp, TonKho tk"
                            + " where sp.SP_ID=tk.SP_ID and ThoiGian = all"
                            + " (select max(thoigian) from tonkho tk1 where tk1.SP_ID=sp.SP_ID group by SP_ID) order by tk.SoLuongTon desc";
            }
            else
            {
                sql = "select sp.SP_ID,TenSP,SoLuongTon,ThoiGian from SanPham sp, TonKho tk"
                            + " where sp.SP_ID=tk.SP_ID and ThoiGian = all"
                            + " (select max(thoigian) from tonkho tk1 where tk1.SP_ID=sp.SP_ID group by SP_ID) order by tk.SoLuongTon";
            }
            SqlDataReader rd = SqlDatabase.ExecuteQueryWithDataReader(sql, CommandType.Text);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    TonKho tk = new TonKho()
                    {
                        SP_ID = int.Parse(rd[0].ToString()),
                        TenSP = rd[1].ToString(),
                        SoLuongTon = int.Parse(rd[2].ToString()),
                        ThoiGian = DateTime.Parse(rd[3].ToString())
                    };
                    ListTK.Add(tk);
                }
            }
            return ListTK;
        }
        // Thêm mới 1 sản phẩm vào tồn kho
        public void ThemMoi(TonKho tk)
        {
            string sql = "insert into TonKho values(@SP_ID, @ThoiGian, @SoLuongTon)";
            SqlParameter spid = new SqlParameter("@SP_ID", tk.SP_ID);
            SqlParameter thoigian = new SqlParameter("@ThoiGian", tk.ThoiGian);
            SqlParameter soluongton = new SqlParameter("@SoLuongTon", tk.SoLuongTon);
            SqlDatabase.ExecuteNonQuery(sql, CommandType.Text, spid, thoigian, soluongton);
        }
        //Nhập kho
        public void NhapKho(TonKho tk)
        {
            string sql = "insert into TonKho values(@SP_ID, @ThoiGian,(select top 1 SoLuongTon from TonKho where SP_ID=@SP_ID order by ThoiGian desc)+@SoLuongTon)";
            SqlParameter spid = new SqlParameter("@SP_ID", tk.SP_ID);
            SqlParameter thoigian = new SqlParameter("@ThoiGian", tk.ThoiGian);
            SqlParameter soluongton = new SqlParameter("@SoLuongTon", tk.SoLuongTon);
            SqlDatabase.ExecuteNonQuery(sql, CommandType.Text, spid, thoigian, soluongton);
        }
        //Xuất kho
        public void XuatKho(TonKho tk)
        {
            string sql = "insert into TonKho values(@SP_ID, @ThoiGian,(select top 1 SoLuongTon from TonKho where SP_ID=@SP_ID order by ThoiGian desc)-@SoLuongTon)";
            SqlParameter spid = new SqlParameter("@SP_ID", tk.SP_ID);
            SqlParameter thoigian = new SqlParameter("@ThoiGian", tk.ThoiGian);
            SqlParameter soluongton = new SqlParameter("@SoLuongTon", tk.SoLuongTon);
            SqlDatabase.ExecuteNonQuery(sql, CommandType.Text, spid, thoigian, soluongton);
        }
        // Xóa sản phẩm
        public void XoaTonKho(TonKho tk)
        {
            string sql = "Delete TonKho where SP_ID=@SP_ID";
            SqlParameter spid = new SqlParameter("@SP_ID", tk.SP_ID);
            SqlDatabase.ExecuteNonQuery(sql, CommandType.Text, spid);
        }

    }
}
