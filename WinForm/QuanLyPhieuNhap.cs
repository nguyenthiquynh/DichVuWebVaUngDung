using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;

using WinForm.PhieuNhapServiceReference1;
using WinForm.CtPhieuNhapServiceReference;
using WinForm.NhaSXServiceReference;
using WinForm.TonKhoServiceReference;
using WinForm.SanPhamServiceReference;

namespace WinForm
{
    public partial class QuanLyPhieuNhap : Form
    {
        //Phieu Nhap
      
        WinForm.PhieuNhapServiceReference1.PhieuNhap pn1 = new WinForm.PhieuNhapServiceReference1.PhieuNhap();
        PhieuNhap1Service1Client PhieuNhapClient = new PhieuNhap1Service1Client();
        //CtPhieuNhap
        CtPhieuNhap ctpn = new CtPhieuNhap();
        CtPhieuNhapService1Client CtPhieuNhapClient = new CtPhieuNhapService1Client();

        //NhaSX
        NhaSX nsx = new NhaSX();
        NhaSXService1Client NhaSXClient = new NhaSXService1Client();

        //SanPham
        SanPham sp = new SanPham();
        SanPhamService1Client SanPhamClient = new SanPhamService1Client();

        // TonKho
        TonKho tk = new TonKho();
        TonKhoService1Client TonKhoClient = new TonKhoService1Client();

        public QuanLyPhieuNhap()
        {
            InitializeComponent();
        }
        public void Ds_PhieuNhap()
        {
            dgvPhieuNhap.AutoGenerateColumns = false; //Không tự tạo các column theo DataSource .
            dgvPhieuNhap.DataSource = PhieuNhapClient.HienThiPhieuNhap();
        }

        private void txtTim_MaPN_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTimKiem.Text == "Mã phiếu nhập")
            {
                txtMaPhieuNhap.Enabled =true;
                cbTim_NSX.Enabled = false;
                dtpNgayNhap.Enabled =false;

            }
            else if (cbTimKiem.Text == "Nhà sản xuất")
            {
                txtMaPhieuNhap.Enabled =false;
                cbTim_NSX.Enabled = true;
                dtpNgayNhap.Enabled = false;
            }
            else
            {
                txtMaPhieuNhap.Enabled = false;
                cbTim_NSX.Enabled = false;
                dtpNgayNhap.Enabled = true;
            }
                
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(cbTimKiem.Text =="Mã phiếu nhập")
            {
                pn1.MaPhieuNhap = (txtMaPhieuNhap.Text);
                pn1.NgayNhap = DateTime.MaxValue;
                pn1.NhaSX_ID = 0;
            }
            else if(cbTimKiem.Text == "Nhà sản xuất")
            {
                pn1.MaPhieuNhap = "";
                pn1.NgayNhap = DateTime.MaxValue;
                pn1.NhaSX_ID = int.Parse(cbTim_NSX.SelectedValue.ToString());

            }
            else
            {
                pn1.MaPhieuNhap = "";
                pn1.NgayNhap = DateTime.Parse(dtpTim_NgayNhap.Value.ToShortDateString());
            }
            dgvPhieuNhap.AutoGenerateColumns = false;
            dgvPhieuNhap.DataSource = PhieuNhapClient.TimKiemPN(pn1);
        }

        private void btnCapNhatLai_Click(object sender, EventArgs e)
        {
            Ds_PhieuNhap();
        }

        public string thoigian;
        private void btnThem_Click(object sender, EventArgs e)
        {
            thoigian = DateTime.Now.ToString("yyyyMMddhhmmss");
            txtMaPhieuNhap.Text= "PN" + thoigian;
            dtpNgayNhap.Value = DateTime.Now;
            cbNhaSX.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                    pn1.MaPhieuNhap = txtMaPhieuNhap.Text;
                    pn1.NhaSX_ID = int.Parse(cbNhaSX.SelectedValue.ToString());
                    pn1.NgayNhap = dtpNgayNhap.Value;
                    pn1.TongTien = 0;
                    if (cbNhaSX.SelectedIndex != -1)
                    {
                        try
                        {
                            PhieuNhapClient.ThemPN(pn1);
                            MessageBox.Show("Thêm Phiếu Nhập Thành Công", "Thông Báo");
                        }
                        catch
                        {
                            MessageBox.Show("Thêm Phiếu Nhập Thất Bại", "Thông Báo");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Chọn Nhà Sản Xuất","Thông báo");
                    }
                    cbNhaSX.SelectedIndex = -1;
                    Ds_PhieuNhap();

            }
            catch
            {
                MessageBox.Show("Xẩy ra lỗi", "Thông báo");
            }
        }
        public void Ds_ChiTietPhieuNhap(string maphieunhap)
        {
            dgvChiTietPhieuNhap.AutoGenerateColumns = false;
            ctpn.maphieunhap = maphieunhap;// lỗi
            dgvChiTietPhieuNhap.DataSource = CtPhieuNhapClient.HienThiCtPhieuNhap(ctpn);
           
        }
    }
}
