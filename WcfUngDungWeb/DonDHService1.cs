﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace WcfUngDungWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DonDHService1" in both code and config file together.
    public class DonDHService1 : IDonDHService1
    {

        public List<DonDH> HienThiDonDH()
        {
            List<DonDH> data = new List<DonDH>();
            string sql = "select * from DonDH";
            SqlDataReader rd = SqlDatabase.ExecuteQueryWithDataReader(sql, CommandType.Text);
            if (rd.HasRows)  // kiem tra xem co rows nao k
            {
                while (rd.Read())
                {
                    DonDH ddh = new DonDH()
                    {
                        DonDH_ID = int.Parse(rd[0].ToString()),
                        MaDonDH = rd[1].ToString(),
                        HoTenKH = rd[2].ToString(),
                        DiaChi = rd[3].ToString(),
                        DienThoai = rd[4].ToString(),
                        Email = rd[5].ToString(),
                        NgayDat = DateTime.Parse(rd[6].ToString()),
                        NgayGiao = DateTime.Parse(rd[7].ToString()),
                        GhiChu = rd[8].ToString(),
                        TinhTrang = rd[9].ToString(),
                        TongTien = float.Parse(rd[10].ToString())
                    };
                    data.Add(ddh);
                }

            }
            return data;
        }

        public List<DonDH> TimKiem(string madondh, DateTime ngaydat)
        {
            List<DonDH> data = new List<DonDH>();
            string sql = "";
            if (madondh != "")
            {
                sql = string.Format("select * from DonDH where MaDonDH='{0}'", madondh);
            }
            else
            {
                sql = string.Format("select * from DonDH where NgayDat='{0}'", ngaydat);
            }
            SqlDataReader rd = SqlDatabase.ExecuteQueryWithDataReader(sql, CommandType.Text);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    DonDH ddh = new DonDH()
                    {
                        DonDH_ID = int.Parse(rd[0].ToString()),
                        MaDonDH = rd[1].ToString(),
                        HoTenKH = rd[2].ToString(),
                        DiaChi = rd[3].ToString(),
                        DienThoai = rd[4].ToString(),
                        Email = rd[5].ToString(),
                        NgayDat = DateTime.Parse(rd[6].ToString()),
                        NgayGiao = DateTime.Parse(rd[7].ToString()),
                        GhiChu = rd[8].ToString(),
                        TinhTrang = rd[9].ToString(),
                        TongTien = float.Parse(rd[10].ToString())
                    };
                    data.Add(ddh);
                }

            }
            return data;
        }

        public List<DonDH> TimKiem_TinhTrang(string tinhtrang)
        {
            List<DonDH> data = new List<DonDH>();
            string sql = string.Format("select * from DonDH where TinhTrang=N'{0}'", tinhtrang);
            SqlDataReader rd = SqlDatabase.ExecuteQueryWithDataReader(sql, CommandType.Text);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    DonDH ddh = new DonDH()
                    {
                        DonDH_ID = int.Parse(rd[0].ToString()),
                        MaDonDH = rd[1].ToString(),
                        HoTenKH = rd[2].ToString(),
                        DiaChi = rd[3].ToString(),
                        DienThoai = rd[4].ToString(),
                        Email = rd[5].ToString(),
                        NgayDat = DateTime.Parse(rd[6].ToString()),
                        NgayGiao = DateTime.Parse(rd[7].ToString()),
                        GhiChu = rd[8].ToString(),
                        TinhTrang = rd[9].ToString(),
                        TongTien = float.Parse(rd[10].ToString())
                    };
                    data.Add(ddh);
                }

            }
            return data;
        }

        public void Them(DonDH ddh)
        {
            string sql = "insert into DonDH values(@MaDonDH,@HoTenKH,@DiaChi,@DienThoai,@Email,@NgayDat,@NgayGiao,@GhiChu,@TinhTrang,@TongTien,@ID_NguoiDung)";
            SqlParameter madondh = new SqlParameter("@MaDonDH", ddh.MaDonDH);
            SqlParameter hotenkh = new SqlParameter("@HoTenKH", ddh.HoTenKH);
            SqlParameter diachi = new SqlParameter("@DiaChi", ddh.DiaChi);
            SqlParameter dienthoai = new SqlParameter("@DienThoai", ddh.DienThoai);
            SqlParameter email = new SqlParameter("@Email", ddh.Email);
            SqlParameter ngaydat = new SqlParameter("@NgayDat", ddh.NgayDat);
            SqlParameter ngaygiao = new SqlParameter("@NgayGiao", ddh.NgayGiao);
            SqlParameter ghichu = new SqlParameter("@GhiChu", ddh.GhiChu);
            SqlParameter tinhtrang = new SqlParameter("@TinhTrang", ddh.TinhTrang);
            SqlParameter tongtien = new SqlParameter("@TongTien", ddh.TongTien);
            SqlParameter iD_NguoiDung = new SqlParameter("@ID_NguoiDung", ddh.ID_NguoiDung);

            SqlDatabase.ExecuteNonQuery(sql, CommandType.Text, madondh, hotenkh, diachi, dienthoai, email, ngaydat, ngaygiao, ghichu, tinhtrang, tongtien, iD_NguoiDung);
        }
        public void SuaTongTien(DonDH ddh)
        {
            string sql = "update DonDH set TongTien=@TongTien where MaDonDH=@MaDonDH";
            SqlParameter madondh = new SqlParameter("@MaDonDH", ddh.MaDonDH);
            SqlParameter tongtien = new SqlParameter("@TongTien", ddh.TongTien);
            SqlDatabase.ExecuteNonQuery(sql, CommandType.Text, madondh, tongtien);
        }
        // Hàm tự viết
        // Cập nhật tình trạng đơn hàng
        public void SuaTinhTrang(DonDH ddh)
        {
            string sql = "update DonDH set TinhTrang=@TinhTrang where MaDonDH=@MaDonDH";
            SqlParameter madondh = new SqlParameter("@MaDonDH", ddh.MaDonDH);
            SqlParameter tinhtrang = new SqlParameter("@TinhTrang", ddh.TinhTrang);
            SqlDatabase.ExecuteNonQuery(sql, CommandType.Text, madondh, tinhtrang);
        }
        // Hàm tự viết
        // Xóa đơn hàng
        public void Xoa(DonDH ddh)
        {
            string sql = "Delete DonDH where MaDonDH=@MaDonDH";
            SqlParameter madondh = new SqlParameter("@MaDonDH", ddh.MaDonDH);
            SqlDatabase.ExecuteNonQuery(sql, CommandType.Text, madondh);
        }
    }
}
