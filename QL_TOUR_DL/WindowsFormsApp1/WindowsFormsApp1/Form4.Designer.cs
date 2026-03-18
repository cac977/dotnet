namespace WindowsFormsApp1
{
    partial class Form4
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
            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDiemDi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDiemDen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numSoNgay = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.lblNgayVe = new System.Windows.Forms.Label();
            this.dtpNgayVe = new System.Windows.Forms.DateTimePicker();
            this.lblSoCho = new System.Windows.Forms.Label();
            this.numSoCho = new System.Windows.Forms.NumericUpDown();

            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoCho)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvTour
            // 
            this.dgvTour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTour.Location = new System.Drawing.Point(18, 400);
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.ReadOnly = true;
            this.dgvTour.RowHeadersVisible = false;
            this.dgvTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTour.Size = new System.Drawing.Size(1350, 420);
            this.dgvTour.TabIndex = 0;
            this.dgvTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick);

            // 
            // labelTitle
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(450, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(438, 37);
            this.label7.TabIndex = 0;
            this.label7.Text = "QUẢN LÝ DANH MỤC TOUR";

            // --- ROW 1 ---
            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.Text = "Tên Tour:";

            // txtTenTour
            this.txtTenTour.Location = new System.Drawing.Point(120, 90);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(300, 26);

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.Text = "Điểm đi:";

            // cboDiemDi
            this.cboDiemDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiemDi.Location = new System.Drawing.Point(530, 90);
            this.cboDiemDi.Name = "cboDiemDi";
            this.cboDiemDi.Size = new System.Drawing.Size(180, 28);

            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(750, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.Text = "Điểm đến:";

            // cboDiemDen
            this.cboDiemDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiemDen.Location = new System.Drawing.Point(850, 90);
            this.cboDiemDen.Name = "cboDiemDen";
            this.cboDiemDen.Size = new System.Drawing.Size(180, 28);

            // --- ROW 2 ---
            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.Text = "Số ngày:";

            // numSoNgay
            this.numSoNgay.Location = new System.Drawing.Point(120, 140);
            this.numSoNgay.Name = "numSoNgay";
            this.numSoNgay.Size = new System.Drawing.Size(100, 26);
            this.numSoNgay.ValueChanged += new System.EventHandler(this.CalculateNgayVe); // <--- Sự kiện tính toán

            // label5
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.Text = "Giá:";

            // txtGia
            this.txtGia.Location = new System.Drawing.Point(310, 140);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(150, 26);

            // lblSoCho
            this.lblSoCho.AutoSize = true;
            this.lblSoCho.Location = new System.Drawing.Point(500, 143);
            this.lblSoCho.Name = "lblSoCho";
            this.lblSoCho.Size = new System.Drawing.Size(64, 20);
            this.lblSoCho.Text = "Số chỗ:";

            // numSoCho
            this.numSoCho.Location = new System.Drawing.Point(580, 140);
            this.numSoCho.Name = "numSoCho";
            this.numSoCho.Size = new System.Drawing.Size(100, 26);
            this.numSoCho.Maximum = 500;

            // --- ROW 3 ---
            // lblNgayDi
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Location = new System.Drawing.Point(30, 193);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(65, 20);
            this.lblNgayDi.Text = "Ngày đi:";

            // dtpNgayDi
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDi.Location = new System.Drawing.Point(120, 190);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(150, 26);
            this.dtpNgayDi.ValueChanged += new System.EventHandler(this.CalculateNgayVe); // <--- Sự kiện tính toán

            // lblNgayVe
            this.lblNgayVe.AutoSize = true;
            this.lblNgayVe.Location = new System.Drawing.Point(310, 193);
            this.lblNgayVe.Name = "lblNgayVe";
            this.lblNgayVe.Size = new System.Drawing.Size(69, 20);
            this.lblNgayVe.Text = "Ngày về:";

            // dtpNgayVe
            this.dtpNgayVe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayVe.Location = new System.Drawing.Point(400, 190);
            this.dtpNgayVe.Name = "dtpNgayVe";
            this.dtpNgayVe.Size = new System.Drawing.Size(150, 26);
            this.dtpNgayVe.Enabled = false; // <--- KHÓA KHÔNG CHO NHẬP TAY

            // --- ROW 4 ---
            // label6
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.Text = "Mô tả:";

            // txtMoTa
            this.txtMoTa.Location = new System.Drawing.Point(120, 240);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(1100, 60);

            // --- BUTTONS ---
            this.btnAdd.Location = new System.Drawing.Point(370, 330);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 45);
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Location = new System.Drawing.Point(520, 330);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 45);
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Location = new System.Drawing.Point(670, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 45);
            this.btnDelete.Text = "Xóa Tour";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnReset.Location = new System.Drawing.Point(820, 330);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 45);
            this.btnReset.Text = "Làm mới";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 850);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenTour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboDiemDi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboDiemDen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numSoNgay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.lblSoCho);
            this.Controls.Add(this.numSoCho);
            this.Controls.Add(this.lblNgayDi);
            this.Controls.Add(this.dtpNgayDi);
            this.Controls.Add(this.lblNgayVe);
            this.Controls.Add(this.dtpNgayVe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvTour);

            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tour";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoCho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDiemDi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDiemDen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSoNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblSoCho;
        private System.Windows.Forms.NumericUpDown numSoCho;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label lblNgayVe;
        private System.Windows.Forms.DateTimePicker dtpNgayVe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label7;
    }
}