namespace QuanLySinhVien
{
    partial class FormQuanLySinhVien
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
            dgvSinhVien = new DataGridView();
            panel2 = new Panel();
            label9 = new Label();
            cbbNganh = new ComboBox();
            label8 = new Label();
            txtDienThoai = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            dTPNgaySinh = new DateTimePicker();
            rbnNu = new RadioButton();
            rbnNam = new RadioButton();
            txtDiaChi = new TextBox();
            txtTen = new TextBox();
            txtMasv = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvSinhVien);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1013, 544);
            panel1.TabIndex = 0;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(3, 394);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.Size = new Size(1007, 138);
            dgvSinhVien.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label9);
            panel2.Controls.Add(cbbNganh);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtDienThoai);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dTPNgaySinh);
            panel2.Controls.Add(rbnNu);
            panel2.Controls.Add(rbnNam);
            panel2.Controls.Add(txtDiaChi);
            panel2.Controls.Add(txtTen);
            panel2.Controls.Add(txtMasv);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1013, 388);
            panel2.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(282, 279);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 28;
            label9.Text = "Ngành học";
            // 
            // cbbNganh
            // 
            cbbNganh.FormattingEnabled = true;
            cbbNganh.Location = new Point(378, 271);
            cbbNganh.Name = "cbbNganh";
            cbbNganh.Size = new Size(270, 28);
            cbbNganh.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(528, 220);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 26;
            label8.Text = "Điện thoại";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(618, 213);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(250, 27);
            txtDienThoai.TabIndex = 25;
            txtDienThoai.TextChanged += textBox4_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(528, 172);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 24;
            label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(528, 130);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 23;
            label6.Text = "Giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 213);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 22;
            label5.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 172);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 21;
            label3.Text = "Tên sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 132);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 20;
            label2.Text = "Mã sinh viên";
            // 
            // dTPNgaySinh
            // 
            dTPNgaySinh.Format = DateTimePickerFormat.Custom;
            dTPNgaySinh.Location = new Point(227, 213);
            dTPNgaySinh.Name = "dTPNgaySinh";
            dTPNgaySinh.Size = new Size(250, 27);
            dTPNgaySinh.TabIndex = 19;
            // 
            // rbnNu
            // 
            rbnNu.AutoSize = true;
            rbnNu.Location = new Point(686, 125);
            rbnNu.Name = "rbnNu";
            rbnNu.Size = new Size(50, 24);
            rbnNu.TabIndex = 18;
            rbnNu.TabStop = true;
            rbnNu.Text = "Nữ";
            rbnNu.UseVisualStyleBackColor = true;
            // 
            // rbnNam
            // 
            rbnNam.AutoSize = true;
            rbnNam.Location = new Point(618, 128);
            rbnNam.Name = "rbnNam";
            rbnNam.Size = new Size(62, 24);
            rbnNam.TabIndex = 17;
            rbnNam.TabStop = true;
            rbnNam.Text = "Nam";
            rbnNam.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(618, 165);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(250, 27);
            txtDiaChi.TabIndex = 16;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(228, 165);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(250, 27);
            txtTen.TabIndex = 15;
            // 
            // txtMasv
            // 
            txtMasv.Location = new Point(227, 125);
            txtMasv.Name = "txtMasv";
            txtMasv.Size = new Size(251, 27);
            txtMasv.TabIndex = 14;
            // 
            // button4
            // 
            button4.Location = new Point(654, 340);
            button4.Name = "button4";
            button4.Size = new Size(106, 45);
            button4.TabIndex = 13;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(533, 340);
            button3.Name = "button3";
            button3.Size = new Size(106, 45);
            button3.TabIndex = 12;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(410, 340);
            button2.Name = "button2";
            button2.Size = new Size(106, 45);
            button2.TabIndex = 11;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(282, 340);
            button1.Name = "button1";
            button1.Size = new Size(106, 45);
            button1.TabIndex = 10;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(404, 47);
            label4.Name = "label4";
            label4.Size = new Size(244, 20);
            label4.TabIndex = 5;
            label4.Text = "Đoàn Trung Hiếu - CD233725 - N01";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(412, 9);
            label1.Name = "label1";
            label1.Size = new Size(236, 38);
            label1.TabIndex = 1;
            label1.Text = "Quản lý sinh viên";
            // 
            // FormQuanLySinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 544);
            Controls.Add(panel1);
            Name = "FormQuanLySinhVien";
            Text = "FormSinhVien";
            Load += FormQuanLySinhVien_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label4;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtDiaChi;
        private TextBox txtTen;
        private TextBox txtMasv;
        private RadioButton rbnNam;
        private RadioButton rbnNu;
        private DateTimePicker dTPNgaySinh;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtDienThoai;
        private Label label8;
        private DataGridView dgvSinhVien;
        private ComboBox cbbNganh;
        private Label label9;
    }
}