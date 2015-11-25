using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.NhaSXServiceReference;
namespace WinForm
{
    public partial class QuanLyNhaSX : Form
    {
        NhaSXService1Client NhaSXClient = new NhaSXService1Client();
        NhaSX NhaSX = new NhaSX();
        bool them_moi = false;

        public QuanLyNhaSX()
        {
            InitializeComponent();
        }
        //Hiển thị danh sách nhà sản xuất
        private void Frm_QuanLyNhaSX_Load(object sender, EventArgs e)
        {
            Ds_NhaSX();
        }
        //Đổ ds sản phẩm vào datagridview
        public void Ds_NhaSX()
        {
            dgvNhaSX.AutoGenerateColumns = false;
            dgvNhaSX.DataSource = NhaSXClient.HienThiNhaSX();
        }
        //Hiển thị chi tiết nhà sản xuất khi chọn nhàn sản xuất
        private void dgvNhaSX_Click(object sender, EventArgs e)
        {
            int vitri = dgvNhaSX.CurrentRow.Index;
            List<NhaSX> list = NhaSXClient.HienThiNhaSX().ToList();
            NhaSX = list[vitri];
            txtNhaSXID.Text = NhaSX.NhaSX_ID.ToString();
            txtTenNhaSX.Text = NhaSX.TenNhaSX.ToString();
        }
        private void LamMoi()
        {
            txtTenNhaSX.Text = "";
            txtNhaSXID.Text = "";
        }
        //Hàm tự viết
        //làm mờ các control
        void MoControl(bool trangthai)
        {
            btnThem.Enabled = !trangthai;
            btnSua.Enabled = !trangthai;
            btnXoa.Enabled = !trangthai;
            btnLuu.Enabled = trangthai;
            btnHuy.Enabled = trangthai;

            txtTenNhaSX.Enabled = trangthai;
        }
        //Thêm mới nhà sản xuất
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenNhaSX.Enabled = true;
            LamMoi();
            them_moi = true;
            MoControl(true);
        }
        //Lưu thông tin xuống csdl
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them_moi == true)
            {
                if (txtTenNhaSX.Text != "")
                {
                    try
                    {
                        NhaSX.TenNhaSX = txtTenNhaSX.Text.Trim();
                        NhaSXClient.ThemNSX(NhaSX);
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        LamMoi();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm không thành công\nLỗi: " + ex.Message, "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập thông tin", "Thông báo");
                }
            }
            else
            {
                if (txtTenNhaSX.Text != "")
                {
                    try
                    {
                        NhaSX.TenNhaSX = txtTenNhaSX.Text.Trim();
                        NhaSXClient.SuaNSX(NhaSX);
                        MessageBox.Show("Sửa thành công", "Thông báo");
                        LamMoi();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa không thành công\nLỗi: " + ex.Message, "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập thông tin", "Thông báo");
                }
            }
            MoControl(false);

            Ds_NhaSX();
        }
        //Hàm tự viết
        //Xử lý control khi bấm vào nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTenNhaSX.Enabled = true;
            them_moi = false;
            MoControl(true);
        }
        //Hủy thao tác hiện tại
        private void btnHuy_Click(object sender, EventArgs e)
        {
            MoControl(false);
            LamMoi();
        }
        //Xóa nhà cũng cấp
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa nhà cung cấp", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    NhaSX.NhaSX_ID = int.Parse(txtNhaSXID.Text);
                    NhaSXClient.XoaNSX(NhaSX);
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa không thành công\nLỗi: " + ex.Message, "Thông báo");
                }
                Ds_NhaSX();
            }
        }
    }
}