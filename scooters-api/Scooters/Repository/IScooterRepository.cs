using scooter_api.Scooters.Dtos;

namespace scooter_api.Scooters.Repository
{
    public interface IScooterRepository
    {
        Task<List<ScooterResponse>> GetScootersAsync();
        Task<ScooterResponse> CreateScooterAsync(AddScooterRequest scooter);
        Task<ScooterResponse> DeleteScooterById(int id);
        Task<ScooterResponse> UpdateScooter(int id, EditScooterRequest scooterRequest);
        Task<ScooterResponse> FindScooterByIdAsync(int id);
        Task<ScooterResponse> FindScooterByBrandAsync(string brand);
        Task<List<ScooterResponse>> GetScootersByMinHP(int minHP);
        Task<List<ScooterResponse>> GetScootersByMinSpeed(int minSpeed);
        Task<List<ScooterResponse>> GetScootersByBrand(string brand);
        Task<List<ScooterResponse>> GetScooterByMinMaxSpeed(int minSpeed, int maxSpeed);
    }
}
