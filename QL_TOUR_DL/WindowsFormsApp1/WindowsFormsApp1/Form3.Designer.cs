namespace WindowsFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTourFilter = new System.Windows.Forms.Label();
            this.dtgrReport = new System.Windows.Forms.DataGridView();
            this.tourLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tourGroupBox = new System.Windows.Forms.GroupBox();
            this.totalTourLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.revenueGroupBox = new System.Windows.Forms.GroupBox();
            this.totalRevenueLabel = new System.Windows.Forms.Label();
            this.reportFilterLabel = new System.Windows.Forms.Label();
            this.radToday = new System.Windows.Forms.RadioButton();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.radMonth = new System.Windows.Forms.RadioButton();
            this.radYear = new System.Windows.Forms.RadioButton();
            this.radWeek = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrReport)).BeginInit();
            this.tourGroupBox.SuspendLayout();
            this.revenueGroupBox.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTourFilter
            // 
            this.lblTourFilter.AutoSize = true;
            this.lblTourFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTourFilter.Location = new System.Drawing.Point(222, 21);
            this.lblTourFilter.Name = "lblTourFilter";
            this.lblTourFilter.Size = new System.Drawing.Size(520, 51);
            this.lblTourFilter.TabIndex = 1;
            this.lblTourFilter.Text = "THONG KE VA BAO CAO";
            this.lblTourFilter.Click += new System.EventHandler(this.lblTourFilter_Click);
            // 
            // dtgrReport
            // 
            this.dtgrReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrReport.Location = new System.Drawing.Point(55, 347);
            this.dtgrReport.Name = "dtgrReport";
            this.dtgrReport.Size = new System.Drawing.Size(890, 230);
            this.dtgrReport.TabIndex = 2;
            // 
            // tourLabel
            // 
            this.tourLabel.AutoSize = true;
            this.tourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tourLabel.Location = new System.Drawing.Point(79, 16);
            this.tourLabel.Name = "tourLabel";
            this.tourLabel.Size = new System.Drawing.Size(187, 31);
            this.tourLabel.TabIndex = 3;
            this.tourLabel.Text = "Tổng số tour:";
            this.tourLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng doanh thu (đ):";
            // 
            // tourGroupBox
            // 
            this.tourGroupBox.Controls.Add(this.totalTourLabel);
            this.tourGroupBox.Controls.Add(this.tourLabel);
            this.tourGroupBox.Location = new System.Drawing.Point(117, 191);
            this.tourGroupBox.Name = "tourGroupBox";
            this.tourGroupBox.Size = new System.Drawing.Size(366, 133);
            this.tourGroupBox.TabIndex = 5;
            this.tourGroupBox.TabStop = false;
            this.tourGroupBox.Text = "Tour";
            // 
            // totalTourLabel
            // 
            this.totalTourLabel.AutoSize = true;
            this.totalTourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTourLabel.Location = new System.Drawing.Point(162, 72);
            this.totalTourLabel.Name = "totalTourLabel";
            this.totalTourLabel.Size = new System.Drawing.Size(24, 25);
            this.totalTourLabel.TabIndex = 4;
            this.totalTourLabel.Text = "0";
            this.totalTourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // revenueGroupBox
            // 
            this.revenueGroupBox.Controls.Add(this.totalRevenueLabel);
            this.revenueGroupBox.Controls.Add(this.label2);
            this.revenueGroupBox.Location = new System.Drawing.Point(545, 191);
            this.revenueGroupBox.Name = "revenueGroupBox";
            this.revenueGroupBox.Size = new System.Drawing.Size(344, 133);
            this.revenueGroupBox.TabIndex = 7;
            this.revenueGroupBox.TabStop = false;
            this.revenueGroupBox.Text = "Doanh thu";
            // 
            // totalRevenueLabel
            // 
            this.totalRevenueLabel.AutoSize = true;
            this.totalRevenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRevenueLabel.Location = new System.Drawing.Point(167, 72);
            this.totalRevenueLabel.Name = "totalRevenueLabel";
            this.totalRevenueLabel.Size = new System.Drawing.Size(24, 25);
            this.totalRevenueLabel.TabIndex = 8;
            this.totalRevenueLabel.Text = "0";
            this.totalRevenueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportFilterLabel
            // 
            this.reportFilterLabel.AutoSize = true;
            this.reportFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportFilterLabel.Location = new System.Drawing.Point(56, 108);
            this.reportFilterLabel.Name = "reportFilterLabel";
            this.reportFilterLabel.Size = new System.Drawing.Size(246, 31);
            this.reportFilterLabel.TabIndex = 8;
            this.reportFilterLabel.Text = "Lọc báo cáo theo:";
            this.reportFilterLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // radToday
            // 
            this.radToday.AutoSize = true;
            this.radToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radToday.Location = new System.Drawing.Point(23, 31);
            this.radToday.Name = "radToday";
            this.radToday.Size = new System.Drawing.Size(97, 24);
            this.radToday.TabIndex = 9;
            this.radToday.TabStop = true;
            this.radToday.Text = "Hôm nay";
            this.radToday.UseVisualStyleBackColor = true;
            this.radToday.CheckedChanged += new System.EventHandler(this.radToday_CheckedChanged);
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.radMonth);
            this.filterGroupBox.Controls.Add(this.radYear);
            this.filterGroupBox.Controls.Add(this.radWeek);
            this.filterGroupBox.Controls.Add(this.radToday);
            this.filterGroupBox.Location = new System.Drawing.Point(308, 84);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(637, 82);
            this.filterGroupBox.TabIndex = 10;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Bộ lọc";
            // 
            // radMonth
            // 
            this.radMonth.AutoSize = true;
            this.radMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMonth.Location = new System.Drawing.Point(279, 32);
            this.radMonth.Name = "radMonth";
            this.radMonth.Size = new System.Drawing.Size(110, 24);
            this.radMonth.TabIndex = 13;
            this.radMonth.TabStop = true;
            this.radMonth.Text = "Tháng này";
            this.radMonth.UseVisualStyleBackColor = true;
            this.radMonth.CheckedChanged += new System.EventHandler(this.radMonth_CheckedChanged);
            // 
            // radYear
            // 
            this.radYear.AutoSize = true;
            this.radYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radYear.Location = new System.Drawing.Point(422, 32);
            this.radYear.Name = "radYear";
            this.radYear.Size = new System.Drawing.Size(96, 24);
            this.radYear.TabIndex = 12;
            this.radYear.TabStop = true;
            this.radYear.Text = "Năm nay";
            this.radYear.UseVisualStyleBackColor = true;
            this.radYear.CheckedChanged += new System.EventHandler(this.radYear_CheckedChanged);
            // 
            // radWeek
            // 
            this.radWeek.AutoSize = true;
            this.radWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWeek.Location = new System.Drawing.Point(147, 32);
            this.radWeek.Name = "radWeek";
            this.radWeek.Size = new System.Drawing.Size(100, 24);
            this.radWeek.TabIndex = 10;
            this.radWeek.TabStop = true;
            this.radWeek.Text = "Tuần này";
            this.radWeek.UseVisualStyleBackColor = true;
            this.radWeek.CheckedChanged += new System.EventHandler(this.radWeek_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 612);
            this.Controls.Add(this.filterGroupBox);
            this.Controls.Add(this.reportFilterLabel);
            this.Controls.Add(this.revenueGroupBox);
            this.Controls.Add(this.tourGroupBox);
            this.Controls.Add(this.dtgrReport);
            this.Controls.Add(this.lblTourFilter);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrReport)).EndInit();
            this.tourGroupBox.ResumeLayout(false);
            this.tourGroupBox.PerformLayout();
            this.revenueGroupBox.ResumeLayout(false);
            this.revenueGroupBox.PerformLayout();
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTourFilter;
        private System.Windows.Forms.DataGridView dtgrReport;
        private System.Windows.Forms.Label tourLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox tourGroupBox;
        private System.Windows.Forms.Label totalTourLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox revenueGroupBox;
        private System.Windows.Forms.Label totalRevenueLabel;
        private System.Windows.Forms.Label reportFilterLabel;
        private System.Windows.Forms.RadioButton radToday;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.RadioButton radYear;
        private System.Windows.Forms.RadioButton radWeek;
        private System.Windows.Forms.RadioButton radMonth;
    }
}