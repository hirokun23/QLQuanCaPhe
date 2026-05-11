using System;
using System.Data;
using System.Windows.Forms;
using QuanLyQuanCafe.BUS;

namespace QuanLyQuanCafe
{
    public partial class BanForm : Form
    {
        BanBUS bus = new BanBUS();

        public BanForm()
        {
            InitializeComponent();
        }

        private void BanForm_Load(object sender, EventArgs e)
        {
            LoadBan();
        }

        void LoadBan()
        {
            dgvBan.DataSource = bus.GetAll();

            txtMaBan.Clear();
            txtTenBan.Clear();
            if (cboTrangThai.Items.Count > 0)
                cboTrangThai.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenBan.Text.Trim() == "")
            {
                MessageBox.Show("Nhập tên bàn đi fen 😏");
                return;
            }

            bus.Insert(txtTenBan.Text, cboTrangThai.Text);
            MessageBox.Show("Thêm thành công");
            LoadBan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaBan.Text == "")
            {
                MessageBox.Show("Chọn bàn cần sửa");
                return;
            }

            int ma;
            if (!int.TryParse(txtMaBan.Text, out ma))
            {
                MessageBox.Show("Mã bàn không hợp lệ");
                return;
            }
            bus.Update(ma, txtTenBan.Text, cboTrangThai.Text);

            MessageBox.Show("Sửa thành công");
            LoadBan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaBan.Text == "")
            {
                MessageBox.Show("Chọn bàn cần xóa");
                return;
            }

            if (MessageBox.Show("Xóa bàn này?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int ma = int.Parse(txtMaBan.Text);
                bus.Delete(ma);

                MessageBox.Show("Xóa thành công");
                LoadBan();
            }
        }

        private void dgvBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvBan.Rows[e.RowIndex];

            txtMaBan.Text = row.Cells["MaBan"].Value?.ToString();
            txtTenBan.Text = row.Cells["TenBan"].Value?.ToString();
            cboTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
        }
    }
}