using AutoMapper;
using scooter_api.Scooters.Dtos;
using scooter_api.Scooters.Models;
using scooters_api.Data.Migrations;
using System.Data.Entity;

namespace scooter_api.Scooters.Repository
{
    public class ScooterRepository : IScooterRepository
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ScooterRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ScooterResponse>> GetScootersAsync()
        {
            var scooters = await _context.Scooter.ToListAsync();
            return _mapper.Map<List<ScooterResponse>>(scooters);
        }

        public async Task<ScooterResponse> CreateScooterAsync(AddScooterRequest req)
        {
            var scooter = _mapper.Map<Scooter>(req);
            _context.Scooter.Add(scooter);
            await _context.SaveChangesAsync();
            return _mapper.Map<ScooterResponse>(scooter);
        }

        public async Task<ScooterResponse> DeleteScooterById(int id)
        {
            var scooter = await _context.Scooter.FindAsync(id);
            if (scooter == null) return null;
            _context.Scooter.Remove(scooter);
            await _context.SaveChangesAsync();
            return _mapper.Map<ScooterResponse>(scooter);
        }

        public async Task<ScooterResponse> UpdateScooter(int id, EditScooterRequest req)
        {
            var scooter = await _context.Scooter.FindAsync(id);
            if (scooter == null) return null;

            scooter.brand = req.Brand ?? scooter.brand;
            scooter.modelType = req.ModelType ?? scooter.modelType;
            scooter.horsePower = req.HorsePower ?? scooter.horsePower;
            scooter.range = req.Range ?? scooter.range;
            scooter.maxSpeed = req.MaxSpeed ?? scooter.maxSpeed;

            _context.Scooter.Update(scooter);
            await _context.SaveChangesAsync();

            return _mapper.Map<ScooterResponse>(scooter);
        }

        public async Task<ScooterResponse> FindScooterByIdAsync(int id)
        {
            var scooter = await _context.Scooter.FirstOrDefaultAsync(s => s.id == id);
            return _mapper.Map<ScooterResponse>(scooter);
        }

        public async Task<ScooterResponse> FindScooterByBrandAsync(string brand)
        {
            var scooter = await _context.Scooter.FirstOrDefaultAsync(s => s.brand == brand);
            return _mapper.Map<ScooterResponse>(scooter);
        }

        public async Task<List<ScooterResponse>> GetScootersByMinHP(int minHP)
        {
            var scooters = await _context.Scooter.Where(s => s.horsePower >= minHP).ToListAsync();
            return _mapper.Map<List<ScooterResponse>>(scooters);
        }

        public async Task<List<ScooterResponse>> GetScootersByMinSpeed(int minSpeed)
        {
            var scooters = await _context.Scooter.Where(s => s.maxSpeed >= minSpeed).ToListAsync();
            return _mapper.Map<List<ScooterResponse>>(scooters);
        }

        public async Task<List<ScooterResponse>> GetScootersByBrand(string brand)
        {
            var scooters = await _context.Scooter.Where(s => s.brand == brand).ToListAsync();
            return _mapper.Map<List<ScooterResponse>>(scooters);
        }

        public async Task<List<ScooterResponse>> GetScooterByMinMaxSpeed(int minSpeed, int maxSpeed)
        {
            var scooters = await _context.Scooter
                .Where(s => s.maxSpeed >= minSpeed && s.maxSpeed <= maxSpeed).ToListAsync();
            return _mapper.Map<List<ScooterResponse>>(scooters);
        }


    }
}
