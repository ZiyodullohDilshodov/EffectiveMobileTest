using EffectiveMobile.Service.DTOs.Region;
using EffectiveMobile.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveMobile.Service.Services
{
    public class RegionService : IRegionService
    {
        public Task<RegionForResultDto> CreateAsync(RegionForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RegionForResultDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RegionForResultDto> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<RegionForResultDto> UpdateAsync(RegionForUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
