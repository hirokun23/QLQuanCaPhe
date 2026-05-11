using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLyQuanCafe.Data
{
    public class DataProvider
    {
        private string connectionString =
            ConfigurationManager.ConnectionStrings["QLCF"].ConnectionString;

        // SELECT
        public DataTable ExecuteQuery(string sql, object[] param = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

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
            }

            return dt;
        }

        // INSERT UPDATE DELETE
        public int ExecuteNonQuery(string sql, object[] param = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                if (param != null)
                {
                    for (int i = 0; i < param.Length; i++)
                    {
                        cmd.Parameters.AddWithValue($"@p{i}", param[i]);
                    }
                }

                return cmd.ExecuteNonQuery();
            }
        }

        // GET 1 VALUE
        public object ExecuteScalar(string sql, object[] param = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                if (param != null)
                {
                    for (int i = 0; i < param.Length; i++)
                        cmd.Parameters.AddWithValue($"@p{i}", param[i]);
                }

                return cmd.ExecuteScalar();
            }
        }
    }
}