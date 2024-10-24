using EffectiveMobile.Service.DTOs.DeliveryLocation;
using EffectiveMobile.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveMobile.Service.Services
{
    public class DeliveryLocationService : IDeliveryLocationSerive
    {
        public Task<DeliveryLocationForResultDto> CreateAsync(DeliveryLocationForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DeliveryLocationForResultDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DeliveryLocationForResultDto> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<DeliveryLocationForResultDto> UpdateAsync(DeliveryLocationForUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
