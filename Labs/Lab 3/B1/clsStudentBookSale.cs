using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    // 1. Khai báo kế thừa từ lớp clsBookSale (dấu hai chấm :)
    class clsStudentBookSale : clsBookSale
    {
        // Khai báo biến thành viên riêng cho lớp con
        bool blnStudentDiscount;

        // Hằng số giảm giá sinh viên là 15%
        const float sngSTUDENT_DISCOUNT_RATE = 0.15f;

        // 2. Constructor (Phương thức khởi tạo)
        // Nó nhận 5 tham số: 4 cái của lớp cha + 1 cái riêng (student)
        public clsStudentBookSale(string title, int quantity, decimal price, bool discount, bool student)
            : base(title, quantity, price, discount) // Đẩy 4 tham số này về cho lớp cha xử lý
        {
            blnStudentDiscount = student; // Chỉ xử lý tham số riêng này
        }

        // 3. Property kiểm tra xem có phải sinh viên không
        public bool StudentDiscount
        {
            get { return blnStudentDiscount; }
            set { blnStudentDiscount = value; }
        }

        // 4. Ghi đè (Override) phương thức tính tiền giảm giá
        // Để tính thêm phần 15% cho sinh viên
        public override decimal DiscountAmount()
        {
            decimal decDiscountAmount;

            // Bước 1: Lấy số tiền giảm giá cơ bản (10%) từ lớp cha trước
            decDiscountAmount = base.DiscountAmount();

            // Bước 2: Nếu là Sinh viên giỏi, cộng thêm 15% nữa
            if (StudentDiscount)
            {
                decDiscountAmount += ExtendedPrice() * Convert.ToDecimal(sngSTUDENT_DISCOUNT_RATE);
            }

            return decDiscountAmount;
        }
    }
}