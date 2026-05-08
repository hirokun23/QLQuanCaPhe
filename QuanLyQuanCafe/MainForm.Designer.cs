namespace QuanLyQuanCafe
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picturelogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picturelogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picturelogo
            // 
            this.picturelogo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picturelogo.Location = new System.Drawing.Point(0, 0);
            this.picturelogo.Name = "picturelogo";
            this.picturelogo.Size = new System.Drawing.Size(166, 83);
            this.picturelogo.TabIndex = 0;
            this.picturelogo.TabStop = false;
            this.picturelogo.Click += new System.EventHandler(this.picturelogo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(166, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 63);
            this.panel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(53, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Home";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "User";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnDoanhThu);
            this.panel2.Controls.Add(this.btnBan);
            this.panel2.Controls.Add(this.btnKho);
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Controls.Add(this.btnNhanVien);
            this.panel2.Controls.Add(this.btnBanHang);
            this.panel2.Location = new System.Drawing.Point(-7, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 524);
            this.panel2.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(53, 475);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 46);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDoanhThu.Location = new System.Drawing.Point(7, 250);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(166, 54);
            this.btnDoanhThu.TabIndex = 10;
            this.btnDoanhThu.Text = "Doanh thu";
            this.btnDoanhThu.UseVisualStyleBackColor = false;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // btnBan
            // 
            this.btnBan.BackColor = System.Drawing.Color.SpringGreen;
            this.btnBan.Location = new System.Drawing.Point(7, 200);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(166, 54);
            this.btnBan.TabIndex = 9;
            this.btnBan.Text = "Bàn";
            this.btnBan.UseVisualStyleBackColor = false;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // btnKho
            // 
            this.btnKho.BackColor = System.Drawing.Color.SpringGreen;
            this.btnKho.Location = new System.Drawing.Point(7, 151);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(166, 54);
            this.btnKho.TabIndex = 8;
            this.btnKho.Text = "Kho";
            this.btnKho.UseVisualStyleBackColor = false;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.SpringGreen;
            this.btnMenu.Location = new System.Drawing.Point(7, 101);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(166, 54);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.SpringGreen;
            this.btnNhanVien.Location = new System.Drawing.Point(7, 51);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(166, 54);
            this.btnNhanVien.TabIndex = 6;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.BackColor = System.Drawing.Color.SpringGreen;
            this.btnBanHang.Location = new System.Drawing.Point(7, 0);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(166, 54);
            this.btnBanHang.TabIndex = 5;
            this.btnBanHang.Text = "Bán Hàng";
            this.btnBanHang.UseVisualStyleBackColor = false;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.DimGray;
            this.panelMain.Location = new System.Drawing.Point(166, 63);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1056, 542);
            this.panelMain.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 603);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picturelogo);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturelogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturelogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
    }
}