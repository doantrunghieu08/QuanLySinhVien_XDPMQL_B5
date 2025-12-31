namespace QuanLySinhVien
{
    partial class FormXemDiem
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
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            txtMaSV = new TextBox();
            label1 = new Label();
            cbbMonHoc = new ComboBox();
            panel2 = new Panel();
            dgvKetQua = new DataGridView();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1321, 623);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1321, 95);
            panel4.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(554, 18);
            label5.Name = "label5";
            label5.Size = new Size(144, 38);
            label5.TabIndex = 8;
            label5.Text = "Xem điểm";
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
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(1061, 347);
            button2.Name = "button2";
            button2.Size = new Size(106, 34);
            button2.TabIndex = 15;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(837, 209);
            button1.Name = "button1";
            button1.Size = new Size(121, 89);
            button1.TabIndex = 14;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txtMaSV, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(cbbMonHoc, 1, 1);
            tableLayoutPanel1.Location = new Point(337, 196);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(479, 102);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(144, 51);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 14;
            label2.Text = "Mã môn học";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(242, 3);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(199, 27);
            txtMaSV.TabIndex = 11;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(145, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 12;
            label1.Text = "Mã sinh viên";
            // 
            // cbbMonHoc
            // 
            cbbMonHoc.FormattingEnabled = true;
            cbbMonHoc.Location = new Point(242, 54);
            cbbMonHoc.Name = "cbbMonHoc";
            cbbMonHoc.Size = new Size(199, 28);
            cbbMonHoc.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvKetQua);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 387);
            panel2.Name = "panel2";
            panel2.Size = new Size(1321, 236);
            panel2.TabIndex = 1;
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
            // 
            // FormXemDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 623);
            Controls.Add(panel1);
            Name = "FormXemDiem";
            Text = "FormXemDiem";
            Load += FormXemDiem_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvKetQua;
        private TextBox txtMaSV;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cbbMonHoc;
        private Label label2;
        private Button button1;
        private Button button2;
        private Panel panel4;
        private Label label5;
        private Label label6;
    }
}