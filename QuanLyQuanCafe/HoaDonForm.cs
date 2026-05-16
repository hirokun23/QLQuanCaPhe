using QuanLyQuanCafe.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace QuanLyQuanCafe
{
    public partial class HoaDonForm : Form
    {
        HoaDonBUS bus = new HoaDonBUS();

        public HoaDonForm()
        {
            InitializeComponent();
        }
        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            dgvChiTiet.DataSource = bus.GetChiTietHoaDon(1);
            LoadHoaDon();
        }

        void LoadHoaDon()
        {
            dgvHoaDon.DataSource = bus.GetAllHoaDon();
        }


        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int maHD = Convert.ToInt32(
                dgvHoaDon.Rows[e.RowIndex].Cells["MaHD"].Value
            );

            DataTable dt = bus.GetChiTietHoaDon(maHD);

            if (dt.Rows.Count > 0)
            {
                dgvChiTiet.DataSource = dt;
            }
            else
            {
                dgvChiTiet.DataSource = null;

                MessageBox.Show(
                    "Hóa đơn này chưa có chi tiết!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        void ExportExcel(DataGridView dgv, string fileName)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Workbook|*.xlsx";
                sfd.FileName = fileName;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add("Data");

                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            ws.Cell(1, i + 1).Value = dgv.Columns[i].HeaderText;
                        }

                        for (int i = 0; i < dgv.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgv.Columns.Count; j++)
                            {
                                ws.Cell(i + 2, j + 1).Value =
                                    dgv.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        wb.SaveAs(sfd.FileName);
                    }

                    MessageBox.Show("Xuất Excel thành công!");
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ExportExcel(dgvHoaDon, "HoaDon");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportExcel(dgvChiTiet, "ChiTietHoaDon");
        }
    }
}
