using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel panelLogin;
        private System.Windows.Forms.Label lblTitle, lblUser, lblPass;
        private Guna.UI2.WinForms.Guna2TextBox txtUser, txtPass;
        private Guna.UI2.WinForms.Guna2Button btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnMk = new Guna.UI2.WinForms.Guna2Button();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.BorderRadius = 15;
            this.panelLogin.Controls.Add(this.btnMk);
            this.panelLogin.Controls.Add(this.lblTitle);
            this.panelLogin.Controls.Add(this.lblUser);
            this.panelLogin.Controls.Add(this.txtUser);
            this.panelLogin.Controls.Add(this.lblPass);
            this.panelLogin.Controls.Add(this.txtPass);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(20)))));
            this.panelLogin.Location = new System.Drawing.Point(50, 60);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.ShadowDecoration.BorderRadius = 15;
            this.panelLogin.ShadowDecoration.Enabled = true;
            this.panelLogin.Size = new System.Drawing.Size(300, 334);
            this.panelLogin.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Orange;
            this.lblTitle.Location = new System.Drawing.Point(50, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(197, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Coffee Manager";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(30, 75);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(68, 17);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Tài khoản";
            // 
            // txtUser
            // 
            this.txtUser.BorderRadius = 8;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultText = "";
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtUser.Location = new System.Drawing.Point(30, 95);
            this.txtUser.Name = "txtUser";
            this.txtUser.PlaceholderText = "Nhập tên đăng nhập...";
            this.txtUser.SelectedText = "";
            this.txtUser.Size = new System.Drawing.Size(240, 36);
            this.txtUser.TabIndex = 2;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(30, 145);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(66, 17);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Mật khẩu";
            // 
            // txtPass
            // 
            this.txtPass.BorderRadius = 8;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPass.Location = new System.Drawing.Point(30, 165);
            this.txtPass.Name = "txtPass";
            this.txtPass.PlaceholderText = "Nhập mật khẩu...";
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(240, 36);
            this.txtPass.TabIndex = 4;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 8;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FillColor = System.Drawing.Color.SaddleBrown;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(30, 235);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(240, 45);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnMk
            // 
            this.btnMk.BorderRadius = 8;
            this.btnMk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMk.FillColor = System.Drawing.Color.SaddleBrown;
            this.btnMk.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnMk.ForeColor = System.Drawing.Color.White;
            this.btnMk.Location = new System.Drawing.Point(80, 295);
            this.btnMk.Name = "btnMk";
            this.btnMk.Size = new System.Drawing.Size(146, 25);
            this.btnMk.TabIndex = 6;
            this.btnMk.Text = "Quên mật khẩu";
            this.btnMk.Click += new System.EventHandler(this.btnMk_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2Button btnMk;
    }
}