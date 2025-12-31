using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Connect
    {
        SqlConnection conn = new SqlConnection("Data Source=TrungHieu\\SQLEXPRESS;Initial Catalog=QLKQ_HieuDT_3725;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        public DataTable loadData(string sql)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }

        }
        public DataTable loadData(SqlCommand cmd)
        {
            // Gán kết nối của class Connect cho cmd
            cmd.Connection = conn;

            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void ExcuteNonQuery(SqlCommand cmd)
        {
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
