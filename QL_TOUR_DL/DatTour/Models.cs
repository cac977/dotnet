namespace DatTour
{
    // Class dùng chung để chứa thông tin khách hàng khi chuyển trang
    public class CustomerDTO
    {
        public string ID { get; set; }
        public string Ten { get; set; }
        public string SDT { get; set; }
        public bool IsNew { get; set; }
    }
}