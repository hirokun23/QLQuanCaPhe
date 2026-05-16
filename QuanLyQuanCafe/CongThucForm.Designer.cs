using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    partial class CongThucForm
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2DataGridView dgvCongThuc;
        private Guna.UI2.WinForms.Guna2ComboBox cboMon, cboNguyenLieu;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuong;
        private Guna.UI2.WinForms.Guna2Button btnThem, btnSua, btnXoa, btnSave, btnHuy, btnImport, btnExport;
        private System.Windows.Forms.Label lblMon, lblNL, lblSoLuong;
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
            this.dgvCongThuc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cboMon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboNguyenLieu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnImport = new Guna.UI2.WinForms.Guna2Button();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.lblMon = new System.Windows.Forms.Label();
            this.lblNL = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.elipseDgv = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongThuc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCongThuc
            // 
            this.dgvCongThuc.AllowUserToAddRows = false;
            this.dgvCongThuc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCongThuc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCongThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCongThuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCongThuc.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCongThuc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCongThuc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCongThuc.Location = new System.Drawing.Point(20, 20);
            this.dgvCongThuc.Name = "dgvCongThuc";
            this.dgvCongThuc.ReadOnly = true;
            this.dgvCongThuc.RowHeadersVisible = false;
            this.dgvCongThuc.RowTemplate.Height = 35;
            this.dgvCongThuc.Size = new System.Drawing.Size(727, 370);
            this.dgvCongThuc.TabIndex = 0;
            this.dgvCongThuc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCongThuc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCongThuc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCongThuc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCongThuc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCongThuc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCongThuc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCongThuc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dgvCongThuc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCongThuc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCongThuc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCongThuc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCongThuc.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvCongThuc.ThemeStyle.ReadOnly = true;
            this.dgvCongThuc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCongThuc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCongThuc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCongThuc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCongThuc.ThemeStyle.RowsStyle.Height = 35;
            this.dgvCongThuc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCongThuc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCongThuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCongThuc_CellClick);
            // 
            // cboMon
            // 
            this.cboMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboMon.BackColor = System.Drawing.Color.Transparent;
            this.cboMon.BorderRadius = 8;
            this.cboMon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMon.FocusedColor = System.Drawing.Color.Empty;
            this.cboMon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboMon.ItemHeight = 30;
            this.cboMon.Location = new System.Drawing.Point(20, 425);
            this.cboMon.Name = "cboMon";
            this.cboMon.Size = new System.Drawing.Size(200, 36);
            this.cboMon.TabIndex = 1;
            // 
            // cboNguyenLieu
            // 
            this.cboNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboNguyenLieu.BackColor = System.Drawing.Color.Transparent;
            this.cboNguyenLieu.BorderRadius = 8;
            this.cboNguyenLieu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNguyenLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNguyenLieu.FocusedColor = System.Drawing.Color.Empty;
            this.cboNguyenLieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNguyenLieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboNguyenLieu.ItemHeight = 30;
            this.cboNguyenLieu.Location = new System.Drawing.Point(240, 425);
            this.cboNguyenLieu.Name = "cboNguyenLieu";
            this.cboNguyenLieu.Size = new System.Drawing.Size(200, 36);
            this.cboNguyenLieu.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSoLuong.BorderRadius = 8;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.DefaultText = "";
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSoLuong.Location = new System.Drawing.Point(460, 425);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PlaceholderText = "0.0";
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
            this.btnSua.Location = new System.Drawing.Point(140, 490);
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
            this.btnXoa.Location = new System.Drawing.Point(260, 490);
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
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(379, 490);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.BorderRadius = 8;
            this.btnHuy.FillColor = System.Drawing.Color.Gray;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(506, 490);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 40);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImport.BorderRadius = 8;
            this.btnImport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(627, 490);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(63, 40);
            this.btnImport.TabIndex = 9;
            this.btnImport.Text = "Nhập";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExport.BorderRadius = 8;
            this.btnExport.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(709, 490);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(63, 40);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Xuất";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblMon
            // 
            this.lblMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMon.AutoSize = true;
            this.lblMon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMon.Location = new System.Drawing.Point(20, 405);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(91, 17);
            this.lblMon.TabIndex = 11;
            this.lblMon.Text = "Chọn món ăn";
            // 
            // lblNL
            // 
            this.lblNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNL.AutoSize = true;
            this.lblNL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNL.Location = new System.Drawing.Point(240, 405);
            this.lblNL.Name = "lblNL";
            this.lblNL.Size = new System.Drawing.Size(83, 17);
            this.lblNL.TabIndex = 12;
            this.lblNL.Text = "Nguyên liệu";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSoLuong.Location = new System.Drawing.Point(460, 405);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(64, 17);
            this.lblSoLuong.TabIndex = 13;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // elipseDgv
            // 
            this.elipseDgv.BorderRadius = 12;
            this.elipseDgv.TargetControl = this.dgvCongThuc;
            // 
            // CongThucForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgvCongThuc);
            this.Controls.Add(this.cboMon);
            this.Controls.Add(this.cboNguyenLieu);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblMon);
            this.Controls.Add(this.lblNL);
            this.Controls.Add(this.lblSoLuong);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "CongThucForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết Kế Công Thức Món Ăn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongThuc)).EndInit();
            this.Load += new System.EventHandler(this.CongThucForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}