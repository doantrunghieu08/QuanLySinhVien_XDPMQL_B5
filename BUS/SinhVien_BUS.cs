using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class SinhVien_BUS
    {
        public SinhVien_DAL sinhVien_DAL = new SinhVien_DAL();

        public DataTable LoadData()
        {
            return sinhVien_DAL.Load();
        }

        public void Insert(SinhVien_DTO ob)
        {
            sinhVien_DAL.InsertSinhVien(ob);
        }

        public void Delete(string maSV)
        {
            sinhVien_DAL.DeleteSinhVien(maSV);
        }
        public void Update(SinhVien_DTO ob, string maSV)
        {
            sinhVien_DAL.UpdateSinhVien(ob, maSV);
        }

        public DataTable Search(string tukhoa)
        {
            return sinhVien_DAL.Search(tukhoa);
        }
    }
}
