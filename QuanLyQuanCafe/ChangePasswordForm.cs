using System;
using System.Windows.Forms;
using QuanLyQuanCafe.BUS;

namespace QuanLyQuanCafe
{
    public partial class ChangePasswordForm : Form
    {
        TaiKhoanBUS bus = new TaiKhoanBUS();

        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!");
                return;
            }

            bus.UpdatePassword(
                OtpService.CurrentUser,
                txtNewPass.Text.Trim()
            );

            MessageBox.Show("Đổi mật khẩu thành công 😏");
            this.Close();
        }
    }
}