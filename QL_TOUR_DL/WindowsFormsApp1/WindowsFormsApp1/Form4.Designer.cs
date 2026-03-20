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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
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
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoCho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdDiemDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdDiemDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdLich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoCho)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTour
            // 
            this.dgvTour.AllowUserToOrderColumns = true;
            this.dgvTour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTenTour,
            this.colDiemDi,
            this.colDiemDen,
            this.colSoNgay,
            this.colGia,
            this.colNgayDi,
            this.colNgayVe,
            this.colSoCho,
            this.colMoTa,
            this.colIdDiemDi,
            this.colIdDiemDen,
            this.colIdLich});
            this.dgvTour.Location = new System.Drawing.Point(18, 400);
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.RowHeadersVisible = false;
            this.dgvTour.RowHeadersWidth = 62;
            this.dgvTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTour.Size = new System.Drawing.Size(1350, 420);
            this.dgvTour.TabIndex = 0;
            this.dgvTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Tour:";
            // 
            // txtTenTour
            // 
            this.txtTenTour.Location = new System.Drawing.Point(120, 90);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(300, 26);
            this.txtTenTour.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Điểm đi:";
            // 
            // cboDiemDi
            // 
            this.cboDiemDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiemDi.Location = new System.Drawing.Point(530, 90);
            this.cboDiemDi.Name = "cboDiemDi";
            this.cboDiemDi.Size = new System.Drawing.Size(180, 28);
            this.cboDiemDi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(750, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Điểm đến:";
            // 
            // cboDiemDen
            // 
            this.cboDiemDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiemDen.Location = new System.Drawing.Point(850, 90);
            this.cboDiemDen.Name = "cboDiemDen";
            this.cboDiemDen.Size = new System.Drawing.Size(180, 28);
            this.cboDiemDen.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số ngày:";
            // 
            // numSoNgay
            // 
            this.numSoNgay.Location = new System.Drawing.Point(120, 140);
            this.numSoNgay.Name = "numSoNgay";
            this.numSoNgay.Size = new System.Drawing.Size(100, 26);
            this.numSoNgay.TabIndex = 8;
            this.numSoNgay.ValueChanged += new System.EventHandler(this.CalculateNgayVe);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giá:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(310, 140);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(150, 26);
            this.txtGia.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mô tả:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(120, 240);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(1100, 60);
            this.txtMoTa.TabIndex = 18;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(30, 343);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 20);
            this.lblSearch.TabIndex = 19;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(120, 340);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 26);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(330, 330);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 45);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Tìm Tour";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(450, 330);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 45);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(590, 330);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 45);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(730, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 45);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Xóa Tour";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(870, 330);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 45);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Làm mới";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(450, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(462, 37);
            this.label7.TabIndex = 0;
            this.label7.Text = "QUẢN LÝ DANH MỤC TOUR";
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Location = new System.Drawing.Point(30, 193);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(65, 20);
            this.lblNgayDi.TabIndex = 13;
            this.lblNgayDi.Text = "Ngày đi:";
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDi.Location = new System.Drawing.Point(120, 190);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(150, 26);
            this.dtpNgayDi.TabIndex = 14;
            this.dtpNgayDi.ValueChanged += new System.EventHandler(this.CalculateNgayVe);
            // 
            // lblNgayVe
            // 
            this.lblNgayVe.AutoSize = true;
            this.lblNgayVe.Location = new System.Drawing.Point(310, 193);
            this.lblNgayVe.Name = "lblNgayVe";
            this.lblNgayVe.Size = new System.Drawing.Size(69, 20);
            this.lblNgayVe.TabIndex = 15;
            this.lblNgayVe.Text = "Ngày về:";
            // 
            // dtpNgayVe
            // 
            this.dtpNgayVe.Enabled = false;
            this.dtpNgayVe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayVe.Location = new System.Drawing.Point(400, 190);
            this.dtpNgayVe.Name = "dtpNgayVe";
            this.dtpNgayVe.Size = new System.Drawing.Size(150, 26);
            this.dtpNgayVe.TabIndex = 16;
            // 
            // lblSoCho
            // 
            this.lblSoCho.AutoSize = true;
            this.lblSoCho.Location = new System.Drawing.Point(500, 143);
            this.lblSoCho.Name = "lblSoCho";
            this.lblSoCho.Size = new System.Drawing.Size(63, 20);
            this.lblSoCho.TabIndex = 11;
            this.lblSoCho.Text = "Số chỗ:";
            // 
            // numSoCho
            // 
            this.numSoCho.Location = new System.Drawing.Point(580, 140);
            this.numSoCho.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numSoCho.Name = "numSoCho";
            this.numSoCho.Size = new System.Drawing.Size(100, 26);
            this.numSoCho.TabIndex = 12;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "";
            this.colID.MinimumWidth = 8;
            this.colID.Name = "colID";
            this.colID.Visible = false;
            // 
            // colTenTour
            // 
            this.colTenTour.DataPropertyName = "TEN_TOUR";
            this.colTenTour.HeaderText = "Tên tour";
            this.colTenTour.MinimumWidth = 8;
            this.colTenTour.Name = "colTenTour";
            // 
            // colDiemDi
            // 
            this.colDiemDi.DataPropertyName = "DIEM_DI";
            this.colDiemDi.HeaderText = "Điểm đi";
            this.colDiemDi.MinimumWidth = 8;
            this.colDiemDi.Name = "colDiemDi";
            // 
            // colDiemDen
            // 
            this.colDiemDen.DataPropertyName = "DIEM_DEN";
            this.colDiemDen.HeaderText = "Điểm đến";
            this.colDiemDen.MinimumWidth = 8;
            this.colDiemDen.Name = "colDiemDen";
            // 
            // colSoNgay
            // 
            this.colSoNgay.DataPropertyName = "SO_NGAY";
            this.colSoNgay.HeaderText = "Số ngày";
            this.colSoNgay.MinimumWidth = 8;
            this.colSoNgay.Name = "colSoNgay";
            // 
            // colGia
            // 
            this.colGia.DataPropertyName = "GIA";
            this.colGia.HeaderText = "Giá";
            this.colGia.MinimumWidth = 8;
            this.colGia.Name = "colGia";
            // 
            // colNgayDi
            // 
            this.colNgayDi.DataPropertyName = "NGAY_DI";
            this.colNgayDi.HeaderText = "Ngày đi";
            this.colNgayDi.MinimumWidth = 8;
            this.colNgayDi.Name = "colNgayDi";
            // 
            // colNgayVe
            // 
            this.colNgayVe.DataPropertyName = "NGAY_VE";
            this.colNgayVe.HeaderText = "Ngày về";
            this.colNgayVe.MinimumWidth = 8;
            this.colNgayVe.Name = "colNgayVe";
            // 
            // colSoCho
            // 
            this.colSoCho.DataPropertyName = "SO_CHO";
            this.colSoCho.HeaderText = "Số chỗ";
            this.colSoCho.MinimumWidth = 8;
            this.colSoCho.Name = "colSoCho";
            // 
            // colMoTa
            // 
            this.colMoTa.DataPropertyName = "MOTA";
            this.colMoTa.HeaderText = "Mô tả";
            this.colMoTa.MinimumWidth = 8;
            this.colMoTa.Name = "colMoTa";
            // 
            // colIdDiemDi
            // 
            this.colIdDiemDi.DataPropertyName = "ID_DIEMDI";
            this.colIdDiemDi.HeaderText = "";
            this.colIdDiemDi.MinimumWidth = 8;
            this.colIdDiemDi.Name = "colIdDiemDi";
            this.colIdDiemDi.Visible = false;
            // 
            // colIdDiemDen
            // 
            this.colIdDiemDen.DataPropertyName = "ID_DIEMDEN";
            this.colIdDiemDen.HeaderText = "";
            this.colIdDiemDen.MinimumWidth = 8;
            this.colIdDiemDen.Name = "colIdDiemDen";
            this.colIdDiemDen.Visible = false;
            // 
            // colIdLich
            // 
            this.colIdLich.DataPropertyName = "ID_LICH";
            this.colIdLich.HeaderText = "";
            this.colIdLich.MinimumWidth = 8;
            this.colIdLich.Name = "colIdLich";
            this.colIdLich.Visible = false;
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
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
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

        // Công cụ tìm kiếm mới thêm vào
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoCho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdDiemDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdDiemDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdLich;
    }
}