using QLTV_DangND_0899_LTMT5; // Đảm bảo namespace này chứa các Form con

namespace QuanLySinhVien
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // QUAN TRỌNG: Phải set cái này thì mới chứa được form con
        }

        // Xử lý menu Chức Năng
        private void ChucNangItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form frm = null; // Khởi tạo là null thay vì new Form()

            switch (e.ClickedItem.Name)
            {
                case "KhoaItem":
                    frm = new FormQuanLyKhoa();
                    break;
                case "SinhVienItem":
                    frm = new FormQuanLySinhVien();
                    break;
                case "MonHocItem":
                    frm = new FormMonHoc();
                    break;
                case "NhapDiemItem":
                    frm = new FormNhapDiem();
                    break;
                case "XemDiemItem":
                    frm = new FormXemDiem();
                    break;
            }

            // Chỉ hiển thị nếu form đã được tạo hợp lệ
            if (frm != null)
            {
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized; // Nếu muốn full màn hình
                frm.Show();
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            // Code chạy khi mở form (nếu cần)
        }

        // Xử lý menu Tìm Kiếm
        private void tìmKiếmToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form frm = null; // Khởi tạo null

            switch (e.ClickedItem.Name)
            {
                case "SearchSinhVienItem":
                    frm = new FormTimSV();
                    break;
                case "SearchKhoaItem":
                    frm = new FormTimKhoa(); // Chú ý: Bạn đang gọi FormTimKhoa cho SearchMonHoc?
                    break;
                case "SearchMonHocItem":
                    frm = new FormTimMonHoc();
                    break;
            }

            // Kiểm tra null để tránh hiện form trắng
            if (frm != null)
            {
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void SearchSinhVienItem_Click(object sender, EventArgs e)
        {

        }
    }
}