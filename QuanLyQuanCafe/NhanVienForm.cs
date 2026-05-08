using QuanLyQuanCafe.BUS;
using QuanLyQuanCafe.Data;
using QuanLyQuanCafe.DTO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class NhanVienForm : Form
    {
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLCF;Integrated Security=True";

        NhanVienBUS nvBus;
        NhanVienDTO nvInfo;

        public NhanVienForm()
        {
            InitializeComponent();
        }

        // LOAD FORM
        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            DataProvider.connectionString = connStr;

            DataProvider provider = new DataProvider();
            provider.connect();

            nvBus = new NhanVienBUS();
            nvInfo = new NhanVienDTO();

            LoadGrid();
        }

        // LOAD DATA GRID
        private void LoadGrid()
        {
            dgvNhanVien.AutoGenerateColumns = true;

            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = nvBus.getDSNhanVien();

            dgvNhanVien.DefaultCellStyle.ForeColor = Color.Black;
            dgvNhanVien.DefaultCellStyle.BackColor = Color.White;

            dgvNhanVien.RowTemplate.Height = 25;

            foreach (DataGridViewColumn col in dgvNhanVien.Columns)
            {
                col.Visible = true;
            }

            if (dgvNhanVien.Columns["MaNV"] != null)
                dgvNhanVien.Columns["MaNV"].Visible = false;
        }

        // LẤY DATA TỪ FORM
        private bool getData()
        {
            nvInfo.TenNV = txtTenNV.Text;
            nvInfo.NgaySinh = dtNgaySinh.Value;
            nvInfo.SDT = txtSDT.Text;
            nvInfo.GioiTinh = cbGioiTinh.Text;
            nvInfo.DiaChi = txtDiaChi.Text;
            nvInfo.ChucVu = txtChucVu.Text;

            if (!float.TryParse(txtLuong.Text, out float luong))
            {
                MessageBox.Show("Lương phải là số!");
                return false;
            }

            nvInfo.Luong = luong;

            if (dgvNhanVien.CurrentRow != null)
            {
                nvInfo.MaNV = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["MaNV"].Value);
            }

            nvBus.info = nvInfo;
            return true;
        }

        // THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!getData()) return;

            if (nvBus.insert())
            {
                MessageBox.Show("Thêm thành công!");
                LoadGrid();
                ClearForm();
            }
        }

        // SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!getData()) return;

            if (nvBus.update())
            {
                MessageBox.Show("Sửa thành công!");
                LoadGrid();
                ClearForm();
            }
        }

        // XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Chọn nhân viên để xóa!");
                return;
            }

            if (MessageBox.Show("Xóa?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!getData()) return;

                if (nvBus.delete())
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadGrid();
                    ClearForm();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        // CLICK GRID
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                txtTenNV.Text = row.Cells["TenNV"].Value.ToString();
                dtNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                cbGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtChucVu.Text = row.Cells["ChucVu"].Value.ToString();
                txtLuong.Text = row.Cells["Luong"].Value.ToString();
            }
        }

        // TÌM KIẾM (simple)
        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            DataTable dt = nvBus.getDSNhanVien();

            DataView dv = dt.DefaultView;
            dv.RowFilter = $"TenNV LIKE '%{keyword}%'";

            dgvNhanVien.DataSource = dv.ToTable();
        }

        // CLEAR FORM
        private void ClearForm()
        {
            txtTenNV.Clear();
            txtSDT.Clear();
            cbGioiTinh.SelectedIndex = -1;
            txtDiaChi.Clear();
            txtChucVu.Clear();
            txtLuong.Clear();
        }
    }
}