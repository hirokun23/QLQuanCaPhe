using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLyQuanCafe.Data
{
    public class DataProvider
    {
        public static string connectionString =
        ConfigurationManager.ConnectionStrings["QLCF"].ConnectionString;
        SqlConnection conn;

        public void connect()
        {
            conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public void close()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }

        public DataTable ExecuteQuery(string sql, object[] param)
        {
            DataTable dt = new DataTable();
            connect();

            SqlCommand cmd = new SqlCommand(sql, conn);

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.AddWithValue($"@p{i}", param[i]);
                }
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            close();
            return dt;
        }

        public int ExecuteNonQuery(string sql, object[] param)
        {
            connect();

            SqlCommand cmd = new SqlCommand(sql, conn);

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.AddWithValue($"@p{i}", param[i]);
                }
            }

            int result = cmd.ExecuteNonQuery();

            close();
            return result;
        }
    }
}