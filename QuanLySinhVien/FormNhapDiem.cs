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
    public partial class FormNhapDiem : Form
    {
        KetQua_BUS ketQua_BUS = new KetQua_BUS();
        public FormNhapDiem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KetQua_DTO ob = new KetQua_DTO();
            ob.MaSV = txtMaSV.Text;
            ob.MaMH = txtMaMonHoc.Text;
            ob.DiemQT = Convert.ToInt32(txtDQT.Text);
            ob.DiemCK = Convert.ToInt32(txtDCK.Text);
            ketQua_BUS.Insert(ob);
            MessageBox.Show("Thêm thành công");
            loadData();

        }

        public void loadData()
        {
            dgvKetQua.DataSource = ketQua_BUS.LoadData();
        }
        private void FormNhapDiem_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = dgvKetQua.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells["MaSV_HieuDT_3725"].Value.ToString();
                txtMaMonHoc.Text = row.Cells["MaMH_HieuDT_3725"].Value.ToString();
                txtDQT.Text = row.Cells["DiemQT_HieuDT_3725"].Value.ToString();
                txtDCK.Text = row.Cells["DiemCK_HieuDT_3725"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn sửa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                KetQua_DTO ob = new KetQua_DTO();
                ob.DiemQT = Convert.ToInt32(txtDQT.Text);
                ob.DiemCK = Convert.ToInt32(txtDCK.Text);
                string maMH = txtMaMonHoc.Text;
                string maSV = txtMaSV.Text;
                ketQua_BUS.Update(maMH, maSV, ob);
                MessageBox.Show("Sửa thành công");
                loadData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string maMH = txtMaMonHoc.Text;
                string maSV = txtMaSV.Text;
                ketQua_BUS.Delete(maMH, maSV);
                MessageBox.Show("Xóa thành công");
                loadData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
