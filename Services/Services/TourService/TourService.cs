using System.Threading.Tasks;
using AutoMapper;
using DomainEntity.Entity.Tour;
using Repository.Repository;
using Services.DTO.Tour;

namespace Services.Services.TourService
{
    public class TourService : ITourService
    {
        private readonly IRepository<Tour> _tourRepository;
        private readonly IMapper _mapper;

        public TourService(IRepository<Tour> tourRepository, IMapper mapper)
        {
            _tourRepository = tourRepository;
            _mapper = mapper;
        }

        public async Task CreateTourAsync(TourDTO tourDTO)
        {
            var tour = _mapper.Map<Tour>(tourDTO);
            await _tourRepository.InsertAsync(tour);
        }
    }
}