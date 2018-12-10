using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DomainEntity.Entity;
using Services.DTO;

namespace Services.Services
{
    public interface ITourService
    {
        Task<IList<Tour>> GetAllTourByParamsAsync(SearchOptionDTO searchOption);
    }
}
