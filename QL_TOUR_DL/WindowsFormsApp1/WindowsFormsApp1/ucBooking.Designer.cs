using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class ucBooking
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

        private void InitializeComponent()
        {
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblThongBaoCho = new System.Windows.Forms.Label();
            this.lblTourInfo = new System.Windows.Forms.Label();
            this.lblNgayDiInfo = new System.Windows.Forms.Label();
            this.lblNgayVeInfo = new System.Windows.Forms.Label();
            this.grpKhachHang = new System.Windows.Forms.GroupBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.grpKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(180, 74);
            this.txtSearchID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(623, 31);
            this.txtSearchID.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(182, 168);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(798, 31);
            this.txtHoTen.TabIndex = 4;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(182, 265);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(785, 31);
            this.txtSDT.TabIndex = 6;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.numSoLuong.Location = new System.Drawing.Point(184, 350);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(170, 34);
            this.numSoLuong.TabIndex = 9;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightBlue;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(820, 74);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(160, 31);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Kiểm tra/Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // Đăng ký sự kiện Click cho các nút
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.ForestGreen;
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(688, 618);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(154, 53);
            this.btnXacNhan.TabIndex = 10;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Location = new System.Drawing.Point(322, 618);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(154, 53);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // lblThongBaoCho
            // 
            this.lblThongBaoCho.AutoSize = true;
            this.lblThongBaoCho.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblThongBaoCho.ForeColor = System.Drawing.Color.DarkRed;
            this.lblThongBaoCho.Location = new System.Drawing.Point(909, 53);
            this.lblThongBaoCho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongBaoCho.Name = "lblThongBaoCho";
            this.lblThongBaoCho.Size = new System.Drawing.Size(167, 28);
            this.lblThongBaoCho.TabIndex = 0;
            this.lblThongBaoCho.Text = "Số chỗ còn lại: 0";
            // 
            // lblTourInfo
            // 
            this.lblTourInfo.AutoSize = true;
            this.lblTourInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTourInfo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTourInfo.Location = new System.Drawing.Point(58, 49);
            this.lblTourInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTourInfo.Name = "lblTourInfo";
            this.lblTourInfo.Size = new System.Drawing.Size(102, 32);
            this.lblTourInfo.TabIndex = 12;
            this.lblTourInfo.Text = "Tour: ...";
            // 
            // lblNgayDiInfo
            // 
            this.lblNgayDiInfo.AutoSize = true;
            this.lblNgayDiInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNgayDiInfo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNgayDiInfo.Location = new System.Drawing.Point(443, 53);
            this.lblNgayDiInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayDiInfo.Name = "lblNgayDiInfo";
            this.lblNgayDiInfo.Size = new System.Drawing.Size(113, 28);
            this.lblNgayDiInfo.TabIndex = 13;
            this.lblNgayDiInfo.Text = "Ngày đi: ...";
            // 
            // lblNgayVeInfo
            // 
            this.lblNgayVeInfo.AutoSize = true;
            this.lblNgayVeInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNgayVeInfo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNgayVeInfo.Location = new System.Drawing.Point(683, 53);
            this.lblNgayVeInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayVeInfo.Name = "lblNgayVeInfo";
            this.lblNgayVeInfo.Size = new System.Drawing.Size(116, 28);
            this.lblNgayVeInfo.TabIndex = 14;
            this.lblNgayVeInfo.Text = "Ngày về: ...";
            // 
            // grpKhachHang
            // 
            this.grpKhachHang.Controls.Add(this.lblCCCD);
            this.grpKhachHang.Controls.Add(this.txtSearchID);
            this.grpKhachHang.Controls.Add(this.btnThem);
            this.grpKhachHang.Controls.Add(this.lblName);
            this.grpKhachHang.Controls.Add(this.txtHoTen);
            this.grpKhachHang.Controls.Add(this.lblPhone);
            this.grpKhachHang.Controls.Add(this.txtSDT);
            this.grpKhachHang.Controls.Add(this.lblQty);
            this.grpKhachHang.Controls.Add(this.numSoLuong);
            this.grpKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpKhachHang.Location = new System.Drawing.Point(64, 120);
            this.grpKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpKhachHang.Name = "grpKhachHang";
            this.grpKhachHang.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpKhachHang.Size = new System.Drawing.Size(1012, 441);
            this.grpKhachHang.TabIndex = 1;
            this.grpKhachHang.TabStop = false;
            this.grpKhachHang.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(32, 80);
            this.lblCCCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(143, 25);
            this.lblCCCD.TabIndex = 0;
            this.lblCCCD.Text = "CCCD/Passport:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 168);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(131, 25);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Họ tên khách:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(36, 265);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(129, 25);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Số điện thoại:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(36, 355);
            this.lblQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(126, 25);
            this.lblQty.TabIndex = 7;
            this.lblQty.Text = "Số lượng đặt:";
            // 
            // ucBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.lblNgayVeInfo);
            this.Controls.Add(this.lblNgayDiInfo);
            this.Controls.Add(this.lblTourInfo);
            this.Controls.Add(this.lblThongBaoCho);
            this.Controls.Add(this.grpKhachHang);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnHuy);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucBooking";
            this.Padding = new System.Windows.Forms.Padding(26, 27, 26, 27);
            this.Size = new System.Drawing.Size(1149, 719);
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.grpKhachHang.ResumeLayout(false);
            this.grpKhachHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox txtSearchID;
        private TextBox txtHoTen;
        private TextBox txtSDT;
        private NumericUpDown numSoLuong;
        private Button btnThem;
        private Button btnXacNhan;
        private Button btnHuy;
        private Label lblThongBaoCho;
        private Label lblTourInfo;
        private Label lblNgayDiInfo;
        private Label lblNgayVeInfo;
        private GroupBox grpKhachHang;
        private Label lblCCCD;
        private Label lblName;
        private Label lblPhone;
        private Label lblQty;
    }
}