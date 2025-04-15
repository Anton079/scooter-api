using AutoMapper;
using scooter_api.Scooters.Models;
using scooter_api.Scooters.Dtos;

namespace scooter_api.Scooters.Mappers
{
    public class ScooterMappingProfile : Profile
    {
        public ScooterMappingProfile()
        {
            CreateMap<AddScooterRequest, Scooter>();
            CreateMap<EditScooterRequest, Scooter>();
            CreateMap<Scooter, ScooterResponse>();
        }
    }
}
