namespace QuanLyQuanCafe
{
    partial class TaiKhoanForm
    {
        private System.ComponentModel.IContainer components = null;

        // Các thành phần điều khiển (Khớp 100% với Code Logic của bạn)
        private Guna.UI2.WinForms.Guna2DataGridView dgvTaiKhoan;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDangNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private Guna.UI2.WinForms.Guna2ComboBox cboChucVu;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private System.Windows.Forms.Label lblTenDN;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblChucVu;
        private Guna.UI2.WinForms.Guna2Elipse elipseDgv;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTaiKhoan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtTenDangNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboChucVu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.lblTenDN = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.elipseDgv = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTaiKhoan.ColumnHeadersHeight = 35;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTaiKhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTaiKhoan.Location = new System.Drawing.Point(20, 20);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.RowHeadersVisible = false;
            this.dgvTaiKhoan.RowTemplate.Height = 35;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(725, 327);
            this.dgvTaiKhoan.TabIndex = 0;
            this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTaiKhoan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTaiKhoan.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvTaiKhoan.ThemeStyle.ReadOnly = true;
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.Height = 35;
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTaiKhoan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTenDangNhap.BorderRadius = 8;
            this.txtTenDangNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDangNhap.DefaultText = "";
            this.txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenDangNhap.Location = new System.Drawing.Point(20, 390);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.PlaceholderText = "";
            this.txtTenDangNhap.SelectedText = "";
            this.txtTenDangNhap.Size = new System.Drawing.Size(163, 36);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMatKhau.BorderRadius = 8;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMatKhau.Location = new System.Drawing.Point(203, 390);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '●';
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(145, 36);
            this.txtMatKhau.TabIndex = 2;
            // 
            // cboChucVu
            // 
            this.cboChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboChucVu.BackColor = System.Drawing.Color.Transparent;
            this.cboChucVu.BorderRadius = 8;
            this.cboChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVu.FocusedColor = System.Drawing.Color.Empty;
            this.cboChucVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboChucVu.ItemHeight = 30;
            this.cboChucVu.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cboChucVu.Location = new System.Drawing.Point(372, 390);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(150, 36);
            this.cboChucVu.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.BorderRadius = 8;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(20, 450);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 40);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.BorderRadius = 8;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(120, 450);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 40);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(220, 450);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 40);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BorderRadius = 8;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(350, 450);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.BorderRadius = 8;
            this.btnHuy.FillColor = System.Drawing.Color.Gray;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(450, 450);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 40);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblTenDN
            // 
            this.lblTenDN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTenDN.AutoSize = true;
            this.lblTenDN.Location = new System.Drawing.Point(20, 370);
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.Size = new System.Drawing.Size(81, 13);
            this.lblTenDN.TabIndex = 9;
            this.lblTenDN.Text = "Tên đăng nhập";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(200, 370);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(52, 13);
            this.lblMatKhau.TabIndex = 10;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // lblChucVu
            // 
            this.lblChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(369, 370);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(47, 13);
            this.lblChucVu.TabIndex = 11;
            this.lblChucVu.Text = "Chức vụ";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEmail.BorderRadius = 8;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(545, 390);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '●';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(161, 36);
            this.txtEmail.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(542, 370);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";

            this.elipseDgv.BorderRadius = 12;
            this.elipseDgv.TargetControl = this.dgvTaiKhoan;

            // 
            // TaiKhoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 520);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.cboChucVu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lblTenDN);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblChucVu);
            this.Name = "TaiKhoanForm";
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.TaiKhoanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}