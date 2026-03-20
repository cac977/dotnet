namespace WindowsFormsApp1
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTourFilter = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.cboDiaDiemDi = new System.Windows.Forms.ComboBox();
            this.dateKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.dtgrTour = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDiaDiemDen = new System.Windows.Forms.ComboBox();
            this.cboGia = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrTour)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTourFilter
            // 
            this.lblTourFilter.AutoSize = true;
            this.lblTourFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTourFilter.Location = new System.Drawing.Point(717, 11);
            this.lblTourFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTourFilter.Name = "lblTourFilter";
            this.lblTourFilter.Size = new System.Drawing.Size(762, 73);
            this.lblTourFilter.TabIndex = 0;
            this.lblTourFilter.Text = "TìM KIẾM VÀ LỌC TOUR";
            this.lblTourFilter.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTourFilter);
            this.panel1.Location = new System.Drawing.Point(-10, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2190, 124);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 498);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Địa điểm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 412);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày Khởi hành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(222, 197);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(384, 26);
            this.txtTen.TabIndex = 6;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // cboDiaDiemDi
            // 
            this.cboDiaDiemDi.FormattingEnabled = true;
            this.cboDiaDiemDi.Location = new System.Drawing.Point(222, 297);
            this.cboDiaDiemDi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDiaDiemDi.Name = "cboDiaDiemDi";
            this.cboDiaDiemDi.Size = new System.Drawing.Size(145, 28);
            this.cboDiaDiemDi.TabIndex = 8;
            // 
            // dateKhoiHanh
            // 
            this.dateKhoiHanh.Checked = false;
            this.dateKhoiHanh.Location = new System.Drawing.Point(222, 403);
            this.dateKhoiHanh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateKhoiHanh.Name = "dateKhoiHanh";
            this.dateKhoiHanh.Size = new System.Drawing.Size(384, 26);
            this.dateKhoiHanh.TabIndex = 9;
            this.dateKhoiHanh.ValueChanged += new System.EventHandler(this.dateKhoiHanh_ValueChanged);
            // 
            // dtgrTour
            // 
            this.dtgrTour.AllowUserToAddRows = false;
            this.dtgrTour.AllowUserToDeleteRows = false;
            this.dtgrTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrTour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrTour.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrTour.Location = new System.Drawing.Point(642, 197);
            this.dtgrTour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgrTour.Name = "dtgrTour";
            this.dtgrTour.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrTour.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrTour.RowHeadersWidth = 62;
            this.dtgrTour.Size = new System.Drawing.Size(1510, 668);
            this.dtgrTour.TabIndex = 10;
            this.dtgrTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrTour_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "đi đến";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cboDiaDiemDen
            // 
            this.cboDiaDiemDen.FormattingEnabled = true;
            this.cboDiaDiemDen.Location = new System.Drawing.Point(460, 297);
            this.cboDiaDiemDen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDiaDiemDen.Name = "cboDiaDiemDen";
            this.cboDiaDiemDen.Size = new System.Drawing.Size(145, 28);
            this.cboDiaDiemDen.TabIndex = 12;
            // 
            // cboGia
            // 
            this.cboGia.FormattingEnabled = true;
            this.cboGia.Location = new System.Drawing.Point(222, 486);
            this.cboGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboGia.Name = "cboGia";
            this.cboGia.Size = new System.Drawing.Size(384, 28);
            this.cboGia.TabIndex = 13;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(64, 637);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(172, 71);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(435, 637);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(172, 71);
            this.btnDong.TabIndex = 15;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2170, 895);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cboGia);
            this.Controls.Add(this.cboDiaDiemDen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgrTour);
            this.Controls.Add(this.dateKhoiHanh);
            this.Controls.Add(this.cboDiaDiemDi);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTourFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ComboBox cboDiaDiemDi;
        private System.Windows.Forms.DateTimePicker dateKhoiHanh;
        private System.Windows.Forms.DataGridView dtgrTour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboDiaDiemDen;
        private System.Windows.Forms.ComboBox cboGia;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnDong;
    }
}