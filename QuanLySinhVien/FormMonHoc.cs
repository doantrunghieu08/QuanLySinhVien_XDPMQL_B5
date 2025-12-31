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
using DTO;

namespace QuanLySinhVien
{
    public partial class FormMonHoc : Form
    {
        MonHoc_BUS monHoc_BUS = new MonHoc_BUS();
        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            dgvMonHoc.DataSource = monHoc_BUS.LoadData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MonHoc_DTO ob = new MonHoc_DTO();
            ob.MaMonHoc = txtMaMon.Text;
            ob.TenMonHoc = txtTenMon.Text;
            ob.SoTiet = Convert.ToInt32(txtSoTiet.Text);
            monHoc_BUS.Insert(ob);
            MessageBox.Show("Thêm thành công");
            loadData();

        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = dgvMonHoc.Rows[e.RowIndex];
                txtMaMon.Text = row.Cells["MaMH_HieuDT_3725"].Value.ToString();
                txtTenMon.Text = row.Cells["TenMH_HieuDT_3725"].Value.ToString();
                txtSoTiet.Text = row.Cells["SoTiet_HieuDT_3725"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn sửa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MonHoc_DTO ob = new MonHoc_DTO();
                ob.TenMonHoc = txtTenMon.Text.Trim();
                ob.SoTiet = Convert.ToInt32(txtSoTiet.Text);
                string maMon = txtMaMon.Text;
                monHoc_BUS.Update(ob, maMon);
                loadData();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                monHoc_BUS.Delete(txtMaMon.Text);
                loadData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
