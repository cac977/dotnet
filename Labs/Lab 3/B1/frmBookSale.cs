namespace Lab3
{
    public partial class frmBookSale : Form
    {
        private clsBookSale mBookSale;
        public frmBookSale()
        {
            InitializeComponent();
        }
        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Khởi tạo đối tượng sách mới với dữ liệu từ Form
                // Dùng lớp con clsStudentBookSale để tính được cả 2 loại giảm giá
                mBookSale = new clsStudentBookSale(
                    txtTitle.Text,                          // Tên sách
                    Convert.ToInt32(txtQuan.Text),          // Số lượng (ép kiểu sang số nguyên)
                    Convert.ToDecimal(txtPrice.Text),       // Giá bán (ép kiểu sang số thập phân)
                    chkDis.Checked,                         // Có giảm giá thường không?
                    chkDisStudent.Checked                   // Có phải sinh viên không?
                );


                // 3. Tính toán và hiển thị kết quả ra các Label
                lblEPrice.Text = mBookSale.ExtendedPrice().ToString("C");   // Thành tiền
                lblDis.Text = mBookSale.DiscountAmount().ToString("C");     // Tiền giảm
                lblNetDue.Text = mBookSale.NetDue().ToString("C");          // Tổng trả
            }
            catch (Exception ex)
            {
                // 4. In lỗi nếu người dùng nhập chữ vào ô số hoặc nhập số âm
                MessageBox.Show("Input Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtQuan.Text = "";
            txtPrice.Text = "";
            lblEPrice.Text = "";
            lblDis.Text = "";
            lblNetDue.Text = "";
            chkDis.Checked = false;
            chkDisStudent.Checked = false;

            // Đưa con trỏ chuột về ô nhập Tên sách
            txtTitle.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void sumaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ biến Static trong class clsBookSale
            string strMessage = "Total income: " + clsBookSale.SalesTotal.ToString("C") +
                                "\nTotal orders: " + clsBookSale.SalesCount.ToString();

            MessageBox.Show(strMessage, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void frmBookSale_Load(object sender, EventArgs e)
        {

        }
    }
}
