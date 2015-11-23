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
            //Ds_NhaSX();
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

                 string duongdan = string.Format("../../../Webform/Hinh/Laptop/{0}", name);
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
        public void HienThiDanhSachNSX()
        {
            List<NhaSX> ListNSX = NhaSXClient.HienThiNhaSX().ToList();
            cbNhaSX.ValueMember = "NhaSX_ID";
            cbNhaSX.DisplayMember = "TenNhaSX";
            cbNhaSX.DataSource = ListNSX;

            cbTimNhaSX.ValueMember = "NhaSX_ID";
            cbTimNhaSX.DisplayMember = "TenNhaSX";
            cbTimNhaSX.DataSource = ListNSX;
        }
    }
}
