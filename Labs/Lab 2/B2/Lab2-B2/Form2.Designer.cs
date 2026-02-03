namespace Lab2_B2
{
    partial class EmployeeDetails
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnSave = new Button();
            btnClear = new Button();
            btnExit = new Button();
            txtName = new TextBox();
            txtAddress = new RichTextBox();
            dateJoin = new DateTimePicker();
            cboDepartment = new ComboBox();
            lstEducation = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(165, 29);
            label1.Name = "label1";
            label1.Size = new Size(198, 31);
            label1.TabIndex = 0;
            label1.Text = "Employee Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 105);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 1;
            label2.Text = "Employee Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 154);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 2;
            label3.Text = "Employee Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 269);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 3;
            label4.Text = "Date of Joining";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 320);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 4;
            label5.Text = "Education";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 373);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 5;
            label6.Text = "Department";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(59, 451);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += buttonSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(192, 451);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(102, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(328, 451);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(92, 29);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(215, 105);
            txtName.Name = "txtName";
            txtName.Size = new Size(254, 27);
            txtName.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(215, 154);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(254, 77);
            txtAddress.TabIndex = 11;
            txtAddress.Text = "";
            // 
            // dateJoin
            // 
            dateJoin.Format = DateTimePickerFormat.Short;
            dateJoin.Location = new Point(213, 262);
            dateJoin.Name = "dateJoin";
            dateJoin.Size = new Size(146, 27);
            dateJoin.TabIndex = 12;
            dateJoin.UseWaitCursor = true;
            dateJoin.Value = new DateTime(2026, 1, 27, 0, 0, 0, 0);
            dateJoin.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cboDepartment
            // 
            cboDepartment.FormattingEnabled = true;
            cboDepartment.Items.AddRange(new object[] { "Human Resource", "Marketing", "R&D" });
            cboDepartment.Location = new Point(213, 365);
            cboDepartment.Name = "cboDepartment";
            cboDepartment.Size = new Size(146, 28);
            cboDepartment.TabIndex = 14;
            // 
            // lstEducation
            // 
            lstEducation.FormattingEnabled = true;
            lstEducation.Items.AddRange(new object[] { "UnderGraduate", "PostGraduate" });
            lstEducation.Location = new Point(213, 316);
            lstEducation.Name = "lstEducation";
            lstEducation.ScrollAlwaysVisible = true;
            lstEducation.Size = new Size(146, 24);
            lstEducation.TabIndex = 15;
            // 
            // EmployeeDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(500, 505);
            Controls.Add(lstEducation);
            Controls.Add(cboDepartment);
            Controls.Add(dateJoin);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmployeeDetails";
            Text = "EmployeeDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnSave;
        private Button btnClear;
        private Button btnExit;
        private TextBox txtName;
        private RichTextBox txtAddress;
        private DateTimePicker dateJoin;
        private ComboBox cboEducation;
        private ComboBox cboDepartment;
        private ListBox listBox1;
        private ListBox lstEducation;
    }
}