using EffectiveMobile.Service.DTOs.OrderRegion;
using EffectiveMobile.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveMobile.Service.Services
{
    public class OrderRegionService : IOrderRegionService
    {
        public Task<OrderRegionForResultDto> CreateAsync(OrderRegionForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderRegionForResultDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OrderRegionForResultDto> GetByIdAsyc(long id)
        {
            throw new NotImplementedException();
        }

        public Task<OrderRegionForResultDto> UpdateAsync(OrderRegionForUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
