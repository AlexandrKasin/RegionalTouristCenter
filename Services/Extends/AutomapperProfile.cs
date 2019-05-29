using AutoMapper;
using DomainEntity.Entity.Tour;
using DomainEntity.Entity.User;
using Services.DTO.Tour;
using Services.DTO.User;

namespace Services.Extends
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<UserRegistrationDTO, User>();

            CreateMap<DatesPricesDTO, DatesPrices>();
            CreateMap<LanguageDTO, Language>();
            CreateMap<TourDescriptionDTO, TourDescription>();
            CreateMap<TourDTO, Tour>();
            CreateMap<TourImagesDTO, TourImages>();
            CreateMap<TourItineraryDTO, TourItinerary>();
        }
    }
}