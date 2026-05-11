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
            string connStr =
                @"Data Source=DESKTOP-DJ9DDFC\SQLEXPRESS;
        Initial Catalog=QLCF;
        Integrated Security=True";

            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                conn.Open();

                string query =
                          @"SELECT *
                          FROM TaiKhoan tk
                          JOIN NhanVien nv
                          ON tk.TenDangNhap = nv.TenDangNhap
                          WHERE tk.TenDangNhap=@user
                          AND tk.MatKhau=@pass";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@user", txtUser.Text);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                 if (reader.Read())
        {
            // lưu user login
            AppState.CurrentUser =
                reader["TenNV"].ToString();

            MessageBox.Show(
                "Đăng nhập thành công!");

            this.Hide();

            MainForm f = new MainForm();

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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
