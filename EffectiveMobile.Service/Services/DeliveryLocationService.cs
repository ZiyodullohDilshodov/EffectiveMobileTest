using AutoMapper;
using EffectiveMobile.Data.IRepositories;
using EffectiveMobile.Domain.Entities;
using EffectiveMobile.Service.DTOs.DeliveryLocation;
using EffectiveMobile.Service.Exceptions;
using EffectiveMobile.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveMobile.Service.Services
{
    
    public class DeliveryLocationService : IDeliveryLocationSerive
    {
        private readonly IMapper _mapper;
        private readonly IDeliveryLocationRepository _deliveryLocationRepository;
        
        public DeliveryLocationService(IMapper mapper, IDeliveryLocationRepository deliveryLocationRepository)
        {
            _mapper = mapper;
            _deliveryLocationRepository = deliveryLocationRepository;
        }
        
        public async Task<DeliveryLocationForResultDto> CreateAsync(DeliveryLocationForCreationDto dto)
        {
            var deliveryLocation = await _deliveryLocationRepository.GetAll()
                .Where(x=>x.Latitude == dto.Latitude && x.Longitude == dto.Longitude)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (deliveryLocation != null)
                throw new EffectiveMobileException(409, "Delivery Location is already exists ");

            var mappedDeliveryLocationData = _mapper.Map<DeliveryLocation>(dto);
            mappedDeliveryLocationData.CreatedAtt = DateTime.UtcNow;

            return _mapper.Map<DeliveryLocationForResultDto>(await _deliveryLocationRepository.CreateAsync(mappedDeliveryLocationData));


        }

        public async Task<bool> DeleteAsync(long id)
        {
            var DeliveryLocation = await _deliveryLocationRepository.GetAll()
                .Where(x => x.Id == id && x.IsDeleted == false)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (DeliveryLocation != null)
                throw new EffectiveMobileException(404, "DeliveryLocation is not found");
            var mappedDeliveryLocation =_mapper.Map<DeliveryLocation>(DeliveryLocation);
            mappedDeliveryLocation.IsDeleted = true;

            var DeliveryLocationInIsdeletedUpdated  = await _deliveryLocationRepository.UpdateAsync(mappedDeliveryLocation);

            if (DeliveryLocationInIsdeletedUpdated.IsDeleted != true)
                throw new EffectiveMobileException(400, "Delivery Location could not be deleted");
           
            return true;

        }

        public async Task<IEnumerable<DeliveryLocationForResultDto>> GetAllAsync()
        {
            var DeliveryLoctations = await  _deliveryLocationRepository.GetAll()
                .Where(x => x.IsDeleted == false)
                .AsNoTracking()
                .ToListAsync();

            return _mapper.Map<IEnumerable<DeliveryLocationForResultDto>>(DeliveryLoctations);
        }

        public async Task<DeliveryLocationForResultDto> GetByIdAsync(long id)
        {
            var deliveryLocation = await _deliveryLocationRepository.GetAll()
                .Where(x=>x.Id == id && x.IsDeleted == false)
                .AsNoTracking()
                .FirstOrDefaultAsync();
            if (deliveryLocation == null)
                throw new EffectiveMobileException(404, "DeliveryLocation is not found");

            return _mapper.Map<DeliveryLocationForResultDto>(deliveryLocation);

        }

        public async Task<DeliveryLocationForResultDto> UpdateAsync (long id ,DeliveryLocationForUpdateDto dto)
        {
            var deliveryLocation = await _deliveryLocationRepository.GetAll()
                .Where(x=>x.Id == id && x.IsDeleted == false)
                .AsNoTracking()
                .FirstOrDefaultAsync ();

            if (deliveryLocation == null)
                throw new EffectiveMobileException(404, "Delivery Location is not found");

            var deliveryLocationMapped = _mapper.Map<DeliveryLocation>(deliveryLocation);
            deliveryLocation.UpdatedAtt = DateTime.UtcNow;

            return _mapper.Map<DeliveryLocationForResultDto>(await _deliveryLocationRepository.UpdateAsync(deliveryLocationMapped));

        }
    }
}
