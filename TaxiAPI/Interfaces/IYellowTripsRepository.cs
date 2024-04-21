using TaxiAPI.DTO;
using TaxiAPI.Entities;

namespace TaxiAPI.Interfaces
{
    public interface IYellowTripsRepository
    {
        IList<YellowTrip> GetTripsFiltered(int limit, int offset, FilterDTO filter);
    }
}
