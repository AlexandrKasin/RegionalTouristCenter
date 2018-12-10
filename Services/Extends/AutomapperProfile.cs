using AutoMapper;
using DomainEntity.Entity;
using Services.DTO;

namespace Services.Extends
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<UserRegistrationDto, User>();
          
        }
    }
}
