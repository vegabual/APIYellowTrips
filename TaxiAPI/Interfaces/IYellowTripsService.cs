using TaxiAPI.DTO;
using TaxiAPI.Entities;

namespace TaxiAPI.Interfaces
{
    public interface IYellowTripsService
    {
        IList<YellowTrip> GetYellowTripsFiltered(int limit, int offset, FilterDTO filter);
    }
}
