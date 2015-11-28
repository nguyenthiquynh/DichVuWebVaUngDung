using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using WinForm.TonKhoServiceReference;

namespace WinForm
{
    public partial class QuanLyTonKho : Form
    {
        // ton kho      
        TonKhoService1Client TonKhoClient = new TonKhoService1Client();
        TonKho tk = new TonKho();

        public QuanLyTonKho()
        {
            InitializeComponent();
            Ds_TonKho();
            LocSoLuongTon();
            NamThang();
        }
        // Load ds tồn kho
        public void Ds_TonKho()
        {
            dgvTonKho.AutoGenerateColumns = false;
            dgvTonKho.DataSource = TonKhoClient.HienThiTonKho();
        }
        // 
        public void NamThang()
        {
            for (int i = 1; i <= 12; i++)
            {
                cbThang.Items.Add(string.Format("{0}", i));
            }
            cbThang.SelectedIndex = 0;
            for (int j = 2011; j <= 2015; j++)
            {
                cbNam.Items.Add(string.Format("{0}", j));
            }
            cbNam.SelectedIndex = 0;
        }
        // Cập nhật ds Tồn kho
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Ds_TonKho();
            txtSP_ID.Text = "";
        }
        // Lọc tồn kho theo điều kiện
        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTonKho.AutoGenerateColumns = false;
                if (cbLocTonKho.Text == "Sản phẩm ID")
                {
                    int sp_id = int.Parse(txtSP_ID.Text);
                    tk.SP_ID = sp_id;

                    if (TonKhoClient.TimKiemTonKho_SPID(tk).Count() > 0)
                    {
                        dgvTonKho.DataSource = TonKhoClient.TimKiemTonKho_SPID(tk);
                    }
                    else
                    {
                        MessageBox.Show("Không có sản phẩm này", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvTonKho.DataSource = null;
                    }
                }
                else if (cbLocTonKho.Text == "Số lượng tồn")
                {
                    int k = int.Parse(cbSoLuongTon.SelectedIndex.ToString());

                    if (TonKhoClient.TimKiemTonKhoTheoSoLuong(k).Count() > 0)
                    {
                        dgvTonKho.DataSource = TonKhoClient.TimKiemTonKhoTheoSoLuong(k);
                    }
                }
                else if (cbLocTonKho.Text == "Tháng năm")
                {
                    int thang = int.Parse(cbThang.SelectedItem.ToString());
                    int nam = int.Parse(cbNam.SelectedItem.ToString());

                    if (TonKhoClient.TimKiemTonKhoTheoTG(thang, nam).Count() > 0)
                    {
                        dgvTonKho.DataSource = TonKhoClient.TimKiemTonKhoTheoTG(thang, nam);
                    }
                    else
                    {
                        MessageBox.Show("Không có tồn kho trong thời gian này", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvTonKho.DataSource = null;
                    }
                }
                else
                {
                    dgvTonKho.DataSource = TonKhoClient.TimKiemTonKhoTheoKhoangTG(dtNgayTu.Value, dtNgayDen.Value);
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Xảy ra lỗi", "Thông báo");
            }
        }
        // cbx Lọc số lượng tồn
        public void LocSoLuongTon()
        {
            cbSoLuongTon.Items.Insert(0, "Giảm dần");
            cbSoLuongTon.Items.Insert(1, "Tăng dần");
            cbSoLuongTon.SelectedIndex = 0;
        }

        // Hàm tự viết
        // HIển thị điều kiện lọc
        private void cbLocTonKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLocTonKho.Text == "Sản phẩm ID")
            {
                txtSP_ID.Enabled = true;
                cbSoLuongTon.Enabled = false;
                pnThangNam.Enabled = false;
                pnNgayThang.Enabled = false;
            }
            else if (cbLocTonKho.Text == "Số lượng tồn")
            {
                txtSP_ID.Enabled = false;
                cbSoLuongTon.Enabled = true;
                pnThangNam.Enabled = false;
                pnNgayThang.Enabled = false;
            }
            else if (cbLocTonKho.Text == "Tháng năm")
            {
                txtSP_ID.Enabled = false;
                cbSoLuongTon.Enabled = false;
                pnThangNam.Enabled = true;
                pnNgayThang.Enabled = false;
            }
            else
            {
                txtSP_ID.Enabled = false;
                cbSoLuongTon.Enabled = false;
                pnThangNam.Enabled = false;
                pnNgayThang.Enabled = true;
            }
        }

        // Hàm tự viết
        // Chỉ nhập số
        private void txtSP_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

    }
}
