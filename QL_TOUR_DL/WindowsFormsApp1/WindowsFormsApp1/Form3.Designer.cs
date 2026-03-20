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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrReport)).BeginInit();
            this.tourGroupBox.SuspendLayout();
            this.revenueGroupBox.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTourFilter
            // 
            this.lblTourFilter.AutoSize = true;
            this.lblTourFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTourFilter.Location = new System.Drawing.Point(372, 20);
            this.lblTourFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTourFilter.Name = "lblTourFilter";
            this.lblTourFilter.Size = new System.Drawing.Size(778, 73);
            this.lblTourFilter.TabIndex = 1;
            this.lblTourFilter.Text = "THỐNG KÊ VÀ BÁO CÁO";
            this.lblTourFilter.Click += new System.EventHandler(this.lblTourFilter_Click);
            // 
            // dtgrReport
            // 
            this.dtgrReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrReport.Location = new System.Drawing.Point(82, 534);
            this.dtgrReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgrReport.Name = "dtgrReport";
            this.dtgrReport.ReadOnly = true;
            this.dtgrReport.RowHeadersWidth = 62;
            this.dtgrReport.Size = new System.Drawing.Size(1335, 354);
            this.dtgrReport.TabIndex = 2;
            // 
            // tourLabel
            // 
            this.tourLabel.AutoSize = true;
            this.tourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tourLabel.Location = new System.Drawing.Point(118, 25);
            this.tourLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tourLabel.Name = "tourLabel";
            this.tourLabel.Size = new System.Drawing.Size(275, 47);
            this.tourLabel.TabIndex = 3;
            this.tourLabel.Text = "Tổng số tour:";
            this.tourLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng doanh thu (đ):";
            // 
            // tourGroupBox
            // 
            this.tourGroupBox.Controls.Add(this.totalTourLabel);
            this.tourGroupBox.Controls.Add(this.tourLabel);
            this.tourGroupBox.Location = new System.Drawing.Point(176, 294);
            this.tourGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tourGroupBox.Name = "tourGroupBox";
            this.tourGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tourGroupBox.Size = new System.Drawing.Size(549, 205);
            this.tourGroupBox.TabIndex = 5;
            this.tourGroupBox.TabStop = false;
            this.tourGroupBox.Text = "Tour";
            // 
            // totalTourLabel
            // 
            this.totalTourLabel.AutoSize = true;
            this.totalTourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTourLabel.Location = new System.Drawing.Point(243, 111);
            this.totalTourLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalTourLabel.Name = "totalTourLabel";
            this.totalTourLabel.Size = new System.Drawing.Size(35, 37);
            this.totalTourLabel.TabIndex = 4;
            this.totalTourLabel.Text = "0";
            this.totalTourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // revenueGroupBox
            // 
            this.revenueGroupBox.Controls.Add(this.totalRevenueLabel);
            this.revenueGroupBox.Controls.Add(this.label2);
            this.revenueGroupBox.Location = new System.Drawing.Point(818, 294);
            this.revenueGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.revenueGroupBox.Name = "revenueGroupBox";
            this.revenueGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.revenueGroupBox.Size = new System.Drawing.Size(516, 205);
            this.revenueGroupBox.TabIndex = 7;
            this.revenueGroupBox.TabStop = false;
            this.revenueGroupBox.Text = "Doanh thu";
            // 
            // totalRevenueLabel
            // 
            this.totalRevenueLabel.AutoSize = true;
            this.totalRevenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRevenueLabel.Location = new System.Drawing.Point(250, 111);
            this.totalRevenueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalRevenueLabel.Name = "totalRevenueLabel";
            this.totalRevenueLabel.Size = new System.Drawing.Size(35, 37);
            this.totalRevenueLabel.TabIndex = 8;
            this.totalRevenueLabel.Text = "0";
            this.totalRevenueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportFilterLabel
            // 
            this.reportFilterLabel.AutoSize = true;
            this.reportFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportFilterLabel.Location = new System.Drawing.Point(84, 166);
            this.reportFilterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reportFilterLabel.Name = "reportFilterLabel";
            this.reportFilterLabel.Size = new System.Drawing.Size(364, 47);
            this.reportFilterLabel.TabIndex = 8;
            this.reportFilterLabel.Text = "Lọc báo cáo theo:";
            this.reportFilterLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // radToday
            // 
            this.radToday.AutoSize = true;
            this.radToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radToday.Location = new System.Drawing.Point(34, 48);
            this.radToday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radToday.Name = "radToday";
            this.radToday.Size = new System.Drawing.Size(139, 33);
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
            this.filterGroupBox.Location = new System.Drawing.Point(462, 129);
            this.filterGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filterGroupBox.Size = new System.Drawing.Size(956, 126);
            this.filterGroupBox.TabIndex = 10;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Bộ lọc";
            // 
            // radMonth
            // 
            this.radMonth.AutoSize = true;
            this.radMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMonth.Location = new System.Drawing.Point(418, 49);
            this.radMonth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radMonth.Name = "radMonth";
            this.radMonth.Size = new System.Drawing.Size(159, 33);
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
            this.radYear.Location = new System.Drawing.Point(633, 49);
            this.radYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radYear.Name = "radYear";
            this.radYear.Size = new System.Drawing.Size(139, 33);
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
            this.radWeek.Location = new System.Drawing.Point(220, 49);
            this.radWeek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radWeek.Name = "radWeek";
            this.radWeek.Size = new System.Drawing.Size(144, 33);
            this.radWeek.TabIndex = 10;
            this.radWeek.TabStop = true;
            this.radWeek.Text = "Tuần này";
            this.radWeek.UseVisualStyleBackColor = true;
            this.radWeek.CheckedChanged += new System.EventHandler(this.radWeek_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTourFilter);
            this.panel1.Location = new System.Drawing.Point(-14, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1534, 108);
            this.panel1.TabIndex = 11;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 942);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.filterGroupBox);
            this.Controls.Add(this.reportFilterLabel);
            this.Controls.Add(this.revenueGroupBox);
            this.Controls.Add(this.tourGroupBox);
            this.Controls.Add(this.dtgrReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
    }
}