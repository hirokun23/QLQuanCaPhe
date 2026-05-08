using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void LoadForm(Form f)
        {
            panelMain.Controls.Clear();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelMain.Controls.Add(f);
            f.Show();
        }
        private void picturelogo_Click(object sender, EventArgs e)
        {
            LoadForm(new HomeForm());
            lblTitle.Text = "Home";
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadForm(new HomeForm());
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            LoadForm(new OrderForm());
            lblTitle.Text = "Bán hàng";
        }


        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            LoadForm(new NhanVienForm());
            lblTitle.Text = "Nhân viên";
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            LoadForm(new KhoForm());
            lblTitle.Text = "Kho";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            LoadForm(new MenuForm());
            lblTitle.Text = "Menu";
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            LoadForm(new BanForm());
            lblTitle.Text = "Quản lý bàn";
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            LoadForm(new DoanhThuForm());
            lblTitle.Text = "Doanh thu";
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(
        "Bạn có muốn thoát không?",
        "Thông báo",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        
        

        
    }
}
