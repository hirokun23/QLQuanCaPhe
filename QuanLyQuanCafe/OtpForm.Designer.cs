using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    partial class OtpForm
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtOTP;
        private Guna.UI2.WinForms.Guna2Button btnSendOTP;
        private Guna.UI2.WinForms.Guna2Button btnVerify;
        private System.Windows.Forms.Label lblTitle;

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
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSendOTP = new Guna.UI2.WinForms.Guna2Button();
            this.btnVerify = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(50, 70);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Nhập email hoặc username";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(300, 40);
            this.txtEmail.TabIndex = 1;
            // 
            // txtOTP
            // 
            this.txtOTP.BorderRadius = 10;
            this.txtOTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOTP.DefaultText = "";
            this.txtOTP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtOTP.Location = new System.Drawing.Point(50, 120);
            this.txtOTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.PlaceholderText = "Nhập mã OTP";
            this.txtOTP.SelectedText = "";
            this.txtOTP.Size = new System.Drawing.Size(300, 40);
            this.txtOTP.TabIndex = 2;
            this.txtOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSendOTP
            // 
            this.btnSendOTP.BorderRadius = 10;
            this.btnSendOTP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSendOTP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSendOTP.ForeColor = System.Drawing.Color.White;
            this.btnSendOTP.Location = new System.Drawing.Point(50, 180);
            this.btnSendOTP.Name = "btnSendOTP";
            this.btnSendOTP.Size = new System.Drawing.Size(300, 40);
            this.btnSendOTP.TabIndex = 3;
            this.btnSendOTP.Text = "Gửi OTP";
            this.btnSendOTP.Click += new System.EventHandler(this.btnSendOTP_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.BorderRadius = 10;
            this.btnVerify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(50, 230);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(300, 40);
            this.btnVerify.TabIndex = 4;
            this.btnVerify.Text = "Xác minh";
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(120, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "XÁC THỰC OTP";
            // 
            // OtpForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.btnSendOTP);
            this.Controls.Add(this.btnVerify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OtpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}