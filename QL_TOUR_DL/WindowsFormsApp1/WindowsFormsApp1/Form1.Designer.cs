namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lblQLTourDuLich = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTourFilter = new System.Windows.Forms.Button();
            this.thong_ke_button = new System.Windows.Forms.Button();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLTourDuLich
            // 
            this.lblQLTourDuLich.AutoSize = true;
            this.lblQLTourDuLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLTourDuLich.Location = new System.Drawing.Point(184, 7);
            this.lblQLTourDuLich.Name = "lblQLTourDuLich";
            this.lblQLTourDuLich.Size = new System.Drawing.Size(460, 51);
            this.lblQLTourDuLich.TabIndex = 0;
            this.lblQLTourDuLich.Text = "Quan Ly Tour Du Lich";
            this.lblQLTourDuLich.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblQLTourDuLich);
            this.panel1.Location = new System.Drawing.Point(-4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 82);
            this.panel1.TabIndex = 1;
            // 
            // btnTourFilter
            // 
            this.btnTourFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTourFilter.Location = new System.Drawing.Point(300, 352);
            this.btnTourFilter.Name = "btnTourFilter";
            this.btnTourFilter.Size = new System.Drawing.Size(169, 32);
            this.btnTourFilter.TabIndex = 2;
            this.btnTourFilter.Text = "Tim Kiem va Loc Tour";
            this.btnTourFilter.UseVisualStyleBackColor = true;
            this.btnTourFilter.Click += new System.EventHandler(this.btnTourFilter_Click);
            // 
            // thong_ke_button
            // 
            this.thong_ke_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thong_ke_button.Location = new System.Drawing.Point(283, 276);
            this.thong_ke_button.Name = "thong_ke_button";
            this.thong_ke_button.Size = new System.Drawing.Size(204, 32);
            this.thong_ke_button.TabIndex = 4;
            this.thong_ke_button.Text = "Thong Ke Va Bao Cao";
            this.thong_ke_button.UseVisualStyleBackColor = true;
            this.thong_ke_button.Click += new System.EventHandler(this.thong_ke_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.thong_ke_button);
            this.Controls.Add(this.btnTourFilter);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            //((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQLTourDuLich;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTourFilter;
        private System.Windows.Forms.Button thong_ke_button;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
    }
}

