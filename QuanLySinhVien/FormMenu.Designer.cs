namespace QuanLySinhVien
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            hệThốnToolStripMenuItem = new ToolStripMenuItem();
            đăngToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            ChucNangItem = new ToolStripMenuItem();
            SinhVienItem = new ToolStripMenuItem();
            KhoaItem = new ToolStripMenuItem();
            MonHocItem = new ToolStripMenuItem();
            NhapDiemItem = new ToolStripMenuItem();
            XemDiemItem = new ToolStripMenuItem();
            ThongKeItem = new ToolStripMenuItem();
            hToolStripMenuItem = new ToolStripMenuItem();
            tìmKiếmToolStripMenuItem = new ToolStripMenuItem();
            SearchSinhVienItem = new ToolStripMenuItem();
            SearchKhoaItem = new ToolStripMenuItem();
            SearchMonHocItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốnToolStripMenuItem, ChucNangItem, hToolStripMenuItem, tìmKiếmToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1214, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốnToolStripMenuItem
            // 
            hệThốnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngToolStripMenuItem, thoátToolStripMenuItem });
            hệThốnToolStripMenuItem.Name = "hệThốnToolStripMenuItem";
            hệThốnToolStripMenuItem.Size = new Size(85, 24);
            hệThốnToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngToolStripMenuItem
            // 
            đăngToolStripMenuItem.Name = "đăngToolStripMenuItem";
            đăngToolStripMenuItem.Size = new Size(160, 26);
            đăngToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(160, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // ChucNangItem
            // 
            ChucNangItem.DropDownItems.AddRange(new ToolStripItem[] { SinhVienItem, KhoaItem, MonHocItem, NhapDiemItem, XemDiemItem, ThongKeItem });
            ChucNangItem.Name = "ChucNangItem";
            ChucNangItem.Size = new Size(93, 24);
            ChucNangItem.Text = "Chức năng";
            ChucNangItem.DropDownItemClicked += ChucNangItem_DropDownItemClicked;
            // 
            // SinhVienItem
            // 
            SinhVienItem.Name = "SinhVienItem";
            SinhVienItem.Size = new Size(224, 26);
            SinhVienItem.Text = "Sinh viên ";
            // 
            // KhoaItem
            // 
            KhoaItem.Name = "KhoaItem";
            KhoaItem.Size = new Size(224, 26);
            KhoaItem.Text = "Khoa";
            // 
            // MonHocItem
            // 
            MonHocItem.Name = "MonHocItem";
            MonHocItem.Size = new Size(224, 26);
            MonHocItem.Text = "Môn học";
            // 
            // NhapDiemItem
            // 
            NhapDiemItem.Name = "NhapDiemItem";
            NhapDiemItem.Size = new Size(224, 26);
            NhapDiemItem.Text = "Nhập điểm";
            // 
            // XemDiemItem
            // 
            XemDiemItem.Name = "XemDiemItem";
            XemDiemItem.Size = new Size(224, 26);
            XemDiemItem.Text = "Xem điểm";
            // 
            // ThongKeItem
            // 
            ThongKeItem.Name = "ThongKeItem";
            ThongKeItem.Size = new Size(224, 26);
            ThongKeItem.Text = "Thống kê";
            // 
            // hToolStripMenuItem
            // 
            hToolStripMenuItem.Name = "hToolStripMenuItem";
            hToolStripMenuItem.Size = new Size(66, 24);
            hToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // tìmKiếmToolStripMenuItem
            // 
            tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SearchSinhVienItem, SearchKhoaItem, SearchMonHocItem });
            tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            tìmKiếmToolStripMenuItem.Size = new Size(84, 24);
            tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            tìmKiếmToolStripMenuItem.DropDownItemClicked += tìmKiếmToolStripMenuItem_DropDownItemClicked;
            // 
            // SearchSinhVienItem
            // 
            SearchSinhVienItem.Name = "SearchSinhVienItem";
            SearchSinhVienItem.Size = new Size(224, 26);
            SearchSinhVienItem.Text = "Sinh viên";
            // 
            // SearchKhoaItem
            // 
            SearchKhoaItem.Name = "SearchKhoaItem";
            SearchKhoaItem.Size = new Size(224, 26);
            SearchKhoaItem.Text = "Khoa";
            // 
            // SearchMonHocItem
            // 
            SearchMonHocItem.Name = "SearchMonHocItem";
            SearchMonHocItem.Size = new Size(224, 26);
            SearchMonHocItem.Text = "Môn học";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 551);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMenu";
            Text = "Form menu";
            Load += FormMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốnToolStripMenuItem;
        private ToolStripMenuItem đăngToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem ChucNangItem;
        private ToolStripMenuItem SinhVienItem;
        private ToolStripMenuItem KhoaItem;
        private ToolStripMenuItem MonHocItem;
        private ToolStripMenuItem NhapDiemItem;
        private ToolStripMenuItem XemDiemItem;
        private ToolStripMenuItem ThongKeItem;
        private ToolStripMenuItem hToolStripMenuItem;
        private ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private ToolStripMenuItem SearchSinhVienItem;
        private ToolStripMenuItem SearchKhoaItem;
        private ToolStripMenuItem SearchMonHocItem;
    }
}
