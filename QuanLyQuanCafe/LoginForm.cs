using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connStr = @"Data Source=DESKTOP-DJ9DDFC\SQLEXPRESS;Initial Catalog=QLCF;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap=@user AND MatKhau=@pass";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", txtUser.Text);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công!");

                    this.Hide();

                    MainForm f = new MainForm();
                    f.FormClosed += (s, args) => this.Close();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
