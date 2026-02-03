using System;
using System.Data;
using System.Data.SqlClient;

namespace prjDVD
{
    public partial class frmDVDCatalog : Form
    {
        int CodeNo;
        decimal price;
        String language;
        int subTitle;
        public frmDVDCatalog()
        {
            InitializeComponent();
        }

        private void resetFields(bool status)
        {
            txtNo.Clear();
            txtTitle.Clear();
            cboLang.SelectedIndex = -1;
            updPrice.Value = updPrice.Minimum;
            radNo.Checked = false;
            radYes.Checked = true;
            btnCancel.Enabled = status;
            btnSave.Enabled = status;
            btnAdd.Enabled = !status;
            txtTitle.Focus();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            price = updPrice.Value;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.openConnection();
                SqlCommand con = new SqlCommand("Select Max(DVDCodeNo) from DVDLibrary", clsDatabase.conn);
                CodeNo = Convert.ToInt32(con.ExecuteScalar());
            }
            catch (Exception)
            {
                CodeNo = 0;
            }
            CodeNo++;
            resetFields(true);
            txtNo.Text = CodeNo.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String strInsert = "Insert into DVDLibrary Values(@DVDNo, @DVDTitle, @DVDLang, @SubTitle. @Price)";
                clsDatabase.openConnection();
                SqlCommand con = new SqlCommand(strInsert, clsDatabase.conn);

                SqlParameter p1 = new SqlParameter("@DVDNo", SqlDbType.Int);
                p1.Value = CodeNo;
                SqlParameter p2 = new SqlParameter("@DVDTitle", SqlDbType.NVarChar);
                p2.Value = txtTitle.Text;
                SqlParameter p3 = new SqlParameter("@DVDLang", SqlDbType.NVarChar);
                p3.Value = language;
                SqlParameter p4 = new SqlParameter("@SubTitle", SqlDbType.Bit);
                p4.Value = subTitle;
                SqlParameter p5 = new SqlParameter("@Price", SqlDbType.Decimal);
                p5.Value = price;

                con.Parameters.Add(p1);
                con.Parameters.Add(p2);
                con.Parameters.Add(p3);
                con.Parameters.Add(p4);
                con.Parameters.Add(p5);

                MessageBox.Show("Insert successfully", "Success", MessageBoxButtons.OK);
                clsDatabase.conn.Close();
                resetFields(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetFields(false);
        }

        private void cboLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLang.SelectedIndex == -1)
            {
                return;
            }
            language = cboLang.Text;
        }

        private void radYes_CheckedChanged(object sender, EventArgs e)
        {
            subTitle = 1;
        }

        private void radNo_CheckedChanged(object sender, EventArgs e)
        {
            subTitle = 0;
        }
    }
}
