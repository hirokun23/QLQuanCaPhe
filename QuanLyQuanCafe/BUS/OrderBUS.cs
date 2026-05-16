using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Data;

namespace QuanLyQuanCafe.BUS
{
    public class OrderBUS
    {
        OrderDAO dao = new OrderDAO();

        public void AddMon(int maBan, int maMon, decimal gia)
        {
            dao.AddMon(maBan, maMon, gia);
        }

        public void RemoveMon(int maBan, int maMon)
        {
            dao.RemoveMon(maBan, maMon);
        }

        public DataTable GetBill(int maBan)
        {
            return dao.GetBill(maBan);
        }

        public decimal TinhTien(int maBan, decimal giam, decimal phuThu)
        {
            DataTable dt = dao.GetBill(maBan);

            decimal tong = 0;

            foreach (DataRow row in dt.Rows)
            {
                decimal gia = Convert.ToDecimal(row["DonGia"]);
                int sl = Convert.ToInt32(row["SoLuong"]);
                tong += gia * sl;
            }

            decimal tienGiam = tong * giam / 100;
            return tong - tienGiam + phuThu;
        }

        public void ThanhToan(int maBan, OrderDTO dto)
        {
            DataTable bill = dao.GetBill(maBan);

            int maHD = Convert.ToInt32(dao.GetOrCreateHoaDon(maBan));

            foreach (DataRow row in bill.Rows)
            {
                int maMon = Convert.ToInt32(row["MaMon"]);
                int soLuong = Convert.ToInt32(row["SoLuong"]);

                // 🔥 TRỪ NGUYÊN LIỆU THEO BILL
                dao.TruNguyenLieu(maMon, soLuong);
            }

            decimal tongTien = TinhTien(maBan, dto.GiamGia, dto.PhuThu);

            dao.ThanhToan(maHD, tongTien, dto.GiamGia, dto.PhuThu);

            dao.ClearBill(maBan);
        }

        public void HuyHoaDon(int maBan)
        {
            dao.ClearBill(maBan);
        }

        public void TangSoLuong(int maBan, int maMon)
        {
            dao.TangSoLuong(maBan, maMon);
        }

        public void GiamSoLuong(int maBan, int maMon)
        {
            dao.GiamSoLuong(maBan, maMon);
        }

    }
}