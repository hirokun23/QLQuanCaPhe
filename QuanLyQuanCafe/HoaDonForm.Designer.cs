namespace QuanLyQuanCafe
{
    partial class HoaDonForm
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2DataGridView dgvHoaDon;
        private Guna.UI2.WinForms.Guna2DataGridView dgvChiTiet;

        private System.Windows.Forms.Label lblTitle;

        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2Button btnExcel;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;

        private Guna.UI2.WinForms.Guna2Elipse elipseDgv1;
        private Guna.UI2.WinForms.Guna2Elipse elipseDgv2;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHoaDon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvChiTiet = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.btnExcel = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.elipseDgv1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elipseDgv2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDon.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.Location = new System.Drawing.Point(25, 120);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowTemplate.Height = 35;
            this.dgvHoaDon.Size = new System.Drawing.Size(712, 180);
            this.dgvHoaDon.TabIndex = 5;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvHoaDon.ThemeStyle.ReadOnly = true;
            this.dgvHoaDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHoaDon.ThemeStyle.RowsStyle.Height = 35;
            this.dgvHoaDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvChiTiet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvChiTiet.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTiet.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvChiTiet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChiTiet.Location = new System.Drawing.Point(25, 325);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.RowHeadersVisible = false;
            this.dgvChiTiet.RowTemplate.Height = 35;
            this.dgvChiTiet.Size = new System.Drawing.Size(712, 200);
            this.dgvChiTiet.TabIndex = 6;
            this.dgvChiTiet.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChiTiet.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvChiTiet.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvChiTiet.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvChiTiet.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvChiTiet.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvChiTiet.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChiTiet.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvChiTiet.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvChiTiet.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiTiet.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvChiTiet.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvChiTiet.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvChiTiet.ThemeStyle.ReadOnly = true;
            this.dgvChiTiet.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChiTiet.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChiTiet.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiTiet.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvChiTiet.ThemeStyle.RowsStyle.Height = 35;
            this.dgvChiTiet.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dgvChiTiet.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(241, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BorderRadius = 10;
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(478, 65);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 38);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "In hóa đơn";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BorderRadius = 10;
            this.btnExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.Location = new System.Drawing.Point(617, 65);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(120, 38);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "Xuất Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 10;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(260, 65);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 38);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Làm mới";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(25, 65);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Tìm mã hóa đơn...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(220, 38);
            this.txtSearch.TabIndex = 1;
            // 
            // elipseDgv1
            // 
            this.elipseDgv1.BorderRadius = 15;
            this.elipseDgv1.TargetControl = this.dgvHoaDon;
            // 
            // elipseDgv2
            // 
            this.elipseDgv2.BorderRadius = 15;
            this.elipseDgv2.TargetControl = this.dgvChiTiet;
            // 
            // HoaDonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.dgvChiTiet);
            this.Name = "HoaDonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.HoaDonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}