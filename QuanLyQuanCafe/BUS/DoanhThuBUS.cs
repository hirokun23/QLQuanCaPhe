using System;
using System.Data;

public class DoanhThuBUS
{
    DoanhThuDAO dao = new DoanhThuDAO();

    public DataTable LayDoanhThu(DateTime from, DateTime to)
    {
        return dao.GetDoanhThu(from, to);
    }

    public decimal TongDoanhThu(DataTable dt)
    {
        decimal tong = 0;

        foreach (DataRow row in dt.Rows)
        {
            tong += Convert.ToDecimal(row["ThanhTien"]);
        }

        return tong;
    }

    public decimal TrungBinhHoaDon(DataTable dt)
    {
        if (dt.Rows.Count == 0) return 0;

        return TongDoanhThu(dt) / dt.Rows.Count;
    }
}