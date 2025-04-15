using AutoMapper;
using scooter_api.Scooters.Dtos;
using scooter_api.Scooters.Exceptions;
using scooter_api.Scooters.Repository;

namespace scooter_api.Scooters.Service
{
    public class ScooterCommandService : IScooterCommandService
    {
        private readonly IScooterRepository _repo;
        private readonly IMapper _mapper;

        public ScooterCommandService(IScooterRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<ScooterResponse> AddScooter(AddScooterRequest req)
        {
            if (await _repo.FindScooterByBrandAsync(req.Brand) != null)
            {
                throw new BrandExistException();
            }

            var result = await _repo.CreateScooterAsync(req);
            return result;
        }

        public async Task<ScooterResponse> EditScooter(int id, EditScooterRequest req)
        {
            var existing = await _repo.FindScooterByIdAsync(id);
            if (existing == null)
            {
                throw new ScooterNotFoundException();
            }

            if (req.Brand != null)
            {
                var duplicate = await _repo.FindScooterByBrandAsync(req.Brand);
                if (duplicate != null && duplicate.Id != id)
                {
                    throw new BrandExistException();
                }
            }

            var result = await _repo.UpdateScooter(id, req);
            return result;
        }

        public async Task<ScooterResponse> DeleteScooterById(int id)
        {
            var existing = await _repo.FindScooterByIdAsync(id);
            if (existing == null)
            {
                throw new ScooterNotFoundException();
            }

            return await _repo.DeleteScooterById(id);
        }

        public async Task<List<ScooterResponse>> GetScootersByMinHorsePower(int minHP)
        {
            var list = await _repo.GetScootersByMinHP(minHP);
            if (list == null || list.Count == 0)
            {
                throw new ScooterNotFoundException();
            }

            return list;
        }

        public async Task<List<ScooterResponse>> GetScootersByMinSpeed(int minSpeed)
        {
            var list = await _repo.GetScootersByMinSpeed(minSpeed);
            if (list == null || list.Count == 0)
            {
                throw new ScooterNotFoundException();
            }

            return list;
        }

        public async Task<List<ScooterResponse>> GetScootersByBrand(string brand)
        {
            var list = await _repo.GetScootersByBrand(brand);
            if (list == null || list.Count == 0)
            {
                throw new ScooterNotFoundException();
            }

            return list;
        }

        public async Task<List<ScooterResponse>> GetScootersBySpeedRange(int minSpeed, int maxSpeed)
        {
            var list = await _repo.GetScooterByMinMaxSpeed(minSpeed, maxSpeed);
            if (list == null || list.Count == 0)
            {
                throw new ScooterNotFoundException();
            }

            return list;
        }
    }
}
