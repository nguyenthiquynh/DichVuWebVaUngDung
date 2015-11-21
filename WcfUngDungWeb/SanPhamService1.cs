﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using WcfUngDungWeb;

namespace WcfUngDungWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SanPhamService" in both code and config file together.
    public class SanPhamService1 : ISanPhamService1
    {
        //Hàm tự viết
        //Hiển thị full sản phẩm
        public List<SanPham> HienThiSanPhamFull()
        {
            List<SanPham> ListSP = new List<SanPham>();
            string sql = "select * from SanPham";
            SqlDataReader rd = SqlDatabase.ExecuteQueryWithDataReader(sql, CommandType.Text);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    SanPham sp = new SanPham()
                    {
                        SP_ID = int.Parse(rd[0].ToString()),
                        TenSP = rd[1].ToString(),
                        NhaSX_ID = int.Parse(rd[2].ToString()),
                        DonGia = float.Parse(rd[7].ToString()),
                        Hinh = rd[8].ToString(),
                    };
                    ListSP.Add(sp);
                }
            }
            return ListSP;
        }

        // Hiển thị 5 sản phẩm mới nhất
        public List<SanPham> HienThiSPMoi()
        {
            List<SanPham> ListSP = new List<SanPham>();
            string sql = "select top 5 from SanPham order by SP_ID desc";
            SqlDataReader rd = SqlDatabase.ExecuteQueryWithDataReader(sql, CommandType.Text);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    SanPham sp = new SanPham()
                    {
                        SP_ID = int.Parse(rd[0].ToString()),
                        TenSP = rd[1].ToString(),
                        NhaSX_ID = int.Parse(rd[2].ToString()),
                        DonGia = float.Parse(rd[7].ToString()),
                        Hinh = rd[8].ToString(),
                    };
                    ListSP.Add(sp);
                }
            }
            return ListSP;
        }
        //hiển thị sản phẩm cùng loại
        public List<SanPham> HienThiSanPhamCungLoai(SanPham sp)
        {
            List<SanPham> data = new List<SanPham>();
            string sql = "select * from SanPham where NhaSX_ID=@NhaSX_ID except select * from SanPham where SP_ID=@SP_ID";
            SqlParameter sp_id = new SqlParameter("@SP_ID", sp.SP_ID);
            SqlParameter nhasx_id = new SqlParameter("@NhaSX_ID", sp.NhaSX_ID);
            SqlDataReader rd = SqlDatabase.ExecuteQueryWithDataReader(sql, CommandType.Text, sp_id, nhasx_id);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    sp = new SanPham()
                    {
                        SP_ID = int.Parse(rd[0].ToString()),
                        TenSP = rd[1].ToString(),
                        NhaSX_ID = int.Parse(rd[2].ToString()),
                        DonGia = float.Parse(rd[7].ToString()),
                        Hinh = rd[8].ToString()
                    };
                    data.Add(sp);
                }
            }
            return data;
        }
        //Hiển thị sản phẩn cũng nhà sản xuất
        public List<SanPham> HienThiSanPhamNhaSX(SanPham sp)
        {
            List<SanPham> ListSP = new List<SanPham>();
            string sql = "select * from SanPham where NhaSX_ID=@NhaSX_ID";
            SqlParameter nhasx_id = new SqlParameter("@NhaSX_ID", sp.NhaSX_ID);
            SqlDataReader rd = SqlDatabase.ExecuteQueryWithDataReader(sql, CommandType.Text, nhasx_id);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    sp = new SanPham()
                    {
                        SP_ID = int.Parse(rd[0].ToString()),
                        TenSP = rd[1].ToString(),
                        NhaSX_ID = int.Parse(rd[2].ToString()),
                        DonGia = float.Parse(rd[7].ToString()),
                        Hinh = rd[8].ToString()
                    };
                    ListSP.Add(sp);
                }
            }
            return ListSP;
        }
        //Tìm kiếm sản phẩm theo tên, nhà sản xuất, khoảng giá
        public List<SanPham> TimKiemSanPham(string tensp, int nhasxid, decimal dongiatu, decimal dongiaden)
        {
            List<SanPham> ListSP = new List<SanPham>();
            string sql;
            if (tensp != "")
            {
                sql = string.Format("select * from SanPham where TenSP like '%{0}%'", tensp);
            }
            else
            {
                sql = string.Format("select * from SanPham where NhaSX_ID={0} and (DonGia between {1} and {2})", nhasxid, dongiatu, dongiaden);
            }
            SqlDataReader rd = SqlDatabase.ExecuteQueryWithDataReader(sql, CommandType.Text);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    SanPham sp = new SanPham()
                    {
                        SP_ID = int.Parse(rd[0].ToString()),
                        TenSP = rd[1].ToString(),
                        NhaSX_ID = int.Parse(rd[2].ToString()),
                        DonGia = float.Parse(rd[7].ToString()),
                        Hinh = rd[8].ToString()
                    };
                    ListSP.Add(sp);
                }
            }
            return ListSP;
        }
    }
}