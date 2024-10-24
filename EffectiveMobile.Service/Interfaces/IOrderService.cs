using EffectiveMobile.Service.DTOs.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveMobile.Service.Interfaces
{
    public  interface IOrderService
    {
        Task<bool> DeleteAsync(long id);
        Task<OrderForResultDto>GetByIdAsync(long id);
        Task<IEnumerable<OrderForResultDto>> GetAllAsync();
        Task<OrderForResultDto> CreateAsync(OrderForCreationDto dto);
        Task<OrderForResultDto> UpdateAsync(OrderForUpdateDto dto);
    }
}
