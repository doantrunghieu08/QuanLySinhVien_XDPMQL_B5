using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QuanLySinhVien
{
    public partial class FormXemDiem : Form
    {
        KetQua_BUS ketQua_BUS = new KetQua_BUS();
        MonHoc_BUS monHoc_BUS = new MonHoc_BUS();
        public FormXemDiem()
        {
            InitializeComponent();
        }

        private void FormXemDiem_Load(object sender, EventArgs e)
        {
            loadData();
            LoadMon();
        }
        public void LoadMon()
        {
            Dictionary<string, string> mapMonHoc = monHoc_BUS.getMonHocList();
            cbbMonHoc.DataSource = new BindingSource(mapMonHoc, null);

            cbbMonHoc.DisplayMember = "Value"; // Hiển thị Tên khoa (phần Value của Dictionary)
            cbbMonHoc.ValueMember = "Key";
        }
        public void loadData()
        {
            dgvKetQua.DataSource = ketQua_BUS.LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maMH = cbbMonHoc.SelectedValue.ToString();
            string maSV = txtMaSV.Text;
            dgvKetQua.DataSource =  ketQua_BUS.layDiem(maMH, maSV);
        }
    }
}
