namespace Lab2_B3
{
    partial class FlightReservation
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnVerify = new Button();
            btnClear = new Button();
            txtTicketNumber = new TextBox();
            txtName = new TextBox();
            txtPassportNum = new TextBox();
            lstSource = new ListBox();
            lstDestination = new ListBox();
            lstServices = new CheckedListBox();
            lstClass = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 19);
            label1.Name = "label1";
            label1.Size = new Size(289, 31);
            label1.TabIndex = 0;
            label1.Text = "Flight Reservation Details";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 80);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "Ticket number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 136);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 2;
            label3.Text = "Passenger Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 186);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 3;
            label4.Text = "Passport Number";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 232);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 4;
            label5.Text = "Source";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 335);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 5;
            label6.Text = "Destination";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 414);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 6;
            label7.Text = "Flight Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 458);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 7;
            label8.Text = "Class";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 496);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 8;
            label9.Text = "Services";
            // 
            // btnVerify
            // 
            btnVerify.Location = new Point(111, 566);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(94, 29);
            btnVerify.TabIndex = 9;
            btnVerify.Text = "Verify";
            btnVerify.UseVisualStyleBackColor = true;
            btnVerify.Click += btnVerify_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(279, 566);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;btnClear.Click += btnClear_Click;
            // 
            // txtTicketNumber
            // 
            txtTicketNumber.Location = new Point(200, 73);
            txtTicketNumber.Name = "txtTicketNumber";
            txtTicketNumber.Size = new Size(125, 27);
            txtTicketNumber.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(200, 129);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 12;
            txtName.TextChanged += textBox2_TextChanged;
            // 
            // txtPassportNum
            // 
            txtPassportNum.Location = new Point(200, 179);
            txtPassportNum.Name = "txtPassportNum";
            txtPassportNum.Size = new Size(125, 27);
            txtPassportNum.TabIndex = 13;
            // 
            // lstSource
            // 
            lstSource.ForeColor = SystemColors.InactiveCaptionText;
            lstSource.FormattingEnabled = true;
            lstSource.Items.AddRange(new object[] { "Hà Nội", "Đà Nẵng", "TP Hồ Chí Minh", "Cần Thơ" });
            lstSource.Location = new Point(200, 232);
            lstSource.Name = "lstSource";
            lstSource.ScrollAlwaysVisible = true;
            lstSource.Size = new Size(157, 64);
            lstSource.TabIndex = 14;
            // 
            // lstDestination
            // 
            lstDestination.FormattingEnabled = true;
            lstDestination.Items.AddRange(new object[] { "Hà Nội", "Đà Nẵng", "TP Hồ Chí Minh", "Cần Thơ" });
            lstDestination.Location = new Point(200, 325);
            lstDestination.Name = "lstDestination";
            lstDestination.ScrollAlwaysVisible = true;
            lstDestination.Size = new Size(157, 64);
            lstDestination.TabIndex = 15;
            lstDestination.SelectedIndexChanged += lstDestination_SelectedIndexChanged;
            // 
            // lstServices
            // 
            lstServices.FormattingEnabled = true;
            lstServices.Items.AddRange(new object[] { "Child Care", "Nurse", "Special Meal" });
            lstServices.Location = new Point(200, 496);
            lstServices.Name = "lstServices";
            lstServices.Size = new Size(157, 48);
            lstServices.TabIndex = 16;
            // 
            // lstClass
            // 
            lstClass.FormattingEnabled = true;
            lstClass.Items.AddRange(new object[] { "Business", "Economy", "First Class" });
            lstClass.Location = new Point(200, 450);
            lstClass.Name = "lstClass";
            lstClass.Size = new Size(157, 28);
            lstClass.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(200, 407);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(157, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // FlightReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 619);
            Controls.Add(dateTimePicker1);
            Controls.Add(lstClass);
            Controls.Add(lstServices);
            Controls.Add(lstDestination);
            Controls.Add(lstSource);
            Controls.Add(txtPassportNum);
            Controls.Add(txtName);
            Controls.Add(txtTicketNumber);
            Controls.Add(btnClear);
            Controls.Add(btnVerify);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FlightReservation";
            Text = "Flight Date";
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
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnVerify;
        private Button btnClear;
        private TextBox txtTicketNumber;
        private TextBox txtName;
        private TextBox txtPassportNum;
        private ListBox lstSource;
        private ListBox lstDestination;
        private CheckedListBox lstServices;
        private ComboBox lstClass;
        private DateTimePicker dateTimePicker1;
    }
}
