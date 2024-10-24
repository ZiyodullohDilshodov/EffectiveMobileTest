using EffectiveMobile.Service.DTOs.Order;
using EffectiveMobile.Service.DTOs.OrderRegion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveMobile.Service.Interfaces
{
    public  interface IOrderRegionService
    {
        Task<bool> DeleteAsync(long id);
        Task<OrderRegionForResultDto>GetByIdAsyc(long id);
        Task<IEnumerable<OrderRegionForResultDto>> GetAllAsync();
        Task<OrderRegionForResultDto>CreateAsync(OrderRegionForCreationDto dto);
        Task<OrderRegionForResultDto> UpdateAsync(OrderRegionForUpdateDto dto);
    }
}
