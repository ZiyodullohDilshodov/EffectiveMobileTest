using EffectiveMobile.Service.DTOs.DeliveryLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveMobile.Service.Interfaces
{
    public  interface IDeliveryLocationSerive 
    {
        Task<bool>DeleteAsync(long id);
        Task<DeliveryLocationForResultDto> GetByIdAsync(long id);
        Task<IEnumerable<DeliveryLocationForResultDto>> GetAllAsync();
        Task<DeliveryLocationForResultDto> UpdateAsync(long id,DeliveryLocationForUpdateDto dto);
        Task<DeliveryLocationForResultDto> CreateAsync(DeliveryLocationForCreationDto dto);
    }
}
