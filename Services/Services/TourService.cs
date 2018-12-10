using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DomainEntity.Entity;
using Microsoft.EntityFrameworkCore;
using Repository.Repository;
using Services.DTO;

namespace Services.Services
{
    public class TourService : ITourService
    {
        private readonly IRepository<Tour> _tourRepository;
        public TourService(IRepository<Tour> tourRepository)
        {
            _tourRepository = tourRepository;
        }
        public async Task<IList<Tour>> GetAllTourByParamsAsync(SearchOptionDTO searchOption)
        {
            return await (await _tourRepository.GetAllAsync()).ToListAsync();
        }
    }
}
