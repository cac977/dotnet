using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.cboLich = new System.Windows.Forms.ComboBox();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTour
            // 
            this.dgvTour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTour.Location = new System.Drawing.Point(132, 74);
            this.dgvTour.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.ReadOnly = true;
            this.dgvTour.RowHeadersVisible = false;
            this.dgvTour.RowHeadersWidth = 62;
            this.dgvTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTour.Size = new System.Drawing.Size(986, 451);
            this.dgvTour.TabIndex = 4;
            this.dgvTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick);
            // 
            // cboLich
            // 
            this.cboLich.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboLich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLich.FormattingEnabled = true;
            this.cboLich.Location = new System.Drawing.Point(287, 557);
            this.cboLich.Margin = new System.Windows.Forms.Padding(4);
            this.cboLich.Name = "cboLich";
            this.cboLich.Size = new System.Drawing.Size(650, 28);
            this.cboLich.TabIndex = 3;
            this.cboLich.SelectedIndexChanged += new System.EventHandler(this.cboLich_SelectedIndexChanged);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTiepTuc.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnTiepTuc.Location = new System.Drawing.Point(945, 552);
            this.btnTiepTuc.Margin = new System.Windows.Forms.Padding(4);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(173, 33);
            this.btnTiepTuc.TabIndex = 2;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.UseVisualStyleBackColor = false;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(494, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH TOUR DU LỊCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 560);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn lịch khởi hành:";
            // 
            // ucTourList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.cboLich);
            this.Controls.Add(this.dgvTour);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucTourList";
            this.Size = new System.Drawing.Size(1253, 655);
            this.Load += new System.EventHandler(this.ucTourList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DataGridView dgvTour;
        private ComboBox cboLich;
        private Button btnTiepTuc;
        private Label label1;
        private Label label2;
    }
}