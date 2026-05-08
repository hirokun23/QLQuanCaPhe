using QuanLyQuanCafe.DTO;
using System.Data;

namespace QuanLyQuanCafe.Data
{
    public class NhanVienDAO
    {
        DataProvider provider = new DataProvider();

        public DataTable getAll()
        {
            string sql = "SELECT MaNV, TenNV, NgaySinh, SDT, GioiTinh, DiaChi, ChucVu, Luong FROM NhanVien";
            return provider.ExecuteQuery(sql, null); // ✅ thêm null
        }

        public int insert(NhanVienDTO nv)
        {
            string sql = @"
            INSERT INTO NhanVien(TenNV, NgaySinh, SDT, GioiTinh, DiaChi, ChucVu, Luong)
            VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6)";

            return provider.ExecuteNonQuery(sql, new object[]
            {
                nv.TenNV,
                nv.NgaySinh,
                nv.SDT,
                nv.GioiTinh,
                nv.DiaChi,
                nv.ChucVu,
                nv.Luong
            });
        }

        public int update(NhanVienDTO nv)
        {
            string sql = @"
            UPDATE NhanVien SET
                TenNV = @p0,
                NgaySinh = @p1,
                SDT = @p2,
                GioiTinh = @p3,
                DiaChi = @p4,
                ChucVu = @p5,
                Luong = @p6
            WHERE MaNV = @p7";

            return provider.ExecuteNonQuery(sql, new object[]
            {
                nv.TenNV,
                nv.NgaySinh,
                nv.SDT,
                nv.GioiTinh,
                nv.DiaChi,
                nv.ChucVu,
                nv.Luong,
                nv.MaNV
            });
        }

        public int delete(int maNV)
        {
            string sql = "DELETE FROM NhanVien WHERE MaNV = @p0";

            return provider.ExecuteNonQuery(sql, new object[]
            {
                maNV
            });
        }
    }
}