using QuanLyQuanCafe.BUS;
using QuanLyQuanCafe.DTO;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyQuanCafe
{
    public partial class LoginForm : Form
    {
        LoginBUS bus = new LoginBUS();
        private LoginDTO currentUser;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginDTO user =
                bus.Login(
                    txtUser.Text,
                    txtPass.Text
                );

            if (user != null)
            {
                MessageBox.Show(
                    "Đăng nhập thành công!");

                this.Hide();

                MainForm f = new MainForm(user);

                f.FormClosed +=
                    (s, args) => this.Close();

                f.Show();
            }
            else
            {
                MessageBox.Show(
                    "Sai tài khoản hoặc mật khẩu!");
            }
        }

        private void btnMk_Click(object sender, EventArgs e)
        {
            OtpForm f = new OtpForm();
            f.ShowDialog();
        }
    }
}