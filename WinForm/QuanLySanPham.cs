using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using WinForm.SanPhamServiceReference;
using WinForm.PhieuNhapServiceReference1;
using WinForm.TonKhoServiceReference;
using WinForm.NhaSXServiceReference;
namespace WinForm
{
    public partial class QuanLySanPham : Form
    {
        SanPhamService1Client SanPhamClient = new SanPhamService1Client();
        TonKhoService1Client TonKhoClient = new TonKhoService1Client();
        NhaSXService1Client NhaSXClient = new NhaSXService1Client();
        SanPham sp = new SanPham();
        TonKho tk = new TonKho();

        //
        string name = "";
        bool them_moi = false;
        //Hàm khỏi tạo 
        public QuanLySanPham()
        {
            InitializeComponent();
            Ds_SanPham();
            Ds_NhaSX();
        }
        //Hiển thị danh sách sản phẩm lên datagridview
        public void Ds_SanPham()
        {
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.DataSource = SanPhamClient.HienThiSanPhamFull();
        }
        //Hiển thị chi tiết sản phẩm khi chọn sản phẩm ở danh sách
        private void dgvSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dgvSanPham.CurrentRow.Index;
                int sp_id = int.Parse(dgvSanPham.Rows[vitri].Cells[0].Value.ToString());
                sp.SP_ID = sp_id;
                DataSet ds = SanPhamClient.ChiTietSanPham(sp);

                txtTenSP.Text = ds.Tables[0].Rows[0]["TenSP"].ToString();
                cbNhaSX.SelectedValue = int.Parse(ds.Tables[0].Rows[0]["NhaSX_ID"].ToString());
                txtBaoHanh.Text = ds.Tables[0].Rows[0]["BaoHanh"].ToString();
                txtCPU.Text = ds.Tables[0].Rows[0]["CPU"].ToString();
                txtDonGia.Text = ds.Tables[0].Rows[0]["DonGia"].ToString();
                txtHDD.Text = ds.Tables[0].Rows[0]["HDD"].ToString();
                txtMoTa.Text = ds.Tables[0].Rows[0]["MoTa"].ToString();
                txtRAM.Text = ds.Tables[0].Rows[0]["MoTa"].ToString();
                txtSoLuongTon.Text = ds.Tables[0].Rows[0]["SoLuongTon"].ToString();

                name = ds.Tables[0].Rows[0]["Hinh"].ToString();

