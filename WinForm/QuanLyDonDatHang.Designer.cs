namespace WinForm
{
    partial class QuanLyDonDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyDonDatHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbTimTinhTrang = new System.Windows.Forms.ComboBox();
            this.btnCapNhatLai = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtpTim_NgayDat = new System.Windows.Forms.DateTimePicker();
            this.txtTim_MaDonDH = new System.Windows.Forms.TextBox();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDonDH = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.dgvChiTietDonDH = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDH)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonDH)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 524);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(907, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Đơn Đăt Hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(871, 168);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm đơn đặt hàng";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbTimTinhTrang);
            this.groupBox6.Controls.Add(this.btnCapNhatLai);
            this.groupBox6.Controls.Add(this.btnTimKiem);
            this.groupBox6.Controls.Add(this.dtpTim_NgayDat);
            this.groupBox6.Controls.Add(this.txtTim_MaDonDH);
            this.groupBox6.Controls.Add(this.cbTimKiem);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(49, 28);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(773, 113);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tìm đơn đặt hàng";
            // 
            // cbTimTinhTrang
            // 
            this.cbTimTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimTinhTrang.Enabled = false;
            this.cbTimTinhTrang.FormattingEnabled = true;
            this.cbTimTinhTrang.Items.AddRange(new object[] {
            "Chọn",
            "Chưa giao hàng",
            "Đã giao hàng"});
            this.cbTimTinhTrang.Location = new System.Drawing.Point(561, 35);
            this.cbTimTinhTrang.Name = "cbTimTinhTrang";
            this.cbTimTinhTrang.Size = new System.Drawing.Size(171, 27);
            this.cbTimTinhTrang.TabIndex = 6;
            // 
            // btnCapNhatLai
            // 
            this.btnCapNhatLai.Location = new System.Drawing.Point(392, 73);
            this.btnCapNhatLai.Name = "btnCapNhatLai";
            this.btnCapNhatLai.Size = new System.Drawing.Size(111, 23);
            this.btnCapNhatLai.TabIndex = 5;
            this.btnCapNhatLai.Text = "Cập nhật lại";
            this.btnCapNhatLai.UseVisualStyleBackColor = true;
            this.btnCapNhatLai.Click += new System.EventHandler(this.btnCapNhatLai_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(265, 73);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(111, 23);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtpTim_NgayDat
            // 
            this.dtpTim_NgayDat.CustomFormat = "dd/MM/yyyy";
            this.dtpTim_NgayDat.Enabled = false;
            this.dtpTim_NgayDat.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.dtpTim_NgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTim_NgayDat.Location = new System.Drawing.Point(419, 35);
            this.dtpTim_NgayDat.Name = "dtpTim_NgayDat";
            this.dtpTim_NgayDat.Size = new System.Drawing.Size(136, 23);
            this.dtpTim_NgayDat.TabIndex = 4;
            // 
            // txtTim_MaDonDH
            // 
            this.txtTim_MaDonDH.Enabled = false;
            this.txtTim_MaDonDH.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtTim_MaDonDH.Location = new System.Drawing.Point(241, 34);
            this.txtTim_MaDonDH.MaxLength = 18;
            this.txtTim_MaDonDH.Name = "txtTim_MaDonDH";
            this.txtTim_MaDonDH.Size = new System.Drawing.Size(156, 23);
            this.txtTim_MaDonDH.TabIndex = 2;
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Items.AddRange(new object[] {
            "Chọn",
            "Mã đơn đặt hàng",
            "Ngày đặt",
            "Tình trạng"});
            this.cbTimKiem.Location = new System.Drawing.Point(85, 34);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(138, 24);
            this.cbTimKiem.TabIndex = 1;
            this.cbTimKiem.SelectedIndexChanged += new System.EventHandler(this.cbTimKiem_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tìm theo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDonDH);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đơn đặt hàng";
            // 
            // dgvDonDH
            // 
            this.dgvDonDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDonDH.Location = new System.Drawing.Point(16, 25);
            this.dgvDonDH.Name = "dgvDonDH";
            this.dgvDonDH.Size = new System.Drawing.Size(855, 175);
            this.dgvDonDH.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DonDH_ID";
            this.Column1.HeaderText = "Đơn Đặt Hàng ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 163;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaDonDH";
            this.Column2.HeaderText = "Mã Đơn Đặt Hàng";
            this.Column2.Name = "Column2";
            this.Column2.Width = 128;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayDat";
            this.Column3.HeaderText = "Ngày Đặt";
            this.Column3.Name = "Column3";
            this.Column3.Width = 128;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayGiao";
            this.Column4.HeaderText = "Ngày Giao";
            this.Column4.Name = "Column4";
            this.Column4.Width = 128;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TongTien";
            this.Column5.HeaderText = "Tổng Tiền";
            this.Column5.Name = "Column5";
            this.Column5.Width = 128;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TinhTrang";
            this.Column6.HeaderText = "Tình Trạng";
            this.Column6.Name = "Column6";
            this.Column6.Width = 128;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(907, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi Tiết Đơn Đặt Hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvChiTietDonDH);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(880, 225);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết đơn đặt hàng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbTinhTrang);
            this.groupBox4.Controls.Add(this.txtEmail);
            this.groupBox4.Controls.Add(this.txtDiaChi);
            this.groupBox4.Controls.Add(this.txtGhiChu);
            this.groupBox4.Controls.Add(this.txtDienThoai);
            this.groupBox4.Controls.Add(this.txtHoTenKH);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(11, 244);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(880, 165);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin đơn đặt hàng";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCapNhat);
            this.groupBox5.Controls.Add(this.btnHuy);
            this.groupBox5.Controls.Add(this.btnXoa);
            this.groupBox5.Controls.Add(this.btnLuu);
            this.groupBox5.Controls.Add(this.btnSua);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(11, 415);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(880, 77);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức năng";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(122, 19);
            this.label18.TabIndex = 2;
            this.label18.Text = "Họ tên khách hàng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 19);
            this.label15.TabIndex = 3;
            this.label15.Text = "Điện thoại";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 19);
            this.label13.TabIndex = 4;
            this.label13.Text = "Ghi chú";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(446, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 19);
            this.label14.TabIndex = 5;
            this.label14.Text = "Địa chỉ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(446, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 19);
            this.label17.TabIndex = 6;
            this.label17.Text = "Email";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(424, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 19);
            this.label16.TabIndex = 7;
            this.label16.Text = "Tình trạng ";
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.Enabled = false;
            this.txtHoTenKH.Location = new System.Drawing.Point(145, 29);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(190, 26);
            this.txtHoTenKH.TabIndex = 8;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Enabled = false;
            this.txtDienThoai.Location = new System.Drawing.Point(145, 65);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(190, 26);
            this.txtDienThoai.TabIndex = 9;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Enabled = false;
            this.txtGhiChu.Location = new System.Drawing.Point(145, 105);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(236, 44);
            this.txtGhiChu.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(512, 29);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(228, 26);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(512, 65);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 26);
            this.txtEmail.TabIndex = 12;
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTinhTrang.Enabled = false;
            this.cbTinhTrang.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Chưa giao hàng",
            "Đã giao hàng"});
            this.cbTinhTrang.Location = new System.Drawing.Point(512, 104);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(168, 24);
            this.cbTinhTrang.TabIndex = 13;
            this.cbTinhTrang.SelectedIndexChanged += new System.EventHandler(this.cbTinhTrang_SelectedIndexChanged);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(145, 43);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 26);
            this.btnSua.TabIndex = 61;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(249, 43);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(86, 26);
            this.btnLuu.TabIndex = 63;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(355, 43);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 26);
            this.btnXoa.TabIndex = 64;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSize = true;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(450, 43);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(86, 26);
            this.btnHuy.TabIndex = 65;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AutoSize = true;
            this.btnCapNhat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(542, 43);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(194, 26);
            this.btnCapNhat.TabIndex = 66;
            this.btnCapNhat.Text = "Cập nhật lại đơn hàng";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // dgvChiTietDonDH
            // 
            this.dgvChiTietDonDH.AllowUserToAddRows = false;
            this.dgvChiTietDonDH.AllowUserToDeleteRows = false;
            this.dgvChiTietDonDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietDonDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDonDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.TenSP,
            this.SoLuongDat,
            this.DonGiaDat});
            this.dgvChiTietDonDH.Location = new System.Drawing.Point(10, 25);
            this.dgvChiTietDonDH.MultiSelect = false;
            this.dgvChiTietDonDH.Name = "dgvChiTietDonDH";
            this.dgvChiTietDonDH.ReadOnly = true;
            this.dgvChiTietDonDH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietDonDH.Size = new System.Drawing.Size(864, 194);
            this.dgvChiTietDonDH.TabIndex = 67;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaDonDH";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã đơn hàng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // SoLuongDat
            // 
            this.SoLuongDat.DataPropertyName = "SoLuongDat";
            this.SoLuongDat.HeaderText = "Số lượng đặt";
            this.SoLuongDat.Name = "SoLuongDat";
            this.SoLuongDat.ReadOnly = true;
            // 
            // DonGiaDat
            // 
            this.DonGiaDat.DataPropertyName = "DonGiaDat";
            dataGridViewCellStyle4.Format = "#,##0";
            this.DonGiaDat.DefaultCellStyle = dataGridViewCellStyle4;
            this.DonGiaDat.HeaderText = "Đơn giá đặt";
            this.DonGiaDat.Name = "DonGiaDat";
            this.DonGiaDat.ReadOnly = true;
            // 
            // QuanLyDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 539);
            this.Controls.Add(this.tabControl1);
            this.Name = "QuanLyDonDatHang";
            this.Text = "QuanLyDonDatHang";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDH)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonDH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cbTimTinhTrang;
        private System.Windows.Forms.Button btnCapNhatLai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DateTimePicker dtpTim_NgayDat;
        private System.Windows.Forms.TextBox txtTim_MaDonDH;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDonDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvChiTietDonDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaDat;
    }
}