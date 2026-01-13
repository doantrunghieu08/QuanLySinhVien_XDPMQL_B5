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
    public partial class FormTimKhoa : Form
    {
        Khoa_BUS khoa_BUS = new Khoa_BUS();
        public FormTimKhoa()
        {
            InitializeComponent();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvTimKhoa.DataSource = khoa_BUS.search(txtTimKiem.Text);
        }

        private void FormTimKhoa_Load(object sender, EventArgs e)
        {
            dgvTimKhoa.DataSource = khoa_BUS.LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassExcel excel = new ClassExcel();
            excel.XuatExcel(dgvTimKhoa, "Khoa.xlsx");
        }
    }
}
