using System;
using System.Data;
using System.Data.SqlClient;

namespace prjDVD
{
    public partial class frmDVDCatalog : Form
    {
        int CodeNo;
        decimal price;
        string language;
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
                SqlCommand com = new SqlCommand("Select Max(DVDCodeNo) from DVDLibrary", clsDatabase.con);
                CodeNo = Convert.ToInt32(com.ExecuteScalar());
                clsDatabase.closeConnection();
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
                string strInsert = "Insert into DVDLibrary Values(@DVDNo, @DVDTitle, @DVDLang, @SubTitle, @Price)";
                clsDatabase.openConnection();
                SqlCommand com = new SqlCommand(strInsert, clsDatabase.con);

                //debug
                if (!clsDatabase.openConnection())
                    throw new InvalidOperationException("Unable to open database connection.");

                SqlParameter p1 = new SqlParameter("@DVDNo", SqlDbType.Int);
                p1.Value = CodeNo;
                SqlParameter p2 = new SqlParameter("@DVDTitle", SqlDbType.NVarChar);
                p2.Value = txtTitle.Text;
                SqlParameter p3 = new SqlParameter("@DVDLang", SqlDbType.NVarChar);
                p3.Value = language;
                SqlParameter p4 = new SqlParameter("@SubTitle", SqlDbType.Bit);
                p4.Value = subTitle;
                SqlParameter p5 = new SqlParameter("@Price", SqlDbType.Money);
                p5.Value = price;

                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.Parameters.Add(p4);
                com.Parameters.Add(p5);
                com.ExecuteNonQuery();

                MessageBox.Show("Insert successfully");
                clsDatabase.closeConnection();
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

//using System;
//using System.Data;
//using System.Data.SqlClient;
//using System.Windows.Forms;

//namespace prjDVD
//{
//    public partial class frmDVDCatalog : Form
//    {
//        // Khai báo các biến bám sát bảng 6.2 và mục 5 trong Lab 6
//        int CodeNo;
//        decimal price;
//        string language = "";
//        int subTitle = 1; // Mặc định là 1 (Yes)

//        public frmDVDCatalog()
//        {
//            InitializeComponent();
//        }

//        // Hàm reset các trường nhập liệu (Mục 5 - bảng 6.3)
//        private void resetFields(bool status)
//        {
//            txtNo.Clear();
//            txtTitle.Clear();
//            cboLang.SelectedIndex = -1;
//            updPrice.Value = updPrice.Minimum;
//            radNo.Checked = false;
//            radYes.Checked = true;
//            btnCancel.Enabled = status;
//            btnSave.Enabled = status;
//            btnAdd.Enabled = !status;
//            txtTitle.Focus();
//        }

//        // Sự kiện khi nhấn nút Add New (Mục 4b trong Lab - Tự động tạo mã)
//        private void btnAdd_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (clsDatabase.openConnection())
//                {
//                    // Lấy mã số DVD lớn nhất hiện có
//                    String strSelect = "Select Max(DVDCodeNo) from DVDLibrary";
//                    SqlCommand con = new SqlCommand(strSelect, clsDatabase.conn);

//                    object result = con.ExecuteScalar();
//                    if (result == DBNull.Value || result == null)
//                        CodeNo = 1;
//                    else
//                        CodeNo = Convert.ToInt32(result) + 1;

//                    txtNo.Text = CodeNo.ToString();
//                    resetFields(true); // Kích hoạt các ô nhập liệu
//                    clsDatabase.closeConnection();
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Lỗi Add New: " + ex.Message);
//            }
//        }

//        // Sự kiện khi nhấn nút Save (Mục 4c trong Lab)
//        private void btnSave_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (clsDatabase.openConnection())
//                {
//                    // LƯU Ý: Đã sửa dvo thành dbo (hoặc bỏ trống) để bám sát SQL Server
//                    String strInsert = "Insert into DVDLibrary Values(@DVDNo, @DVDTitle, @DVDLang, @SubTitle, @Price)";
//                    SqlCommand con = new SqlCommand(strInsert, clsDatabase.conn);

//                    // Sử dụng SqlParameter bám sát hướng dẫn Lab 6
//                    SqlParameter p1 = new SqlParameter("@DVDNo", SqlDbType.Int);
//                    p1.Value = CodeNo;

//                    SqlParameter p2 = new SqlParameter("@DVDTitle", SqlDbType.NVarChar);
//                    p2.Value = txtTitle.Text;

//                    SqlParameter p3 = new SqlParameter("@DVDLang", SqlDbType.NVarChar);
//                    p3.Value = language;

//                    SqlParameter p4 = new SqlParameter("@SubTitle", SqlDbType.Bit);
//                    p4.Value = subTitle;

//                    SqlParameter p5 = new SqlParameter("@Price", SqlDbType.Money);
//                    p5.Value = price;

//                    con.Parameters.Add(p1);
//                    con.Parameters.Add(p2);
//                    con.Parameters.Add(p3);
//                    con.Parameters.Add(p4);
//                    con.Parameters.Add(p5);

//                    con.ExecuteNonQuery();

//                    MessageBox.Show("Insert successfully", "Success", MessageBoxButtons.OK);
//                    clsDatabase.closeConnection();
//                    resetFields(false); // Quay lại trạng thái ban đầu
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                clsDatabase.closeConnection();
//            }
//        }

//        // --- CÁC SỰ KIỆN GÁN GIÁ TRỊ CHO BIẾN ---

//        private void cboLang_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            if (cboLang.SelectedIndex != -1)
//            {
//                language = cboLang.Text;
//            }
//        }

//        private void radYes_CheckedChanged(object sender, EventArgs e)
//        {
//            subTitle = 1;
//        }

//        private void radNo_CheckedChanged(object sender, EventArgs e)
//        {
//            subTitle = 0;
//        }

//        private void updPrice_ValueChanged(object sender, EventArgs e)
//        {
//            price = updPrice.Value;
//        }

//        private void btnCancel_Click(object sender, EventArgs e)
//        {
//            resetFields(false);
//        }
//    }
//}