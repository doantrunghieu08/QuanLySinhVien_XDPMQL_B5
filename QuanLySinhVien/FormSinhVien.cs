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
    public partial class FormQuanLySinhVien : Form
    {
        public SinhVien_BUS sinhVien_BUS = new SinhVien_BUS();
        public Khoa_BUS khoa_BUS = new Khoa_BUS();
        public FormQuanLySinhVien()
        {
            InitializeComponent();
            dTPNgaySinh.Format = DateTimePickerFormat.Custom;
            dTPNgaySinh.CustomFormat = "dd/MM/yyyy";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien_DTO ob = new SinhVien_DTO();
            ob.MaSV = txtMasv.Text;
            ob.TenSV = txtTen.Text;
            ob.NgaySinh = dTPNgaySinh.Value;

            if (rbnNam.Checked)
            {
                // 1 - Nam, 0 - Nữ
                ob.GioiTinh = 1;
            }
            else {
                ob.GioiTinh = 0;
            }

            ob.DiaChi = txtDiaChi.Text;
            ob.DienThoai = txtDienThoai.Text;
            ob.MaKhoa = cbbNganh.SelectedValue.ToString();
            sinhVien_BUS.Insert(ob);
        }

        public void LoadData()
        {
            dgvSinhVien.DataSource = sinhVien_BUS.LoadData();
        }

        public void LoadKhoa()
        {
            Dictionary<string, string> mapNganhHoc = khoa_BUS.getKhoaList();
            cbbNganh.DataSource = new BindingSource(mapNganhHoc, null);
           
            cbbNganh.DisplayMember = "Value"; // Hiển thị Tên khoa (phần Value của Dictionary)
            cbbNganh.ValueMember = "Key";
        }
        

        private void FormQuanLySinhVien_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadKhoa();
        }
    }
}
