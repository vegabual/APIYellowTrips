using Parquet.Serialization;
using TaxiAPI.DTO;
using TaxiAPI.Entities;
using TaxiAPI.Interfaces;

namespace TaxiAPI.Repositories
{
    public class YellowTripsRepository : IYellowTripsRepository
    {
        const string DATA_FILE_LOCATION = "./Data/yellow_tripdata_2024-01.parquet";


        private async Task<IList<YellowTrip>> GetData()
        {
            IList<YellowTrip> data = await ParquetSerializer.DeserializeAsync<YellowTrip>(DATA_FILE_LOCATION);

            return data;
        }

        public IList<YellowTrip> GetTripsFiltered(int limit, int offset, FilterDTO filter)
        {
            IList<YellowTrip> data = this.GetData().Result;
            var filteredData = data.Where(x =>
                (filter.Vendor is null || x.VendorID == (int)filter.Vendor) &&
                (filter.PickUpDateStart == null || x.tpep_pickup_datetime > filter.PickUpDateStart) &&
                (filter.PickUpDateEnd == null || x.tpep_pickup_datetime < filter.PickUpDateEnd) &&
                (filter.DropOffStart == null || x.tpep_dropoff_datetime > filter.DropOffStart) &&
                (filter.DropOffEnd == null || x.tpep_dropoff_datetime < filter.DropOffEnd) &&
                (filter.RateCode == null || x.RatecodeID == (int)filter.RateCode) &&
                (filter.PaymentType == null || x.Payment_type == (int)filter.PaymentType)
            ).Skip(offset).Take(limit).ToList();

            return filteredData;
        }

    }
}
