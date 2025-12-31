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
    public class SinhVien_DAL : Connect
    {
        public DataTable Load()
        {
            return loadData("SELECT MaSV_HieuDT_3725, HoTen_HieuDT_3725, NgaySinh_HieuDT_3725, GioiTinh_HieuDT_3725, DiaChi_HieuDT_3725, DienThoai_HieuDT_3725, MaKhoa_HieuDT_3725\r\nFROM     SinhVien_HieuDT_3725");

        }

        public void InsertSinhVien(SinhVien_DTO ob)
        {
            SqlCommand cmd = new SqlCommand(@"
                INSERT INTO SinhVien_HieuDT_3725
                  (MaSV_HieuDT_3725, HoTen_HieuDT_3725, NgaySinh_HieuDT_3725, GioiTinh_HieuDT_3725, DiaChi_HieuDT_3725, DienThoai_HieuDT_3725, MaKhoa_HieuDT_3725)
                VALUES (@MaSV_HieuDT_3725,@HoTen_HieuDT_3725,@NgaySinh_HieuDT_3725,@GioiTinh_HieuDT_3725,@DiaChi_HieuDT_3725,@DienThoai_HieuDT_3725,@MaKhoa_HieuDT_3725)
            ");
            cmd.Parameters.AddWithValue("@MaSV_HieuDT_3725", ob.MaSV);
            cmd.Parameters.AddWithValue("@HoTen_HieuDT_3725", ob.TenSV);
            cmd.Parameters.AddWithValue("@NgaySinh_HieuDT_3725", ob.NgaySinh);
            cmd.Parameters.AddWithValue("@GioiTinh_HieuDT_3725", ob.GioiTinh);
            cmd.Parameters.AddWithValue("@DienThoai_HieuDT_3725", ob.DienThoai);
            cmd.Parameters.AddWithValue("@MaKhoa_HieuDT_3725", ob.MaKhoa);
            ExcuteNonQuery(cmd);
        }

        public void DeleteSinhVien(string maSV)
        {
            SqlCommand cmd = new SqlCommand(@"
                DELETE FROM SinhVien_HieuDT_3725
                WHERE (MaSV_HieuDT_3725 = @Original_MaSV_HieuDT_3725)
            ");
            cmd.Parameters.AddWithValue("@Original_MaSV_HieuDT_3725", maSV);
            ExcuteNonQuery(cmd);
        }

        public void UpdateSinhVien(SinhVien_DTO ob, string maSV)
        {
            SqlCommand cmd = new SqlCommand(@"
                            UPDATE SinhVien_HieuDT_3725
            SET  HoTen_HieuDT_3725 = @HoTen_HieuDT_3725, NgaySinh_HieuDT_3725 = @NgaySinh_HieuDT_3725, GioiTinh_HieuDT_3725 = @GioiTinh_HieuDT_3725, DiaChi_HieuDT_3725 = @DiaChi_HieuDT_3725, 
                              DienThoai_HieuDT_3725 = @DienThoai_HieuDT_3725, MaKhoa_HieuDT_3725 = @MaKhoa_HieuDT_3725
            WHERE (MaSV_HieuDT_3725 = @Original_MaSV_HieuDT_3725)
            ");
            cmd.Parameters.AddWithValue("@HoTen_HieuDT_3725", ob.TenSV);
            cmd.Parameters.AddWithValue("@NgaySinh_HieuDT_3725", ob.NgaySinh);
            cmd.Parameters.AddWithValue("@GioiTinh_HieuDT_3725", ob.GioiTinh);
            cmd.Parameters.AddWithValue("@DiaChi_HieuDT_3725", ob.GioiTinh);
            cmd.Parameters.AddWithValue("@DienThoai_HieuDT_3725", ob.DienThoai);
            cmd.Parameters.AddWithValue("@MaKhoa_HieuDT_3725", ob.MaKhoa);

        }

        // Thay vì nhận DTO, ta nhận một chuỗi (string)
        public DataTable Search(string tuKhoa)
        {
            // Tư duy: Tìm xem từ khóa có xuất hiện trong Mã OR Tên OR Địa chỉ OR SĐT không?
            // Dùng LIKE và N'%' để tìm tiếng Việt có dấu
            string query = @"
        SELECT MaSV_HieuDT_3725, HoTen_HieuDT_3725, NgaySinh_HieuDT_3725, 
               GioiTinh_HieuDT_3725, DiaChi_HieuDT_3725, DienThoai_HieuDT_3725, MaKhoa_HieuDT_3725
        FROM SinhVien_HieuDT_3725
        WHERE (MaSV_HieuDT_3725 LIKE '%' + @TuKhoa + '%') 
           OR (HoTen_HieuDT_3725 LIKE N'%' + @TuKhoa + '%')
           OR (DiaChi_HieuDT_3725 LIKE N'%' + @TuKhoa + '%')
           OR (DienThoai_HieuDT_3725 LIKE '%' + @TuKhoa + '%')
           OR (MaKhoa_HieuDT_3725 LIKE '%' + @TuKhoa + '%')
    ";

            // Lưu ý: Tôi đã bỏ NgaySinh và GioiTinh ra khỏi tìm kiếm text vì chúng khác kiểu dữ liệu, 
            // tìm text trên đó dễ gây lỗi hoặc không hiệu quả.

            SqlCommand cmd = new SqlCommand(query);

            // Truyền tham số duy nhất
            cmd.Parameters.AddWithValue("@TuKhoa", tuKhoa);

            // Gọi hàm loadDataByParameter (Hàm này nằm trong class Connect mà bạn đã viết)
            return loadData(cmd);
        }

    }
}
