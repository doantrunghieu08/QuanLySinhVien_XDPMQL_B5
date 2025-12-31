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
    public class KetQua_DAL : Connect
    {
        public DataTable Load()
        {
            return loadData(@"SELECT ketQua_HieuDT_3725.MaSV_HieuDT_3725 , SinhVien_HieuDT_3725.HoTen_HieuDT_3725,  ketQua_HieuDT_3725.MaMH_HieuDT_3725,  MonHoc_HieuDT_3725.TenMH_HieuDT_3725 , ketQua_HieuDT_3725.DiemQT_HieuDT_3725, ketQua_HieuDT_3725.DiemCK_HieuDT_3725
                 
                    FROM  ketQua_HieuDT_3725 INNER JOIN
                                      MonHoc_HieuDT_3725 ON ketQua_HieuDT_3725.MaMH_HieuDT_3725 = MonHoc_HieuDT_3725.MaMH_HieuDT_3725 INNER JOIN
                                      SinhVien_HieuDT_3725 ON ketQua_HieuDT_3725.MaSV_HieuDT_3725 = SinhVien_HieuDT_3725.MaSV_HieuDT_3725");
        }

        public void InsertKetQua(KetQua_DTO ob)
        {
            SqlCommand cmd = new SqlCommand(@"
                INSERT INTO ketQua_HieuDT_3725
                  (MaSV_HieuDT_3725, MaMH_HieuDT_3725, DiemQT_HieuDT_3725, DiemCK_HieuDT_3725)
                VALUES (@MaSV_HieuDT_3725,@MaMH_HieuDT_3725,@DiemQT_HieuDT_3725,@DiemCK_HieuDT_3725)
            ");
            cmd.Parameters.AddWithValue("@MaSV_HieuDT_3725", ob.MaSV);
            cmd.Parameters.AddWithValue("@MaMH_HieuDT_3725", ob.MaMH);
            cmd.Parameters.AddWithValue("@DiemQT_HieuDT_3725", ob.DiemQT);
            cmd.Parameters.AddWithValue("@DiemCK_HieuDT_3725", ob.DiemCK);
            ExcuteNonQuery(cmd);
        }

        public void DeleteKetQua(string maSV, string maMH)
        {
            SqlCommand cmd = new SqlCommand(@"
                DELETE FROM ketQua_HieuDT_3725
                WHERE  (MaSV_HieuDT_3725 = @Original_MaSV_HieuDT_3725) AND (MaMH_HieuDT_3725 = @Original_MaMH_HieuDT_3725)
            ");
            cmd.Parameters.AddWithValue("@Original_MaSV_HieuDT_3725", maSV);
            cmd.Parameters.AddWithValue("@Original_MaMH_HieuDT_3725", maMH);
            ExcuteNonQuery(cmd);
        }

        public void UpdateKetQua(string maSV, string maMH, KetQua_DTO ob)
        {
            SqlCommand cmd = new SqlCommand(@"
                UPDATE ketQua_HieuDT_3725
                SET  DiemQT_HieuDT_3725 = @DiemQT_HieuDT_3725, DiemCK_HieuDT_3725 = @DiemCK_HieuDT_3725
                WHERE  (MaSV_HieuDT_3725 = @Original_MaSV_HieuDT_3725) AND (MaMH_HieuDT_3725 = @Original_MaMH_HieuDT_3725)
            ");
            cmd.Parameters.AddWithValue("@DiemQT_HieuDT_3725", ob.DiemQT);
            cmd.Parameters.AddWithValue("@DiemCK_HieuDT_3725", ob.DiemCK);
            cmd.Parameters.AddWithValue("@Original_MaSV_HieuDT_3725", maSV);
            cmd.Parameters.AddWithValue("@Original_MaMH_HieuDT_3725", maMH);
            ExcuteNonQuery(cmd);
        }

        public DataTable layDiem(string maSV, string maMH)
        {
            string query = @"SELECT ketQua_HieuDT_3725.MaSV_HieuDT_3725, 
                            SinhVien_HieuDT_3725.HoTen_HieuDT_3725, 
                            ketQua_HieuDT_3725.MaMH_HieuDT_3725, 
                            MonHoc_HieuDT_3725.TenMH_HieuDT_3725, 
                            ketQua_HieuDT_3725.DiemQT_HieuDT_3725, 
                            ketQua_HieuDT_3725.DiemCK_HieuDT_3725
                     FROM ketQua_HieuDT_3725 
                     INNER JOIN SinhVien_HieuDT_3725 ON ketQua_HieuDT_3725.MaSV_HieuDT_3725 = SinhVien_HieuDT_3725.MaSV_HieuDT_3725 
                     INNER JOIN MonHoc_HieuDT_3725 ON ketQua_HieuDT_3725.MaMH_HieuDT_3725 = MonHoc_HieuDT_3725.MaMH_HieuDT_3725
                     WHERE (ketQua_HieuDT_3725.MaSV_HieuDT_3725 = @MaSV) 
                       AND (ketQua_HieuDT_3725.MaMH_HieuDT_3725 = @MaMH)";

            // 3. Tạo SqlCommand và thêm tham số
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@MaSV", maSV);
            cmd.Parameters.AddWithValue("@MaMH", maMH);

            // 4. Gọi hàm loadData mới bổ sung để lấy dữ liệu
            return loadData(cmd);
        }
        
    }
}
