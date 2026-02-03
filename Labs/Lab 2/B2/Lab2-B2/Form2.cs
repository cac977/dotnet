using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_B2
{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string info =
                "Name: " + txtName.Text +
                "\nAddress: " + txtAddress.Text +
                "\nJoin Date: " + dateJoin.Value.ToShortDateString() +
                "\nEducation: " + lstEducation.Text +
                "\nDepartment: " + cboDepartment.Text;

            MessageBox.Show(info, "Employee Information");

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddress.Clear();

            lstEducation.SelectedIndex = -1;
            cboDepartment.SelectedIndex = -1;

            dateJoin.Value = DateTime.Now;
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateJoin.Value > DateTime.Now)
            {
                MessageBox.Show(
                      "Joining date can't be in the future",
                      "Error",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error
                  );
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
