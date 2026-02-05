using System.Data;
using System.Data.SqlClient;

namespace ThanhToanApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Khai báo controls
        private TextBox txtSoHD, txtTenKH, txtCMND, txtSoTien;
        private ComboBox cboPhong;
        private DateTimePicker dtNgayTT;
        private Button btnThem, btnLuu, btnThoat;
        private Label lblSoHD, lblTenKH, lblCMND, lblSoTien, lblPhong, lblNgayTT;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSoHD = new Label();
            txtSoHD = new TextBox();
            lblTenKH = new Label();
            txtTenKH = new TextBox();
            lblCMND = new Label();
            txtCMND = new TextBox();
            lblSoTien = new Label();
            txtSoTien = new TextBox();
            lblPhong = new Label();
            cboPhong = new ComboBox();
            lblNgayTT = new Label();
            dtNgayTT = new DateTimePicker();
            btnThem = new Button();
            btnLuu = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblSoHD
            // 
            lblSoHD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSoHD.AutoSize = true;
            lblSoHD.Location = new Point(20, 25);
            lblSoHD.Name = "lblSoHD";
            lblSoHD.Size = new Size(64, 25);
            lblSoHD.TabIndex = 0;
            lblSoHD.Text = "Số HD";
            // 
            // txtSoHD
            // 
            txtSoHD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSoHD.Location = new Point(120, 20);
            txtSoHD.Name = "txtSoHD";
            txtSoHD.ReadOnly = true;
            txtSoHD.Size = new Size(130, 31);
            txtSoHD.TabIndex = 1;
            txtSoHD.TabStop = false;
            // 
            // lblTenKH
            // 
            lblTenKH.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTenKH.AutoSize = true;
            lblTenKH.Location = new Point(20, 65);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(66, 25);
            lblTenKH.TabIndex = 2;
            lblTenKH.Text = "Họ tên";
            // 
            // txtTenKH
            // 
            txtTenKH.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTenKH.Location = new Point(120, 60);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(400, 31);
            txtTenKH.TabIndex = 3;
            txtTenKH.TextChanged += KiemTraDuLieu;
            txtTenKH.KeyPress += txtTenKH_KeyPress;
            // 
            // lblCMND
            // 
            lblCMND.AutoSize = true;
            lblCMND.Location = new Point(20, 105);
            lblCMND.Name = "lblCMND";
            lblCMND.Size = new Size(91, 25);
            lblCMND.TabIndex = 4;
            lblCMND.Text = "Số CMND";
            // 
            // txtCMND
            // 
            txtCMND.Location = new Point(120, 100);
            txtCMND.MaxLength = 12;
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(130, 31);
            txtCMND.TabIndex = 5;
            txtCMND.TextChanged += KiemTraDuLieu;
            txtCMND.KeyPress += txtCMND_KeyPress;
            // 
            // lblSoTien
            // 
            lblSoTien.AutoSize = true;
            lblSoTien.Location = new Point(20, 145);
            lblSoTien.Name = "lblSoTien";
            lblSoTien.Size = new Size(90, 25);
            lblSoTien.TabIndex = 8;
            lblSoTien.Text = "Số tiền TT";
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(120, 140);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(130, 31);
            txtSoTien.TabIndex = 9;
            txtSoTien.TextChanged += KiemTraDuLieu;
            txtSoTien.KeyPress += txtSoTien_KeyPress;
            // 
            // lblPhong
            // 
            lblPhong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPhong.AutoSize = true;
            lblPhong.Location = new Point(270, 105);
            lblPhong.Name = "lblPhong";
            lblPhong.Size = new Size(91, 25);
            lblPhong.TabIndex = 6;
            lblPhong.Text = "Số phòng";
            // 
            // cboPhong
            // 
            cboPhong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboPhong.DrawMode = DrawMode.OwnerDrawFixed;
            cboPhong.Location = new Point(370, 105);
            cboPhong.Name = "cboPhong";
            cboPhong.Size = new Size(150, 32);
            cboPhong.TabIndex = 7;
            cboPhong.DrawItem += cboPhong_DrawItem;
            cboPhong.SelectedIndexChanged += KiemTraDuLieu;
            // 
            // lblNgayTT
            // 
            lblNgayTT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNgayTT.AutoSize = true;
            lblNgayTT.Location = new Point(270, 145);
            lblNgayTT.Name = "lblNgayTT";
            lblNgayTT.Size = new Size(77, 25);
            lblNgayTT.TabIndex = 10;
            lblNgayTT.Text = "Ngày TT";
            // 
            // dtNgayTT
            // 
            dtNgayTT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtNgayTT.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtNgayTT.Format = DateTimePickerFormat.Custom;
            dtNgayTT.Location = new Point(370, 145);
            dtNgayTT.Name = "dtNgayTT";
            dtNgayTT.Size = new Size(150, 31);
            dtNgayTT.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom;
            btnThem.Location = new Point(150, 200);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 32);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Bottom;
            btnLuu.Enabled = false;
            btnLuu.Location = new Point(250, 200);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(80, 32);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Bottom;
            btnThoat.Location = new Point(350, 200);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(80, 32);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(558, 272);
            Controls.Add(lblSoHD);
            Controls.Add(txtSoHD);
            Controls.Add(lblTenKH);
            Controls.Add(txtTenKH);
            Controls.Add(lblCMND);
            Controls.Add(txtCMND);
            Controls.Add(lblPhong);
            Controls.Add(cboPhong);
            Controls.Add(lblSoTien);
            Controls.Add(txtSoTien);
            Controls.Add(lblNgayTT);
            Controls.Add(dtNgayTT);
            Controls.Add(btnThem);
            Controls.Add(btnLuu);
            Controls.Add(btnThoat);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thanh toán";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}