using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class ucPayment
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblThongTinKhach = new System.Windows.Forms.Label();
            this.lblTour = new System.Windows.Forms.Label();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.lblNgayVe = new System.Windows.Forms.Label();
            this.lblGiaTour = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnXacNhanThanhToan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblThongBaoThanhCong = new System.Windows.Forms.Label();
            this.timerRedirect = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblThongTinKhach
            // 
            this.lblThongTinKhach.Location = new System.Drawing.Point(227, 62);
            this.lblThongTinKhach.Name = "lblThongTinKhach";
            this.lblThongTinKhach.Size = new System.Drawing.Size(400, 25);
            this.lblThongTinKhach.TabIndex = 6;
            this.lblThongTinKhach.Text = "Khách hàng: ...";
            // 
            // lblTour
            // 
            this.lblTour.Location = new System.Drawing.Point(227, 97);
            this.lblTour.Name = "lblTour";
            this.lblTour.Size = new System.Drawing.Size(400, 25);
            this.lblTour.TabIndex = 5;
            this.lblTour.Text = "Tour: ...";
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.Location = new System.Drawing.Point(227, 132);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(400, 25);
            this.lblNgayDi.TabIndex = 4;
            this.lblNgayDi.Text = "Ngày đi: ...";
            // 
            // lblNgayVe
            // 
            this.lblNgayVe.Location = new System.Drawing.Point(227, 167);
            this.lblNgayVe.Name = "lblNgayVe";
            this.lblNgayVe.Size = new System.Drawing.Size(400, 25);
            this.lblNgayVe.TabIndex = 7;
            this.lblNgayVe.Text = "Ngày về: ...";
            // 
            // lblGiaTour
            // 
            this.lblGiaTour.Location = new System.Drawing.Point(227, 202);
            this.lblGiaTour.Name = "lblGiaTour";
            this.lblGiaTour.Size = new System.Drawing.Size(400, 25);
            this.lblGiaTour.TabIndex = 8;
            this.lblGiaTour.Text = "Giá tour: ...";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Location = new System.Drawing.Point(227, 237);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(400, 25);
            this.lblSoLuong.TabIndex = 9;
            this.lblSoLuong.Text = "Số lượng đặt: ...";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Blue;
            this.lblTongTien.Location = new System.Drawing.Point(227, 308);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(400, 35);
            this.lblTongTien.TabIndex = 3;
            this.lblTongTien.Text = "TỔNG TIỀN: 0 VNĐ";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXacNhanThanhToan
            // 
            this.btnXacNhanThanhToan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXacNhanThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXacNhanThanhToan.Location = new System.Drawing.Point(440, 366);
            this.btnXacNhanThanhToan.Name = "btnXacNhanThanhToan";
            this.btnXacNhanThanhToan.Size = new System.Drawing.Size(150, 40);
            this.btnXacNhanThanhToan.TabIndex = 2;
            this.btnXacNhanThanhToan.Text = "Xác nhận thanh toán";
            this.btnXacNhanThanhToan.UseVisualStyleBackColor = false;
            this.btnXacNhanThanhToan.Click += new System.EventHandler(this.btnXacNhanThanhToan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(245, 366);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 40);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Quay lại";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblThongBaoThanhCong
            // 
            this.lblThongBaoThanhCong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblThongBaoThanhCong.ForeColor = System.Drawing.Color.Green;
            this.lblThongBaoThanhCong.Location = new System.Drawing.Point(240, 431);
            this.lblThongBaoThanhCong.Name = "lblThongBaoThanhCong";
            this.lblThongBaoThanhCong.Size = new System.Drawing.Size(350, 25);
            this.lblThongBaoThanhCong.TabIndex = 0;
            this.lblThongBaoThanhCong.Text = "Đặt Tour Thành Công! Tự động quay về sau 3s...";
            this.lblThongBaoThanhCong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThongBaoThanhCong.Visible = false;
            // 
            // timerRedirect
            // 
            this.timerRedirect.Interval = 1000;
            this.timerRedirect.Tick += new System.EventHandler(this.timerRedirect_Tick);
            // 
            // ucPayment
            // 
            this.Controls.Add(this.lblThongBaoThanhCong);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhanThanhToan);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblGiaTour);
            this.Controls.Add(this.lblNgayVe);
            this.Controls.Add(this.lblNgayDi);
            this.Controls.Add(this.lblTour);
            this.Controls.Add(this.lblThongTinKhach);
            this.Name = "ucPayment";
            this.Size = new System.Drawing.Size(819, 520);
            this.ResumeLayout(false);

        }

        private Label lblThongTinKhach;
        private Label lblTour;
        private Label lblNgayDi;
        private Label lblNgayVe;
        private Label lblGiaTour;
        private Label lblSoLuong;
        private Label lblTongTien;
        private Button btnXacNhanThanhToan;
        private Button btnHuy;
        private Label lblThongBaoThanhCong;
        private System.Windows.Forms.Timer timerRedirect;
    }
}