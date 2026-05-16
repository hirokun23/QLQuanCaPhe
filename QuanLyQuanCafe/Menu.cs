using ClosedXML.Excel;
using QuanLyQuanCafe.BUS;
using System;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;


namespace QuanLyQuanCafe
{
    public partial class MenuForm : Form
    {
        MonBUS bus = new MonBUS();

        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            LoadMon();
            KhoaNut(false);
        }

        

        bool isAdding = false;
        bool isEditing = false;

        void KhoaNut(bool editing)
        {   
            txtMaMon.Enabled = editing;
            txtTenMon.Enabled = editing;
            txtGia.Enabled = editing;
            cboLoai.Enabled = editing;

            btnSave.Enabled = editing;
            btnHuy.Enabled = editing;

            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;
        }

        void ClearForm()
        {
            txtMaMon.Clear();
            txtTenMon.Clear();
            txtGia.Clear();

            cboLoai.SelectedIndex = 0;
        }

        void LoadMon()
        {
            dgvMon.DataSource = bus.GetAll();

            ClearForm();
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
            if (txtMaMon.Text == "")
            {
                MessageBox.Show("Chọn món cần sửa");
                return;
            }

            isAdding = false;
            isEditing = true;

            KhoaNut(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text == "")
            {
                MessageBox.Show("Chọn món cần xóa");
                return;
            }

            if (MessageBox.Show(
                "Xóa món này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) == DialogResult.Yes)
            {
                int ma = int.Parse(txtMaMon.Text);

                bus.Delete(ma);

                MessageBox.Show("Xóa thành công 😏");

                LoadMon();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenMon.Text.Trim() == "" ||
                txtGia.Text.Trim() == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin 😏");
                return;
            }

            float gia;

            if (!float.TryParse(txtGia.Text, out gia))
            {
                MessageBox.Show("Giá phải là số!");
                return;
            }

            // THÊM
            if (isAdding)
            {
                bus.Insert(
                    txtTenMon.Text,
                    gia,
                    cboLoai.Text
                );

                MessageBox.Show("Thêm thành công");
            }

            // SỬA
            else if (isEditing)
            {
                int ma = int.Parse(txtMaMon.Text);

                bus.Update(
                    ma,
                    txtTenMon.Text,
                    gia,
                    cboLoai.Text
                );

                MessageBox.Show("Sửa thành công");
            }

            LoadMon();

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


        private void dgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaMon.Text = dgvMon.Rows[e.RowIndex].Cells["MaMon"].Value.ToString();
                txtTenMon.Text = dgvMon.Rows[e.RowIndex].Cells["TenMon"].Value.ToString();
                txtGia.Text = dgvMon.Rows[e.RowIndex].Cells["Gia"].Value.ToString();
                cboLoai.Text = dgvMon.Rows[e.RowIndex].Cells["Loai"].Value.ToString();
            }
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
                        string tenMon = ws.Cell(row, 1).Value.ToString();

                        float gia = 0;
                        float.TryParse(ws.Cell(row, 2).Value.ToString(), out gia);

                        string loai = ws.Cell(row, 3).Value.ToString();

                        bus.Insert(tenMon, gia, loai);

                        row++;
                    }

                    MessageBox.Show("Import món thành công 😏");
                    LoadMon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files|*.xlsx";
            sfd.FileName = "Menu.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var wb = new XLWorkbook();
                var ws = wb.Worksheets.Add("Menu");

                // header
                ws.Cell(1, 1).Value = "TenMon";
                ws.Cell(1, 2).Value = "Gia";
                ws.Cell(1, 3).Value = "Loai";

                int row = 2;

                foreach (DataGridViewRow r in dgvMon.Rows)
                {
                    if (r.IsNewRow) continue;

                    ws.Cell(row, 1).Value = r.Cells["TenMon"].Value?.ToString();
                    ws.Cell(row, 2).Value = r.Cells["Gia"].Value?.ToString();
                    ws.Cell(row, 3).Value = r.Cells["Loai"].Value?.ToString();

                    row++;
                }

                wb.SaveAs(sfd.FileName);

                MessageBox.Show("Xuất món thành công 😏");
            }
        }
    }
}