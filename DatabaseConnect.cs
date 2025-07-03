using System;
using System.Data;
using System.Data.SqlClient;

namespace KHACHHANG // đổi theo namespace project của bạn
{
    public class DatabaseConnect
    {
        private readonly string connectionString;

        public DatabaseConnect()
        {
            // ⚠️ Đổi lại server và tên DB phù hợp với bạn
            connectionString = @"Server=FX505DT;Database=CustomerList;Trusted_Connection=True;";
        }

        // Hàm mở kết nối
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Hàm SELECT: không có parameter (giữ nguyên)
        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        // ✅ Hàm SELECT: có parameter
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        // Hàm INSERT/UPDATE/DELETE
        public int ExecuteNonQuery(string query)
        {
            int rowsAffected = 0;

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }

        public int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            int rowsAffected = 0;

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }

    }
}