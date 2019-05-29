using System.Threading.Tasks;
using Services.DTO.Tour;

namespace Services.Services.TourService
{
    public interface ITourService
    {
        Task CreateTourAsync(TourDTO tour);
    }
}