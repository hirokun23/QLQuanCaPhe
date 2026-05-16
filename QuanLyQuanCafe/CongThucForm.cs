using ClosedXML.Excel;
using QuanLyQuanCafe.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class CongThucForm : Form
    {
        CongThucBUS bus = new CongThucBUS();
        MonBUS monBus = new MonBUS();
        NguyenLieuBUS nlBus = new NguyenLieuBUS();

        bool isAdding = false;
        bool isEditing = false;

        public CongThucForm()
        {
            InitializeComponent();
        }

        private void CongThucForm_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBox();
            KhoaNut(false);
        }

        void LoadComboBox()
        {
            // Load danh sách món
            cboMon.DataSource = monBus.GetAll();
            cboMon.DisplayMember = "TenMon";
            cboMon.ValueMember = "MaMon";

            // Load danh sách nguyên liệu
            cboNguyenLieu.DataSource = nlBus.GetAll();
            cboNguyenLieu.DisplayMember = "TenNL";
            cboNguyenLieu.ValueMember = "MaNL";
        }

        void LoadData()
        {
            dgvCongThuc.DataSource = bus.GetAll();
            ClearForm();
        }

        void KhoaNut(bool editing)
        {
            cboMon.Enabled = editing && isAdding; // Chỉ cho chọn Món khi thêm mới
            cboNguyenLieu.Enabled = editing && isAdding; // Chỉ cho chọn NL khi thêm mới
            txtSoLuong.Enabled = editing;

            btnSave.Enabled = editing;
            btnHuy.Enabled = editing;
            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;
        }

        void ClearForm()
        {
            if (cboMon.Items.Count > 0) cboMon.SelectedIndex = 0;
            if (cboNguyenLieu.Items.Count > 0) cboNguyenLieu.SelectedIndex = 0;
            txtSoLuong.Clear();
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
            if (dgvCongThuc.CurrentRow == null) return;
            isAdding = false;
            isEditing = true;
            KhoaNut(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvCongThuc.CurrentRow == null) return;
            if (MessageBox.Show("Xác nhận xóa công thức này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int maMon = (int)cboMon.SelectedValue;
                string maNL = cboNguyenLieu.SelectedValue.ToString();
                bus.Delete(maMon, maNL);
                LoadData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoLuong.Text)) return;

            float soLuong;
            if (!float.TryParse(txtSoLuong.Text, out soLuong))
            {
                MessageBox.Show("Số lượng phải là số!");
                return;
            }

            int maMon = (int)cboMon.SelectedValue;
            string maNL = cboNguyenLieu.SelectedValue.ToString();

            if (isAdding)
            {
                bus.Insert(maMon, maNL, soLuong);
                MessageBox.Show("Thêm thành công!");
            }
            else if (isEditing)
            {
                bus.Update(maMon, maNL, soLuong);
                MessageBox.Show("Cập nhật thành công!");
            }

            LoadData();
            KhoaNut(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            KhoaNut(false);
            isAdding = isEditing = false;
        }

        private void dgvCongThuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCongThuc.Rows[e.RowIndex];
                cboMon.SelectedValue = row.Cells["MaMon"].Value;
                cboNguyenLieu.SelectedValue = row.Cells["MaNL"].Value;
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
            }
        }

        // --- Import/Export Excel y chang mẫu ---
        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Files|*.xlsx", FileName = "CongThuc.xlsx" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var wb = new XLWorkbook();
                var ws = wb.Worksheets.Add("CongThuc");
                ws.Cell(1, 1).Value = "MaMon";
                ws.Cell(1, 2).Value = "MaNL";
                ws.Cell(1, 3).Value = "SoLuong";

                for (int i = 0; i < dgvCongThuc.Rows.Count; i++)
                {
                    ws.Cell(i + 2, 1).Value = dgvCongThuc.Rows[i].Cells["MaMon"].Value.ToString();
                    ws.Cell(i + 2, 2).Value = dgvCongThuc.Rows[i].Cells["MaNL"].Value.ToString();
                    ws.Cell(i + 2, 3).Value = dgvCongThuc.Rows[i].Cells["SoLuong"].Value.ToString();
                }
                wb.SaveAs(sfd.FileName);
                MessageBox.Show("Xuất thành công 😏");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Excel Files|*.xlsx" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var wb = new XLWorkbook(ofd.FileName);
                    var ws = wb.Worksheet(1);
                    int row = 2;
                    while (!ws.Cell(row, 1).IsEmpty())
                    {
                        int maM = int.Parse(ws.Cell(row, 1).Value.ToString());
                        string maN = ws.Cell(row, 2).Value.ToString();
                        float sl = float.Parse(ws.Cell(row, 3).Value.ToString());
                        bus.Insert(maM, maN, sl);
                        row++;
                    }
                    LoadData();
                    MessageBox.Show("Import thành công 😏");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}