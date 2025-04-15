using AutoMapper;
using scooter_api.Scooters.Dtos;
using scooter_api.Scooters.Repository;

namespace scooter_api.Scooters.Service
{
    public class ScooterQueryService
    {
        private readonly IScooterRepository _repo;
        private readonly IMapper _mapper;

        public ScooterQueryService(IScooterRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<List<ScooterResponse>> GetAllScooters()
        {
            var scooters = await _repo.GetScootersAsync();
            return _mapper.Map<List<ScooterResponse>>(scooters);
        }
    }
}
