using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class clsBookSale
    {
        // 1. Khai báo các dữ liệu thành viên (Fields)
        private string strTitle;
        private int intQuantity;
        private decimal decPrice;
        private bool blnDiscount;

        // 2. Khai báo biến Static để thống kê tổng doanh thu (dùng chung cho mọi quyển sách bán ra)
        static decimal decSalesTotal = 0;
        static int intSalesCount = 0;

        // Hằng số mức giảm giá 10%
        const float sngDISCOUNT_RATE = 0.1f;

        // 3. Constructor (Phương thức khởi tạo) để gán giá trị ban đầu
        public clsBookSale(string title, int quantity, decimal price, bool discount)
        {
            this.Title = title;
            this.Quantity = quantity;
            this.Price = price;
            this.Discount = discount;
        }

        // 4. Định nghĩa các Thuộc tính (Properties) để kiểm soát dữ liệu nhập vào
        public string Title
        {
            get { return strTitle; }
            set { strTitle = value; } 
        }

        public int Quantity
        {
            get { return intQuantity; }
            set
            {
                // Chỉ nhận giá trị > 0, nếu không thì báo lỗi
                if (value > 0) intQuantity = value;
                else throw new Exception("Quantity must be greater than 0");
            }
        }

        public decimal Price
        {
            get { return decPrice; }
            set
            {
                // Chỉ nhận giá >= 0
                if (value >= 0) decPrice = value;
                else throw new Exception("Price must be non-negative");
            }
        }

        public bool Discount
        {
            get { return blnDiscount; }
            set { blnDiscount = value; }         }

        // Các thuộc tính Static (chỉ đọc) để lấy thông tin thống kê
        public static decimal SalesTotal
        {
            get { return decSalesTotal; }
        }

        public static int SalesCount
        {
            get { return intSalesCount; }
        }

        // 5. Phương thức tính Thành tiền (Số lượng * Đơn giá)
        public decimal ExtendedPrice()
        {
            decimal decExtendedPrice = intQuantity * decPrice;
            return decExtendedPrice;
        }

        // 6. Phương thức tính tiền Giảm giá
        // Từ khóa 'virtual' cho phép lớp con (clsStudentBookSale) ghi đè lại phương thức này
        
        public virtual decimal DiscountAmount()
        {
            decimal decDiscountAmount = 0;
            if (blnDiscount) // Nếu có check vào ô giảm giá
            {
                decDiscountAmount = intQuantity * decPrice * Convert.ToDecimal(sngDISCOUNT_RATE);
            }
            return decDiscountAmount;
        }

        // 7. Phương thức tính Tổng tiền phải trả (Net Due)
        public decimal NetDue()
        {
            decimal decNetDue = ExtendedPrice() - DiscountAmount();

            // Cập nhật vào biến thống kê tổng của cửa hàng ngay khi tính tiền
            decSalesTotal += decNetDue;
            intSalesCount += 1;

            return decNetDue;
        }
    }
}
