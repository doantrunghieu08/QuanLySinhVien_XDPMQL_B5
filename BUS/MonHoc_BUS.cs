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
    public class MonHoc_BUS
    {
        public MonHoc_DAL monHoc_DAL = new MonHoc_DAL();

        public DataTable LoadData()
        {
            return monHoc_DAL.Load();
        }

        public void Insert(MonHoc_DTO ob)
        {
            monHoc_DAL.InsertMonHoc(ob);
        }

        public void Delete(string maMH) {
            monHoc_DAL.DeleteMonHoc(maMH);
        }

        public void Update(MonHoc_DTO ob, string maMH)
        {
            monHoc_DAL.UpdateMonHoc(ob, maMH);
        }

        public Dictionary<string, string> getMonHocList()
        {
            return monHoc_DAL.GetMonHoc();
        }
        public DataTable Search(string tuKhoa)
        {
            return monHoc_DAL.Search(tuKhoa);
        }
        
    }
}
