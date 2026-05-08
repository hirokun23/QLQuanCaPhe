using QuanLyQuanCafe.DAL;
using QuanLyQuanCafe.DTO;
using System.Collections.Generic;
using System.Data.SqlClient;

public class NhanVienDAL
{
    public List<NhanVien> GetAll()
    {
        List<NhanVien> list = new List<NhanVien>();

        using (var conn = DB.GetConnection())
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien", conn);
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                list.Add(new NhanVien
                {
                    MaNV = (int)r["MaNV"],
                    TenNV = r["TenNV"].ToString(),
                    ChucVu = r["ChucVu"].ToString(),
                    Luong = (decimal)r["Luong"]
                });
            }
        }

        return list;
    }

    public void Insert(NhanVien nv)
    {
        using (var conn = DB.GetConnection())
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO NhanVien VALUES(@ten,@cv,@luong)", conn);

            cmd.Parameters.AddWithValue("@ten", nv.TenNV);
            cmd.Parameters.AddWithValue("@cv", nv.ChucVu);
            cmd.Parameters.AddWithValue("@luong", nv.Luong);

            cmd.ExecuteNonQuery();
        }
    }

    public void Update(NhanVien nv)
    {
        using (var conn = DB.GetConnection())
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "UPDATE NhanVien SET TenNV=@ten,ChucVu=@cv,Luong=@luong WHERE MaNV=@id", conn);

            cmd.Parameters.AddWithValue("@ten", nv.TenNV);
            cmd.Parameters.AddWithValue("@cv", nv.ChucVu);
            cmd.Parameters.AddWithValue("@luong", nv.Luong);
            cmd.Parameters.AddWithValue("@id", nv.MaNV);

            cmd.ExecuteNonQuery();
        }
    }

    public void Delete(int id)
    {
        using (var conn = DB.GetConnection())
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "DELETE FROM NhanVien WHERE MaNV=@id", conn);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }
    }
}