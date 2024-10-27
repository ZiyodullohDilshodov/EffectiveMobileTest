using AutoMapper;
using EffectiveMobile.Data.IRepositories;
using EffectiveMobile.Domain.Entities;
using EffectiveMobile.Service.DTOs.Region;
using EffectiveMobile.Service.Exceptions;
using EffectiveMobile.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EffectiveMobile.Service.Services
{
    public class RegionService : IRegionService
    {
        private readonly IMapper _mapper;
        private readonly IRegionRepository _regionRepository;
      


        public RegionService(IRegionRepository regionRepository, IMapper mapper, IOrderRepository orderRepository)
        {
            _mapper = mapper;
            _regionRepository = regionRepository;
        }
        public async Task<RegionForResultDto> CreateAsync(RegionForCreationDto dto)
        {
            if (dto.Name == null || dto.Name == " ")
                throw new EffectiveMobileException(400, "Region not found !!!!");

            var region = await _regionRepository.GetAll()
                .Where(x=>x.Name == dto.Name)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (region != null)
                throw new EffectiveMobileException(409, "Region is already exists");


            var mappedRegionData =  _mapper.Map<Region>(dto);
            mappedRegionData.CreatedAtt = DateTime.UtcNow;
            return _mapper.Map<RegionForResultDto>(await _regionRepository.CreateAsync(mappedRegionData));
        }

        public async Task<bool> DeleteAsync(long id)
        {
            if (id <= 0)
                throw new EffectiveMobileException(400, "Region id can not zero {0} !!!");

            var region = await _regionRepository.GetAll()
                .Where(x=>x.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (region == null)
                throw new EffectiveMobileException(404, "Region is not found");
           
            return await _regionRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<RegionForResultDto>> GetAllAsync()
        {
            var regions = await _regionRepository.GetAll()
                .Include(x => x.Orders)
                .AsNoTracking()
                .ToListAsync();

            return _mapper.Map<IEnumerable<RegionForResultDto>>(regions);
        }

        public async Task<RegionForResultDto> GetByIdAsync(long id)
        {
            if (id <= 0)
                throw new EffectiveMobileException(400, "Region id can not zero {0} !!!");

            var region = await _regionRepository.GetAll()
                .Where(x => x.Id == id)
                .Include(x => x.Orders)
                .AsNoTracking()
                .FirstOrDefaultAsync();
                
            if (region == null)
                throw new EffectiveMobileException(404, "Region is not found");

            return _mapper.Map<RegionForResultDto>(region);
        }

        public async Task<RegionForResultDto> UpdateAsync(long id ,RegionForUpdateDto dto)
        {
            if (id <= 0)
                throw new EffectiveMobileException(400, "Region id can not zero {0} !!!");

            if (dto.Name == null || dto.Name == " ")
                throw new EffectiveMobileException(400, "Region not found !!!");

            var region = await _regionRepository.GetAll()
                .Where(x=>x.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (region == null)
                throw new EffectiveMobileException(404, "Region is not found");

            var mappedRegionData = _mapper.Map(dto,region);
            mappedRegionData.CreatedAtt = DateTime.UtcNow;

            return _mapper.Map<RegionForResultDto>(await _regionRepository.UpdateAsync(mappedRegionData));
        }
    }
}
