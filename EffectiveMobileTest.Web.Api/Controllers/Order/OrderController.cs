using EffectiveMobile.Service.DTOs.Order;
using EffectiveMobile.Service.Interfaces;
using EffectiveMobileTest.Web.Api.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace EffectiveMobileTest.Web.Api.Controllers.Order
{
    public class OrderController : BaseController
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(OrderForCreationDto dto)
            => Ok(new Response
            {
                StatusCode = 200,
                StatusMassage = "Ok",
                Data = await _orderService.CreateAsync(dto)
            });
      

        [HttpGet]
        public async Task<IActionResult>GetAllAync()
            =>Ok(new Response
            {
                StatusCode = 200,
                StatusMassage = "OK",
                Data = await _orderService.GetAllAsync()
                
            });

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(long id)
            => Ok(new Response
            {
                StatusCode = 200,
                StatusMassage = "OK",
                Data = await _orderService.GetByIdAsync(id)
            });


        [HttpPut("{id}")]
        public async Task<IActionResult> ModifyAsync(long id, OrderForUpdateDto dto)
            => Ok(new Response
            {
                StatusCode = 200,
                StatusMassage = "OK",
                Data = await _orderService.UpdateAsync(id, dto)
            });

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(long id)
            => Ok(new Response
            {
                StatusCode = 200,
                StatusMassage = "OK",
                Data = await _orderService.DeleteAsync(id)
            });


    }
}
