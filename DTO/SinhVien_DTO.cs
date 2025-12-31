using System.Diagnostics.Tracing;

namespace DTO
{
    public class SinhVien_DTO
    {
        public string MaSV {  get; set; }
        public string TenSV { get; set; }

        public int GioiTinh {  get; set; }
        
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }

        public string DienThoai { get; set; }

        public string MaKhoa {  get; set; }
    }
}
