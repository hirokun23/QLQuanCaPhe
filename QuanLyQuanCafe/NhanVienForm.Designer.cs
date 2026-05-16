using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    partial class NhanVienForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtChucVu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.groupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvNhanVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.elipseDgv = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnImport = new Guna.UI2.WinForms.Guna2Button();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.BackColor = System.Drawing.Color.Transparent;
            this.lblTenNV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTenNV.Location = new System.Drawing.Point(20, 65);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(57, 17);
            this.lblTenNV.TabIndex = 3;
            this.lblTenNV.Text = "Tên NV:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.BackColor = System.Drawing.Color.Transparent;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSDT.Location = new System.Drawing.Point(20, 115);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(37, 17);
            this.lblSDT.TabIndex = 4;
            this.lblSDT.Text = "SĐT:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblDiaChi.Location = new System.Drawing.Point(20, 165);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(55, 17);
            this.lblDiaChi.TabIndex = 5;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblGioiTinh.Location = new System.Drawing.Point(20, 215);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(66, 17);
            this.lblGioiTinh.TabIndex = 6;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblNgaySinh.Location = new System.Drawing.Point(280, 65);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(74, 17);
            this.lblNgaySinh.TabIndex = 7;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.BackColor = System.Drawing.Color.Transparent;
            this.lblChucVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblChucVu.Location = new System.Drawing.Point(280, 115);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(62, 17);
            this.lblChucVu.TabIndex = 8;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblLuong.Location = new System.Drawing.Point(280, 165);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(52, 17);
            this.lblLuong.TabIndex = 9;
            this.lblLuong.Text = "Lương:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(20, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tìm kiếm:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.BorderRadius = 8;
            this.txtTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNV.DefaultText = "";
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTenNV.Location = new System.Drawing.Point(90, 55);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.PlaceholderText = "";
            this.txtTenNV.SelectedText = "";
            this.txtTenNV.Size = new System.Drawing.Size(160, 36);
            this.txtTenNV.TabIndex = 16;
            // 
            // txtSDT
            // 
            this.txtSDT.BorderRadius = 8;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSDT.Location = new System.Drawing.Point(90, 105);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(160, 36);
            this.txtSDT.TabIndex = 17;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderRadius = 8;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDiaChi.Location = new System.Drawing.Point(90, 155);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(160, 36);
            this.txtDiaChi.TabIndex = 18;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSearch.Location = new System.Drawing.Point(100, 55);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Nhập tên/SĐT...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(220, 36);
            this.txtSearch.TabIndex = 0;
            // 
            // txtChucVu
            // 
            this.txtChucVu.BorderRadius = 8;
            this.txtChucVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChucVu.DefaultText = "";
            this.txtChucVu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtChucVu.Location = new System.Drawing.Point(360, 105);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.PlaceholderText = "";
            this.txtChucVu.SelectedText = "";
            this.txtChucVu.Size = new System.Drawing.Size(150, 36);
            this.txtChucVu.TabIndex = 19;
            // 
            // txtLuong
            // 
            this.txtLuong.BorderRadius = 8;
            this.txtLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLuong.DefaultText = "";
            this.txtLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLuong.Location = new System.Drawing.Point(360, 155);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.PlaceholderText = "VNĐ";
            this.txtLuong.SelectedText = "";
            this.txtLuong.Size = new System.Drawing.Size(150, 36);
            this.txtLuong.TabIndex = 20;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cbGioiTinh.BorderRadius = 8;
            this.cbGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FocusedColor = System.Drawing.Color.Empty;
            this.cbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbGioiTinh.ItemHeight = 30;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(90, 205);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(160, 36);
            this.cbGioiTinh.TabIndex = 14;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.BorderRadius = 8;
            this.dtNgaySinh.Checked = true;
            this.dtNgaySinh.FillColor = System.Drawing.Color.White;
            this.dtNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh.Location = new System.Drawing.Point(360, 55);
            this.dtNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(150, 36);
            this.dtNgaySinh.TabIndex = 13;
            this.dtNgaySinh.Value = new System.DateTime(2026, 5, 13, 0, 0, 0, 0);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 8;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(20, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 8;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(20, 130);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(340, 130);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 40);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 8;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(182, 130);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // button1
            // 
            this.button1.BorderRadius = 8;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(340, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 26;
            this.button1.Text = "Tìm kiếm";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BorderRadius = 8;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FillColor = System.Drawing.Color.Gray;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(182, 190);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 40);
            this.btnHuy.TabIndex = 27;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BorderRadius = 8;
            this.groupBox1.Controls.Add(this.lblTenNV);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.lblNgaySinh);
            this.groupBox1.Controls.Add(this.dtNgaySinh);
            this.groupBox1.Controls.Add(this.lblSDT);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.lblChucVu);
            this.groupBox1.Controls.Add(this.txtChucVu);
            this.groupBox1.Controls.Add(this.lblDiaChi);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.lblLuong);
            this.groupBox1.Controls.Add(this.txtLuong);
            this.groupBox1.Controls.Add(this.lblGioiTinh);
            this.groupBox1.Controls.Add(this.cbGioiTinh);
            this.groupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 250);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BorderRadius = 8;
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Controls.Add(this.btnImport);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(560, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 250);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.Text = "Tiện ích";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNhanVien.ColumnHeadersHeight = 40;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.Location = new System.Drawing.Point(20, 290);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowTemplate.Height = 35;
            this.dgvNhanVien.Size = new System.Drawing.Size(1000, 260);
            this.dgvNhanVien.TabIndex = 12;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNhanVien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dgvNhanVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNhanVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhanVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNhanVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvNhanVien.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvNhanVien.ThemeStyle.ReadOnly = true;
            this.dgvNhanVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhanVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhanVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNhanVien.ThemeStyle.RowsStyle.Height = 35;
            this.dgvNhanVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // elipseDgv
            // 
            this.elipseDgv.BorderRadius = 12;
            this.elipseDgv.TargetControl = this.dgvNhanVien;
            // 
            // btnImport
            // 
            this.btnImport.BorderRadius = 8;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(340, 190);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(56, 40);
            this.btnImport.TabIndex = 28;
            this.btnImport.Text = "Nhập";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.BorderRadius = 8;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(404, 190);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(56, 40);
            this.btnExport.TabIndex = 29;
            this.btnExport.Text = "Xuất";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // NhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1074, 571);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNhanVien);
            this.MinimumSize = new System.Drawing.Size(1090, 610);
            this.Name = "NhanVienForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.NhanVienForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label label1;

        private Guna.UI2.WinForms.Guna2ComboBox cbGioiTinh;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNV;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtChucVu;
        private Guna.UI2.WinForms.Guna2TextBox txtLuong;

        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button button1;
        private Guna.UI2.WinForms.Guna2Button btnHuy;

        private Guna.UI2.WinForms.Guna2GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtNgaySinh;
        private Guna.UI2.WinForms.Guna2DataGridView dgvNhanVien;
        private Guna.UI2.WinForms.Guna2Elipse elipseDgv;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private Guna.UI2.WinForms.Guna2Button btnImport;
    }
}