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
            KhoaNut(false);
        }
        void ClearForm()
        {
            txtMaBan.Clear();
            txtTenBan.Clear();

            if (cboTrangThai.Items.Count > 0)
                cboTrangThai.SelectedIndex = 0;
        }

        void LoadBan()
        {
            dgvBan.DataSource = bus.GetAll();

            txtMaBan.Clear();
            txtTenBan.Clear();
            if (cboTrangThai.Items.Count > 0)
                cboTrangThai.SelectedIndex = 0;
        }
        bool isAdding = false;
        bool isEditing = false;
        void KhoaNut(bool editing)
        {
            txtTenBan.Enabled = editing;
            cboTrangThai.Enabled = editing;

            btnSave.Enabled = editing;
            btnHuy.Enabled = editing;

            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            isEditing = false;

            ClearForm();
            KhoaNut(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaBan.Text == "")
            {
                MessageBox.Show("Chọn bàn cần sửa");
                return;
            }

            isAdding = false;
            isEditing = true;

            KhoaNut(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaBan.Text == "")
            {
                MessageBox.Show("Chọn bàn cần xóa");
                return;
            }

            if (MessageBox.Show("Xóa bàn này?",
                "Xác nhận",
                MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                int ma = int.Parse(txtMaBan.Text);

                bus.Delete(ma);

                MessageBox.Show("Xóa thành công 😏");

                LoadBan();
                ClearForm();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenBan.Text.Trim() == "")
            {
                MessageBox.Show("Nhập tên bàn đi fen 😏");
                return;
            }

            // THÊM
            if (isAdding)
            {
                bus.Insert(
                    txtTenBan.Text,
                    cboTrangThai.Text
                );

                MessageBox.Show("Thêm thành công");
            }

            // SỬA
            else if (isEditing)
            {
                int ma = int.Parse(txtMaBan.Text);

                bus.Update(
                    ma,
                    txtTenBan.Text,
                    cboTrangThai.Text
                );

                MessageBox.Show("Sửa thành công");
            }

            LoadBan();

            ClearForm();

            KhoaNut(false);

            isAdding = false;
            isEditing = false;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearForm();

            KhoaNut(false);

            isAdding = false;
            isEditing = false;
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