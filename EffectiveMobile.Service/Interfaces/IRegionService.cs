using EffectiveMobile.Service.DTOs.Region;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveMobile.Service.Interfaces
{
    public  interface IRegionService
    {
        Task<bool> DeleteAsync(long id);
        Task<RegionForResultDto>GetByIdAsync(long id);
        Task<IEnumerable<RegionForResultDto>> GetAllAsync();
        Task<RegionForResultDto>UpdateAsync(long id ,RegionForUpdateDto dto);
        Task<RegionForResultDto>CreateAsync(RegionForCreationDto dto);

    }
}
