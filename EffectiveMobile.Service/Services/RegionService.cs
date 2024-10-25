using AutoMapper;
using EffectiveMobile.Data.IRepositories;
using EffectiveMobile.Domain.Entities;
using EffectiveMobile.Service.DTOs.Region;
using EffectiveMobile.Service.Exceptions;
using EffectiveMobile.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveMobile.Service.Services
{
    public class RegionService : IRegionService
    {
        private readonly IMapper _mapper;
        private readonly IRegionRepository _regionRepository;


        public RegionService(IRegionRepository regionRepository, IMapper mapper)
        {
            _mapper = mapper;
            _regionRepository = regionRepository;
        }
        public async Task<RegionForResultDto> CreateAsync(RegionForCreationDto dto)
        {
            var region = await _regionRepository.GetAll()
                .Where(x=>x.Name == dto.Name)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (region != null)
                throw new EffectiveMobileException(409, "Region is already exists");

            var mappedRegionData =  _mapper.Map<Region>(dto);
            return _mapper.Map<RegionForResultDto>(await _regionRepository.CreateAsync(mappedRegionData));
        }

        public async Task<bool> DeleteAsync(long id)
        {
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
            return _mapper.Map<IEnumerable<RegionForResultDto>>(_regionRepository.GetAll());
        }

        public async Task<RegionForResultDto> GetByIdAsync(long id)
        {
            var region = await _regionRepository.GetByIdAsync(id);
            if (region == null)
                throw new EffectiveMobileException(404, "Region is not found");

            return _mapper.Map<RegionForResultDto>(region);
        }

        public async Task<RegionForResultDto> UpdateAsync(long id ,RegionForUpdateDto dto)
        {
            var region = await _regionRepository.GetAll()
                .Where(x=>x.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (region == null)
                throw new EffectiveMobileException(404, "Region is not found");

            var mappedRegionData = _mapper.Map<Region>(dto);
            mappedRegionData.CreatedAtt = DateTime.UtcNow;

            return _mapper.Map<RegionForResultDto>(await _regionRepository.UpdateAsync(mappedRegionData));

        }
    }
}
