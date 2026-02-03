namespace Lab2_B1
{
    partial class StudentDetails
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
            txtName = new TextBox();
            txtYear = new TextBox();
            cboDiv = new ComboBox();
            lstClass = new ListBox();
            lstHob = new CheckedListBox();
            btnConfirm = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(188, 100);
            txtName.Name = "txtName";
            txtName.Size = new Size(252, 27);
            txtName.TabIndex = 0;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(188, 143);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(125, 27);
            txtYear.TabIndex = 1;
            // 
            // cboDiv
            // 
            cboDiv.AutoCompleteCustomSource.AddRange(new string[] { "A", "B", "C", "D" });
            cboDiv.FormattingEnabled = true;
            cboDiv.Items.AddRange(new object[] { "A", "B", "C", "D" });
            cboDiv.Location = new Point(188, 324);
            cboDiv.Name = "cboDiv";
            cboDiv.Size = new Size(151, 28);
            cboDiv.TabIndex = 2;
            cboDiv.SelectedIndexChanged += cboDiv_SelectedIndexChanged;
            // 
            // lstClass
            // 
            lstClass.FormattingEnabled = true;
            lstClass.Items.AddRange(new object[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" });
            lstClass.Location = new Point(188, 197);
            lstClass.Name = "lstClass";
            lstClass.Size = new Size(150, 104);
            lstClass.TabIndex = 3;
            lstClass.SelectedIndexChanged += lstClass_SelectedIndexChanged;
            // 
            // lstHob
            // 
            lstHob.FormattingEnabled = true;
            lstHob.Items.AddRange(new object[] { "Singing", "Dancing", "Swimming", "Reading", "Travelling" });
            lstHob.Location = new Point(188, 385);
            lstHob.Name = "lstHob";
            lstHob.ScrollAlwaysVisible = true;
            lstHob.Size = new Size(151, 70);
            lstHob.TabIndex = 4;
            // 
            // btnConfirm
            // 
            btnConfirm.ForeColor = SystemColors.ActiveCaptionText;
            btnConfirm.Location = new Point(67, 506);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(197, 36);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Confirm Student Details";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.TitleBar;
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(115, 35);
            label1.Name = "label1";
            label1.Size = new Size(253, 31);
            label1.TabIndex = 7;
            label1.Text = "Student's Class Details";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 100);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 8;
            label2.Text = "Student Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 146);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 9;
            label3.Text = "Year of Birth";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 197);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 10;
            label4.Text = "Standard/Class";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 324);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 11;
            label5.Text = "Division";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 385);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 12;
            label6.Text = "Hobbies";
            label6.Click += label6_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(315, 506);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(106, 36);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // StudentDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(480, 590);
            Controls.Add(btnClear);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConfirm);
            Controls.Add(lstHob);
            Controls.Add(lstClass);
            Controls.Add(cboDiv);
            Controls.Add(txtYear);
            Controls.Add(txtName);
            Name = "StudentDetails";
            Text = "StudentDetails";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private TextBox txtName;
        private TextBox txtYear;
        private ComboBox cboDiv;
        private ListBox lstClass;
        private CheckedListBox lstHob;
        private Button btnConfirm;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnClear;
    }
}
