using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Khoa_DAL : Connect
    {
        public DataTable Load()
        {
            return loadData("SELECT MaKhoa_HieuDT_3725, TenKhoa_HieuDT_3725\r\nFROM    Khoa_HieuDT_3725");
        }

        public void InsertKhoa(Khoa_DTO ob)
        {
            SqlCommand cmd = new SqlCommand(@"
                INSERT INTO Khoa_HieuDT_3725
                  (MaKhoa_HieuDT_3725, TenKhoa_HieuDT_3725)
                VALUES (@MaKhoa_HieuDT_3725,@TenKhoa_HieuDT_3725)
            ");
            cmd.Parameters.AddWithValue("@MaKhoa_HieuDT_3725", ob.MaKhoa);
            cmd.Parameters.AddWithValue("@TenKhoa_HieuDT_3725", ob.TenKhoa);
            ExcuteNonQuery(cmd);
        }

        public void DeleteKhoa(string maKhoa)
        {
            SqlCommand cmd = new SqlCommand(@"DELETE FROM Khoa_HieuDT_3725
            WHERE  (MaKhoa_HieuDT_3725 = @Original_MaKhoa_HieuDT_3725)");
            cmd.Parameters.AddWithValue("@Original_MaKhoa_HieuDT_3725", maKhoa);
            ExcuteNonQuery(cmd);
        }

        public void UpdateKhoa(Khoa_DTO ob, string maKhoa)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE Khoa_HieuDT_3725
            SET TenKhoa_HieuDT_3725 = @TenKhoa_HieuDT_3725
            WHERE  (MaKhoa_HieuDT_3725 = @Original_MaKhoa_HieuDT_3725)");
            cmd.Parameters.AddWithValue("@TenKhoa_HieuDT_3725", ob.TenKhoa);
            cmd.Parameters.AddWithValue("@Original_MaKhoa_HieuDT_3725", maKhoa);
            ExcuteNonQuery(cmd);
        }

        public Dictionary<string, string> GetNganhHoc()
        {
            Dictionary<string, string> mapNganhHoc = new Dictionary<string, string>();

            DataTable dt = loadData("SELECT  MaKhoa_HieuDT_3725, TenKhoa_HieuDT_3725 FROM Khoa_HieuDT_3725");

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string maKhoa = row["MaKhoa_HieuDT_3725"].ToString();
                    String tenKhoa = row["TenKhoa_HieuDT_3725"].ToString();

                    if (!mapNganhHoc.ContainsKey(maKhoa))
                    {
                        mapNganhHoc.Add(maKhoa, tenKhoa);
                    }
                }
            }
            return mapNganhHoc;

        }

        public DataTable Search(string tuKhoa)
        {
            // Dùng LIKE để tìm gần đúng
            // Dùng OR để tìm xem từ khóa nằm ở Mã HOẶC Tên
            string query = @"
        SELECT MaKhoa_HieuDT_3725, TenKhoa_HieuDT_3725
        FROM Khoa_HieuDT_3725
        WHERE (MaKhoa_HieuDT_3725 LIKE '%' + @TuKhoa + '%') 
           OR (TenKhoa_HieuDT_3725 LIKE N'%' + @TuKhoa + '%')
    ";

            SqlCommand cmd = new SqlCommand(query);

            // Chỉ cần 1 tham số duy nhất cho cả 2 điều kiện
            cmd.Parameters.AddWithValue("@TuKhoa", tuKhoa);

            return loadData(cmd);
        }


    }
}
