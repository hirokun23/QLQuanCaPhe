using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe
{
    public partial class MainForm : Form
    {

        LoginDTO currentUser;

        // ================= MÀU MENU =================

        // Màu menu bình thường
        private Color defaultFillColor = Color.FromArgb(60, 167, 50);

        // Màu khi bấm vào (sáng hơn)
        private Color activeFillColor = Color.FromArgb(90, 220, 130);

        // Màu chữ
        private Color defaultForeColor = Color.WhiteSmoke;
        private Color activeForeColor = Color.White;

        // ================= DANH SÁCH MENU =================
        private List<Guna2Button> menuButtons;

        public MainForm(LoginDTO user)
        {
            InitializeComponent();
            currentUser = user;

            // ===== DANH SÁCH CÁC NÚT MENU =====
            menuButtons = new List<Guna2Button>
            {
                btnBanHang,
                btnNhanVien,
                btnKho,
                btnMenu,
                btnBan,
                btnDoanhThu,
                btnHoadon,
                btnAccount,
                btnCongthuc
            };

            // ===== STYLE CHUNG CHO MENU =====
            foreach (Guna2Button btn in menuButtons)
            {
                btn.FillColor = defaultFillColor;
                btn.ForeColor = defaultForeColor;

                btn.BorderRadius = 8;

                // Hover effect
                btn.HoverState.FillColor = Color.FromArgb(110, 150, 90);
                // Border trái
                btn.CustomBorderThickness = new Padding(4, 0, 0, 0);
                btn.CustomBorderColor = defaultFillColor;

                // Text đẹp hơn
                btn.TextAlign = HorizontalAlignment.Left;
            }
        }

        // ================= LOAD FORM =================
        void LoadForm(Form f)
        {
            panelMain.Controls.Clear();

            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            panelMain.Controls.Add(f);

            f.Show();
        }

        // ================= ACTIVE MENU =================
        private void BatDenNut(Guna2Button activeBtn)
        {
            // Reset tất cả nút
            foreach (Guna2Button btn in menuButtons)
            {
                btn.FillColor = defaultFillColor;
                btn.ForeColor = defaultForeColor;

                btn.CustomBorderColor = defaultFillColor;
            }

            // Active nút được chọn
            if (activeBtn != null)
            {
                activeBtn.FillColor = activeFillColor;
                activeBtn.ForeColor = activeForeColor;

                activeBtn.CustomBorderColor = Color.Lime;
            }
        }

        // ================= LOAD =================
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadForm(new HomeForm());

            lblTitle.Text = "Home";

            lblname.Text = "Xin chào, " + currentUser.TenNV;
            BatDenNut(null);

            // ===== PHÂN QUYỀN =====
            if (currentUser.ChucVu == "User")
            {
                btnNhanVien.Visible = false;
                btnKho.Visible = false;
                btnMenu.Visible = false;
                btnDoanhThu.Visible = false;
                btnAccount.Visible = false;
                btnCongthuc.Visible = false;
            }
        }

        // ================= LOGO =================
        private void picturelogo_Click(object sender, EventArgs e)
        {
            LoadForm(new HomeForm());

            lblTitle.Text = "Home";

            foreach (Guna2Button btn in menuButtons)
            {
                btn.FillColor = defaultFillColor;
                btn.ForeColor = defaultForeColor;
                btn.CustomBorderColor = defaultFillColor;
            }
        }

        // ================= BÁN HÀNG =================
        private void btnBanHang_Click(object sender, EventArgs e)
        {
            LoadForm(new OrderForm(currentUser));

            lblTitle.Text = "Bán hàng";

            BatDenNut(btnBanHang);
        }

        // ================= NHÂN VIÊN =================
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            LoadForm(new NhanVienForm());

            lblTitle.Text = "Nhân viên";

            BatDenNut(btnNhanVien);
        }

        // ================= KHO =================
        private void btnKho_Click(object sender, EventArgs e)
        {
            LoadForm(new KhoForm());

            lblTitle.Text = "Kho";

            BatDenNut(btnKho);
        }

        // ================= MENU =================
        private void btnMenu_Click(object sender, EventArgs e)
        {
            LoadForm(new MenuForm());

            lblTitle.Text = "Menu";

            BatDenNut(btnMenu);
        }

        // ================= QUẢN LÝ BÀN =================
        private void btnBan_Click(object sender, EventArgs e)
        {
            LoadForm(new BanForm());

            lblTitle.Text = "Quản lý bàn";

            BatDenNut(btnBan);
        }

        // ================= QUẢN LÝ HÓA ĐƠN =================
        private void btnHoadon_Click(object sender, EventArgs e)
        {
            LoadForm(new HoaDonForm());

            lblTitle.Text = "Quản lý hóa đơn";

            BatDenNut(btnHoadon);
        }
        // ================= DOANH THU =================
        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            LoadForm(new DoanhThuForm());

            lblTitle.Text = "Doanh thu";

            BatDenNut(btnDoanhThu);
        }

        // ================= THOÁT =================
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

        private void btnAccount_Click(object sender, EventArgs e)
        {
            LoadForm(new TaiKhoanForm());

            lblTitle.Text = "Quản lý tài khoản";

            BatDenNut(btnAccount);
        }

        private void btnCongthuc_Click(object sender, EventArgs e)
        {
            LoadForm(new CongThucForm());

            lblTitle.Text = "Quản lý công thức";

            BatDenNut(btnCongthuc);
        }
    }
}