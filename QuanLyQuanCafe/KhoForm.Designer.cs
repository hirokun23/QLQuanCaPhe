namespace QuanLyQuanCafe
{
    partial class KhoForm
    {
        private System.ComponentModel.IContainer components = null;

        // Khai báo các control theo phong cách Guna2
        private Guna.UI2.WinForms.Guna2DataGridView dgvKho;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNL, txtTenNL, txtSoLuong;
        private Guna.UI2.WinForms.Guna2Button btnThem, btnSua, btnXoa, btnSave, btnHuy;
        private System.Windows.Forms.Label lblMa, lblTen, lblSoLuong;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKho = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtMaNL = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenNL = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.elipseDgv = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnImport = new Guna.UI2.WinForms.Guna2Button();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKho
            // 
            this.dgvKho.AllowUserToAddRows = false;
            this.dgvKho.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvKho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvKho.ColumnHeadersHeight = 35;
            this.dgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKho.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvKho.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKho.Location = new System.Drawing.Point(20, 20);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.ReadOnly = true;
            this.dgvKho.RowHeadersVisible = false;
            this.dgvKho.RowTemplate.Height = 35;
            this.dgvKho.Size = new System.Drawing.Size(725, 370);
            this.dgvKho.TabIndex = 0;
            this.dgvKho.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKho.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKho.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKho.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKho.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKho.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvKho.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKho.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dgvKho.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKho.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKho.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKho.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvKho.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvKho.ThemeStyle.ReadOnly = true;
            this.dgvKho.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKho.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKho.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKho.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKho.ThemeStyle.RowsStyle.Height = 35;
            this.dgvKho.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKho.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKho_CellClick);
            // 
            // txtMaNL
            // 
            this.txtMaNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaNL.BorderRadius = 8;
            this.txtMaNL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNL.DefaultText = "";
            this.txtMaNL.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMaNL.Location = new System.Drawing.Point(20, 425);
            this.txtMaNL.Name = "txtMaNL";
            this.txtMaNL.PlaceholderText = "Tự động";
            this.txtMaNL.ReadOnly = true;
            this.txtMaNL.SelectedText = "";
            this.txtMaNL.Size = new System.Drawing.Size(120, 36);
            this.txtMaNL.TabIndex = 1;
            // 
            // txtTenNL
            // 
            this.txtTenNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTenNL.BorderRadius = 8;
            this.txtTenNL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNL.DefaultText = "";
            this.txtTenNL.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTenNL.Location = new System.Drawing.Point(160, 425);
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.PlaceholderText = "Tên nguyên liệu...";
            this.txtTenNL.SelectedText = "";
            this.txtTenNL.Size = new System.Drawing.Size(190, 36);
            this.txtTenNL.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSoLuong.BorderRadius = 8;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.DefaultText = "";
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSoLuong.Location = new System.Drawing.Point(379, 425);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PlaceholderText = "Số lượng";
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.Size = new System.Drawing.Size(120, 36);
            this.txtSoLuong.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.BorderRadius = 8;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(20, 490);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.BorderRadius = 8;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(135, 490);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(250, 490);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BorderRadius = 8;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(379, 490);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.BorderRadius = 8;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FillColor = System.Drawing.Color.Gray;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(506, 490);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 40);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblMa
            // 
            this.lblMa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMa.Location = new System.Drawing.Point(20, 405);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(100, 23);
            this.lblMa.TabIndex = 14;
            this.lblMa.Text = "Mã nguyên liệu";
            // 
            // lblTen
            // 
            this.lblTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTen.Location = new System.Drawing.Point(160, 405);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(100, 23);
            this.lblTen.TabIndex = 15;
            this.lblTen.Text = "Tên nguyên liệu";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSoLuong.Location = new System.Drawing.Point(379, 405);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(100, 23);
            this.lblSoLuong.TabIndex = 16;
            this.lblSoLuong.Text = "Số lượng tồn";
            // 
            // elipseDgv
            // 
            this.elipseDgv.BorderRadius = 12;
            this.elipseDgv.TargetControl = this.dgvKho;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImport.BorderRadius = 8;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.FillColor = System.Drawing.Color.LimeGreen;
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(522, 425);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(84, 36);
            this.btnImport.TabIndex = 17;
            this.btnImport.Text = "Nhập";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExport.BorderRadius = 8;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FillColor = System.Drawing.Color.Turquoise;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(625, 425);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(84, 36);
            this.btnExport.TabIndex = 18;
            this.btnExport.Text = "Xuất";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // KhoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.dgvKho);
            this.Controls.Add(this.txtMaNL);
            this.Controls.Add(this.txtTenNL);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblSoLuong);
            this.Name = "KhoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Kho Nguyên Liệu";
            this.Load += new System.EventHandler(this.KhoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2Button btnImport;
        private Guna.UI2.WinForms.Guna2Button btnExport;
    }
}