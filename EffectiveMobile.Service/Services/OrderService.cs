using EffectiveMobile.Service.DTOs.Order;
using EffectiveMobile.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveMobile.Service.Services
{
    public class OrderService : IOrderService
    {
        public Task<OrderForResultDto> CreateAsync(OrderForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderForResultDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OrderForResultDto> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<OrderForResultDto> UpdateAsync(OrderForUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
