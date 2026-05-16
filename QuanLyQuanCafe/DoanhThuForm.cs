using ClosedXML.Excel;
using QuanLyQuanCafe.BUS;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyQuanCafe
{
    public partial class DoanhThuForm : Form
    {
        DoanhThuBUS bus = new DoanhThuBUS();

        public DoanhThuForm()
        {
            InitializeComponent();

      

            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;

            LoadDoanhThu();
        }


        
        void LoadDoanhThu()
        {
            DateTime from = dtpFrom.Value.Date;

            DateTime to = dtpTo.Value.Date
                .AddDays(1)
                .AddTicks(-1);

            DataTable dt = bus.LayDoanhThu(from, to);

            dgvDoanhThu.DataSource = dt;

            lblSoHD.Text = dt.Rows.Count.ToString();
            lblTongTien.Text = bus.TongDoanhThu(dt).ToString("N0");
            lblTrungBinh.Text = bus.TrungBinhHoaDon(dt).ToString("N0");

            
        }

        
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadDoanhThu();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;

            LoadDoanhThu();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files|*.xlsx";
            sfd.FileName = "DoanhThu.xlsx";

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                var wb = new XLWorkbook();
                var ws = wb.Worksheets.Add("DoanhThu");

                // HEADER
                ws.Cell(1, 1).Value = "MaHD";
                ws.Cell(1, 2).Value = "NgayLap";
                ws.Cell(1, 3).Value = "TongTien";

                int row = 2;

                foreach (DataGridViewRow r in dgvDoanhThu.Rows)
                {
                    if (r.IsNewRow) continue;

                    ws.Cell(row, 1).Value = r.Cells[0].Value?.ToString();
                    ws.Cell(row, 2).Value = r.Cells[1].Value?.ToString();
                    ws.Cell(row, 3).Value = r.Cells[2].Value?.ToString();

                    row++;
                }

                // thêm tổng kết phía dưới
                row += 2;

                ws.Cell(row, 1).Value = "Số hóa đơn";
                ws.Cell(row, 2).Value = lblSoHD.Text;

                ws.Cell(row + 1, 1).Value = "Tổng doanh thu";
                ws.Cell(row + 1, 2).Value = lblTongTien.Text;

                ws.Cell(row + 2, 1).Value = "Trung bình";
                ws.Cell(row + 2, 2).Value = lblTrungBinh.Text;

                wb.SaveAs(sfd.FileName);

                MessageBox.Show("Xuất doanh thu thành công 😏");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}