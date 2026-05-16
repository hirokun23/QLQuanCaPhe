using QuanLyQuanCafe.BUS;
using System;
using System.Drawing;
using System.Windows.Forms;
using ClosedXML.Excel;  
namespace QuanLyQuanCafe
{
    public partial class KhoForm : Form
    {
        NguyenLieuBUS bus = new NguyenLieuBUS();

        public KhoForm()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            dgvKho.DataSource = bus.GetAll();
        }

        private void KhoForm_Load(object sender, EventArgs e)
        {
            LoadData();

            dgvKho.DefaultCellStyle.ForeColor = Color.Black;
            dgvKho.DefaultCellStyle.BackColor = Color.White;

            KhoaNut(false);

            string canhBao = bus.CanhBaoNguyenLieu();

            if (canhBao != "")
            {
                MessageBox.Show(canhBao,
                    "Cảnh báo kho",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        bool isAdding = false;
        bool isEditing = false;

        void KhoaNut(bool editing)
        {
            txtMaNL.Enabled = editing;
            txtTenNL.Enabled = editing;
            txtSoLuong.Enabled = editing;

            btnSave.Enabled = editing;
            btnHuy.Enabled = editing;

            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;
        }

        void ClearForm()
        {
            txtMaNL.Clear();
            txtTenNL.Clear();
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
            if (txtMaNL.Text == "")
            {
                MessageBox.Show("Chọn nguyên liệu cần sửa");
                return;
            }

            isAdding = false;
            isEditing = true;

            KhoaNut(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNL.Text == "")
            {
                MessageBox.Show("Chọn nguyên liệu cần xóa");
                return;
            }

            if (MessageBox.Show(
                "Xóa nguyên liệu này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) == DialogResult.Yes)
            {
                bus.Delete(txtMaNL.Text);

                MessageBox.Show("Xóa thành công 😏");

                LoadData();

                ClearForm();
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            int sl;

            if (!int.TryParse(txtSoLuong.Text, out sl))
            {
                MessageBox.Show("Số lượng phải là số!");
                return;
            }

            if (txtMaNL.Text.Trim() == "" ||
                txtTenNL.Text.Trim() == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
                return;
            }

            // THÊM
            if (isAdding)
            {
                bus.Insert(
                    txtMaNL.Text,
                    txtTenNL.Text,
                    sl
                );

                MessageBox.Show("Thêm thành công");
            }

            // SỬA
            else if (isEditing)
            {
                bus.Update(
                    txtMaNL.Text,
                    txtTenNL.Text,
                    sl
                );

                MessageBox.Show("Sửa thành công");
            }

            LoadData();

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

        private void dgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvKho.Rows[e.RowIndex];

            txtMaNL.Text = row.Cells["MaNL"].Value.ToString();
            txtTenNL.Text = row.Cells["TenNL"].Value.ToString();
            txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Excel Files|*.xlsx";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var wb = new XLWorkbook(ofd.FileName);

                    var ws = wb.Worksheet(1);

                    int row = 2;

                    while (!ws.Cell(row, 1).IsEmpty())
                    {
                        string maNL =
                            ws.Cell(row, 1).Value.ToString();

                        string tenNL =
                            ws.Cell(row, 2).Value.ToString();

                        int soLuong =
                            int.Parse(ws.Cell(row, 3).Value.ToString());

                        bus.Insert(maNL, tenNL, soLuong);

                        row++;
                    }

                    MessageBox.Show("Import thành công ");

                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "Excel Files|*.xlsx";
                sfd.FileName = "KhoNguyenLieu.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var wb = new XLWorkbook();
                    var ws = wb.Worksheets.Add("Kho");

                    // header
                    ws.Cell(1, 1).Value = "MaNL";
                    ws.Cell(1, 2).Value = "TenNL";
                    ws.Cell(1, 3).Value = "SoLuong";

                    // data
                    int row = 2;

                    foreach (DataGridViewRow r in dgvKho.Rows)
                    {
                        if (r.IsNewRow) continue;

                        ws.Cell(row, 1).Value =
                            r.Cells["MaNL"].Value.ToString();

                        ws.Cell(row, 2).Value =
                            r.Cells["TenNL"].Value.ToString();

                        ws.Cell(row, 3).Value =
                            r.Cells["SoLuong"].Value.ToString();

                        row++;
                    }

                    wb.SaveAs(sfd.FileName);

                    MessageBox.Show("Xuất Excel thành công ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}