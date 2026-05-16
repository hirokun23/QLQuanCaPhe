using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    partial class MenuForm
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2DataGridView dgvMon;
        private Guna.UI2.WinForms.Guna2TextBox txtMaMon, txtTenMon, txtGia;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoai;
        private Guna.UI2.WinForms.Guna2Button btnThem, btnSua, btnXoa;
        private System.Windows.Forms.Label lblMa, lblTen, lblGia, lblLoai;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtMaMon = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenMon = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.elipseDgv = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnImport = new Guna.UI2.WinForms.Guna2Button();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMon
            // 
            this.dgvMon.AllowUserToAddRows = false;
            this.dgvMon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvMon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMon.ColumnHeadersHeight = 35;
            this.dgvMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMon.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMon.Location = new System.Drawing.Point(20, 20);
            this.dgvMon.Name = "dgvMon";
            this.dgvMon.ReadOnly = true;
            this.dgvMon.RowHeadersVisible = false;
            this.dgvMon.RowTemplate.Height = 35;
            this.dgvMon.Size = new System.Drawing.Size(723, 370);
            this.dgvMon.TabIndex = 0;
            this.dgvMon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dgvMon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMon.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvMon.ThemeStyle.ReadOnly = true;
            this.dgvMon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMon.ThemeStyle.RowsStyle.Height = 35;
            this.dgvMon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMon_CellClick);
            // 
            // txtMaMon
            // 
            this.txtMaMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaMon.BorderRadius = 8;
            this.txtMaMon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaMon.DefaultText = "";
            this.txtMaMon.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMaMon.Location = new System.Drawing.Point(20, 425);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.PlaceholderText = "Tự động";
            this.txtMaMon.ReadOnly = true;
            this.txtMaMon.SelectedText = "";
            this.txtMaMon.Size = new System.Drawing.Size(100, 36);
            this.txtMaMon.TabIndex = 1;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTenMon.BorderRadius = 8;
            this.txtTenMon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenMon.DefaultText = "";
            this.txtTenMon.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTenMon.Location = new System.Drawing.Point(140, 425);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.PlaceholderText = "Nhập tên món...";
            this.txtTenMon.SelectedText = "";
            this.txtTenMon.Size = new System.Drawing.Size(180, 36);
            this.txtTenMon.TabIndex = 2;
            // 
            // txtGia
            // 
            this.txtGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGia.BorderRadius = 8;
            this.txtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGia.DefaultText = "";
            this.txtGia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtGia.Location = new System.Drawing.Point(340, 425);
            this.txtGia.Name = "txtGia";
            this.txtGia.PlaceholderText = "VNĐ";
            this.txtGia.SelectedText = "";
            this.txtGia.Size = new System.Drawing.Size(120, 36);
            this.txtGia.TabIndex = 3;
            // 
            // cboLoai
            // 
            this.cboLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboLoai.BackColor = System.Drawing.Color.Transparent;
            this.cboLoai.BorderRadius = 8;
            this.cboLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.FocusedColor = System.Drawing.Color.Empty;
            this.cboLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.ItemHeight = 30;
            this.cboLoai.Items.AddRange(new object[] {
            "Cafe",
            "Trà",
            "Nước",
            "Khác"});
            this.cboLoai.Location = new System.Drawing.Point(480, 425);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(180, 36);
            this.cboLoai.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.BorderRadius = 8;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(20, 490);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.BorderRadius = 8;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(140, 490);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(260, 490);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblMa
            // 
            this.lblMa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblMa.Location = new System.Drawing.Point(20, 405);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(59, 17);
            this.lblMa.TabIndex = 8;
            this.lblMa.Text = "Mã món";
            // 
            // lblTen
            // 
            this.lblTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTen.Location = new System.Drawing.Point(140, 405);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(62, 17);
            this.lblTen.TabIndex = 9;
            this.lblTen.Text = "Tên món";
            // 
            // lblGia
            // 
            this.lblGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblGia.Location = new System.Drawing.Point(340, 405);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(57, 17);
            this.lblGia.TabIndex = 10;
            this.lblGia.Text = "Đơn giá";
            // 
            // lblLoai
            // 
            this.lblLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblLoai.Location = new System.Drawing.Point(480, 405);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(71, 17);
            this.lblLoai.TabIndex = 11;
            this.lblLoai.Text = "Danh mục";
            // 
            // elipseDgv
            // 
            this.elipseDgv.BorderRadius = 12;
            this.elipseDgv.TargetControl = this.dgvMon;
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
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImport.BorderRadius = 8;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(627, 490);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(63, 40);
            this.btnImport.TabIndex = 14;
            this.btnImport.Text = "Nhập";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExport.BorderRadius = 8;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(709, 490);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(63, 40);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Xuất";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvMon);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.cboLoai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblLoai);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnImport;
        private Guna.UI2.WinForms.Guna2Button btnExport;
    }
}