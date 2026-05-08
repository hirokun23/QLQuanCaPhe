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
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.Label lblDen;

        private void InitializeComponent()
        {
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTu = new System.Windows.Forms.Label();
            this.lblDen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.Location = new System.Drawing.Point(20, 80);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.Size = new System.Drawing.Size(600, 250);
            this.dgvDoanhThu.TabIndex = 0;
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTuNgay.Location = new System.Drawing.Point(316, 14);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(154, 20);
            this.dtTuNgay.TabIndex = 1;
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDenNgay.Location = new System.Drawing.Point(90, 14);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(154, 20);
            this.dtDenNgay.TabIndex = 2;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Green;
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(545, 15);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(20, 350);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(100, 23);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "Tổng tiền: 0";
            // 
            // lblTu
            // 
            this.lblTu.Location = new System.Drawing.Point(20, 20);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(100, 23);
            this.lblTu.TabIndex = 5;
            this.lblTu.Text = "Từ ngày:";
            // 
            // lblDen
            // 
            this.lblDen.Location = new System.Drawing.Point(250, 20);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(100, 23);
            this.lblDen.TabIndex = 6;
            this.lblDen.Text = "Đến ngày:";
            // 
            // DoanhThuForm
            // 
            this.ClientSize = new System.Drawing.Size(782, 449);
            this.Controls.Add(this.dgvDoanhThu);
            this.Controls.Add(this.dtTuNgay);
            this.Controls.Add(this.dtDenNgay);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblTu);
            this.Controls.Add(this.lblDen);
            this.Name = "DoanhThuForm";
            this.Text = "Quản lý Doanh Thu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

    }
}