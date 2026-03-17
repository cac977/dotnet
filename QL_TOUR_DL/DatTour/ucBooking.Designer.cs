namespace DatTour
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
            txtSearchID = new TextBox();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            numSoLuong = new NumericUpDown();
            btnThem = new Button();
            btnXacNhan = new Button();
            btnHuy = new Button();
            lblThongBaoCho = new Label();
            lblTourInfo = new Label();
            lblNgayDiInfo = new Label();
            lblNgayVeInfo = new Label();
            grpKhachHang = new GroupBox();
            lblCCCD = new Label();
            lblName = new Label();
            lblPhone = new Label();
            lblQty = new Label();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            grpKhachHang.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearchID
            // 
            txtSearchID.Location = new Point(140, 40);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(200, 23);
            txtSearchID.TabIndex = 1;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(140, 80);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(320, 23);
            txtHoTen.TabIndex = 4;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(140, 120);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(320, 23);
            txtSDT.TabIndex = 6;
            // 
            // numSoLuong
            // 
            numSoLuong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            numSoLuong.Location = new Point(140, 160);
            numSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(80, 25);
            numSoLuong.TabIndex = 9;
            numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightBlue;
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Location = new Point(350, 40);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 23);
            btnThem.TabIndex = 2;
            btnThem.Text = "Kiểm tra/Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.ForestGreen;
            btnXacNhan.Cursor = Cursors.Hand;
            btnXacNhan.FlatStyle = FlatStyle.Flat;
            btnXacNhan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXacNhan.ForeColor = Color.White;
            btnXacNhan.Location = new Point(310, 320);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(120, 40);
            btnXacNhan.TabIndex = 10;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.White;
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHuy.Location = new Point(160, 320);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(120, 40);
            btnHuy.TabIndex = 11;
            btnHuy.Text = "Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // lblThongBaoCho
            // 
            lblThongBaoCho.AutoSize = true;
            lblThongBaoCho.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblThongBaoCho.ForeColor = Color.DarkRed;
            lblThongBaoCho.Location = new Point(400, 50);
            lblThongBaoCho.Name = "lblThongBaoCho";
            lblThongBaoCho.Size = new Size(118, 19);
            lblThongBaoCho.TabIndex = 0;
            lblThongBaoCho.Text = "Số chỗ còn lại: 0";
            // 
            // lblTourInfo
            // 
            lblTourInfo.AutoSize = true;
            lblTourInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTourInfo.ForeColor = Color.DarkBlue;
            lblTourInfo.Location = new Point(50, 20);
            lblTourInfo.Name = "lblTourInfo";
            lblTourInfo.Size = new Size(65, 21);
            lblTourInfo.TabIndex = 12;
            lblTourInfo.Text = "Tour: ...";
            // 
            // lblNgayDiInfo
            // 
            lblNgayDiInfo.AutoSize = true;
            lblNgayDiInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNgayDiInfo.ForeColor = Color.DarkGreen;
            lblNgayDiInfo.Location = new Point(50, 50);
            lblNgayDiInfo.Name = "lblNgayDiInfo";
            lblNgayDiInfo.Size = new Size(82, 19);
            lblNgayDiInfo.TabIndex = 13;
            lblNgayDiInfo.Text = "Ngày đi: ...";
            // 
            // lblNgayVeInfo
            // 
            lblNgayVeInfo.AutoSize = true;
            lblNgayVeInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNgayVeInfo.ForeColor = Color.DarkGreen;
            lblNgayVeInfo.Location = new Point(220, 50);
            lblNgayVeInfo.Name = "lblNgayVeInfo";
            lblNgayVeInfo.Size = new Size(85, 19);
            lblNgayVeInfo.TabIndex = 14;
            lblNgayVeInfo.Text = "Ngày về: ...";
            // 
            // grpKhachHang
            // 
            grpKhachHang.Controls.Add(lblCCCD);
            grpKhachHang.Controls.Add(txtSearchID);
            grpKhachHang.Controls.Add(btnThem);
            grpKhachHang.Controls.Add(lblName);
            grpKhachHang.Controls.Add(txtHoTen);
            grpKhachHang.Controls.Add(lblPhone);
            grpKhachHang.Controls.Add(txtSDT);
            grpKhachHang.Controls.Add(lblQty);
            grpKhachHang.Controls.Add(numSoLuong);
            grpKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpKhachHang.Location = new Point(50, 90);
            grpKhachHang.Name = "grpKhachHang";
            grpKhachHang.Size = new Size(490, 210);
            grpKhachHang.TabIndex = 1;
            grpKhachHang.TabStop = false;
            grpKhachHang.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(25, 43);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(92, 15);
            lblCCCD.TabIndex = 0;
            lblCCCD.Text = "CCCD/Passport:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(25, 83);
            lblName.Name = "lblName";
            lblName.Size = new Size(84, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Họ tên khách:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(25, 123);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(83, 15);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Số điện thoại:";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(25, 163);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(82, 15);
            lblQty.TabIndex = 7;
            lblQty.Text = "Số lượng đặt:";
            // 
            // ucBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            Controls.Add(lblNgayVeInfo);
            Controls.Add(lblNgayDiInfo);
            Controls.Add(lblTourInfo);
            Controls.Add(lblThongBaoCho);
            Controls.Add(grpKhachHang);
            Controls.Add(btnXacNhan);
            Controls.Add(btnHuy);
            Name = "ucBooking";
            Padding = new Padding(20);
            Size = new Size(596, 399);
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            grpKhachHang.ResumeLayout(false);
            grpKhachHang.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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