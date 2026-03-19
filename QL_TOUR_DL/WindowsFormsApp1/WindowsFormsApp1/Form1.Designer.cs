namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblQLTourDuLich = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTourFilter = new System.Windows.Forms.Button();
            this.thong_ke_button = new System.Windows.Forms.Button();
            this.quanLyTour = new System.Windows.Forms.Button();
            this.quanlykhach = new System.Windows.Forms.Button();
            this.datTour = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQLTourDuLich
            // 
            this.lblQLTourDuLich.AutoSize = true;
            this.lblQLTourDuLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLTourDuLich.Location = new System.Drawing.Point(143, 7);
            this.lblQLTourDuLich.Name = "lblQLTourDuLich";
            this.lblQLTourDuLich.Size = new System.Drawing.Size(544, 51);
            this.lblQLTourDuLich.TabIndex = 0;
            this.lblQLTourDuLich.Text = "QUẢN LÝ TOUR DU LỊCH";
            this.lblQLTourDuLich.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblQLTourDuLich);
            this.panel1.Location = new System.Drawing.Point(-4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 82);
            this.panel1.TabIndex = 1;
            // 
            // btnTourFilter
            // 
            this.btnTourFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTourFilter.Location = new System.Drawing.Point(283, 336);
            this.btnTourFilter.Name = "btnTourFilter";
            this.btnTourFilter.Size = new System.Drawing.Size(204, 32);
            this.btnTourFilter.TabIndex = 2;
            this.btnTourFilter.Text = "Tìm kiếm và lọc tour";
            this.btnTourFilter.UseVisualStyleBackColor = true;
            this.btnTourFilter.Click += new System.EventHandler(this.btnTourFilter_Click);
            // 
            // thong_ke_button
            // 
            this.thong_ke_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thong_ke_button.Location = new System.Drawing.Point(283, 276);
            this.thong_ke_button.Name = "thong_ke_button";
            this.thong_ke_button.Size = new System.Drawing.Size(204, 32);
            this.thong_ke_button.TabIndex = 4;
            this.thong_ke_button.Text = "Thống kê và báo cáo";
            this.thong_ke_button.UseVisualStyleBackColor = true;
            this.thong_ke_button.Click += new System.EventHandler(this.thong_ke_button_Click);
            // 
            // quanLyTour
            // 
            this.quanLyTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLyTour.Location = new System.Drawing.Point(283, 219);
            this.quanLyTour.Name = "quanLyTour";
            this.quanLyTour.Size = new System.Drawing.Size(204, 32);
            this.quanLyTour.TabIndex = 5;
            this.quanLyTour.Text = "Quản lý tour";
            this.quanLyTour.UseVisualStyleBackColor = true;
            this.quanLyTour.Click += new System.EventHandler(this.button1_Click);
            // 
            // quanlykhach
            // 
            this.quanlykhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanlykhach.Location = new System.Drawing.Point(283, 164);
            this.quanlykhach.Name = "quanlykhach";
            this.quanlykhach.Size = new System.Drawing.Size(204, 32);
            this.quanlykhach.TabIndex = 6;
            this.quanlykhach.Text = "Quản lý khách";
            this.quanlykhach.UseVisualStyleBackColor = true;
            this.quanlykhach.Click += new System.EventHandler(this.quanLyKhach);
            // 
            // datTour
            // 
            this.datTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datTour.Location = new System.Drawing.Point(283, 107);
            this.datTour.Name = "datTour";
            this.datTour.Size = new System.Drawing.Size(204, 32);
            this.datTour.TabIndex = 7;
            this.datTour.Text = "Đặt tour";
            this.datTour.UseVisualStyleBackColor = true;
            this.datTour.Click += new System.EventHandler(this.datTour_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datTour);
            this.Controls.Add(this.quanlykhach);
            this.Controls.Add(this.quanLyTour);
            this.Controls.Add(this.thong_ke_button);
            this.Controls.Add(this.btnTourFilter);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQLTourDuLich;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTourFilter;
        private System.Windows.Forms.Button thong_ke_button;
        private System.Windows.Forms.Button quanLyTour;
        private System.Windows.Forms.Button quanlykhach;
        private System.Windows.Forms.Button datTour;
    }
}