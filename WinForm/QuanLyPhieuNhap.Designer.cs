namespace WinForm
{
    partial class QuanLyPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNhaSX = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCapNhatLai = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtpTim_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cbTim_NSX = new System.Windows.Forms.ComboBox();
            this.txtTim_MaPN = new System.Windows.Forms.TextBox();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBangNhap = new System.Windows.Forms.DataGridView();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuuSanPham = new System.Windows.Forms.Button();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(897, 510);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(889, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phiếu Nhập ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.txtTongTien);
            this.groupBox3.Controls.Add(this.dtpNgayNhap);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbNhaSX);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtMaPhieuNhap);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(877, 159);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thêm phiếu nhập";
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(427, 118);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(182, 35);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu - Cập nhật chi tiết";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(274, 119);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(147, 34);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm phiếu nhập";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtTongTien.Location = new System.Drawing.Point(510, 70);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(141, 23);
            this.txtTongTien.TabIndex = 9;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhap.Enabled = false;
            this.dtpNgayNhap.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(510, 31);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(141, 23);
            this.dtpNgayNhap.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày nhập hàng";
            // 
            // cbNhaSX
            // 
            this.cbNhaSX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhaSX.Enabled = false;
            this.cbNhaSX.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbNhaSX.FormattingEnabled = true;
            this.cbNhaSX.Items.AddRange(new object[] {
            "Chọn nhà sản xuất"});
            this.cbNhaSX.Location = new System.Drawing.Point(111, 70);
            this.cbNhaSX.Name = "cbNhaSX";
            this.cbNhaSX.Size = new System.Drawing.Size(153, 24);
            this.cbNhaSX.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhà sản xuất";
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Enabled = false;
            this.txtMaPhieuNhap.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(111, 30);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(153, 23);
            this.txtMaPhieuNhap.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCapNhatLai);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.dtpTim_NgayNhap);
            this.groupBox2.Controls.Add(this.cbTim_NSX);
            this.groupBox2.Controls.Add(this.txtTim_MaPN);
            this.groupBox2.Controls.Add(this.cbTimKiem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(877, 119);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm phiếu nhập";
            // 
            // btnCapNhatLai
            // 
            this.btnCapNhatLai.Location = new System.Drawing.Point(427, 77);
            this.btnCapNhatLai.Name = "btnCapNhatLai";
            this.btnCapNhatLai.Size = new System.Drawing.Size(111, 36);
            this.btnCapNhatLai.TabIndex = 8;
            this.btnCapNhatLai.Text = "Cập nhật lại";
            this.btnCapNhatLai.UseVisualStyleBackColor = true;
            this.btnCapNhatLai.Click += new System.EventHandler(this.btnCapNhatLai_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(310, 77);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(111, 36);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtpTim_NgayNhap
            // 
            this.dtpTim_NgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtpTim_NgayNhap.Enabled = false;
            this.dtpTim_NgayNhap.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.dtpTim_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTim_NgayNhap.Location = new System.Drawing.Point(590, 35);
            this.dtpTim_NgayNhap.Name = "dtpTim_NgayNhap";
            this.dtpTim_NgayNhap.Size = new System.Drawing.Size(136, 23);
            this.dtpTim_NgayNhap.TabIndex = 6;
            // 
            // cbTim_NSX
            // 
            this.cbTim_NSX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTim_NSX.Enabled = false;
            this.cbTim_NSX.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbTim_NSX.FormattingEnabled = true;
            this.cbTim_NSX.Items.AddRange(new object[] {
            "Chọn nhà sản xuất"});
            this.cbTim_NSX.Location = new System.Drawing.Point(439, 35);
            this.cbTim_NSX.Name = "cbTim_NSX";
            this.cbTim_NSX.Size = new System.Drawing.Size(124, 24);
            this.cbTim_NSX.TabIndex = 5;
            // 
            // txtTim_MaPN
            // 
            this.txtTim_MaPN.Enabled = false;
            this.txtTim_MaPN.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtTim_MaPN.Location = new System.Drawing.Point(247, 36);
            this.txtTim_MaPN.MaxLength = 18;
            this.txtTim_MaPN.Name = "txtTim_MaPN";
            this.txtTim_MaPN.Size = new System.Drawing.Size(156, 23);
            this.txtTim_MaPN.TabIndex = 3;
            this.txtTim_MaPN.TextChanged += new System.EventHandler(this.txtTim_MaPN_TextChanged);
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Items.AddRange(new object[] {
            "Mã phiếu nhập",
            "Nhà sản xuất",
            "Ngày nhập hàng"});
            this.cbTimKiem.Location = new System.Drawing.Point(74, 32);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(138, 24);
            this.cbTimKiem.TabIndex = 2;
            this.cbTimKiem.SelectedIndexChanged += new System.EventHandler(this.cbTimKiem_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm theo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPhieuNhap);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu nhập";
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvPhieuNhap.Location = new System.Drawing.Point(6, 22);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.Size = new System.Drawing.Size(864, 143);
            this.dgvPhieuNhap.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PhieuNhap_ID";
            this.Column1.HeaderText = "Phiếu Nhập ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 144;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaPhieuNhap";
            this.Column2.HeaderText = "Mã Phiếu Nhập";
            this.Column2.Name = "Column2";
            this.Column2.Width = 143;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NhaSX_ID";
            this.Column3.HeaderText = "Nhà Sản Xuất ID";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenNhaSX";
            this.Column4.HeaderText = "Tên Nhà Sản Xuất";
            this.Column4.Name = "Column4";
            this.Column4.Width = 144;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayNhap";
            this.Column5.HeaderText = "Ngày Nhập";
            this.Column5.Name = "Column5";
            this.Column5.Width = 143;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TongTien";
            this.Column6.HeaderText = "Tổng Tiền";
            this.Column6.Name = "Column6";
            this.Column6.Width = 144;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnHoanTat);
            this.tabPage2.Controls.Add(this.btnLuuSanPham);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(889, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi Tiết Phiếu Nhập";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvBangNhap);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(10, 200);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(866, 166);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông Tin Nhập Hàng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvChiTietPhieuNhap);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(10, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(867, 180);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi Tiết Phiếu Nhập";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // dgvChiTietPhieuNhap
            // 
            this.dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgvChiTietPhieuNhap.Location = new System.Drawing.Point(54, 25);
            this.dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            this.dgvChiTietPhieuNhap.Size = new System.Drawing.Size(764, 143);
            this.dgvChiTietPhieuNhap.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MaPhieuNhap";
            this.Column7.HeaderText = "Mã Phiếu Nhập";
            this.Column7.Name = "Column7";
            this.Column7.Width = 144;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "SP_ID";
            this.Column8.HeaderText = "SP_ID";
            this.Column8.Name = "Column8";
            this.Column8.Width = 144;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TenSP";
            this.Column9.HeaderText = "Tên Sản Phẩm";
            this.Column9.Name = "Column9";
            this.Column9.Width = 144;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "SoLuongNhap";
            this.Column10.HeaderText = "Số Lượng Nhập";
            this.Column10.Name = "Column10";
            this.Column10.Width = 144;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "DonGiaNhap";
            this.Column11.HeaderText = "Đơn Giá Nhập";
            this.Column11.Name = "Column11";
            this.Column11.Width = 144;
            // 
            // dgvBangNhap
            // 
            this.dgvBangNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dgvBangNhap.Location = new System.Drawing.Point(56, 32);
            this.dgvBangNhap.Name = "dgvBangNhap";
            this.dgvBangNhap.Size = new System.Drawing.Size(762, 120);
            this.dgvBangNhap.TabIndex = 0;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "SP_ID";
            this.Column12.HeaderText = "Sản Phẩm ID";
            this.Column12.Name = "Column12";
            this.Column12.Width = 180;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "TenSP";
            this.Column13.HeaderText = "Tên Sản Phẩm";
            this.Column13.Name = "Column13";
            this.Column13.Width = 180;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "SoLuongNhap";
            this.Column14.HeaderText = "Số Lượng Nhập";
            this.Column14.Name = "Column14";
            this.Column14.Width = 180;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "DonGiaNhap";
            this.Column15.HeaderText = "Đơn Giá Nhập";
            this.Column15.Name = "Column15";
            this.Column15.Width = 180;
            // 
            // btnLuuSanPham
            // 
            this.btnLuuSanPham.Enabled = false;
            this.btnLuuSanPham.Location = new System.Drawing.Point(276, 372);
            this.btnLuuSanPham.Name = "btnLuuSanPham";
            this.btnLuuSanPham.Size = new System.Drawing.Size(173, 32);
            this.btnLuuSanPham.TabIndex = 2;
            this.btnLuuSanPham.Text = "Lưu sản phẩm";
            this.btnLuuSanPham.UseVisualStyleBackColor = true;
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Enabled = false;
            this.btnHoanTat.Location = new System.Drawing.Point(455, 372);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(173, 32);
            this.btnHoanTat.TabIndex = 3;
            this.btnHoanTat.Text = "Hoàn tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            // 
            // QuanLyPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 527);
            this.Controls.Add(this.tabControl1);
            this.Name = "QuanLyPhieuNhap";
            this.Text = "QuanLyPhieuNhap";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangNhap)).EndInit();
            this.ResumeLayout(false);

        }

        private void groupBox4_Enter(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTim_MaPN;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTim_NgayNhap;
        private System.Windows.Forms.ComboBox cbTim_NSX;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNhaSX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapNhatLai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.Button btnLuuSanPham;
        private System.Windows.Forms.DataGridView dgvBangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
    }
}