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
using WinForm.SanPhamServiceReference;
using WinForm.TonKhoServiceReference;

namespace WinForm
{
    public partial class QuanLyPhieuNhap : Form
    {
        
        WinForm.PhieuNhapServiceReference1.PhieuNhap pn1 = new WinForm.PhieuNhapServiceReference1.PhieuNhap();
        WinForm.SanPhamServiceReference.PhieuNhap pn = new WinForm.SanPhamServiceReference.PhieuNhap();
        CtPhieuNhap ctpn = new CtPhieuNhap();
        PhieuNhapService1Client PhieuNhapClient = new PhieuNhapService1Client();
        CtPhieuNhapService1Client CtPhieuNhapClient = new CtPhieuNhapService1Client();

        //nha sx
        NhaSX nsx = new NhaSX();
        NhaSXService1Client NhaSXClient = new NhaSXService1Client();

        // san pham 
        SanPham sp = new SanPham();
        SanPhamService1Client SanPhamClient = new SanPhamService1Client();

        // ton kho
        TonKho tk = new TonKho();
        TonKhoService1Client TonKhoClient = new TonKhoService1Client();
        public QuanLyPhieuNhap()
        {
            InitializeComponent();
            Ds_NhaSX();
            Ds_PhieuNhap();

            cbNhaSX.SelectedIndex = -1;
            cbTim_NSX.SelectedIndex = -1;
        }

        float tongtien;
        public void Ds_PhieuNhap()   
        {
            dgvPhieuNhap.AutoGenerateColumns = false;
            dgvPhieuNhap.DataSource = PhieuNhapClient.HienThiPhieuNhap();
        }
        public void Ds_CtPhieuNhap(string maphieunhap)
        {
            dgvChiTietPhieuNhap.AutoGenerateColumns = false;
            ctpn.MaPhieuNhap = maphieunhap;
            dgvChiTietPhieuNhap.DataSource = CtPhieuNhapClient.HienThiCtPhieuNhap(ctpn);
        }
       

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTimKiem.Text == "Mã phiếu nhập")
                {
                    pn1.MaPhieuNhap = txtTim_MaPN.Text;
                    pn1.NhaSX_ID = 0;
                    pn1.NgayNhap = DateTime.MaxValue;
                }
                else if (cbTimKiem.Text == "Nhà sản xuất")
                {
                    pn1.MaPhieuNhap = "";
                    pn1.NhaSX_ID = int.Parse(cbTim_NSX.SelectedValue.ToString());
                    pn1.NgayNhap = DateTime.MaxValue;
                }
                else
                {
                    pn1.MaPhieuNhap = "";
                    pn1.NhaSX_ID = 0;
                    pn1.NgayNhap = DateTime.Parse(dtpTim_NgayNhap.Value.ToShortDateString());
                }

