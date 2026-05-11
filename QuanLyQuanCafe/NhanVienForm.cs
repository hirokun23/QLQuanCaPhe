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

        NhanVienBUS nvBus;
        NhanVienDTO nvInfo;
        string action = "";

        public NhanVienForm()
        {
            InitializeComponent();
        }

        // LOAD FORM
        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            

            nvBus = new NhanVienBUS();
            nvInfo = new NhanVienDTO();

            LoadGrid();
            KhoaNut(false);
        }

        int currentRowIndex = -1;

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

            if (currentRowIndex >= 0
                && currentRowIndex < dgvNhanVien.Rows.Count)
            {
                dgvNhanVien.Rows[currentRowIndex].Selected = true;

                dgvNhanVien.CurrentCell =
                    dgvNhanVien.Rows[currentRowIndex].Cells[1];
            }
        }



        void KhoaNut(bool editing)
        {
            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;

            btnSave.Enabled = editing;

            txtTenNV.Enabled = editing;
            dtNgaySinh.Enabled = editing;
            txtSDT.Enabled = editing;
            cbGioiTinh.Enabled = editing;
            txtDiaChi.Enabled = editing;
            txtChucVu.Enabled = editing;
            txtLuong.Enabled = editing;
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

        bool isAdding = false;
        bool isEditing = false;

        // ================= THÊM =================
        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            isEditing = false;

            ClearForm();
            KhoaNut(true);

            btnSave.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        // ================= SỬA =================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Chọn nhân viên!");
                return;
            }

            isAdding = false;
            isEditing = true;

            btnSave.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            KhoaNut(true);
        }

        // ================= XÓA =================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Chọn nhân viên để xóa!");
                return;
            }

            DialogResult rs = MessageBox.Show(
                "Xóa nhân viên này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rs == DialogResult.Yes)
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

        // ================= LƯU =================
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!getData()) return;

            // thêm
            if (isAdding)
            {
                if (nvBus.insert())
                {
                    MessageBox.Show("Thêm thành công!");
                }
            }

            // sửa
            else if (isEditing)
            {
                if (nvBus.update())
                {
                    MessageBox.Show("Sửa thành công!");
                }
            }

            LoadGrid();

            ClearForm();
            KhoaNut(false);

            isAdding = false;
            isEditing = false;

            btnSave.Enabled = false;
            btnHuy.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        // ================= HỦY =================
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearForm();
            KhoaNut(false);

            isAdding = false;
            isEditing = false;

            btnSave.Enabled = false;
            btnHuy.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
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

                currentRowIndex = e.RowIndex;
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