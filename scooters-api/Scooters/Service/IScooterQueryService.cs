using scooter_api.Scooters.Dtos;

namespace scooter_api.Scooters.Service
{
    public interface IScooterQueryService
    {
        Task<List<ScooterResponse>> GetAllScooters();

    }
}
