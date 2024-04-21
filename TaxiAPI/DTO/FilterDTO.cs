using TaxiAPI.Enums;

namespace TaxiAPI.DTO
{
    public class FilterDTO
    {
        public VendorEnum? Vendor { get; set; }
        public DateTime? PickUpDateStart { get; set; }
        public DateTime? PickUpDateEnd { get; set; }
        public DateTime? DropOffStart { get; set; }
        public DateTime? DropOffEnd { get; set;}
        public RateCodeEnum? RateCode { get; set; }
        public PaymentTypeEnum? PaymentType { get; set; }
    }
}
