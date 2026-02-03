namespace prjDVD
{
    partial class frmDVDCatalog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            lblHeading = new Label();
            lblDVDCodeNo = new Label();
            lblTitle = new Label();
            lblLang = new Label();
            lblPrice = new Label();
            grpSubtitles = new GroupBox();
            radNo = new RadioButton();
            radYes = new RadioButton();
            updPrice = new NumericUpDown();
            cboLang = new ComboBox();
            btnAdd = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            txtNo = new TextBox();
            txtTitle = new TextBox();
            grpSubtitles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updPrice).BeginInit();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblHeading.Location = new Point(170, 32);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(213, 45);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "DVD Catalog";
            lblHeading.Click += label1_Click;
            // 
            // lblDVDCodeNo
            // 
            lblDVDCodeNo.AutoSize = true;
            lblDVDCodeNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDVDCodeNo.Location = new Point(33, 110);
            lblDVDCodeNo.Name = "lblDVDCodeNo";
            lblDVDCodeNo.Size = new Size(82, 15);
            lblDVDCodeNo.TabIndex = 1;
            lblDVDCodeNo.Text = "DVD Number";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitle.Location = new Point(33, 165);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(59, 15);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "DVD title";
            // 
            // lblLang
            // 
            lblLang.AutoSize = true;
            lblLang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLang.Location = new Point(33, 229);
            lblLang.Name = "lblLang";
            lblLang.Size = new Size(60, 15);
            lblLang.TabIndex = 3;
            lblLang.Text = "Language";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPrice.Location = new Point(33, 284);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(35, 15);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price";
            // 
            // grpSubtitles
            // 
            grpSubtitles.Controls.Add(radNo);
            grpSubtitles.Controls.Add(radYes);
            grpSubtitles.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpSubtitles.Location = new Point(163, 350);
            grpSubtitles.Name = "grpSubtitles";
            grpSubtitles.Size = new Size(192, 72);
            grpSubtitles.TabIndex = 5;
            grpSubtitles.TabStop = false;
            grpSubtitles.Text = "Sub title";
            // 
            // radNo
            // 
            radNo.AutoSize = true;
            radNo.Location = new Point(124, 34);
            radNo.Name = "radNo";
            radNo.Size = new Size(41, 19);
            radNo.TabIndex = 7;
            radNo.Text = "No";
            radNo.UseVisualStyleBackColor = true;
            radNo.CheckedChanged += radNo_CheckedChanged;
            // 
            // radYes
            // 
            radYes.AutoSize = true;
            radYes.Checked = true;
            radYes.Location = new Point(27, 34);
            radYes.Name = "radYes";
            radYes.Size = new Size(43, 19);
            radYes.TabIndex = 6;
            radYes.TabStop = true;
            radYes.Text = "Yes";
            radYes.UseVisualStyleBackColor = true;
            radYes.CheckedChanged += radYes_CheckedChanged;
            // 
            // updPrice
            // 
            updPrice.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            updPrice.Location = new Point(162, 282);
            updPrice.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            updPrice.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            updPrice.Name = "updPrice";
            updPrice.Size = new Size(154, 23);
            updPrice.TabIndex = 6;
            updPrice.Value = new decimal(new int[] { 5, 0, 0, 0 });
            updPrice.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // cboLang
            // 
            cboLang.FormattingEnabled = true;
            cboLang.Items.AddRange(new object[] { "English", "Spanish", "French", "Chinese", "Russian" });
            cboLang.Location = new Point(162, 229);
            cboLang.Name = "cboLang";
            cboLang.Size = new Size(155, 23);
            cboLang.TabIndex = 7;
            cboLang.SelectedIndexChanged += cboLang_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.Location = new Point(87, 478);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 32);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.Location = new Point(372, 478);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 32);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.Location = new Point(233, 478);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 32);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtNo
            // 
            txtNo.Location = new Point(162, 110);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(155, 23);
            txtNo.TabIndex = 11;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(162, 165);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(302, 23);
            txtTitle.TabIndex = 12;
            txtTitle.TextChanged += textBox2_TextChanged;
            // 
            // frmDVDCatalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 560);
            Controls.Add(txtTitle);
            Controls.Add(txtNo);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(cboLang);
            Controls.Add(updPrice);
            Controls.Add(grpSubtitles);
            Controls.Add(lblPrice);
            Controls.Add(lblLang);
            Controls.Add(lblTitle);
            Controls.Add(lblDVDCodeNo);
            Controls.Add(lblHeading);
            Name = "frmDVDCatalog";
            Text = "DVD Library";
            Load += Form1_Load;
            grpSubtitles.ResumeLayout(false);
            grpSubtitles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)updPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private Label lblDVDCodeNo;
        private Label lblTitle;
        private Label lblLang;
        private Label lblPrice;
        private GroupBox grpSubtitles;
        private RadioButton radYes;
        private NumericUpDown updPrice;
        private ComboBox cboLang;
        private Button btnAdd;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtNo;
        private TextBox txtTitle;
        private RadioButton radNo;
    }
}
