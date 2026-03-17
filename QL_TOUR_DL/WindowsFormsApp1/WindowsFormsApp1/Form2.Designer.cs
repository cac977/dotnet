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
            this.lblTourFilter.Location = new System.Drawing.Point(522, 7);
            this.lblTourFilter.Name = "lblTourFilter";
            this.lblTourFilter.Size = new System.Drawing.Size(513, 51);
            this.lblTourFilter.TabIndex = 0;
            this.lblTourFilter.Text = "TIM KIEM VA LOC TOUR";
            this.lblTourFilter.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTourFilter);
            this.panel1.Location = new System.Drawing.Point(-7, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1461, 81);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dia Diem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngay Khoi Hanh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ten";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(214, 128);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(257, 20);
            this.txtTen.TabIndex = 6;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // cboDiaDiemDi
            // 
            this.cboDiaDiemDi.FormattingEnabled = true;
            this.cboDiaDiemDi.Location = new System.Drawing.Point(214, 193);
            this.cboDiaDiemDi.Name = "cboDiaDiemDi";
            this.cboDiaDiemDi.Size = new System.Drawing.Size(98, 21);
            this.cboDiaDiemDi.TabIndex = 8;
            // 
            // dateKhoiHanh
            // 
            this.dateKhoiHanh.Checked = false;
            this.dateKhoiHanh.Location = new System.Drawing.Point(214, 262);
            this.dateKhoiHanh.Name = "dateKhoiHanh";
            this.dateKhoiHanh.Size = new System.Drawing.Size(257, 20);
            this.dateKhoiHanh.TabIndex = 9;
            this.dateKhoiHanh.ValueChanged += new System.EventHandler(this.dateKhoiHanh_ValueChanged);
            // 
            // dtgrTour
            // 
            this.dtgrTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrTour.Location = new System.Drawing.Point(525, 128);
            this.dtgrTour.Name = "dtgrTour";
            this.dtgrTour.Size = new System.Drawing.Size(910, 434);
            this.dtgrTour.TabIndex = 10;
            this.dtgrTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrTour_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Di dien";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cboDiaDiemDen
            // 
            this.cboDiaDiemDen.FormattingEnabled = true;
            this.cboDiaDiemDen.Location = new System.Drawing.Point(373, 193);
            this.cboDiaDiemDen.Name = "cboDiaDiemDen";
            this.cboDiaDiemDen.Size = new System.Drawing.Size(98, 21);
            this.cboDiaDiemDen.TabIndex = 12;
            // 
            // cboGia
            // 
            this.cboGia.FormattingEnabled = true;
            this.cboGia.Location = new System.Drawing.Point(214, 316);
            this.cboGia.Name = "cboGia";
            this.cboGia.Size = new System.Drawing.Size(257, 21);
            this.cboGia.TabIndex = 13;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(109, 414);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(115, 46);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tim kiem";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(356, 414);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(115, 46);
            this.btnDong.TabIndex = 15;
            this.btnDong.Text = "Dong";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 582);
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