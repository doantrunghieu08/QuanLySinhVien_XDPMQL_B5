namespace QuanLySinhVien
{
    partial class FormQuanLyKhoa
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
            dgvKhoa = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvKhoa);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1270, 633);
            panel1.TabIndex = 0;
            // 
            // dgvKhoa
            // 
            dgvKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoa.Location = new Point(0, 283);
            dgvKhoa.Name = "dgvKhoa";
            dgvKhoa.RowHeadersWidth = 51;
            dgvKhoa.Size = new Size(1267, 350);
            dgvKhoa.TabIndex = 10;
            dgvKhoa.CellClick += dgvKhoa_CellClick;
            // 
            // button4
            // 
            button4.Location = new Point(725, 191);
            button4.Name = "button4";
            button4.Size = new Size(106, 45);
            button4.TabIndex = 9;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(604, 191);
            button3.Name = "button3";
            button3.Size = new Size(106, 45);
            button3.TabIndex = 8;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(481, 191);
            button2.Name = "button2";
            button2.Size = new Size(106, 45);
            button2.TabIndex = 7;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(353, 191);
            button1.Name = "button1";
            button1.Size = new Size(106, 45);
            button1.TabIndex = 6;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(488, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 27);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(481, 67);
            label4.Name = "label4";
            label4.Size = new Size(244, 20);
            label4.TabIndex = 4;
            label4.Text = "Đoàn Trung Hiếu - CD233725 - N01";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(488, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 27);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 155);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên khoa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 108);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã khoa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(505, 29);
            label1.Name = "label1";
            label1.Size = new Size(187, 38);
            label1.TabIndex = 0;
            label1.Text = "Quản lý khoa";
            label1.Click += label1_Click;
            // 
            // FormQuanLyKhoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 633);
            Controls.Add(panel1);
            Name = "FormQuanLyKhoa";
            Text = "FormQuanLyKhoa";
            Load += FormQuanLyKhoa_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dgvKhoa;
    }
}