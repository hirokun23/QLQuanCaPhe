using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    partial class BanForm
    {
        private Guna.UI2.WinForms.Guna2DataGridView dgvBan;
        private Guna.UI2.WinForms.Guna2TextBox txtMaBan;
        private Guna.UI2.WinForms.Guna2TextBox txtTenBan;
        private Guna.UI2.WinForms.Guna2ComboBox cboTrangThai;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private System.Windows.Forms.Label lblMa, lblTen, lblTrangThai;
        private Guna.UI2.WinForms.Guna2Elipse elipseDgv; // Dùng để bo góc DataGridView

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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtMaBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.elipseDgv = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBan
            // 
            this.dgvBan.AllowUserToAddRows = false;
            this.dgvBan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(167)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(167)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBan.ColumnHeadersHeight = 35;
            this.dgvBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBan.Location = new System.Drawing.Point(20, 20);
            this.dgvBan.Name = "dgvBan";
            this.dgvBan.ReadOnly = true;
            this.dgvBan.RowHeadersVisible = false;
            this.dgvBan.RowTemplate.Height = 35;
            this.dgvBan.Size = new System.Drawing.Size(578, 213);
            this.dgvBan.TabIndex = 0;
            this.dgvBan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(167)))), ((int)(((byte)(50)))));
            this.dgvBan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBan.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvBan.ThemeStyle.ReadOnly = true;
            this.dgvBan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBan.ThemeStyle.RowsStyle.Height = 35;
            this.dgvBan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBan_CellClick);
            // 
            // txtMaBan
            // 
            this.txtMaBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaBan.BorderRadius = 8;
            this.txtMaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaBan.DefaultText = "";
            this.txtMaBan.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMaBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtMaBan.Location = new System.Drawing.Point(20, 268);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.PlaceholderText = "";
            this.txtMaBan.ReadOnly = true;
            this.txtMaBan.SelectedText = "";
            this.txtMaBan.Size = new System.Drawing.Size(140, 36);
            this.txtMaBan.TabIndex = 1;
            // 
            // txtTenBan
            // 
            this.txtTenBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTenBan.BorderRadius = 8;
            this.txtTenBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenBan.DefaultText = "";
            this.txtTenBan.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTenBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtTenBan.Location = new System.Drawing.Point(180, 268);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.PlaceholderText = "";
            this.txtTenBan.SelectedText = "";
            this.txtTenBan.Size = new System.Drawing.Size(140, 36);
            this.txtTenBan.TabIndex = 2;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cboTrangThai.BorderRadius = 8;
            this.cboTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FocusedColor = System.Drawing.Color.Empty;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cboTrangThai.ItemHeight = 30;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Trống",
            "Có khách"});
            this.cboTrangThai.Location = new System.Drawing.Point(340, 268);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(140, 36);
            this.cboTrangThai.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.BorderRadius = 8;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(167)))), ((int)(((byte)(50)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(20, 323);
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
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(135, 323);
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
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(250, 323);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblMa
            // 
            this.lblMa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblMa.Location = new System.Drawing.Point(20, 248);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(47, 15);
            this.lblMa.TabIndex = 7;
            this.lblMa.Text = "Mã bàn";
            // 
            // lblTen
            // 
            this.lblTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTen.Location = new System.Drawing.Point(180, 248);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(50, 15);
            this.lblTen.TabIndex = 8;
            this.lblTen.Text = "Tên bàn";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTrangThai.Location = new System.Drawing.Point(340, 248);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(62, 15);
            this.lblTrangThai.TabIndex = 9;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // elipseDgv
            // 
            this.elipseDgv.BorderRadius = 12;
            this.elipseDgv.TargetControl = this.dgvBan;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BorderRadius = 8;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(366, 323);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 10;
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
            this.btnHuy.Location = new System.Drawing.Point(483, 323);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 40);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // BanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(640, 394);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvBan);
            this.Controls.Add(this.txtMaBan);
            this.Controls.Add(this.txtTenBan);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblTrangThai);
            this.MinimumSize = new System.Drawing.Size(600, 420);
            this.Name = "BanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bàn";
            this.Load += new System.EventHandler(this.BanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
    }
}