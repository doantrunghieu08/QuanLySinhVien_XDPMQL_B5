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
using QuanLyThuVien;

namespace QuanLySinhVien
{
    public partial class FormTimMonHoc : Form
    {
        MonHoc_BUS bus = new MonHoc_BUS();
        public FormTimMonHoc()
        {
            InitializeComponent();
        }

        private void FormTimMonHoc_Load(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = bus.LoadData();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = bus.Search(txtTimKiem.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassExcel excel = new ClassExcel();
            excel.XuatExcel(dgvMonHoc, "MonHoc.xlsx");
        }
    }
}
