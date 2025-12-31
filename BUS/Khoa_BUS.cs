using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{

    public class Khoa_BUS
    {
        public Khoa_DAL khoa_DAL = new Khoa_DAL();

        public DataTable LoadData()
        {
            return khoa_DAL.Load();
        }

        public void Insert(Khoa_DTO ob)
        {
            khoa_DAL.InsertKhoa(ob);
        }

        public void Delete(string maKhoa)
        {
            khoa_DAL.DeleteKhoa(maKhoa);
        } 

        public void update(string maKhoa, Khoa_DTO ob)
        {
            khoa_DAL.UpdateKhoa(ob, maKhoa);
        }
        public Dictionary<string, string> getKhoaList()
        {
            return khoa_DAL.GetNganhHoc();
        }
        public DataTable search(string tuKhoa)
        {
            return khoa_DAL.Search(tuKhoa);
        }
    }
}
