namespace DatTour
{
    partial class ucTourList
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvTour = new DataGridView();
            cboLich = new ComboBox();
            btnTiepTuc = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTour).BeginInit();
            SuspendLayout();
            // 
            // dgvTour
            // 
            dgvTour.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTour.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTour.Location = new Point(20, 50);
            dgvTour.Name = "dgvTour";
            dgvTour.ReadOnly = true;
            dgvTour.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTour.Size = new Size(560, 200);
            dgvTour.TabIndex = 4;
            dgvTour.CellClick += dgvTour_CellClick;
            // 
            // cboLich
            // 
            cboLich.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLich.FormattingEnabled = true;
            cboLich.Location = new Point(150, 270);
            cboLich.Name = "cboLich";
            cboLich.Size = new Size(300, 23);
            cboLich.TabIndex = 3;
            // 
            // btnTiepTuc
            // 
            btnTiepTuc.BackColor = SystemColors.InactiveBorder;
            btnTiepTuc.Location = new Point(460, 268);
            btnTiepTuc.Name = "btnTiepTuc";
            btnTiepTuc.Size = new Size(120, 25);
            btnTiepTuc.TabIndex = 2;
            btnTiepTuc.Text = "Tiếp tục";
            btnTiepTuc.UseVisualStyleBackColor = false;
            btnTiepTuc.Click += btnTiepTuc_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(193, 12);
            label1.Name = "label1";
            label1.Size = new Size(217, 21);
            label1.TabIndex = 1;
            label1.Text = "DANH SÁCH TOUR DU LỊCH";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 273);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 0;
            label2.Text = "Chọn lịch khởi hành:";
            // 
            // ucTourList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTiepTuc);
            Controls.Add(cboLich);
            Controls.Add(dgvTour);
            Name = "ucTourList";
            Size = new Size(600, 350);
            ((System.ComponentModel.ISupportInitialize)dgvTour).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dgvTour;
        private ComboBox cboLich;
        private Button btnTiepTuc;
        private Label label1;
        private Label label2;
    }
}