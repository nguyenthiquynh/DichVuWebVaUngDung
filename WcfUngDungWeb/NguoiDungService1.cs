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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NguoiDungService1" in both code and config file together.
    public class NguoiDungService1 : INguoiDungService1
    {

        public List<NguoiDung> listuser()
        {
            List<NguoiDung> list = new List<NguoiDung>();
            string Sql = ("select * from NguoiDung");
            SqlDataReader rd = SqlDatabase.ExecuteQueryWithDataReader(Sql, CommandType.Text);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    NguoiDung u = new NguoiDung()
                    {
                        ID = int.Parse(rd[0].ToString()),
                        Ten = rd[1].ToString(),
                        TenDangNhap = rd[2].ToString(),
                        Email = rd[4].ToString(),
                        Quyen = int.Parse(rd[5].ToString()),
                        DiaChi = (rd[6].ToString()),
                        SoDienThoai = (rd[7].ToString()),
                        Status = int.Parse(rd[8].ToString()),
                    };
                    list.Add(u);
                }
            }
            return list;
        }


        public bool Register(NguoiDung u)
        {
            string sql = ("select * from NguoiDung");
            DataSet ds = SqlDatabase.ExecuteQueryWithDataSet(sql, CommandType.Text);
            if (ds.Tables[0].Rows.Count > 0)
            {
                string ID = ds.Tables[0].Rows[0]["ID"].ToString();
                u.ID = int.Parse(ID) + 1;
            }
            else
            {
                u.ID = 1;
            }
            string Sql = "insert into NguoiDung values (@ID,@Ten,@TenDangNhap,@Email,@Quyen,@DiaChi,@SoDienThoai,@Status)";
            SqlParameter id = new SqlParameter("@ID", u.ID);
            SqlParameter ten = new SqlParameter("@Ten", u.Ten);
            SqlParameter tdn = new SqlParameter("@TenDangNhap", u.TenDangNhap);
            SqlParameter email = new SqlParameter("@Email", u.Email);
            SqlParameter quyen = new SqlParameter("@Quyen", u.Quyen);
            SqlParameter diachi = new SqlParameter("@DiaChi", u.DiaChi);
            SqlParameter sdt = new SqlParameter("@SoDienThoai", u.SoDienThoai);
            SqlParameter status = new SqlParameter(@"Status", u.Status);
            SqlDatabase.ExecuteNonQuery(Sql, CommandType.Text, id, ten, tdn, email, quyen, diachi, sdt, status);
            DataSet ds1 = SqlDatabase.ExecuteQueryWithDataSet(Sql, CommandType.Text);
            if (ds != null)
            { return true; }
            return false;
        }


        public NguoiDung Authentication(string Username, string Password)
        {
            string Sql = ("select Ten,ID,Quyen from NguoiDung where TenDangNhap = @tdn and MatKhau = @mk ");
            SqlParameter tdn = new SqlParameter("@tdn", Username);
            SqlParameter mk = new SqlParameter("@mk", Password);
            SqlDataReader ds = SqlDatabase.ExecuteQueryWithDataReader(Sql, CommandType.Text,tdn,mk);
            if (ds.HasRows)
            {
                while (ds.Read())
                {
                    NguoiDung u = new NguoiDung()
                    {
                        ID = int.Parse(ds[1].ToString()),
                        Ten = ds[0].ToString(),
                        Quyen = int.Parse(ds[2].ToString())
                    };
                    return u;
                }
            }
            return null;
        }


        public NguoiDung Searchuser(string Username)
        {
            string Sql = ("select * from NguoiDung where TenDangNhap = @Username");
            SqlParameter tdn = new SqlParameter("@Username", Username);
            SqlDataReader rd = SqlDatabase.ExecuteQueryWithDataReader(Sql, CommandType.Text, tdn);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    NguoiDung u = new NguoiDung()
                    {
                        ID = int.Parse(rd[0].ToString()),
                        Ten = rd[1].ToString(),
                        TenDangNhap = rd[2].ToString(),
                        Email = rd[4].ToString(),
                        Quyen = int.Parse(rd[5].ToString()),
                        DiaChi = (rd[6].ToString()),
                        SoDienThoai = (rd[7].ToString()),
                        Status = int.Parse(rd[8].ToString()),
                    };

                    return u;
                }
            }
            return null;
        }


        public bool Create(NguoiDung u)
        {
            string sql = ("select * from NguoiDung");
            DataSet ds1 = SqlDatabase.ExecuteQueryWithDataSet(sql, CommandType.Text);
            if(ds1.Tables[0].Rows.Count >0)
            {
                string ID = ds1.Tables[0].Rows[0]["ID"].ToString();
                u.ID = int.Parse(ID) + 1;
            }
            else
            {
                u.ID = 1;
            }
            string Sql = "intsert into NguoiDung values(@ID,@Ten,@TenDangNhap,@MatKhau,@Email,@Quyen,@DiaChi,@SoDienThoai,@Status)";
            SqlParameter id = new SqlParameter("@ID", u.ID);
            SqlParameter ten = new SqlParameter("@Ten", u.Ten);
            SqlParameter tdn = new SqlParameter("@TenDangNhap", u.TenDangNhap);
            SqlParameter mk = new SqlParameter("@MatKhau", u.MatKhau);
            SqlParameter email = new SqlParameter("@Email", u.Email);
            SqlParameter quyen = new SqlParameter("@Quyen", u.Quyen);
            SqlParameter diachi = new SqlParameter("@DiaChi", u.DiaChi);
            SqlParameter sdt = new SqlParameter("@SoDienThoai", u.SoDienThoai);
            SqlParameter status = new SqlParameter("@Status", u.Status);
            SqlDatabase.ExecuteNonQuery(Sql, CommandType.Text, id, ten, tdn, mk, email, quyen, diachi, sdt, status);
            DataSet ds = SqlDatabase.ExecuteQueryWithDataSet(Sql, CommandType.Text);
            if(ds != null)
            {
                return true;
            }
            return false;
        }


        public bool Delete(int ID)
        {
            try
            {
                string Sql = ("delete NguoiDung where ID = @ID");
                SqlParameter id = new SqlParameter("@ID", ID);
                SqlDatabase.ExecuteNonQuery(Sql, CommandType.Text, id);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool Edit(NguoiDung u, int ID)
        {
            try { 
                //string sql = ("select * from NguoiDung where ID = @ID");
            
            //DataSet ds = SqlDatabase.ExecuteQueryWithDataSet(sql, CommandType.Text,id);
            string Sql = "update NguoiDung set Ten = @Ten, MatKhau=@pass, TenDangNhap = @TenDangNhap, Email = @Email, Quyen = @Quyen, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, Status = @Status where ID=@ID";
            SqlParameter id = new SqlParameter("@ID", ID);
            SqlParameter ten = new SqlParameter("@Ten", u.Ten);
            SqlParameter tdn = new SqlParameter("@TenDangNhap", u.TenDangNhap);
            SqlParameter pass= new SqlParameter("@Ten", u.MatKhau);
            SqlParameter email = new SqlParameter("@Email", u.Email);
            SqlParameter quyen = new SqlParameter("@Quyen", u.Quyen);
            SqlParameter diachi = new SqlParameter("@DiaChi", u.DiaChi);
            SqlParameter sdt = new SqlParameter("@SoDienThoai", u.SoDienThoai);
            SqlParameter status = new SqlParameter("@Status", u.Status);
            SqlDatabase.ExecuteNonQuery(Sql, CommandType.Text, ten, tdn,pass, email, quyen, diachi, sdt, status,id);
            //DataSet ds1 = SqlDatabase.ExecuteQueryWithDataSet(Sql, CommandType.Text);
            //if(ds1 != null)
            //{
                return true;
            //}
            }
            catch
            {
                return false;
            }
        }


        public NguoiDung Searchid(int ID)
        {
            string sql = ("select * from NguoiDung where ID = @ID");
            SqlParameter id = new SqlParameter("@ID", ID);
            SqlDataReader ds = SqlDatabase.ExecuteQueryWithDataReader(sql, CommandType.Text,id);
            if(ds.HasRows)
            {
                while(ds.Read())
                {
                    NguoiDung u = new NguoiDung()
                    {
                         ID = int.Parse(ds[0].ToString()),
                        Ten = ds[1].ToString(),
                        TenDangNhap = ds[2].ToString(),
                        Email = ds[4].ToString(),
                        Quyen = int.Parse(ds[5].ToString()),
                        DiaChi = (ds[6].ToString()),
                        SoDienThoai = (ds[7].ToString()),
                        Status = int.Parse(ds[8].ToString()),
                    };
                    return u;
                }
            }
            return null;
        }


        public bool Lock(int ID)
        {
            try { 
            string Sql = "update NguoiDung set Status = 0 where ID = @ID";
            SqlParameter id = new SqlParameter("@ID", ID);
            SqlDatabase.ExecuteNonQuery(Sql, CommandType.Text, id);
            return true;
                }
            catch
            {
                return false;
            }
        }

        public bool Unlock(int ID)
        {
            try
            {
                string Sql = "update NguoiDung set Status = 1 where ID = @ID";
                SqlParameter id = new SqlParameter("@ID", ID);
                SqlDatabase.ExecuteNonQuery(Sql, CommandType.Text, id);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
