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
            components = new System.ComponentModel.Container();
            lblThongTinKhach = new Label();
            lblTour = new Label();
            lblNgayDi = new Label();
            lblNgayVe = new Label(); // Thêm mới
            lblTongTien = new Label();
            btnXacNhanThanhToan = new Button();
            btnHuy = new Button();
            lblThongBaoThanhCong = new Label();
            timerRedirect = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblThongTinKhach
            // 
            lblThongTinKhach.Location = new Point(50, 40);
            lblThongTinKhach.Name = "lblThongTinKhach";
            lblThongTinKhach.Size = new Size(400, 25);
            lblThongTinKhach.TabIndex = 6;
            lblThongTinKhach.Text = "Khách hàng: ...";
            // 
            // lblTour
            // 
            lblTour.Location = new Point(50, 75);
            lblTour.Name = "lblTour";
            lblTour.Size = new Size(400, 25);
            lblTour.TabIndex = 5;
            lblTour.Text = "Tour: ...";
            // 
            // lblNgayDi
            // 
            lblNgayDi.Location = new Point(50, 110);
            lblNgayDi.Name = "lblNgayDi";
            lblNgayDi.Size = new Size(400, 25);
            lblNgayDi.TabIndex = 4;
            lblNgayDi.Text = "Ngày đi: ...";
            // 
            // lblNgayVe (Thêm mới)
            // 
            lblNgayVe.Location = new Point(50, 145);
            lblNgayVe.Name = "lblNgayVe";
            lblNgayVe.Size = new Size(400, 25);
            lblNgayVe.TabIndex = 7;
            lblNgayVe.Text = "Ngày về: ...";
            // 
            // lblTongTien
            // 
            lblTongTien.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.Blue;
            lblTongTien.Location = new Point(50, 190);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(400, 35);
            lblTongTien.TabIndex = 3;
            lblTongTien.Text = "TỔNG TIỀN: 0 VNĐ";
            // 
            // btnXacNhanThanhToan
            // 
            btnXacNhanThanhToan.BackColor = SystemColors.GradientActiveCaption;
            btnXacNhanThanhToan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXacNhanThanhToan.Location = new Point(205, 250);
            btnXacNhanThanhToan.Name = "btnXacNhanThanhToan";
            btnXacNhanThanhToan.Size = new Size(150, 40);
            btnXacNhanThanhToan.TabIndex = 2;
            btnXacNhanThanhToan.Text = "Xác nhận thanh toán";
            btnXacNhanThanhToan.UseVisualStyleBackColor = false;
            btnXacNhanThanhToan.Click += btnXacNhanThanhToan_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(50, 250);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(100, 40);
            btnHuy.TabIndex = 1;
            btnHuy.Text = "Quay lại";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // lblThongBaoThanhCong
            // 
            lblThongBaoThanhCong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblThongBaoThanhCong.ForeColor = Color.Green;
            lblThongBaoThanhCong.Location = new Point(50, 310);
            lblThongBaoThanhCong.Name = "lblThongBaoThanhCong";
            lblThongBaoThanhCong.Size = new Size(350, 25);
            lblThongBaoThanhCong.TabIndex = 0;
            lblThongBaoThanhCong.Text = "Đặt Tour Thành Công! Tự động quay về sau 3s...";
            lblThongBaoThanhCong.Visible = false;
            // 
            // timerRedirect
            // 
            timerRedirect.Interval = 1000;
            timerRedirect.Tick += timerRedirect_Tick;
            // 
            // ucPayment
            // 
            Controls.Add(lblThongBaoThanhCong);
            Controls.Add(btnHuy);
            Controls.Add(btnXacNhanThanhToan);
            Controls.Add(lblTongTien);
            Controls.Add(lblNgayVe); // Thêm mới
            Controls.Add(lblNgayDi);
            Controls.Add(lblTour);
            Controls.Add(lblThongTinKhach);
            Name = "ucPayment";
            Size = new Size(462, 400);
            ResumeLayout(false);
        }

        private Label lblThongTinKhach;
        private Label lblTour;
        private Label lblNgayDi;
        private Label lblNgayVe; // Thêm mới
        private Label lblTongTien;
        private Button btnXacNhanThanhToan;
        private Button btnHuy;
        private Label lblThongBaoThanhCong;
        private System.Windows.Forms.Timer timerRedirect;
    }
}