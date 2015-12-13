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
using WinForm.DonDHServiceReference;
using WinForm.CtDonDHServiceReference;
using WinForm.TonKhoServiceReference;

namespace WinForm
{
    public partial class QuanLyDonDatHang : Form
    {
        DonDHService1Client DonDHClient = new DonDHService1Client();
        DonDH ddh = new DonDH();
        CtDonDH ctddh = new CtDonDH();
        CtDonDHServiceClient CtDonDHClient = new CtDonDHServiceClient();
        TonKhoService1Client TonKhoClient = new TonKhoService1Client();
        TonKho tk = new TonKho();
        public QuanLyDonDatHang()
        {
            InitializeComponent();
            Ds_DonDH();
        }
        public void Ds_DonDH()  //R
        {
            dgvDonDH.AutoGenerateColumns = false;
            dgvDonDH.DataSource = DonDHClient.HienThiDonDH();
        }
        private void Ds_CtDonDH(CtDonDH ct)  //R
        {
            dgvChiTietDonDH.AutoGenerateColumns = false;
            dgvChiTietDonDH.DataSource = CtDonDHClient.HienThiCtDonDH(ct);
        }
        private void dgvDonDH_Click(object sender, EventArgs e)  //R
        {
            int vitri = dgvDonDH.CurrentRow.Index;
            List<DonDH> list = DonDHClient.HienThiDonDH().ToList();
            ddh = list[vitri];

            txtHoTenKH.Text = ddh.HoTenKH;
            txtDiaChi.Text = ddh.DiaChi;
            txtDienThoai.Text = ddh.DienThoai;
            txtEmail.Text = ddh.Email;
            txtGhiChu.Text = ddh.GhiChu;
            cbTinhTrang.SelectedItem = ddh.TinhTrang;

            string madondh = dgvDonDH.CurrentRow.Cells[1].Value.ToString();

            ctddh.MaDonDH = madondh;
            Ds_CtDonDH(ctddh);
        }
      
        private void btnTimKiem_Click(object sender, EventArgs e)  //R
        {
            if (cbTimKiem.Text == "Mã đơn đặt hàng")
            {
                if (txtTim_MaDonDH.Text != "")
                {
                    dgvDonDH.AutoGenerateColumns = false;
                    dgvDonDH.DataSource = DonDHClient.TimKiem(txtTim_MaDonDH.Text, DateTime.Now);
                }
                else
                {
                    MessageBox.Show("Nhập mã đơn đặt hàng");
                }
            }
            else if (cbTimKiem.Text == "Ngày đặt")
            {
                dgvDonDH.AutoGenerateColumns = false;
                dgvDonDH.DataSource = DonDHClient.TimKiem("", dtpTim_NgayDat.Value);
            }
            else
            {
                dgvDonDH.AutoGenerateColumns = false;
                string tt = cbTimTinhTrang.SelectedItem.ToString();
                dgvDonDH.DataSource = DonDHClient.TimKiem_TinhTrang(tt);
            }
        }

        private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)  //R
        {
            if (cbTimKiem.Text == "Mã đơn đặt hàng")
            {
                txtTim_MaDonDH.Enabled = true;
                dtpTim_NgayDat.Enabled = false;
                cbTimTinhTrang.Enabled = false;
            }
            else if (cbTimKiem.Text == "Ngày đặt")
            {
                txtTim_MaDonDH.Enabled = false;
                dtpTim_NgayDat.Enabled = true;
                cbTimTinhTrang.Enabled = false;
            }
            else
            {
                txtTim_MaDonDH.Enabled = false;
                dtpTim_NgayDat.Enabled = false;
                cbTimTinhTrang.Enabled = true;
            }
        }

        private void btnCapNhatLai_Click(object sender, EventArgs e) //R
        {
            Ds_DonDH();
            cbTimKiem.SelectedIndex = 0;
            cbTimTinhTrang.SelectedIndex = 0;
        }

        private void cbTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e) //R
        {
            string tinhtrang = dgvDonDH.CurrentRow.Cells[5].Value.ToString();
            if (tinhtrang == "Chưa giao hàng")
            {
                cbTinhTrang.Enabled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e) //R
        {
            try
            {
                string madondh = dgvDonDH.CurrentRow.Cells[1].Value.ToString();
                string tinhtrang = cbTinhTrang.SelectedItem.ToString();
                ddh.MaDonDH = madondh;
                ddh.TinhTrang = tinhtrang;
                DonDHClient.SuaTinhTrang(ddh);
                Ds_DonDH();
                cbTinhTrang.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e) //R
        {
            string thoigian = DateTime.Now.ToString("yyyyMMddhhmmss");
            if (MessageBox.Show("Chương trình sẽ xóa đơn đặt hàng và chi tiết ?", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    // lay ma don dh
                    ctddh.MaDonDH = dgvDonDH.CurrentRow.Cells[1].Value.ToString();

                    // cap nhat ton kho
                    List<CtDonDH> list_ct = CtDonDHClient.HienThiCtDonDH(ctddh).ToList();
                    for (int i = 0; i < list_ct.Count; i++)
                    {
                        ctddh = list_ct[i];
                        tk.SP_ID = ctddh.SP_ID;
                        tk.ThoiGian = DateTime.Now;
                        tk.SoLuongTon = ctddh.SoLuongDat;
                        TonKhoClient.ThemMoi(tk);
                    }

                    // xoa chi tiet
                    //bll_ctdondh.MaDonDH = dgvDonDH.CurrentRow.Cells[1].Value.ToString();
                    CtDonDHClient.Xoa(ctddh);

                    // xoa don dat hang
                    ddh.MaDonDH = dgvDonDH.CurrentRow.Cells[1].Value.ToString();
                    DonDHClient.Xoa(ddh);


                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa không thành công\nLỗi: " + ex.Message, "Thông báo");
                }
                Ds_DonDH();
                dgvChiTietDonDH.AutoGenerateColumns = false;
                dgvChiTietDonDH.DataSource = null;
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)  //R
        {
            cbTinhTrang.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Ds_DonDH();
        }

        private void dgvDonDH_CellContentClick(object sender, DataGridViewCellEventArgs e) //R
        {
            int vitri = dgvDonDH.CurrentRow.Index;
            List<DonDH> list = DonDHClient.HienThiDonDH().ToList();
            ddh = list[vitri];

            txtHoTenKH.Text = ddh.HoTenKH;
            txtDiaChi.Text = ddh.DiaChi;
            txtDienThoai.Text = ddh.DienThoai;
            txtEmail.Text = ddh.Email;
            txtGhiChu.Text = ddh.GhiChu;
            cbTinhTrang.SelectedItem = ddh.TinhTrang;

            string madondh = dgvDonDH.CurrentRow.Cells[1].Value.ToString();

            ctddh.MaDonDH = madondh;
            Ds_CtDonDH(ctddh);
        }

    }
}
