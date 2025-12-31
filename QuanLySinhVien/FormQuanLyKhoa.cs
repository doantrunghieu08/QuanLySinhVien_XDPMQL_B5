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
    public partial class FormQuanLyKhoa : Form
    {
        Khoa_BUS khoa_BUS = new Khoa_BUS();
        public FormQuanLyKhoa()
        {
            InitializeComponent();
        }

        public void LoadForm()
        {
            dgvKhoa.DataSource = khoa_BUS.LoadData();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Khoa_DTO ob = new Khoa_DTO();
            ob.MaKhoa = textBox1.Text;
            ob.TenKhoa = textBox2.Text;
            khoa_BUS.Insert(ob);
            MessageBox.Show("Lưu thành công");
            LoadForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn sửa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Khoa_DTO ob = new Khoa_DTO();
                string maKhoa = (string)textBox1.Text.Trim();
                ob.TenKhoa = textBox2.Text.Trim();
                khoa_BUS.update(maKhoa, ob);
                LoadForm();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string maKhoa = (string)textBox1.Text.Trim();
                khoa_BUS.Delete(maKhoa);
                LoadForm();
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

        private void FormQuanLyKhoa_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhoa.Rows[e.RowIndex];
                textBox1.Text = row.Cells["MaKhoa_HieuDT_3725"].Value.ToString();
                textBox2.Text = row.Cells["TenKhoa_HieuDT_3725"].Value.ToString();
            }
        }
    }
}
