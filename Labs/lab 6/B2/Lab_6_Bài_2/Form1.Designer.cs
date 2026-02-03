namespace Lab_6_Bài_2
{
    partial class Form1
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMaCB = new TextBox();
            txtTenCB = new TextBox();
            cbChucVu = new ComboBox();
            txtSoGioGiang = new TextBox();
            txtDonGia = new TextBox();
            btnThem = new Button();
            btnLuu = new Button();
            btnDong = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(142, 38);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(296, 32);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN CÁN BỘ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(50, 135);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "MSCB";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(50, 212);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 2;
            label3.Text = "Họ tên CB";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(50, 288);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 3;
            label4.Text = "Chức vụ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(50, 365);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(114, 25);
            label5.TabIndex = 4;
            label5.Text = "Số giờ giảng";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(50, 442);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(75, 25);
            label6.TabIndex = 5;
            label6.Text = "Đơn giá";
            // 
            // txtMaCB
            // 
            txtMaCB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMaCB.BackColor = SystemColors.Control;
            txtMaCB.BorderStyle = BorderStyle.FixedSingle;
            txtMaCB.Location = new Point(217, 129);
            txtMaCB.Margin = new Padding(5, 6, 5, 6);
            txtMaCB.Name = "txtMaCB";
            txtMaCB.ReadOnly = true;
            txtMaCB.Size = new Size(347, 31);
            txtMaCB.TabIndex = 6;
            txtMaCB.TabStop = false;
            txtMaCB.Enter += txtMaCB_Enter;
            // 
            // txtTenCB
            // 
            txtTenCB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTenCB.BorderStyle = BorderStyle.FixedSingle;
            txtTenCB.Location = new Point(217, 206);
            txtTenCB.Margin = new Padding(5, 6, 5, 6);
            txtTenCB.Name = "txtTenCB";
            txtTenCB.Size = new Size(347, 31);
            txtTenCB.TabIndex = 7;
            // 
            // cbChucVu
            // 
            cbChucVu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbChucVu.FormattingEnabled = true;
            cbChucVu.Location = new Point(217, 283);
            cbChucVu.Margin = new Padding(5, 6, 5, 6);
            cbChucVu.Name = "cbChucVu";
            cbChucVu.Size = new Size(347, 33);
            cbChucVu.TabIndex = 8;
            // 
            // txtSoGioGiang
            // 
            txtSoGioGiang.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSoGioGiang.BorderStyle = BorderStyle.FixedSingle;
            txtSoGioGiang.Location = new Point(217, 360);
            txtSoGioGiang.Margin = new Padding(5, 6, 5, 6);
            txtSoGioGiang.Name = "txtSoGioGiang";
            txtSoGioGiang.Size = new Size(347, 31);
            txtSoGioGiang.TabIndex = 9;
            // 
            // txtDonGia
            // 
            txtDonGia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDonGia.BorderStyle = BorderStyle.FixedSingle;
            txtDonGia.Location = new Point(217, 437);
            txtDonGia.Margin = new Padding(5, 6, 5, 6);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(347, 31);
            txtDonGia.TabIndex = 10;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom;
            btnThem.Location = new Point(100, 539);
            btnThem.Margin = new Padding(5, 6, 5, 6);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(125, 58);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Bottom;
            btnLuu.Enabled = false;
            btnLuu.Location = new Point(267, 539);
            btnLuu.Margin = new Padding(5, 6, 5, 6);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(125, 58);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnDong
            // 
            btnDong.Anchor = AnchorStyles.Bottom;
            btnDong.Location = new Point(433, 539);
            btnDong.Margin = new Padding(5, 6, 5, 6);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(125, 58);
            btnDong.TabIndex = 13;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 656);
            Controls.Add(btnDong);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(txtDonGia);
            Controls.Add(txtSoGioGiang);
            Controls.Add(cbChucVu);
            Controls.Add(txtTenCB);
            Controls.Add(txtMaCB);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cán Bụ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaCB;
        private System.Windows.Forms.TextBox txtTenCB;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.TextBox txtSoGioGiang;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
    }
}