namespace QuanLySinhVien
{
    partial class FormNhapDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel4 = new Panel();
            label5 = new Label();
            label6 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtMaMonHoc = new TextBox();
            txtMaSV = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtDQT = new TextBox();
            txtDCK = new TextBox();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            dgvKetQua = new DataGridView();
            khoa_HieudT_3725TableAdapter1 = new QuanLyDiemTableAdapters.Khoa_HieuDT_3725TableAdapter();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1298, 598);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1298, 95);
            panel4.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(554, 18);
            label5.Name = "label5";
            label5.Size = new Size(158, 38);
            label5.TabIndex = 8;
            label5.Text = "Nhập điểm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(527, 56);
            label6.Name = "label6";
            label6.Size = new Size(244, 20);
            label6.TabIndex = 9;
            label6.Text = "Đoàn Trung Hiếu - CD233725 - N01";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtMaMonHoc, 1, 1);
            tableLayoutPanel1.Controls.Add(txtMaSV, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txtDQT, 1, 2);
            tableLayoutPanel1.Controls.Add(txtDCK, 1, 3);
            tableLayoutPanel1.Controls.Add(panel3, 0, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(151, 101);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(948, 235);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // txtMaMonHoc
            // 
            txtMaMonHoc.Location = new Point(477, 50);
            txtMaMonHoc.Name = "txtMaMonHoc";
            txtMaMonHoc.Size = new Size(199, 27);
            txtMaMonHoc.TabIndex = 10;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(477, 3);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(199, 27);
            txtMaSV.TabIndex = 10;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(379, 141);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 8;
            label4.Text = "Điểm cuối kì";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(363, 94);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 7;
            label3.Text = "Điểm quá trình";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(379, 47);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 6;
            label2.Text = "Mã môn học";
            // 
            // txtDQT
            // 
            txtDQT.Location = new Point(477, 97);
            txtDQT.Name = "txtDQT";
            txtDQT.Size = new Size(199, 27);
            txtDQT.TabIndex = 2;
            // 
            // txtDCK
            // 
            txtDCK.Location = new Point(477, 144);
            txtDCK.Name = "txtDCK";
            txtDCK.Size = new Size(199, 27);
            txtDCK.TabIndex = 3;
            // 
            // panel3
            // 
            tableLayoutPanel1.SetColumnSpan(panel3, 2);
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 191);
            panel3.Name = "panel3";
            panel3.Size = new Size(942, 41);
            panel3.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(button4, 3, 0);
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Controls.Add(button3, 2, 0);
            tableLayoutPanel2.Controls.Add(button2, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(942, 41);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(773, 4);
            button4.Name = "button4";
            button4.Size = new Size(100, 32);
            button4.TabIndex = 5;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(67, 4);
            button1.Name = "button1";
            button1.Size = new Size(100, 32);
            button1.TabIndex = 2;
            button1.Text = "Thêm ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(537, 4);
            button3.Name = "button3";
            button3.Size = new Size(100, 32);
            button3.TabIndex = 4;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(302, 4);
            button2.Name = "button2";
            button2.Size = new Size(100, 32);
            button2.TabIndex = 3;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(380, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 5;
            label1.Text = "Mã sinh viên";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvKetQua);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 362);
            panel2.Name = "panel2";
            panel2.Size = new Size(1298, 236);
            panel2.TabIndex = 0;
            // 
            // dgvKetQua
            // 
            dgvKetQua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKetQua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQua.Location = new Point(151, 3);
            dgvKetQua.Name = "dgvKetQua";
            dgvKetQua.RowHeadersWidth = 51;
            dgvKetQua.Size = new Size(1016, 230);
            dgvKetQua.TabIndex = 0;
            dgvKetQua.CellClick += dgvKetQua_CellClick;
            // 
            // khoa_HieudT_3725TableAdapter1
            // 
            khoa_HieudT_3725TableAdapter1.ClearBeforeFill = true;
            // 
            // FormNhapDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 598);
            Controls.Add(panel1);
            Name = "FormNhapDiem";
            Text = "FormNhapDiem";
            Load += FormNhapDiem_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvKetQua;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtDQT;
        private TextBox txtDCK;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Panel panel4;
        private Label label5;
        private Label label6;
        private TextBox txtMaMonHoc;
        private TextBox txtMaSV;
        private QuanLyDiemTableAdapters.Khoa_HieuDT_3725TableAdapter khoa_HieudT_3725TableAdapter1;
    }
}