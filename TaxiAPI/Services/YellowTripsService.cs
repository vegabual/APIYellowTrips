using TaxiAPI.DTO;
using TaxiAPI.Entities;
using TaxiAPI.Interfaces;
using TaxiAPI.Repositories;
using TaxiAPI.Utils;

namespace TaxiAPI.Services
{
    public class YellowTripsService : IYellowTripsService
    {
        IYellowTripsRepository _yellowTripRepository;

        public YellowTripsService(IYellowTripsRepository yellowTripRepository)
        {
            _yellowTripRepository = y;   
        }

        public IList<YellowTrip> GetYellowTripsFiltered(int limit, int offset, FilterDTO filter)
        {
            return _yellowTripRepository.GetTripsFiltered(limit, offset, filter);
        }
    }
}
