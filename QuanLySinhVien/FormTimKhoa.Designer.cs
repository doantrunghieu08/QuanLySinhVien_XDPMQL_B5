namespace QuanLySinhVien
{
    partial class FormTimKhoa
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
            tableLayoutPanel1 = new TableLayoutPanel();
            txtTimKiem = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label8 = new Label();
            dgvTimKhoa = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTimKhoa).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(txtTimKiem, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(dgvTimKhoa, 1, 2);
            tableLayoutPanel1.Controls.Add(button1, 0, 2);
            tableLayoutPanel1.Controls.Add(button2, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.2718449F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.3130751F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.077348F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 59.6685066F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(938, 543);
            tableLayoutPanel1.TabIndex = 40;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(315, 135);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(274, 27);
            txtTimKiem.TabIndex = 36;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Location = new Point(242, 131);
            label2.Name = "label2";
            label2.Size = new Size(67, 55);
            label2.TabIndex = 37;
            label2.Text = "Từ Khóa:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(315, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 125);
            panel1.TabIndex = 41;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 6);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(197, 31);
            label1.TabIndex = 41;
            label1.Text = "Tìm Kiếm Khoa";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(39, 57);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(244, 20);
            label8.TabIndex = 40;
            label8.Text = "Đoàn Trung Hiếu - CD233725 - N01";
            // 
            // dgvTimKhoa
            // 
            dgvTimKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTimKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dgvTimKhoa, 3);
            dgvTimKhoa.Location = new Point(3, 222);
            dgvTimKhoa.Margin = new Padding(3, 4, 3, 4);
            dgvTimKhoa.Name = "dgvTimKhoa";
            dgvTimKhoa.RowHeadersWidth = 51;
            dgvTimKhoa.Size = new Size(932, 317);
            dgvTimKhoa.TabIndex = 39;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(109, 189);
            button1.Name = "button1";
            button1.Size = new Size(94, 26);
            button1.TabIndex = 42;
            button1.Text = "Xuất excel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(421, 189);
            button2.Name = "button2";
            button2.Size = new Size(94, 26);
            button2.TabIndex = 43;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormTimKhoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 543);
            Controls.Add(tableLayoutPanel1);
            Name = "FormTimKhoa";
            Text = "FormTimKhoa";
            Load += FormTimKhoa_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTimKhoa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtTimKiem;
        private Label label2;
        private DataGridView dgvTimKhoa;
        private Label label8;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}