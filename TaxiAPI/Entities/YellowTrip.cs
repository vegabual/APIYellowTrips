using Microsoft.OpenApi.Extensions;
using TaxiAPI.Enums;

namespace TaxiAPI.Entities
{
    public class YellowTrip
    {
        public int? VendorID { get; set; }

        public string? VendorName
        {
            get
            {
                if (VendorID.HasValue)
                {
                    switch ((VendorEnum)VendorID)
                    {
                        case VendorEnum.CreativeMobileTechnologies:
                            return "Creative Mobile Technologies, LLC";
                        case VendorEnum.Verifone:
                            return "VeriFone Inc.";
                    }
                }
                return null;
            }
        }

        public DateTime? tpep_pickup_datetime { get; set; }

        public DateTime? tpep_dropoff_datetime { get; set; }

        public Int64? passenger_count { get; set; }

        public double? trip_distance { get; set; }

        public Int64? RatecodeID { get; set; }

        public string? RateCode
        {
            get
            {
                if (RatecodeID.HasValue)
                {
                    switch ((RateCodeEnum)RatecodeID)
                    {
                        case RateCodeEnum.StandardRate:
                            return "Standard rate";
                        case RateCodeEnum.JFK:
                            return "JFK";
                        case RateCodeEnum.Newark:
                            return "Newark";
                        case RateCodeEnum.NassauOrWestchester:
                            return "Nassau or Westchester";
                        case RateCodeEnum.NegotiatedFare:
                            return "Negotiated fare";
                        case RateCodeEnum.GroupRide:
                            return "Group ride";
                    }
                }
                return null;
            }
        }

        public string? store_and_fwd_flag { get; set; }

        public int? PULocationID { get; set; }

        public int? DOLocationID { get; set; }

        public int? Payment_type { get; set; }

        public string? Payment_type_name
        {
            get
            {
                if (Payment_type.HasValue)
                {
                    switch ((PaymentTypeEnum)Payment_type)
                    {
                        case PaymentTypeEnum.CreditCard:
                            return "Credit card";
                        case PaymentTypeEnum.Cash:
                            return "Cash";
                        case PaymentTypeEnum.NoCharge:
                            return "No charge";
                        case PaymentTypeEnum.Dispute:
                            return "Dispute";
                        case PaymentTypeEnum.Unknown:
                            return "Unknown";
                        case PaymentTypeEnum.VoidedTrip:
                            return "Voided Trip";
                    }
                }
                return null;
            }
        }

        public decimal? Fare_amount { get; set; }

        public decimal? Extra { get; set; }

        public decimal? MTA_tax { get; set; }

        public decimal? Improvement_surcharge { get; set; }

        public decimal? Tip_amount { get; set; }

        public decimal? Tolls_amount { get; set; }

        public decimal? Total_amount { get; set; }

        public decimal? Congestion_Surcharge { get; set; }

        public double? Airport_fee { get; set; }

    }
}
