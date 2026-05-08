using QuanLyQuanCafe.BUS;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class OrderForm : Form
    {
        MonBUS monBUS = new MonBUS();

        int currentTable = 0;

        public OrderForm()
        {
            InitializeComponent();
            this.Load += OrderForm_Load;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadTable();
            LoadMenu();
        }

        // ================= LOAD BÀN =================
        void LoadTable()
        {
            flowLayoutPanelTable.Controls.Clear();

            int soBan = 50;

            for (int i = 1; i <= soBan; i++)
            {
                Button btn = new Button();
                btn.Width = 80;
                btn.Height = 80;
                btn.Margin = new Padding(5);

                string state = "empty";

                if (AppState.BanTrangThai.ContainsKey(i))
                    state = AppState.BanTrangThai[i];

                btn.Tag = i; // lưu mã bàn

                if (state == "full")
                {
                    btn.Text = $"Bàn {i}\nCó khách";
                    btn.BackColor = Color.Orange;
                }
                else
                {
                    btn.Text = $"Bàn {i}\nTrống";
                    btn.BackColor = Color.LightBlue;
                }

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
                Panel p = new Panel();
                p.Width = 120;
                p.Height = 150;
                p.BorderStyle = BorderStyle.FixedSingle;
                p.Margin = new Padding(10);

                Label lblName = new Label();
                lblName.Text = row["TenMon"].ToString();
                lblName.Top = 95;
                lblName.Left = 10;
                lblName.AutoSize = true;

                Label lblPrice = new Label();
                lblPrice.Text = row["Gia"].ToString();
                lblPrice.Top = 115;
                lblPrice.Left = 10;
                lblPrice.AutoSize = true;

                p.Controls.Add(lblName);
                p.Controls.Add(lblPrice);

                p.Tag = row;

                p.Click += ChonMon;
                lblName.Click += ChonMon;

                flowLayoutPanelMenu.Controls.Add(p);
            }
        }

        // ================= CHỌN BÀN =================
        void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            int maBan = (int)btn.Tag;
            currentTable = maBan;

            AppState.BanTrangThai[maBan] = "full";

            LoadTable();

            lblTitle.Text = $"Chi tiết hóa đơn - Bàn {maBan}";

            LoadBill(maBan);
        }

        // ================= CHỌN MÓN =================
        void ChonMon(object sender, EventArgs e)
        {
            if (currentTable == 0)
            {
                MessageBox.Show("Vui lòng chọn bàn!");
                return;
            }

            Control c = sender as Control;
            Panel p = (c is Panel) ? (Panel)c : (Panel)c.Parent;

            DataRow row = (DataRow)p.Tag;

            string tenMon = row["TenMon"].ToString();
            float gia = Convert.ToSingle(row["Gia"]);

            if (!AppState.BillTheoBan.ContainsKey(currentTable))
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("STT");
                dt.Columns.Add("TenMon");
                dt.Columns.Add("Gia");
                dt.Columns.Add("SL");

                AppState.BillTheoBan[currentTable] = dt;
            }

            var bill = AppState.BillTheoBan[currentTable];

            foreach (DataRow r in bill.Rows)
            {
                if (r["TenMon"].ToString() == tenMon)
                {
                    r["SL"] = Convert.ToInt32(r["SL"]) + 1;
                    LoadBill(currentTable);
                    return;
                }
            }

            bill.Rows.Add(bill.Rows.Count + 1, tenMon, gia, 1);

            LoadBill(currentTable);
        }

        // ================= LOAD BILL =================
        void LoadBill(int maBan)
        {
            dgvBill.Rows.Clear();

            if (!AppState.BillTheoBan.ContainsKey(maBan))
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("STT");
                dt.Columns.Add("TenMon");
                dt.Columns.Add("Gia");
                dt.Columns.Add("SL");

                AppState.BillTheoBan[maBan] = dt;
            }

            foreach (DataRow row in AppState.BillTheoBan[maBan].Rows)
            {
                dgvBill.Rows.Add(
                    row["STT"],
                    row["TenMon"],
                    row["Gia"],
                    row["SL"]
                );
            }

            TinhTien();
        }

        // ================= TÍNH TIỀN =================
        void TinhTien()
        {
            int tong = 0;

            foreach (DataGridViewRow row in dgvBill.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    int gia = Convert.ToInt32(row.Cells[2].Value);
                    int sl = Convert.ToInt32(row.Cells[3].Value);

                    tong += gia * sl;
                }
            }

            int giam = string.IsNullOrEmpty(txtDiscount.Text) ? 0 : Convert.ToInt32(txtDiscount.Text);
            int phuthu = string.IsNullOrEmpty(txtExtra.Text) ? 0 : Convert.ToInt32(txtExtra.Text);

            txtTotal.Text = (tong - giam + phuthu).ToString();
        }

        // ================= THANH TOÁN =================
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (currentTable == 0)
            {
                MessageBox.Show("Chưa chọn bàn!");
                return;
            }

            if (!AppState.BillTheoBan.ContainsKey(currentTable)
    || AppState.BillTheoBan[currentTable].Rows.Count == 0)
            {
                MessageBox.Show("Chưa có món!");
                return;
            }

            DialogResult rs = MessageBox.Show(
                "Xác nhận thanh toán?",
                "Thanh toán",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rs == DialogResult.Yes)
            {
                // reset trạng thái bàn
                AppState.BanTrangThai[currentTable] = "empty";

                // xóa bill
                if (AppState.BillTheoBan.ContainsKey(currentTable))
                {
                    AppState.BillTheoBan.Remove(currentTable);
                }

                // reset giao diện
                currentTable = 0;

                dgvBill.Rows.Clear();

                txtTotal.Text = "0";

                lblTitle.Text = "Chưa chọn bàn";

                // load lại bàn
                LoadTable();

                MessageBox.Show("Thanh toán thành công!");
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvBill.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn món!");
                return;
            }

            int sl =
                Convert.ToInt32(
                    dgvBill.SelectedRows[0].Cells[3].Value);

            dgvBill.SelectedRows[0].Cells[3].Value =
                sl + 1;

            TinhTien();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBill.SelectedRows.Count == 0) return;

            dgvBill.Rows.RemoveAt(dgvBill.SelectedRows[0].Index);
            TinhTien();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (currentTable == 0)
            {
                MessageBox.Show("Chưa chọn bàn!");
                return;
            }

            DialogResult rs = MessageBox.Show(
                "Hủy hóa đơn bàn này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rs == DialogResult.Yes)
            {
                // reset trạng thái bàn
                AppState.BanTrangThai[currentTable] = "empty";

                // xóa bill
                if (AppState.BillTheoBan.ContainsKey(currentTable))
                {
                    AppState.BillTheoBan.Remove(currentTable);
                }

                // reset giao diện
                dgvBill.Rows.Clear();

                txtTotal.Text = "0";

                lblTitle.Text = "Chưa chọn bàn";

                currentTable = 0;

                // reload lại bàn
                LoadTable();

                MessageBox.Show("Đã hủy hóa đơn!");
            }
        }
    }
}