namespace Lab2_B3
{
    public partial class FlightReservation : Form
    {
        public FlightReservation()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstDestination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (lstSource.Text == lstDestination.Text)
            {
                MessageBox.Show(
                    "Departure city and destination city cannot be the same!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            string ticketClass = "";

            if (lstClass.SelectedIndex == 0)
                ticketClass = "Economy";
            else if (lstClass.SelectedIndex == 1)
                ticketClass = "Business";
            else if (lstClass.SelectedIndex == 2)
                ticketClass = "First Class";
            else
            {
                MessageBox.Show("Please select ticket class");
                return;
            }

            string services = "";
            foreach (var item in lstServices.CheckedItems)
            {
                services += item + ", ";
            }

            MessageBox.Show(
                "Ticket ID: " + txtTicketNumber.Text +
                "\nPassenger: " + txtName.Text +
                "\nPassport: " + txtPassportNum.Text +
                "\nFlight Date: " + dateTimePicker1.Value.ToShortDateString() +
                "\nFrom: " + lstSource.Text +
                "\nTo: " + lstDestination.Text +
                "\nClass: " + ticketClass +
                "\nServices: " + services,
                "Ticket Information"
            );
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTicketNumber.Clear();
            txtName.Clear();
            txtPassportNum.Clear();

            lstSource.SelectedIndex = -1;
            lstDestination.SelectedIndex = -1;

            lstClass.Text = "";


            for (int i = 0; i < lstServices.Items.Count; i++)
            {
                lstServices.SetItemChecked(i, false);
            }

            dateTimePicker1.Value = DateTime.Now;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
