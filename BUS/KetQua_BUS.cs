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
    public class KetQua_BUS
    {
        public KetQua_DAL ketQua_DAL = new KetQua_DAL();
        public DataTable LoadData()
        {
            return ketQua_DAL.Load();
        }

        public void Insert(KetQua_DTO ob)
        {
            ketQua_DAL.InsertKetQua(ob);
        }

        public void Delete(string maMH, string maSV)
        {
            ketQua_DAL.DeleteKetQua(maSV, maMH);
        }

        public void Update(string maMH, string maSV, KetQua_DTO ob)
        {
            ketQua_DAL.UpdateKetQua(maSV, maMH, ob);
        }
        public DataTable layDiem(string maMH, string maSV)
        {
            return ketQua_DAL.layDiem(maSV, maMH);
        }
    }
}
