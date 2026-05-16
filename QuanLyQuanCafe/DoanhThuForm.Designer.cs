using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    partial class DoanhThuForm
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

        private Guna.UI2.WinForms.Guna2DataGridView dgvDoanhThu;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.Label lblSoHD;
        private System.Windows.Forms.Label lblTrungBinh;
        private Guna.UI2.WinForms.Guna2Panel PanelTong;
        private Guna.UI2.WinForms.Guna2Panel panelSoHD;
        private Guna.UI2.WinForms.Guna2Panel panelTB;
        private Guna.UI2.WinForms.Guna2Elipse elipseDgv;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDoanhThu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTu = new System.Windows.Forms.Label();
            this.lblDen = new System.Windows.Forms.Label();
            this.lblSoHD = new System.Windows.Forms.Label();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.lblTrungBinh = new System.Windows.Forms.Label();
            this.PanelTong = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSoHD = new Guna.UI2.WinForms.Guna2Panel();
            this.panelTB = new Guna.UI2.WinForms.Guna2Panel();
            this.elipseDgv = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.PanelTong.SuspendLayout();
            this.panelSoHD.SuspendLayout();
            this.panelTB.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AllowUserToAddRows = false;
            this.dgvDoanhThu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDoanhThu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(167)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(167)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoanhThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDoanhThu.ColumnHeadersHeight = 35;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoanhThu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDoanhThu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDoanhThu.Location = new System.Drawing.Point(20, 100);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.ReadOnly = true;
            this.dgvDoanhThu.RowHeadersVisible = false;
            this.dgvDoanhThu.RowTemplate.Height = 35;
            this.dgvDoanhThu.Size = new System.Drawing.Size(720, 240);
            this.dgvDoanhThu.TabIndex = 0;
            this.dgvDoanhThu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDoanhThu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDoanhThu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDoanhThu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDoanhThu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDoanhThu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDoanhThu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDoanhThu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(167)))), ((int)(((byte)(50)))));
            this.dgvDoanhThu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDoanhThu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDoanhThu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDoanhThu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDoanhThu.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvDoanhThu.ThemeStyle.ReadOnly = true;
            this.dgvDoanhThu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDoanhThu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDoanhThu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDoanhThu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDoanhThu.ThemeStyle.RowsStyle.Height = 35;
            this.dgvDoanhThu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDoanhThu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dtpTo
            // 
            this.dtpTo.BorderRadius = 8;
            this.dtpTo.Checked = true;
            this.dtpTo.FillColor = System.Drawing.Color.White;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(335, 40);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(140, 36);
            this.dtpTo.TabIndex = 1;
            this.dtpTo.Value = new System.DateTime(2026, 5, 14, 17, 44, 14, 852);
            // 
            // dtpFrom
            // 
            this.dtpFrom.BorderRadius = 8;
            this.dtpFrom.Checked = true;
            this.dtpFrom.FillColor = System.Drawing.Color.White;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(95, 40);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(140, 36);
            this.dtpFrom.TabIndex = 2;
            this.dtpFrom.Value = new System.DateTime(2026, 5, 14, 17, 44, 14, 894);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThongKe.BorderRadius = 8;
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(167)))), ((int)(((byte)(50)))));
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(504, 40);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(91, 36);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblTongTien.Location = new System.Drawing.Point(5, 10);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(45, 20);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "Tổng";
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTu.Location = new System.Drawing.Point(20, 50);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(63, 17);
            this.lblTu.TabIndex = 5;
            this.lblTu.Text = "Từ ngày:";
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblDen.Location = new System.Drawing.Point(255, 50);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(71, 17);
            this.lblDen.TabIndex = 6;
            this.lblDen.Text = "Đến ngày:";
            // 
            // lblSoHD
            // 
            this.lblSoHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSoHD.AutoSize = true;
            this.lblSoHD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSoHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSoHD.Location = new System.Drawing.Point(3, 10);
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.Size = new System.Drawing.Size(52, 20);
            this.lblSoHD.TabIndex = 7;
            this.lblSoHD.Text = "Số HD";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BorderRadius = 8;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(601, 40);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(73, 36);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTrungBinh
            // 
            this.lblTrungBinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTrungBinh.AutoSize = true;
            this.lblTrungBinh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTrungBinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTrungBinh.Location = new System.Drawing.Point(3, 10);
            this.lblTrungBinh.Name = "lblTrungBinh";
            this.lblTrungBinh.Size = new System.Drawing.Size(28, 20);
            this.lblTrungBinh.TabIndex = 9;
            this.lblTrungBinh.Text = "TB";
            // 
            // PanelTong
            // 
            this.PanelTong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelTong.BackColor = System.Drawing.Color.Transparent;
            this.PanelTong.BorderRadius = 8;
            this.PanelTong.Controls.Add(this.lblTongTien);
            this.PanelTong.FillColor = System.Drawing.Color.White;
            this.PanelTong.Location = new System.Drawing.Point(105, 365);
            this.PanelTong.Name = "PanelTong";
            this.PanelTong.Size = new System.Drawing.Size(120, 40);
            this.PanelTong.TabIndex = 10;
            // 
            // panelSoHD
            // 
            this.panelSoHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSoHD.BackColor = System.Drawing.Color.Transparent;
            this.panelSoHD.BorderRadius = 8;
            this.panelSoHD.Controls.Add(this.lblSoHD);
            this.panelSoHD.FillColor = System.Drawing.Color.White;
            this.panelSoHD.Location = new System.Drawing.Point(375, 365);
            this.panelSoHD.Name = "panelSoHD";
            this.panelSoHD.Size = new System.Drawing.Size(100, 40);
            this.panelSoHD.TabIndex = 11;
            // 
            // panelTB
            // 
            this.panelTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelTB.BackColor = System.Drawing.Color.Transparent;
            this.panelTB.BorderRadius = 8;
            this.panelTB.Controls.Add(this.lblTrungBinh);
            this.panelTB.FillColor = System.Drawing.Color.White;
            this.panelTB.Location = new System.Drawing.Point(601, 365);
            this.panelTB.Name = "panelTB";
            this.panelTB.Size = new System.Drawing.Size(120, 40);
            this.panelTB.TabIndex = 12;
            // 
            // elipseDgv
            // 
            this.elipseDgv.BorderRadius = 12;
            this.elipseDgv.TargetControl = this.dgvDoanhThu;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(20, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tổng tiền: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(274, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Số hóa đơn: ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(506, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Trung bình:";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BorderRadius = 8;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(680, 40);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(60, 36);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "In";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // DoanhThuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(784, 449);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTB);
            this.Controls.Add(this.panelSoHD);
            this.Controls.Add(this.PanelTong);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvDoanhThu);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.lblTu);
            this.Controls.Add(this.lblDen);
            this.MinimumSize = new System.Drawing.Size(800, 488);
            this.Name = "DoanhThuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Doanh Thu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.PanelTong.ResumeLayout(false);
            this.PanelTong.PerformLayout();
            this.panelSoHD.ResumeLayout(false);
            this.panelSoHD.PerformLayout();
            this.panelTB.ResumeLayout(false);
            this.panelTB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btnExport;
    }
}