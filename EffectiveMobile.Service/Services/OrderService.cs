using AutoMapper;
using EffectiveMobile.Data.IRepositories;
using EffectiveMobile.Domain.Entities;
using EffectiveMobile.Service.DTOs.Order;
using EffectiveMobile.Service.Exceptions;
using EffectiveMobile.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EffectiveMobile.Service.Services
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;
        private readonly IRegionRepository _regionRepository;


        public OrderService(IOrderRepository orderRepository, IMapper mapper,
                             IRegionRepository regionRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
            _regionRepository = regionRepository;
        }
        public async Task<OrderForResultDto> CreateAsync(OrderForCreationDto dto)
        {
            if (dto.Weight < 0)
                throw new EffectiveMobileException(400, "Order Weight < 0");

            var region = await _regionRepository.GetAll()
                .Where(x=>x.Id == dto.RegionId)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (region == null)
                throw new EffectiveMobileException(404, "Region is not found");

            
            var updateRegionNumberOfOrders = _mapper.Map<Region>(region);
            var oldRegionNumberOfOrder = updateRegionNumberOfOrders.NumberOfOrders;
            updateRegionNumberOfOrders.NumberOfOrders++;

            var updateRegionNumberOfOrder = await _regionRepository.UpdateAsync(updateRegionNumberOfOrders);
            //check Region number of order 
            if (oldRegionNumberOfOrder >= updateRegionNumberOfOrder.NumberOfOrders)
                throw new EffectiveMobileException(400, "Region number of Order not be Updated");

            var mappedOrder = _mapper.Map<Order>(dto);
            mappedOrder.DeliveryTime = DateTime.UtcNow.AddDays(1);
            mappedOrder.CreatedAtt = DateTime.UtcNow;

            return _mapper.Map<OrderForResultDto>(await _orderRepository.CreateAsync(mappedOrder));


        }

        public async Task<bool> DeleteAsync(long id)
        {
            var order  = await _orderRepository.GetAll()
                .Where(x=>x.Id==id)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (order == null)
                throw new EffectiveMobileException(404, "Order is not found");

            var mappedOrder = _mapper.Map<Order>(order);
            mappedOrder.IsDeleted = true;

            var updateOrderInIsDeleted = await _orderRepository.UpdateAsync(mappedOrder);
            if (updateOrderInIsDeleted.IsDeleted != true)
                throw new EffectiveMobileException(400, "Order could not be deleted!!!");

            return true;
        }

        public async Task<IEnumerable<OrderForResultDto>> GetAllAsync()
        {
            var orders = await _orderRepository.GetAll()
                .Where(x => x.IsDeleted == false)
                .Include(x=>x.Locations)
                .AsNoTracking()
                .ToListAsync();

            return _mapper.Map<IEnumerable<OrderForResultDto>>(orders);
        }

        public async Task<OrderForResultDto> GetByIdAsync(long id)
        {
            var order = await _orderRepository.GetAll()
                .Where (x => x.Id==id && x.IsDeleted == false)
                .Include(x=>x.Region)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (order == null)
                throw new EffectiveMobileException(404, "Order is not found");

            return _mapper.Map<OrderForResultDto>(order);
        }

        public async Task<OrderForResultDto> UpdateAsync(long id,OrderForUpdateDto dto)
        {
            var order = await _orderRepository.GetAll()
                .Where(x => x.Id == id && x.IsDeleted == false)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (order == null)
                throw new EffectiveMobileException(404, "Order is not found");

            var mappedOrderData = _mapper.Map(dto,order);
            mappedOrderData.UpdatedAtt = DateTime.UtcNow;

            return _mapper.Map<OrderForResultDto>(await _orderRepository.UpdateAsync(mappedOrderData));
        }
    }
}
