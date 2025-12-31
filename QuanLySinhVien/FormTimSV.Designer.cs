namespace QLTV_DangND_0899_LTMT5
{
    partial class FormTimSV
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
            label1 = new Label();
            txtTimKiem = new TextBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvTimSV = new DataGridView();
            label8 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTimSV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(297, 0);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 31);
            label1.TabIndex = 34;
            label1.Text = "Tìm Kiếm Sinh Viên";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(284, 156);
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
            label2.Location = new Point(211, 152);
            label2.Name = "label2";
            label2.Size = new Size(67, 152);
            label2.TabIndex = 37;
            label2.Text = "Từ Khóa:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tableLayoutPanel1.Controls.Add(txtTimKiem, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(dgvTimSV, 0, 2);
            tableLayoutPanel1.Location = new Point(2, -1);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 299F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(912, 603);
            tableLayoutPanel1.TabIndex = 39;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // dgvTimSV
            // 
            dgvTimSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dgvTimSV, 3);
            dgvTimSV.Location = new Point(3, 308);
            dgvTimSV.Margin = new Padding(3, 4, 3, 4);
            dgvTimSV.Name = "dgvTimSV";
            dgvTimSV.RowHeadersWidth = 51;
            dgvTimSV.Size = new Size(905, 291);
            dgvTimSV.TabIndex = 39;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(304, 45);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(244, 20);
            label8.TabIndex = 35;
            label8.Text = "Đoàn Trung Hiếu - CD233725 - N01";
            // 
            // FormTimSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label8);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormTimSV";
            Text = "FormTimSV";
            Load += FormTimSV_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTimSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtTimKiem;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvTimSV;
        private Label label8;
    }
}