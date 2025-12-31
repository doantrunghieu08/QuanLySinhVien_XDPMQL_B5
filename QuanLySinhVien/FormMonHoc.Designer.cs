namespace QuanLySinhVien
{
    partial class FormMonHoc
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
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            txtSoTiet = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            txtMaMon = new TextBox();
            txtTenMon = new TextBox();
            panel2 = new Panel();
            dgvMonHoc = new DataGridView();
            txtTimKiem = new TextBox();
            button5 = new Button();
            label6 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonHoc).BeginInit();
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
            panel1.Size = new Size(1164, 528);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1164, 81);
            panel4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(454, 8);
            label5.Name = "label5";
            label5.Size = new Size(234, 38);
            label5.TabIndex = 6;
            label5.Text = "Quản lý môn học";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 46);
            label4.Name = "label4";
            label4.Size = new Size(244, 20);
            label4.TabIndex = 7;
            label4.Text = "Đoàn Trung Hiếu - CD233725 - N01";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(label6, 2, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtSoTiet, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtMaMon, 1, 0);
            tableLayoutPanel1.Controls.Add(txtTenMon, 1, 1);
            tableLayoutPanel1.Controls.Add(button5, 2, 3);
            tableLayoutPanel1.Controls.Add(txtTimKiem, 2, 2);
            tableLayoutPanel1.Location = new Point(142, 90);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.3968258F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.338623F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.1322746F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.1322746F));
            tableLayoutPanel1.Size = new Size(802, 188);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(212, 105);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 5;
            label3.Text = "Số tiết";
            // 
            // txtSoTiet
            // 
            txtSoTiet.Anchor = AnchorStyles.Left;
            txtSoTiet.Location = new Point(270, 102);
            txtSoTiet.Name = "txtSoTiet";
            txtSoTiet.Size = new Size(157, 27);
            txtSoTiet.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(198, 59);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên môn";
            // 
            // panel3
            // 
            tableLayoutPanel1.SetColumnSpan(panel3, 2);
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Location = new Point(3, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(528, 43);
            panel3.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(button3, 2, 0);
            tableLayoutPanel2.Controls.Add(button4, 3, 0);
            tableLayoutPanel2.Controls.Add(button2, 1, 0);
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(522, 34);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(281, 3);
            button3.Name = "button3";
            button3.Size = new Size(87, 28);
            button3.TabIndex = 5;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(412, 3);
            button4.Name = "button4";
            button4.Size = new Size(87, 28);
            button4.TabIndex = 6;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(151, 3);
            button2.Name = "button2";
            button2.Size = new Size(87, 28);
            button2.TabIndex = 4;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(21, 3);
            button1.Name = "button1";
            button1.Size = new Size(87, 28);
            button1.TabIndex = 3;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(200, 13);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 3;
            label1.Text = "Mã môn";
            // 
            // txtMaMon
            // 
            txtMaMon.Anchor = AnchorStyles.Left;
            txtMaMon.Location = new Point(270, 10);
            txtMaMon.Name = "txtMaMon";
            txtMaMon.Size = new Size(157, 27);
            txtMaMon.TabIndex = 3;
            // 
            // txtTenMon
            // 
            txtTenMon.Anchor = AnchorStyles.Left;
            txtTenMon.Location = new Point(270, 56);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(157, 27);
            txtTenMon.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvMonHoc);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 281);
            panel2.Name = "panel2";
            panel2.Size = new Size(1164, 247);
            panel2.TabIndex = 1;
            // 
            // dgvMonHoc
            // 
            dgvMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonHoc.Location = new Point(123, 3);
            dgvMonHoc.Name = "dgvMonHoc";
            dgvMonHoc.RowHeadersWidth = 51;
            dgvMonHoc.Size = new Size(925, 241);
            dgvMonHoc.TabIndex = 0;
            dgvMonHoc.CellClick += dgvMonHoc_CellClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Left;
            txtTimKiem.Location = new Point(537, 102);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(262, 27);
            txtTimKiem.TabIndex = 9;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Location = new Point(621, 149);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 10;
            button5.Text = "Tìm kiếm";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Location = new Point(636, 72);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 8;
            label6.Text = "Mã môn";
            // 
            // FormMonHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 528);
            Controls.Add(panel1);
            Name = "FormMonHoc";
            Text = "FormMonHoc";
            Load += FormMonHoc_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMonHoc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvMonHoc;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button2;
        private TextBox txtMaMon;
        private TextBox txtSoTiet;
        private TextBox txtTenMon;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel4;
        private TextBox txtTimKiem;
        private Button button5;
        private Label label6;
    }
}