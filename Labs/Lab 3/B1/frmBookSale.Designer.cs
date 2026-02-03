namespace Lab3
{
    partial class frmBookSale
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            calculateToolStripMenuItem = new ToolStripMenuItem();
            sumaryToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            txtTitle = new TextBox();
            groupBox1 = new GroupBox();
            chkDisStudent = new CheckBox();
            chkDis = new CheckBox();
            lblNetDue = new Label();
            lblDis = new Label();
            lblEPrice = new Label();
            label8 = new Label();
            txtPrice = new TextBox();
            txtQuan = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(584, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, calculateToolStripMenuItem, sumaryToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(224, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // calculateToolStripMenuItem
            // 
            calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            calculateToolStripMenuItem.Size = new Size(224, 26);
            calculateToolStripMenuItem.Text = "Calculate";
            calculateToolStripMenuItem.Click += calculateToolStripMenuItem_Click;
            // 
            // sumaryToolStripMenuItem
            // 
            sumaryToolStripMenuItem.Name = "sumaryToolStripMenuItem";
            sumaryToolStripMenuItem.Size = new Size(224, 26);
            sumaryToolStripMenuItem.Text = "Summary";
            sumaryToolStripMenuItem.Click += sumaryToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click_1;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(201, 64);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(315, 27);
            txtTitle.TabIndex = 1;
            txtTitle.UseWaitCursor = true;
            txtTitle.TextChanged += textBox1_TextChanged_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkDisStudent);
            groupBox1.Controls.Add(chkDis);
            groupBox1.Controls.Add(lblNetDue);
            groupBox1.Controls.Add(lblDis);
            groupBox1.Controls.Add(lblEPrice);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtQuan);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 403);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Information";
            groupBox1.UseCompatibleTextRendering = true;
            groupBox1.UseWaitCursor = true;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // chkDisStudent
            // 
            chkDisStudent.AutoSize = true;
            chkDisStudent.Font = new Font("Arial Rounded MT Bold", 9F);
            chkDisStudent.Location = new Point(373, 283);
            chkDisStudent.Name = "chkDisStudent";
            chkDisStudent.Size = new Size(154, 21);
            chkDisStudent.TabIndex = 16;
            chkDisStudent.Text = "Discount Student";
            chkDisStudent.UseVisualStyleBackColor = true;
            chkDisStudent.UseWaitCursor = true;
            // 
            // chkDis
            // 
            chkDis.AutoSize = true;
            chkDis.Font = new Font("Arial Rounded MT Bold", 9F);
            chkDis.Location = new Point(373, 241);
            chkDis.Name = "chkDis";
            chkDis.Size = new Size(151, 21);
            chkDis.TabIndex = 15;
            chkDis.Text = "Normal Discount";
            chkDis.UseVisualStyleBackColor = true;
            chkDis.UseWaitCursor = true;
            chkDis.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lblNetDue
            // 
            lblNetDue.BackColor = SystemColors.InactiveCaption;
            lblNetDue.BorderStyle = BorderStyle.Fixed3D;
            lblNetDue.Location = new Point(201, 318);
            lblNetDue.Name = "lblNetDue";
            lblNetDue.Size = new Size(137, 27);
            lblNetDue.TabIndex = 14;
            lblNetDue.TextAlign = ContentAlignment.MiddleLeft;
            lblNetDue.UseWaitCursor = true;
            // 
            // lblDis
            // 
            lblDis.BackColor = SystemColors.InactiveCaption;
            lblDis.BorderStyle = BorderStyle.Fixed3D;
            lblDis.Location = new Point(201, 269);
            lblDis.Name = "lblDis";
            lblDis.Size = new Size(137, 27);
            lblDis.TabIndex = 13;
            lblDis.TextAlign = ContentAlignment.MiddleLeft;
            lblDis.UseWaitCursor = true;
            // 
            // lblEPrice
            // 
            lblEPrice.BackColor = SystemColors.InactiveCaption;
            lblEPrice.BorderStyle = BorderStyle.Fixed3D;
            lblEPrice.Location = new Point(201, 219);
            lblEPrice.Name = "lblEPrice";
            lblEPrice.Size = new Size(137, 27);
            lblEPrice.TabIndex = 12;
            lblEPrice.TextAlign = ContentAlignment.MiddleLeft;
            lblEPrice.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(223, 219);
            label8.Name = "label8";
            label8.Size = new Size(0, 16);
            label8.TabIndex = 11;
            label8.UseWaitCursor = true;
            label8.Click += label8_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(201, 166);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(137, 27);
            txtPrice.TabIndex = 10;
            txtPrice.UseWaitCursor = true;
            // 
            // txtQuan
            // 
            txtQuan.Location = new Point(201, 114);
            txtQuan.Name = "txtQuan";
            txtQuan.Size = new Size(137, 27);
            txtQuan.TabIndex = 9;
            txtQuan.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold);
            label7.Location = new Point(61, 318);
            label7.Name = "label7";
            label7.Size = new Size(66, 18);
            label7.TabIndex = 8;
            label7.Text = "Net Due";
            label7.UseWaitCursor = true;
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold);
            label6.Location = new Point(61, 269);
            label6.Name = "label6";
            label6.Size = new Size(71, 18);
            label6.TabIndex = 7;
            label6.Text = "Discount";
            label6.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold);
            label5.Location = new Point(61, 219);
            label5.Name = "label5";
            label5.Size = new Size(117, 18);
            label5.TabIndex = 6;
            label5.Text = "Extended Price";
            label5.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 245);
            label4.Name = "label4";
            label4.Size = new Size(0, 16);
            label4.TabIndex = 5;
            label4.UseWaitCursor = true;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold);
            label3.Location = new Point(61, 169);
            label3.Name = "label3";
            label3.Size = new Size(45, 18);
            label3.TabIndex = 4;
            label3.Text = "Price";
            label3.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold);
            label2.Location = new Point(61, 117);
            label2.Name = "label2";
            label2.Size = new Size(67, 18);
            label2.TabIndex = 3;
            label2.Text = "Quantity";
            label2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold);
            label1.Location = new Point(61, 67);
            label1.Name = "label1";
            label1.Size = new Size(40, 18);
            label1.TabIndex = 2;
            label1.Text = "Title";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // frmBookSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 446);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Name = "frmBookSale";
            Text = "Book Sale";
            Load += frmBookSale_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private TextBox txtTitle;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem calculateToolStripMenuItem;
        private ToolStripMenuItem sumaryToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label8;
        private TextBox txtPrice;
        private TextBox txtQuan;
        private CheckBox chkDisStudent;
        private CheckBox chkDis;
        private Label lblNetDue;
        private Label lblDis;
        private Label lblEPrice;
    }
}
