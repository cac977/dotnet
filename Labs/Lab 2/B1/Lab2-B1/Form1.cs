namespace Lab2_B1
{
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int cnt = lstHob.CheckedItems.Count;
            string hobby = "";
            for (int index = 0; index <= cnt - 1; index++)
            {
                hobby += lstHob.CheckedItems[index];
                if (index < cnt - 1)
                    hobby += ",";
            }
            MessageBox.Show(txtName.Text + " born in" + txtYear.Text + " from Class " + lstClass.Text + ", Division " + cboDiv.Text + " has following hobbies " + hobby);
        }
        
        private void cboDiv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtYear.Clear();
            lstClass.ClearSelected();
            cboDiv.Text = "";
            lstHob.ClearSelected();
            for (int i = 0; i < lstHob.Items.Count; i++)
            {
              lstHob.SetItemChecked(i, false);
            }
        }

    }
}
