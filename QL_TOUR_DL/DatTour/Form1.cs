using System;
using System.Windows.Forms;

namespace DatTour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Định nghĩa hàm ShowPage để hoán đổi các UserControl trong panel1
        public void ShowPage(UserControl uc)
        {
            if (panel1 == null) return;

            panel1.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Hiển thị trang danh sách tour đầu tiên khi mở ứng dụng
            // Đảm bảo bạn đã tạo file ucTourList.cs
            ShowPage(new ucTourList(this));
        }
    }
}