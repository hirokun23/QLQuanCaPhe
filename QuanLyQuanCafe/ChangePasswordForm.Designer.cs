using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    partial class ChangePasswordForm
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2TextBox txtNewPass;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPass;
        private Guna.UI2.WinForms.Guna2Button btnSave;
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
            this.txtNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewPass
            // 
            this.txtNewPass.BorderRadius = 10;
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.DefaultText = "";
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewPass.Location = new System.Drawing.Point(50, 70);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '●';
            this.txtNewPass.PlaceholderText = "Mật khẩu mới";
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.Size = new System.Drawing.Size(300, 40);
            this.txtNewPass.TabIndex = 1;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BorderRadius = 10;
            this.txtConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPass.DefaultText = "";
            this.txtConfirmPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConfirmPass.Location = new System.Drawing.Point(50, 120);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '●';
            this.txtConfirmPass.PlaceholderText = "Xác nhận mật khẩu";
            this.txtConfirmPass.SelectedText = "";
            this.txtConfirmPass.Size = new System.Drawing.Size(300, 40);
            this.txtConfirmPass.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(50, 180);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(300, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu mật khẩu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(120, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐỔI MẬT KHẨU";
            // 
            // ChangePasswordForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}