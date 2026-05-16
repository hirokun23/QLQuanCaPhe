using QuanLyQuanCafe.BUS;
using QuanLyQuanCafe.DTO;
using System;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class LoginForm : Form
    {
        LoginBUS bus = new LoginBUS();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            shadowForm.SetShadowForm(this);

            string imagePathPng = Application.StartupPath + @"\Images\cafe_bg.png";

            if (System.IO.File.Exists(imagePathPng))
            {
                picBackground.Image = System.Drawing.Image.FromFile(imagePathPng);
            }

            panelLogin.Parent = picBackground;
            picBackground.SendToBack();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginDTO user = bus.Login(txtUser.Text, txtPass.Text);

            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                MainForm f = new MainForm(user);
                f.FormClosed += (s, args) =>
                {
                    this.Close();
                };

                f.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMk_Click(object sender, EventArgs e)
        {
            OtpForm f = new OtpForm();
            f.ShowDialog();
        }
    }
}