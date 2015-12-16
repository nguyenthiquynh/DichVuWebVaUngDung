using System;
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
            List<SanPham> data = new List<SanPham>();
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
                    data.Add(sp);
                }
            }
            return data;
        }
        //Hiển thị chi tiết sản phẩm
        public DataSet ChiTietSanPham(SanPham sp)
        {
            string sql;
            TonKho TonKho = new TonKho();
            TonKhoService1 _TonKho = new TonKhoService1();
            TonKho.SP_ID = sp.SP_ID;
            List<TonKho> ListTK = _TonKho.TimKiemTonKho_SPID(TonKho);
            if (ListTK.Count > 0)
            {
                sql = "select sp.SP_ID,TenSP,sp.NhaSX_ID,TenNhaSX,CPU,RAM,HDD,BaoHanh,Hinh,DonGia,MoTa,SoLuongTon,ThoiGian"
                            + " from SanPham sp, NhaSX nsx, (select top 1 * from TonKho where SP_ID=@SP_ID order by ThoiGian desc) as tk"
                            + " where sp.NhaSX_ID = nsx.NhaSX_ID and sp.SP_ID=tk.SP_ID";
            }
            else
            {
                sql = "select sp.SP_ID,TenSP,sp.NhaSX_ID,TenNhaSX,CPU,RAM,HDD,BaoHanh,Hinh,DonGia,MoTa,SoLuongTon=0"
                            + " from SanPham sp, NhaSX nsx"
                            + " where sp.NhaSX_ID = nsx.NhaSX_ID and SP_ID=@SP_ID";
            }
            SqlParameter spid = new SqlParameter("@SP_ID", sp.SP_ID);
            DataSet ds = SqlDatabase.ExecuteQueryWithDataSet(sql, CommandType.Text, spid);
            return ds;
        }
        public DataSet ThongTinNhapSP(PhieuNhap pn)
        {
            CtPhieuNhapService1 dal = new CtPhieuNhapService1();
            string mapn = pn.MaPhieuNhap.ToString();
            string sql = "";
            bool kt = dal.KiemTraMaPhieuNhap(mapn);
            if (kt == true)
            {
               sql = string.Format("select SP_ID,TenSP,NhaSX_ID from SanPham where NhaSX_ID=@NhaSX_ID"
                      + " and SP_ID not in"
                          + " (select ct_pn.SP_ID from SanPham sp, PhieuNhap pn, CT_PhieuNhap ct_pn"
                           + " where pn.MaPhieuNhap=ct_pn.MaPhieuNhap and ct_pn.SP_ID=sp.SP_ID"
                           + " and ct_pn.MaPhieuNhap='{0}')", mapn);
            }
            else
           {
               sql = "select SP_ID,TenSP,NhaSX_ID from SanPham where NhaSX_ID=@NhaSX_ID";
           }
            SqlParameter nhasxid = new SqlParameter("@NhaSX_ID", pn.NhaSX_ID);
            return SqlDatabase.ExecuteQueryWithDataSet(sql, CommandType.Text, nhasxid);
         }
        //Thêm sản phẩm
        public void ThemSanPham(SanPham sp)
        {
            string sql = "insert into SanPham values(@TenSP,@NhaSX_ID,@CPU,@RAM,@HDD,@BaoHanh,@DonGia,@Hinh,@MoTa)";
            SqlParameter tensp = new SqlParameter("@TenSP", sp.TenSP);
            SqlParameter nhasx = new SqlParameter("@NhaSX_ID", sp.NhaSX_ID);
            SqlParameter cpu = new SqlParameter("@CPU", sp.CPU);
            SqlParameter ram = new SqlParameter("@RAM", sp.RAM);
            SqlParameter hdd = new SqlParameter("@HDD", sp.HDD);
            SqlParameter baohanh = new SqlParameter("@BaoHanh", sp.BaoHanh);
            SqlParameter dongia = new SqlParameter("@DonGia", sp.DonGia);
            SqlParameter hinh = new SqlParameter("@Hinh", sp.Hinh);
            SqlParameter mota = new SqlParameter("@MoTa", sp.MoTa);
            SqlDatabase.ExecuteNonQuery(sql, CommandType.Text, tensp, nhasx, cpu, ram, hdd, baohanh, dongia, hinh, mota);
        }
        // Sửa sản phẩm

        public void SuaSanPham(SanPham sp)
        {
            string sql = "update SanPham set TenSP=@TenSP,NhaSX_ID=@NhaSX_ID,CPU=@CPU,RAM=@RAM,HDD=@HDD,BaoHanh=@BaoHanh,DonGia=@DonGia,Hinh=@Hinh,MoTa=@MoTa where SP_ID=@SP_ID";
            SqlParameter spid = new SqlParameter("@SP_ID", sp.SP_ID);
            SqlParameter tensp = new SqlParameter("@TenSP", sp.TenSP);
            SqlParameter nhasx = new SqlParameter("@NhaSX_ID", sp.NhaSX_ID);
            SqlParameter cpu = new SqlParameter("@CPU", sp.CPU);
            SqlParameter ram = new SqlParameter("@RAM", sp.RAM);
            SqlParameter hdd = new SqlParameter("@HDD", sp.HDD);
            SqlParameter baohanh = new SqlParameter("@BaoHanh", sp.BaoHanh);
            SqlParameter dongia = new SqlParameter("@DonGia", sp.DonGia);
            SqlParameter hinh = new SqlParameter("@Hinh", sp.Hinh);
            SqlParameter mota = new SqlParameter("@MoTa", sp.MoTa);
            SqlDatabase.ExecuteNonQuery(sql, CommandType.Text, spid, tensp, nhasx, cpu, ram, hdd, baohanh, dongia, hinh, mota);
        }
        // Xóa sản phẩm
        public void XoaSanPham(SanPham sp)
        {
            string sql = "delete SanPham where SP_ID=@SP_ID";
            SqlParameter spid = new SqlParameter("@SP_ID", sp.SP_ID);
            SqlDatabase.ExecuteNonQuery(sql, CommandType.Text, spid);
        }



        public List<SanPham> Spnew()
        {
            List<SanPham> listnew = new List<SanPham>();
            string sql = "select p.SP_ID,p.TenSP,g.TenNhaSX,p.DonGia, p.Hinh from SanPham p,NhaSX g where p.NhaSX_ID = g.NhaSX_ID order by p.SP_ID desc";
            SqlDataReader dr = SqlDatabase.ExecuteQueryWithDataReader(sql, CommandType.Text);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    SanPham sp = new SanPham()
                    {
                        SP_ID = int.Parse(dr[0].ToString()),
                        TenSP = dr[1].ToString(),
                        TenNhaSX = dr[2].ToString(),
                        DonGia = float.Parse(dr[3].ToString()),
                        Hinh = dr[4].ToString(),
                    };
                    listnew.Add(sp);
                }
            }
            return listnew;
        }


        public List<SanPham> Spfea()
        {
            List<SanPham> listfea = new List<SanPham>();
            string Sql = ("select p.SP_ID,p.TenSP,g.TenNhaSX,p.DonGia, p.Hinh from SanPham p,NhaSX g where p.NhaSX_ID = g.NhaSX_ID order by p.DonGia desc");
            SqlDataReader dr = SqlDatabase.ExecuteQueryWithDataReader(Sql, CommandType.Text);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    SanPham sp = new SanPham()
                    {
                        SP_ID = int.Parse(dr[0].ToString()),
                        TenSP = dr[1].ToString(),
                        TenNhaSX = dr[2].ToString(),
                        DonGia = float.Parse(dr[3].ToString()),
                        Hinh = dr[4].ToString(),
                    };
                    listfea.Add(sp);
                }
            }
            return listfea;
        }

        public List<SanPham> Sprun()
        {
            List<SanPham> listrun = new List<SanPham>();
            string Sql = ("select p.SP_ID,p.TenSP,g.TenNhaSX,p.DonGia, p.Hinh from SanPham p,NhaSX g where p.NhaSX_ID = g.NhaSX_ID order by p.DonGia asc");
            SqlDataReader dr = SqlDatabase.ExecuteQueryWithDataReader(Sql, CommandType.Text);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    SanPham sp = new SanPham()
                    {
                        SP_ID = int.Parse(dr[0].ToString()),
                        TenSP = dr[1].ToString(),
                        TenNhaSX = dr[2].ToString(),
                        DonGia = float.Parse(dr[3].ToString()),
                        Hinh = dr[4].ToString(),
                    };
                    listrun.Add(sp);
                }
            }
            return listrun;
        }

        public List<SanPham> SpAcer()
        {
            List<SanPham> listacer = new List<SanPham>();
            string Sql = ("select p.SP_ID,p.TenSP,p.DonGia, p.Hinh from SanPham p,NhaSX g where p.NhaSX_ID = g.NhaSX_ID and p.NhaSX_ID = 1");
            SqlDataReader dr = SqlDatabase.ExecuteQueryWithDataReader(Sql, CommandType.Text);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    SanPham sp = new SanPham()
                    {
                        SP_ID = int.Parse(dr[0].ToString()),
                        TenSP = dr[1].ToString(),
                        DonGia = float.Parse(dr[2].ToString()),
                        Hinh = dr[3].ToString(),
                    };
                    listacer.Add(sp);
                }
            }
            return listacer;
        }

        public List<SanPham> SpSam()
        {
            List<SanPham> listsam = new List<SanPham>();
            string Sql = ("select p.SP_ID,p.TenSP,p.DonGia, p.Hinh from SanPham p,NhaSX g where p.NhaSX_ID = g.NhaSX_ID and p.NhaSX_ID = 2");
            SqlDataReader dr = SqlDatabase.ExecuteQueryWithDataReader(Sql, CommandType.Text);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    SanPham sp = new SanPham()
                    {
                        SP_ID = int.Parse(dr[0].ToString()),
                        TenSP = dr[1].ToString(),
                        DonGia = float.Parse(dr[2].ToString()),
                        Hinh = dr[3].ToString(),
                    };
                    listsam.Add(sp);
                }
            }
            return listsam;
        }

        public List<SanPham> SpHP()
        {
            List<SanPham> listhp = new List<SanPham>();
            string Sql = ("select p.SP_ID,p.TenSP,p.DonGia, p.Hinh from SanPham p,NhaSX g where p.NhaSX_ID = g.NhaSX_ID and p.NhaSX_ID = 3 ");
            SqlDataReader dr = SqlDatabase.ExecuteQueryWithDataReader(Sql, CommandType.Text);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    SanPham sp = new SanPham()
                    {
                        SP_ID = int.Parse(dr[0].ToString()),
                        TenSP = dr[1].ToString(),
                        DonGia = float.Parse(dr[2].ToString()),
                        Hinh = dr[3].ToString(),
                    };
                    listhp.Add(sp);
                }
            }
            return listhp;
        }

        public List<SanPham> SpDell()
        {
            List<SanPham> listdell = new List<SanPham>();
            string Sql = ("select p.SP_ID,p.TenSP,p.DonGia, p.Hinh from SanPham p,NhaSX g where p.NhaSX_ID = g.NhaSX_ID and p.NhaSX_ID = 4 ");
            SqlDataReader dr = SqlDatabase.ExecuteQueryWithDataReader(Sql, CommandType.Text);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    SanPham sp = new SanPham()
                    {
                        SP_ID = int.Parse(dr[0].ToString()),
                        TenSP = dr[1].ToString(),
                        DonGia = float.Parse(dr[2].ToString()),
                        Hinh = dr[3].ToString(),
                    };
                    listdell.Add(sp);
                }
            }
            return listdell;
        }

        public List<SanPham> SpApple()
        {
            List<SanPham> listapple = new List<SanPham>();
            string Sql = ("select p.SP_ID,p.TenSP,p.DonGia, p.Hinh from SanPham p,NhaSX g where p.NhaSX_ID = g.NhaSX_ID and p.NhaSX_ID = 5 ");
            SqlDataReader dr = SqlDatabase.ExecuteQueryWithDataReader(Sql, CommandType.Text);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    SanPham sp = new SanPham()
                    {
                        SP_ID = int.Parse(dr[0].ToString()),
                        TenSP = dr[1].ToString(),
                        DonGia = float.Parse(dr[2].ToString()),
                        Hinh = dr[3].ToString(),
                    };
                    listapple.Add(sp);
                }
            }
            return listapple;
        }

        public List<SanPham> Category(int ID)
        {
            List<SanPham> list = new List<SanPham>();
            string Sql = ("select p.SP_ID,p.TenSP,p.NhaSX_ID ,p.DonGia,p.Hinh from SanPham p where p.NhaSX_ID = @ID");
            SqlParameter id = new SqlParameter("@ID", ID);
            SqlDataReader rd = SqlDatabase.ExecuteQueryWithDataReader(Sql, CommandType.Text, id);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    TonKho tk = new TonKho();
                    SanPham sp = new SanPham()
                    {
                        SP_ID = int.Parse(rd[0].ToString()),
                        TenSP = rd[1].ToString(),
                        DonGia = float.Parse(rd[3].ToString()),
                        Hinh = rd[4].ToString(),

                    };
                    list.Add(sp);
                }
            }
            return list;
        }

        public SanPham Detail(int ID)
        {

            string Sql = "select * "
                            + " from SanPham sp where SP_ID=@SP_ID";
            SqlParameter spid = new SqlParameter("@SP_ID", ID);
            SqlDataReader rd = SqlDatabase.ExecuteQueryWithDataReader(Sql, CommandType.Text, spid);
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
                    return sp;
                }
            }
            return null;
        }



        public SanPham Searchid(int ID)
        {
            string sql = ("select * from SanPham where SP_ID = @ID");
            SqlParameter id = new SqlParameter("@ID", ID);
            SqlDataReader ds = SqlDatabase.ExecuteQueryWithDataReader(sql, CommandType.Text, id);
            if(ds.HasRows)
            {
                while(ds.Read())
                {
                    SanPham sp = new SanPham()
                    {
                        SP_ID = int.Parse(ds[0].ToString()),
                        TenSP = ds[1].ToString(),
                        NhaSX_ID = int.Parse(ds[2].ToString()),
                        CPU = ds[3].ToString(),
                        RAM = ds[4].ToString(),
                        HDD = ds[5].ToString(),
                        BaoHanh = ds[6].ToString(),
                        DonGia = float.Parse(ds[7].ToString()),
                        Hinh = ds[8].ToString(),
                        MoTa = ds[9].ToString(),
                    };
                    return sp;
                }
            } 
            return null;
        }

        public bool Create(SanPham sp)
        {
            
            string sql = ("select * from SanPham");
            DataSet ds = SqlDatabase.ExecuteQueryWithDataSet(sql, CommandType.Text);
            if(ds.Tables[0].Rows.Count >0)
            {
                string ID = ds.Tables[0].Rows[0]["ID"].ToString();
                ID = int.Parse(ID).ToString();
            }
            else
            {
                sp.SP_ID = 1;
            }
            try
            {
            string Sql = "insert into SanPham values (SP_ID = @ID, TenSP = @Ten, NhaSX_ID = @nsxID, CPU = @cpu, RAM = @ram, HDD = @hdd, BaoHanh = @baohanh, DonGia = @dongia, Hinh = @Hinh, Mota = @mota)";
            SqlParameter spid = new SqlParameter("@SP_ID", sp.SP_ID);
            SqlParameter tensp = new SqlParameter("@Ten", sp.TenSP);
            SqlParameter nhasx = new SqlParameter("@nsxID", sp.NhaSX_ID);
            SqlParameter cpu = new SqlParameter("@cpu", sp.CPU);
            SqlParameter ram = new SqlParameter("@ram", sp.RAM);
            SqlParameter hdd = new SqlParameter("@hdd", sp.HDD);
            SqlParameter baohanh = new SqlParameter("@baohanh", sp.BaoHanh);
            SqlParameter dongia = new SqlParameter("@dongia", sp.DonGia);
            SqlParameter hinh = new SqlParameter("@Hinh", sp.Hinh);
            SqlParameter mota = new SqlParameter("@mota", sp.MoTa);
            SqlDatabase.ExecuteNonQuery(Sql, CommandType.Text, spid, tensp, nhasx, cpu, ram, hdd, baohanh, dongia, hinh, mota);
            return true;
                }
            catch
            {
                return false;
            }
        }

        public bool Edit(SanPham sp, int ID)
        {
            try
            {
                string sql = "update SanPham set TenSP=@TenSP,NhaSX_ID=@NhaSX_ID,CPU=@CPU,RAM=@RAM,HDD=@HDD,BaoHanh=@BaoHanh,DonGia=@DonGia,Hinh=@Hinh,MoTa=@MoTa where SP_ID = @ID";
                SqlParameter id = new SqlParameter("@ID", ID);
                SqlParameter spid = new SqlParameter("@SP_ID", sp.SP_ID);
                SqlParameter tensp = new SqlParameter("@TenSP", sp.TenSP);
                SqlParameter nhasx = new SqlParameter("@NhaSX_ID", sp.NhaSX_ID);
                SqlParameter cpu = new SqlParameter("@CPU", sp.CPU);
                SqlParameter ram = new SqlParameter("@RAM", sp.RAM);
                SqlParameter hdd = new SqlParameter("@HDD", sp.HDD);
                SqlParameter baohanh = new SqlParameter("@BaoHanh", sp.BaoHanh);
                SqlParameter dongia = new SqlParameter("@DonGia", sp.DonGia);
                SqlParameter hinh = new SqlParameter("@Hinh", sp.Hinh);
                SqlParameter mota = new SqlParameter("@MoTa", sp.MoTa);
                SqlDatabase.ExecuteNonQuery(sql, CommandType.Text, spid, tensp, nhasx, cpu, ram, hdd, baohanh, dongia, hinh, mota);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int ID)
        {
            try
            {
                string Sql = "delete SanPham where SP_ID = @ID";
                SqlParameter id = new SqlParameter("@ID", ID);
                SqlDatabase.ExecuteNonQuery(Sql, CommandType.Text, id);
                return true;
            }
            catch
            {
                return false;
            }

        }


        public List<SanPham> listpro()
        {
            List<SanPham> list = new List<SanPham>();
            string Sql = ("select * from SanPham");
            SqlDataReader ds = SqlDatabase.ExecuteQueryWithDataReader(Sql, CommandType.Text);
            if(ds.HasRows)
            {
                while(ds.Read())
                {
                    SanPham sp = new SanPham()
                    {
                        SP_ID = int.Parse(ds[0].ToString()),
                        TenSP = ds[1].ToString(),
                        NhaSX_ID = int.Parse(ds[2].ToString()),
                        CPU = ds[3].ToString(),
                        RAM = ds[4].ToString(),
                        HDD = ds[5].ToString(),
                        BaoHanh = ds[6].ToString(),
                        DonGia = float.Parse(ds[7].ToString()),
                        Hinh = ds[8].ToString(),
                        MoTa = ds[9].ToString(),
                    };
                    list.Add(sp);
                }
            }
            return list;
        }
    }

}