                dgvPhieuNhap.AutoGenerateColumns = false;
                dgvPhieuNhap.DataSource = PhieuNhapClient.TimKiem(pn1);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi", "Thông báo");
            }
        }

        private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Mã phiếu nhập")
            {
                txtTim_MaPN.Enabled = true;
                cbTim_NSX.Enabled = false;
                dtpTim_NgayNhap.Enabled = false;
            }
            else if (cbTimKiem.Text == "Nhà sản xuất")
            {
                txtTim_MaPN.Enabled = false;
                cbTim_NSX.Enabled = true;
                dtpTim_NgayNhap.Enabled = false;
            }
            else
            {
                txtTim_MaPN.Enabled = false;
                cbTim_NSX.Enabled = false;
                dtpTim_NgayNhap.Enabled = true;
            }
        }

        private void btnCapNhatLai_Click(object sender, EventArgs e)
        {
            Ds_PhieuNhap();
        }

        public string thoigian;
        private void btnThem_Click(object sender, EventArgs e)
        {
            thoigian = DateTime.Now.ToString("yyyyMMddhhmmss");
            cbNhaSX.Enabled = true;
            txtMaPhieuNhap.Text = "PN" + thoigian;
            dtpNgayNhap.Value = DateTime.Now;
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
                        PhieuNhapClient.Them(pn1);
                        MessageBox.Show("Thêm phiếu nhập thành công", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm phiếu nhập không thành công\n" + ex.Message, "Thông báo");
                    }
                    txtMaPhieuNhap.Text = "";
                }
                else
                {
                    MessageBox.Show("Chọn nhà sản xuất", "Thông báo");
                }
                cbNhaSX.SelectedIndex = -1;
                Ds_PhieuNhap();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi", "Thông báo");
            }
        }

        private void btnLuuSanPham_Click(object sender, EventArgs e)
        {
            string maphieunhap = txtMaPhieuNhap.Text;
            int soluongnhap; float dongianhap;

            List<TonKho> list;

            try
            {
                for (int i = 0; i < dgvBangNhap.Rows.Count; i++)
                {
                    if (dgvBangNhap.Rows[i].Cells[2].Value != null && dgvBangNhap.Rows[i].Cells[3].Value != null)
                    {
                        soluongnhap = int.Parse(dgvBangNhap.Rows[i].Cells[2].Value.ToString());
                        dongianhap = float.Parse(dgvBangNhap.Rows[i].Cells[3].Value.ToString());
                        if (soluongnhap > 0 && dongianhap > 0)
                        {
                            ctpn.MaPhieuNhap = maphieunhap;
                            ctpn.SP_ID = int.Parse(dgvBangNhap.Rows[i].Cells[0].Value.ToString());
                            ctpn.SoLuongNhap = soluongnhap;
                            ctpn.DonGiaNhap = dongianhap;
                            tongtien = tongtien + (soluongnhap * dongianhap);
                            CtPhieuNhapClient.Them(ctpn);

                            // cap nhat don gia trong bang san pham
                            sp.SP_ID = int.Parse(dgvBangNhap.Rows[i].Cells[0].Value.ToString());
                            sp.DonGia = dongianhap + (dongianhap * 10 / 100);
                            SanPhamClient.SuaSanPham(sp);

                            // ton kho
                            //bll_tonkho.SP_ID = int.Parse(dgvBangNhap.Rows[i].Cells[0].Value.ToString());
                            tk.SP_ID = int.Parse(dgvBangNhap.Rows[i].Cells[0].Value.ToString());
                            tk.ThoiGian = DateTime.Now;
                            tk.SoLuongTon = soluongnhap;

                            list = TonKhoClient.TimKiemTonKho_SPID(tk).ToList(); // Kiem tra ton kho
                            if (list.Count > 0)
                            {
                                // cap nhat ton kho
                                TonKhoClient.ThemMoi(tk);
                            }
                            else
                            {
                                // them moi
                                TonKhoClient.ThemMoi(tk);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nhập không hợp lệ", "Thông báo lỗi");
                        }
                    }
                }
                Ds_CtPhieuNhap(maphieunhap);
                pn1.MaPhieuNhap = txtMaPhieuNhap.Text;
                pn1.TongTien = tongtien;
                PhieuNhapClient.Sua_TongTien(pn1);
                Ds_PhieuNhap();
                NhapSanPham(int.Parse(cbNhaSX.SelectedValue.ToString()), maphieunhap);

            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi", "Thông báo");
            }
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnLuuSanPham.Enabled = false;
            btnHoanTat.Enabled = false;
        }
        public void Ds_NhaSX() 
        {
            cbNhaSX.ValueMember = "NhaSX_ID";
            cbNhaSX.DisplayMember = "TenNhaSX";
            cbNhaSX.DataSource = NhaSXClient.HienThiNhaSX();

            cbTim_NSX.ValueMember = "NhaSX_ID";
            cbTim_NSX.DisplayMember = "TenNhaSX";
            cbTim_NSX.DataSource = NhaSXClient.HienThiNhaSX();
        }
        public void NhapSanPham(int nhasxid, string maphieunhap)
        {
            pn.NhaSX_ID = nhasxid;
            pn.MaPhieuNhap = maphieunhap;
            dgvBangNhap.AutoGenerateColumns = false;
            DataTable dt = SanPhamClient.ThongTinNhapSP(pn).Tables[0];
            dgvBangNhap.DataSource = dt;
        }

        private void dgvPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maphieunhap = dgvPhieuNhap.CurrentRow.Cells[1].Value.ToString();
            int nhasx_id = int.Parse(dgvPhieuNhap.CurrentRow.Cells[2].Value.ToString());
            Ds_CtPhieuNhap(maphieunhap);

            NhapSanPham(nhasx_id, maphieunhap);

            txtMaPhieuNhap.Text = maphieunhap;
            cbNhaSX.SelectedValue = nhasx_id;
            dtpNgayNhap.Value = DateTime.Parse(dgvPhieuNhap.CurrentRow.Cells[4].Value.ToString());
            tongtien = float.Parse(dgvPhieuNhap.CurrentRow.Cells[5].Value.ToString());
            txtTongTien.Text = tongtien.ToString("#,##0");

            if (dgvBangNhap.Rows.Count > 0)
            {
                btnHoanTat.Enabled = true;
                btnLuuSanPham.Enabled = true;
            }
            else
            {
                btnHoanTat.Enabled = false;
                btnLuuSanPham.Enabled = false;
            }
        }
    }
       
}
