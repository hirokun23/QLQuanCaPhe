using QuanLyQuanCafe.BUS;
using QuanLyQuanCafe.DTO;
using System;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace QuanLyQuanCafe
{
    public partial class OrderForm : Form
    {
        private LoginDTO currentUser;
        MonBUS monBUS = new MonBUS();
        OrderBUS orderBUS = new OrderBUS();
        BanBUS banBUS = new BanBUS();   
        int currentTable = 0;
        

        public OrderForm(LoginDTO user)
        {
            InitializeComponent();
            currentUser = user;
            dtpCreated.Value = DateTime.Now;
            this.Load += OrderForm_Load;
            txtDiscount.TextChanged += (s, e) => UpdateTotal();
            txtExtra.TextChanged += (s, e) => UpdateTotal();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadTable();
            LoadMenu();
            LoadCategory();

            cboStaff.Items.Add(currentUser.TenNV);
            cboStaff.SelectedIndex = 0;
        }

        // ================= LOAD BÀN =================
        void LoadTable()
        {
            flowLayoutPanelTable.Controls.Clear();

            DataTable dt = banBUS.GetAll();

            foreach (DataRow row in dt.Rows)
            {
                int maBan = (int)row["MaBan"];
                string trangThai = row["TrangThai"].ToString();

                Guna2Button btn = new Guna2Button();

                btn.Width = 85;
                btn.Height = 85;
                btn.Margin = new Padding(6);

                // ===== BO GÓC =====
                btn.BorderRadius = 15;

                // ===== FONT =====
                btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btn.TextAlign = HorizontalAlignment.Center;

                // ===== DATA =====
                btn.Tag = maBan;
                btn.Text = $"Bàn {maBan}\n{trangThai}";

                // ===== MÀU THEO TRẠNG THÁI =====
                if (trangThai == "Có khách")
                {
                    btn.FillColor = Color.FromArgb(60, 167, 50);
                    btn.ForeColor = Color.White;
                }
                else
                {
                    btn.FillColor = Color.LightSkyBlue;
                    btn.ForeColor = Color.Black;
                }

                // ===== CLICK =====
                btn.Click += Btn_Click;

                flowLayoutPanelTable.Controls.Add(btn);
            }
        }

        // ================= LOAD MENU =================
        void LoadMenu()
        {
            flowLayoutPanelMenu.Controls.Clear();

            DataTable dt = monBUS.GetAll();

            foreach (DataRow row in dt.Rows)
            {
                Guna2Panel p = new Guna2Panel();

                p.Width = 130;
                p.Height = 170;

                p.Margin = new Padding(12);

                p.BorderRadius = 18;

                p.FillColor = Color.FromArgb(248, 249, 250);

                p.ShadowDecoration.Enabled = true;
                p.ShadowDecoration.Depth = 8;
                p.ShadowDecoration.BorderRadius = 18;

                p.Cursor = Cursors.Hand;

                // ===== ẢNH =====
                PictureBox pic = new PictureBox();

                pic.Width = 115;
                pic.Height = 105;

                pic.Top = 10;
                pic.Left = 15;

                pic.SizeMode = PictureBoxSizeMode.Zoom;

                pic.BackColor = Color.Transparent;

                string path = row["HinhAnh"].ToString();

                if (System.IO.File.Exists(path))
                {
                    using (var stream = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        pic.Image = Image.FromStream(stream);
                    }
                }

                // ===== TÊN =====
                Label lblName = new Label();

                lblName.Text = row["TenMon"].ToString();

                lblName.Top = 118;
                lblName.Left = 5;

                lblName.Width = 120;
                lblName.Height = 32;

                lblName.TextAlign = ContentAlignment.MiddleCenter;

                lblName.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                lblName.ForeColor = Color.FromArgb(40, 40, 40);


                // ===== GIÁ =====
                Label lblPrice = new Label();

                lblPrice.Text = row["Gia"].ToString() + " đ";

                lblPrice.Top = 145;
                lblPrice.Left = 5;

                lblPrice.Width = 120;

                lblPrice.TextAlign = ContentAlignment.MiddleCenter;

                lblPrice.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                lblPrice.ForeColor = Color.FromArgb(220, 53, 69);


                // ===== ADD CONTROL =====
                p.Controls.Add(pic);
                p.Controls.Add(lblName);
                p.Controls.Add(lblPrice);

                p.Tag = row;

                // ===== CLICK =====
                p.Click += ChonMon;
                pic.Click += ChonMon;
                lblName.Click += ChonMon;
                lblPrice.Click += ChonMon;

                flowLayoutPanelMenu.Controls.Add(p);
            }
        }

        // ================= CHỌN BÀN =================
        void Btn_Click(object sender, EventArgs e)
        {
            var btn = sender as Guna2Button;
            if (btn == null || btn.Tag == null) return;

            int maBan = Convert.ToInt32(btn.Tag);

            currentTable = maBan;
            txtTable.Text = maBan.ToString();

            banBUS.UpdateTrangThai(maBan, "Có khách");
            LoadTable();

            lblTitle.Text = $"Chi tiết hóa đơn - Bàn {maBan}";
            LoadBill();
        }
        int selectedMaMon = -1;
        // ================= CHỌN MÓN =================
        void ChonMon(object sender, EventArgs e)
        {
            if (currentTable == 0)
            {
                MessageBox.Show("Chọn bàn trước!");
                return;
            }

            Control c = sender as Control;
            Guna2Panel p = c.Parent as Guna2Panel ?? c as Guna2Panel;

            DataRow row = (DataRow)p.Tag;

            orderBUS.AddMon(
                currentTable,
                Convert.ToInt32(row["MaMon"]),
                Convert.ToDecimal(row["Gia"])
            );

            LoadBill();
        }

        // ================= LOAD BILL =================
        void LoadBill()
        {
            dgvBill.Rows.Clear();

            if (currentTable == 0) return;

            DataTable bill = orderBUS.GetBill(currentTable);

            foreach (DataRow row in bill.Rows)
            {
                dgvBill.Rows.Add(
                    row["MaMon"],
                    row["TenMon"],
                    row["DonGia"],
                    row["SoLuong"]
                );
            }

            txtTotal.Text = orderBUS.TinhTien(currentTable, 0, 0).ToString();
        }

        // ================= TÍNH TIỀN =================
        private void UpdateTotal()
        {
            decimal giam = 0;
            decimal phuThu = 0;

            decimal.TryParse(txtDiscount.Text, out giam);
            decimal.TryParse(txtExtra.Text, out phuThu);

            txtTotal.Text = orderBUS.TinhTien(currentTable, giam, phuThu).ToString();
        }

        // ================= THANH TOÁN =================
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (currentTable == 0)
            {
                MessageBox.Show("Chưa chọn bàn!");
                return;
            }

            DataTable bill = orderBUS.GetBill(currentTable);

            if (bill.Rows.Count == 0)
            {
                MessageBox.Show("Chưa chọn món!");
                return;
            }

            decimal tongTien = Convert.ToDecimal(txtTotal.Text);
            decimal giam = string.IsNullOrWhiteSpace(txtDiscount.Text) ? 0 : Convert.ToDecimal(txtDiscount.Text);
            decimal phuThu = string.IsNullOrWhiteSpace(txtExtra.Text) ? 0 : Convert.ToDecimal(txtExtra.Text);
            int maNV = 1;

            OrderDTO dto = new OrderDTO
            {
                MaBan = currentTable,
                MaNV = maNV,
                GiamGia = giam,
                PhuThu = phuThu
            };

            orderBUS.ThanhToan(currentTable, dto);

            banBUS.UpdateTrangThai(currentTable, "Trống");

            dgvBill.Rows.Clear();
            txtTotal.Text = "0";
            currentTable = 0;

            LoadTable();

            MessageBox.Show("Thanh toán thành công!");
        }




        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (currentTable == 0) return;

            DialogResult rs = MessageBox.Show(
                "Hủy hóa đơn?",
                "Confirm",
                MessageBoxButtons.YesNo);

            if (rs == DialogResult.Yes)
            {
                orderBUS.HuyHoaDon(currentTable);

                banBUS.UpdateTrangThai(currentTable, "Trống");

                dgvBill.Rows.Clear();
                txtTotal.Text = "0";
                currentTable = 0;

                LoadTable();

                MessageBox.Show("Đã hủy!");
            }
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            if (selectedMaMon == -1 || currentTable == 0) return;

            orderBUS.TangSoLuong(currentTable, selectedMaMon);
            LoadBill();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (selectedMaMon == -1 || currentTable == 0) return;

            orderBUS.GiamSoLuong(currentTable, selectedMaMon);
            LoadBill();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedMaMon == -1) return;

            orderBUS.RemoveMon(currentTable, selectedMaMon);

            selectedMaMon = -1;

            LoadBill();
        }

        void LoadCategory()
        {
            cboLoai.Items.Clear();
            cboLoai.Items.Add("All");
            cboLoai.Items.Add("Cafe");
            cboLoai.Items.Add("Trà");
            cboLoai.Items.Add("Nước ép");
            cboLoai.Items.Add("Sinh tố");
            cboLoai.Items.Add("Nước ngọt");

            cboLoai.SelectedIndex = 0;
        }
        void FilterMenu()
        {
            string loai = cboLoai.Text;
            DataTable dt = monBUS.GetAll();

            if (loai == "All")
            {
                RenderMenu(dt);
                return;
            }

            DataTable filtered = dt.Clone();

            foreach (DataRow row in dt.Rows)
            {
                if (row["Loai"].ToString() == loai)
                    filtered.ImportRow(row);
            }

            RenderMenu(filtered);
        }

        private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterMenu();
        }
        void RenderMenu(DataTable dt)
        {
            flowLayoutPanelMenu.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                Guna2Panel p = new Guna2Panel();

                p.Width = 130;
                p.Height = 170;

                p.Margin = new Padding(12);

                p.BorderRadius = 18;

                p.FillColor = Color.FromArgb(248, 249, 250);

                p.ShadowDecoration.Enabled = true;
                p.ShadowDecoration.Depth = 8;
                p.ShadowDecoration.BorderRadius = 18;

                p.Cursor = Cursors.Hand;

                PictureBox pic = new PictureBox();

                pic.Width = 115;
                pic.Height = 105;

                pic.Top = 10;
                pic.Left = 15;

                pic.SizeMode = PictureBoxSizeMode.Zoom;

                pic.BackColor = Color.Transparent;

                string path = row["HinhAnh"].ToString();

                if (System.IO.File.Exists(path))
                {
                    using (var stream = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        pic.Image = Image.FromStream(stream);
                    }
                }

                // ===== TÊN =====
                Label lblName = new Label();

                lblName.Text = row["TenMon"].ToString();

                lblName.Top = 118;
                lblName.Left = 5;

                lblName.Width = 120;
                lblName.Height = 32;

                lblName.TextAlign = ContentAlignment.MiddleCenter;

                lblName.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                lblName.ForeColor = Color.FromArgb(40, 40, 40);


                // ===== GIÁ =====
                Label lblPrice = new Label();

                lblPrice.Text = row["Gia"].ToString() + " đ";

                lblPrice.Top = 145;
                lblPrice.Left = 5;

                lblPrice.Width = 120;

                lblPrice.TextAlign = ContentAlignment.MiddleCenter;

                lblPrice.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                lblPrice.ForeColor = Color.FromArgb(220, 53, 69);

                // ===== ADD CONTROL =====
                p.Controls.Add(pic);
                p.Controls.Add(lblName);
                p.Controls.Add(lblPrice);

                p.Tag = row;

                // ===== CLICK =====
                p.Click += ChonMon;
                pic.Click += ChonMon;
                lblName.Click += ChonMon;
                lblPrice.Click += ChonMon;

                flowLayoutPanelMenu.Controls.Add(p);
            }
        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            dgvBill.ClearSelection();
            dgvBill.Rows[e.RowIndex].Selected = true;

            selectedMaMon = Convert.ToInt32(
                dgvBill.Rows[e.RowIndex].Cells[0].Value
            );
        }
    }
}