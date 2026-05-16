using QuanLyQuanCafe.BUS;
using System;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class OtpForm : Form
    {
        public OtpForm()
        {
            InitializeComponent();
        }

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();

                if (email == "")
                {
                    MessageBox.Show("Nhập email!");
                    return;
                }

                // 🔥 CHECK EMAIL CÓ TRONG DB KHÔNG
                TaiKhoanBUS bus = new TaiKhoanBUS();
                string user = bus.GetUserByEmail(email);

                if (user == null)
                {
                    MessageBox.Show("Email không tồn tại trong hệ thống!");
                    return;
                }

                // lưu user đúng
                OtpService.CurrentUser = user;
                OtpService.CurrentEmail = email;

                OtpService.GenerateOTP();
                MailService.SendOTP(email, OtpService.OTPCode);

                MessageBox.Show("OTP đã gửi 😏");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi mail: " + ex.Message);
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text.Trim() == OtpService.OTPCode)
            {
                MessageBox.Show("OTP đúng 😏");

                ChangePasswordForm f = new ChangePasswordForm();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("OTP sai!");
            }
        }
    }
}