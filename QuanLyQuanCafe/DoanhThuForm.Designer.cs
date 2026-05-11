using System;
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

        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.Label lblDen;

        private void InitializeComponent()
        {
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTu = new System.Windows.Forms.Label();
            this.lblDen = new System.Windows.Forms.Label();
            this.lblSoHD = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTrungBinh = new System.Windows.Forms.Label();
            this.PanelTong = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.Location = new System.Drawing.Point(20, 80);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.ReadOnly = true;
            this.dgvDoanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoanhThu.Size = new System.Drawing.Size(707, 250);
            this.dgvDoanhThu.TabIndex = 0;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(331, 46);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(154, 20);
            this.dtpTo.TabIndex = 1;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(99, 46);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(154, 20);
            this.dtpFrom.TabIndex = 2;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThongKe.BackColor = System.Drawing.Color.Green;
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(508, 44);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongTien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(16, 383);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(100, 23);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "Tổng tiền: ";
            // 
            // lblTu
            // 
            this.lblTu.Location = new System.Drawing.Point(17, 49);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(76, 23);
            this.lblTu.TabIndex = 5;
            this.lblTu.Text = "Từ ngày:";
            // 
            // lblDen
            // 
            this.lblDen.Location = new System.Drawing.Point(259, 46);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(83, 23);
            this.lblDen.TabIndex = 6;
            this.lblDen.Text = "Đến ngày:";
            // 
            // lblSoHD
            // 
            this.lblSoHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSoHD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoHD.ForeColor = System.Drawing.Color.Red;
            this.lblSoHD.Location = new System.Drawing.Point(225, 383);
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.Size = new System.Drawing.Size(179, 23);
            this.lblSoHD.TabIndex = 7;
            this.lblSoHD.Text = "Số Hóa Đơn: ";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(619, 43);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // lblTrungBinh
            // 
            this.lblTrungBinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTrungBinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTrungBinh.ForeColor = System.Drawing.Color.Red;
            this.lblTrungBinh.Location = new System.Drawing.Point(457, 383);
            this.lblTrungBinh.Name = "lblTrungBinh";
            this.lblTrungBinh.Size = new System.Drawing.Size(179, 23);
            this.lblTrungBinh.TabIndex = 9;
            this.lblTrungBinh.Text = "Trung Bình:";
            // 
            // PanelTong
            // 
            this.PanelTong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelTong.Location = new System.Drawing.Point(113, 383);
            this.PanelTong.Name = "PanelTong";
            this.PanelTong.Size = new System.Drawing.Size(106, 23);
            this.PanelTong.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Location = new System.Drawing.Point(331, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 23);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Location = new System.Drawing.Point(573, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(106, 23);
            this.panel2.TabIndex = 11;
            // 
            // DoanhThuForm
            // 
            this.ClientSize = new System.Drawing.Size(782, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelTong);
            this.Controls.Add(this.lblTrungBinh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblSoHD);
            this.Controls.Add(this.dgvDoanhThu);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblTu);
            this.Controls.Add(this.lblDen);
            this.MinimumSize = new System.Drawing.Size(800, 488);
            this.Name = "DoanhThuForm";
            this.Text = "Quản lý Doanh Thu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        private Label lblSoHD;
        private Button btnReset;
        private Label lblTrungBinh;
        private Panel PanelTong;
        private Panel panel1;
        private Panel panel2;
    }
}