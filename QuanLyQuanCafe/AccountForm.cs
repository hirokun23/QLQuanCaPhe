using System;
using System.Data;
using System.Windows.Forms;
using QuanLyQuanCafe.BUS; // Đảm bảo bạn đã có lớp BUS này

namespace QuanLyQuanCafe
{
    public partial class TaiKhoanForm : Form
    {
        // Khởi tạo lớp nghiệp vụ
        TaiKhoanBUS bus = new TaiKhoanBUS();

        // Biến trạng thái để xác định đang Thêm hay Sửa
        bool isAdding = false;
        bool isEditing = false;

        public TaiKhoanForm()
        {
            InitializeComponent();
        }

        private void TaiKhoanForm_Load(object sender, EventArgs e)
        {
            LoadData();
            KhoaNut(false); // Ban đầu khóa các ô nhập liệu
        }

        /// <summary>
        /// Tải dữ liệu từ SQL lên DataGridView
        /// </summary>
        void LoadData()
        {
            try
            {
                dgvTaiKhoan.DataSource = bus.GetAll();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xóa trống các ô nhập liệu
        /// </summary>
        void ClearForm()
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtEmail.Clear();

            if (cboChucVu.Items.Count > 0)
                cboChucVu.SelectedIndex = 0;
        }

        /// <summary>
        /// Trạng thái của các nút bấm và ô nhập liệu
        /// </summary>
        /// <param name="editing">True nếu đang trong chế độ nhập liệu (Thêm/Sửa)</param>
        void KhoaNut(bool editing)
        {
            // Các ô nhập liệu
            // Khi sửa thì không cho phép sửa Tên đăng nhập (vì là Khóa chính)
            txtTenDangNhap.Enabled = editing && !isEditing;
            txtMatKhau.Enabled = editing;
            cboChucVu.Enabled = editing;
            txtEmail.Enabled = editing;

            // Các nút chức năng
            btnSave.Enabled = editing;
            btnHuy.Enabled = editing;

            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tránh lỗi khi click vào header của DataGridView
            if (e.RowIndex < 0) return;

            // Nếu đang trong chế độ Thêm/Sửa thì không cho phép click chọn dòng khác để tránh rối logic
            if (isAdding || isEditing) return;

            var row = dgvTaiKhoan.Rows[e.RowIndex];

            // Đổ dữ liệu từ Grid lên các Control
            txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value?.ToString();
            txtMatKhau.Text = row.Cells["MatKhau"].Value?.ToString();
            cboChucVu.Text = row.Cells["ChucVu"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            isEditing = false;

            ClearForm();
            KhoaNut(true);
            txtTenDangNhap.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa từ danh sách!", "Thông báo");
                return;
            }

            isAdding = false;
            isEditing = true;

            KhoaNut(true);
            txtMatKhau.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!", "Thông báo");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản [{txtTenDangNhap.Text}] không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bus.Delete(txtTenDangNhap.Text))
                {
                    MessageBox.Show("Xóa thành công! 😏", "Thông báo");
                    LoadData();
                    KhoaNut(false);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Lỗi");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu!", "Thông báo");
                return;
            }

            if (isAdding)
            {
                // Thực hiện thêm mới
                if (bus.Insert(txtTenDangNhap.Text.Trim(), txtMatKhau.Text.Trim(), cboChucVu.Text, txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại hoặc có lỗi xảy ra!", "Lỗi");
                    return;
                }
            }
            else if (isEditing)
            {
                // Thực hiện cập nhật
                if (bus.Update(txtTenDangNhap.Text.Trim(), txtMatKhau.Text.Trim(), cboChucVu.Text, txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi");
                    return;
                }
            }

            // Reset trạng thái form
            isAdding = false;
            isEditing = false;
            LoadData();
            KhoaNut(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isAdding = false;
            isEditing = false;

            ClearForm();
            KhoaNut(false);

            // Tải lại dữ liệu để tránh hiển thị sai lệch nếu đang sửa dở
            LoadData();
        }
    }
}