                string duongdan = string.Format("../../../Winform/Hinh1/{0}", name);
                picHinh.Load(duongdan);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi", "Thông báo");
            }
        }
        //Xử lý ẩn/hiện các control 
        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.Text == "Tên sản phẩm")
            {
                cbTimGia.Visible = false;
                cbNhaSX.Visible = false;
                txttimkiem.Visible = true;
            }
            else
            {
                txttimkiem.Visible = false;
                cbTimGia.Visible = true;
                cbTimNhaSX.Visible = true;
                cbTimGia.SelectedIndex = -1;
                cbTimNhaSX.SelectedIndex = -1;
            }
        }
        //Hiển thị danh sách nhà sản xuất
        public void Ds_NhaSX()
        {
            List<NhaSX> ListNSX = NhaSXClient.HienThiNhaSX().ToList();
            cbNhaSX.ValueMember = "NhaSX_ID";
            cbNhaSX.DisplayMember = "TenNhaSX";
            cbNhaSX.DataSource = ListNSX;

            cbTimNhaSX.ValueMember = "NhaSX_ID";
            cbTimNhaSX.DisplayMember = "TenNhaSX";
            cbTimNhaSX.DataSource = ListNSX;
        }
        // Làm mới control
        public void LamMoi()
        {
            txtBaoHanh.Text = "";
            txtCPU.Text = "";            
            txtHDD.Text = "";
            txtMoTa.Text = "";
            txtRAM.Text = "";
            txtTenSP.Text = "";
            txtDonGia.Text = "0";
            txtSoLuongTon.Text = "0";
            cbNhaSX.SelectedIndex = 0;
        }
        //Làm mờ control
        public void MoControl(bool trangthai)
        {
            txtTenSP.Enabled = trangthai;
            cbNhaSX.Enabled = trangthai;
            txtBaoHanh.Enabled = trangthai;
            txtCPU.Enabled = trangthai;
            txtRAM.Enabled = trangthai;
            txtHDD.Enabled = trangthai;
            txtMoTa.Enabled = trangthai;
            //txtDonGia.Enabled = trangthai;
            //txtSoLuongTon.Enabled = trangthai;
        }
        //Xử lý control khi bấm nút thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            MoControl(true);
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThemHinh.Enabled = true;
            picHinh.InitialImage = null;
            LamMoi();
            them_moi = true;
        }
        //Xử lý các control khi bấm nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text != "")
            {
                MoControl(true);

                btnSua.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
                btnThemHinh.Enabled = true;
                them_moi = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa", "Thông báo");
            }
        }
        //Xóa sản phẩm
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chương trình sẽ xóa sản phẩm ?", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    int sp_id = int.Parse(dgvSanPham.CurrentRow.Cells[0].Value.ToString());
                    sp.SP_ID = sp_id;

                    tk.SP_ID = sp_id;
                    TonKhoClient.XoaTonKho(tk);

                    SanPhamClient.XoaSanPham(sp);
                    MessageBox.Show("Xóa thành công", "Thông báo");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa không thành công\nLỗi: " + ex.Message, "Thông báo");
                }
            }
            Ds_SanPham();
            LamMoi();
        }
        //Xử lý các control khi bấm nút Hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Ds_SanPham();
            LamMoi();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtDonGia.Enabled = false;
            btnThemHinh.Enabled = false;

            MoControl(false);
        }
        //Kiểm tra xem các textbox đã nhập chưa
        bool KiemTra()
        {
            if (txtTenSP.Text == "" || txtBaoHanh.Text == "" || txtCPU.Text == "" || txtHDD.Text == "" || txtRAM.Text == ""
                || txtMoTa.Text == "" || txtDonGia.Text == "")
                return false;
            return true;
        }
        //Lưu thông tin xuống csdl
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                sp.TenSP = txtTenSP.Text;
                sp.NhaSX_ID = int.Parse(cbNhaSX.SelectedValue.ToString());
                sp.BaoHanh = txtBaoHanh.Text;
                sp.HDD = txtHDD.Text;
                sp.MoTa = txtMoTa.Text;
                sp.RAM = txtRAM.Text;
                sp.CPU = txtCPU.Text;
                sp.Hinh = name;
                sp.DonGia = float.Parse(txtDonGia.Text);
                if (KiemTra() == true)
                {

                    if (them_moi == false)
                    {
                        try
                        {
                            SanPhamClient.SuaSanPham(sp);
                            MessageBox.Show("Sửa thành công", "Thông báo");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Sửa không thành công\n" + ex.Message, "Thông báo");
                        }
                    }
                    else
                    {
                        try
                        {
                            SanPhamClient.ThemSanPham(sp);
                            MessageBox.Show("Thêm thành công", "Thông báo");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Sửa không thành công\n" + ex.Message, "Thông báo");
                        }
                    }
                    Ds_SanPham();
                    LamMoi();
                    MoControl(false);
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;
                    btnThemHinh.Enabled = false;
                    txtDonGia.Enabled = false;

                    // cap nhat hinh anh
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi", "Thông báo");
            }
        }
        // Xử lý control tìm kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (type.Text == "Tên sản phẩm")
            {
                if (txttimkiem.Text != "")
                {
                    if (SanPhamClient.TimKiemSanPham(txttimkiem.Text, 0, 0, 0).Count() > 0)
                    {
                        dgvSanPham.AutoGenerateColumns = false;
                        dgvSanPham.DataSource = SanPhamClient.TimKiemSanPham(txttimkiem.Text, 0, 0, 0);
                    }
                    else
                    {
                        dgvSanPham.DataSource = null;
                        MessageBox.Show("Không có sản phẩm cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Nhập tên sản phẩm", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    int nhasxid = int.Parse(cbTimNhaSX.SelectedValue.ToString());
                    string dongia = cbTimGia.SelectedItem.ToString();
                    string[] gia = dongia.Split('-');
                    decimal dongiatu = decimal.Parse(gia[0].ToString());
                    decimal dongiaden = decimal.Parse(gia[1].ToString());

                    dgvSanPham.AutoGenerateColumns = false;
                    if (SanPhamClient.TimKiemSanPham("", nhasxid, dongiatu, dongiaden).Count() > 0)
                    {
                        dgvSanPham.AutoGenerateColumns = false;
                        dgvSanPham.DataSource = SanPhamClient.TimKiemSanPham("", nhasxid, dongiatu, dongiaden);
                    }
                    else
                    {
                        dgvSanPham.DataSource = null;
                        MessageBox.Show("Không có sản phẩm cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Chọn nhà sản xuất và khoảng giá", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //Chọn hình ảnh cho sản phẩm
        private void btnThemHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                picHinh.Load(f.FileName);
                name = f.SafeFileName;
                string duongdanmoi = "../../../WinForm/Hinh1/" + name;
                File.Copy(f.FileName, duongdanmoi);
                MessageBox.Show(name);
            }
        }
        //Hàm tự viết
        //Hiển thị danh sách sản phẩm
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            Ds_SanPham();
        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_QuanLySanPham_Load(object sender, EventArgs e)
        {

        }

        private void type_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (type.SelectedIndex)
            {
                case 0:
                    txttimkiem.Visible = true;
                    cbTimNhaSX.Visible = false;
                    cbTimGia.Visible = false;
                    break;
                case 1:
                    txttimkiem.Visible = false;
                    cbTimNhaSX.Visible = true;
                    cbTimGia.Visible = true;
                    break;
            }
        }
    }
}
