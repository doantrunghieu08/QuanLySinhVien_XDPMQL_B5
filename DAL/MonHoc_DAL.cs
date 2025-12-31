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
    public class MonHoc_DAL : Connect
    {
        public DataTable Load()
        {
            return loadData("SELECT MaMH_HieuDT_3725, TenMH_HieuDT_3725, SoTiet_HieuDT_3725\r\nFROM     MonHoc_HieuDT_3725");
        }

        public void InsertMonHoc(MonHoc_DTO ob)
        {
            SqlCommand cmd = new SqlCommand(@"
                INSERT INTO MonHoc_HieuDT_3725
                  (MaMH_HieuDT_3725, TenMH_HieuDT_3725, SoTiet_HieuDT_3725)
                VALUES (@MaMH_HieuDT_3725,@TenMH_HieuDT_3725,@SoTiet_HieuDT_3725)
            ");

            cmd.Parameters.AddWithValue("@MaMH_HieuDT_3725", ob.MaMonHoc);
            cmd.Parameters.AddWithValue("@TenMH_HieuDT_3725", ob.TenMonHoc);
            cmd.Parameters.AddWithValue("@SoTiet_HieuDT_3725", ob.SoTiet);

            ExcuteNonQuery(cmd);

        }
        public void DeleteMonHoc(string maMH)
        {
            SqlCommand cmd = new SqlCommand(@"
                DELETE FROM MonHoc_HieuDT_3725
                WHERE  (MaMH_HieuDT_3725 = @Original_MaMH_HieuDT_3725)
            ");
            cmd.Parameters.AddWithValue("@Original_MaMH_HieuDT_3725", maMH);
            ExcuteNonQuery(cmd);
        }

        public void UpdateMonHoc(MonHoc_DTO ob, string maMH)
        {
            SqlCommand cmd = new SqlCommand(@"
                UPDATE MonHoc_HieuDT_3725
                SET TenMH_HieuDT_3725 = @TenMH_HieuDT_3725, SoTiet_HieuDT_3725 = @SoTiet_HieuDT_3725
                WHERE  (MaMH_HieuDT_3725 = @Original_MaMH_HieuDT_3725)
            ");
            cmd.Parameters.AddWithValue("@TenMH_HieuDT_3725", ob.TenMonHoc);
            cmd.Parameters.AddWithValue("@SoTiet_HieuDT_3725", ob.SoTiet);
            cmd.Parameters.AddWithValue("@Original_MaMH_HieuDT_3725", maMH);
            ExcuteNonQuery(cmd);
        }

        public Dictionary<string, string> GetMonHoc()
        {
            Dictionary<string, string> mapMonHoc = new Dictionary<string, string>();

            DataTable dt = loadData(@"SELECT MaMH_HieuDT_3725, TenMH_HieuDT_3725
                                    FROM     MonHoc_HieuDT_3725");

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string maMonHoc = row["MaMH_HieuDT_3725"].ToString();
                    String tenMonHoc = row["TenMH_HieuDT_3725"].ToString();

                    if (!mapMonHoc.ContainsKey(maMonHoc))
                    {
                        mapMonHoc.Add(maMonHoc, tenMonHoc);
                    }
                }
            }
            return mapMonHoc;

        }

        public DataTable Search(string tuKhoa)
        {
            // Tư duy: Tìm Mã gần đúng OR Tên gần đúng OR Số Tiết giống với số nhập vào
            // Lưu ý: Cột SoTiet là số, nên ta ép kiểu sang chuỗi (NVARCHAR) để dùng được LIKE
            string query = @"
        SELECT MaMH_HieuDT_3725, TenMH_HieuDT_3725, SoTiet_HieuDT_3725
        FROM MonHoc_HieuDT_3725
        WHERE (MaMH_HieuDT_3725 LIKE '%' + @TuKhoa + '%') 
           OR (TenMH_HieuDT_3725 LIKE N'%' + @TuKhoa + '%')
           OR (CAST(SoTiet_HieuDT_3725 AS NVARCHAR) LIKE '%' + @TuKhoa + '%')
    ";

            SqlCommand cmd = new SqlCommand(query);

            // Truyền tham số duy nhất
            cmd.Parameters.AddWithValue("@TuKhoa", tuKhoa);

            return loadData(cmd);
        }
    
    }
}
