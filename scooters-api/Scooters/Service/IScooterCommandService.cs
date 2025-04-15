using scooter_api.Scooters.Dtos;

namespace scooter_api.Scooters.Service
{
    public interface IScooterCommandService
    {
        Task<ScooterResponse> AddScooter(AddScooterRequest req);
        Task<ScooterResponse> EditScooter(int id, EditScooterRequest req);
        Task<ScooterResponse> DeleteScooterById(int id);
        Task<List<ScooterResponse>> GetScootersByMinHorsePower(int minHP);
        Task<List<ScooterResponse>> GetScootersByMinSpeed(int minSpeed);
        Task<List<ScooterResponse>> GetScootersByBrand(string brand);
        Task<List<ScooterResponse>> GetScootersBySpeedRange(int minSpeed, int maxSpeed);
    }
}
