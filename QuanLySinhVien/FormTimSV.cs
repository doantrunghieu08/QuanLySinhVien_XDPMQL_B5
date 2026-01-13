using BUS;
using QuanLyThuVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV_DangND_0899_LTMT5
{
    public partial class FormTimSV : Form
    {
        SinhVien_BUS bus = new SinhVien_BUS();
        public FormTimSV()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void loadData()
        {
            dgvTimSV.DataSource = bus.LoadData();
        }
        private void FormTimSV_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

            dgvTimSV.DataSource = bus.Search(txtTimKiem.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassExcel excel = new ClassExcel();
            excel.XuatExcel(dgvTimSV, "sinhvien.xlsx");
        }
    }
}
