using EffectiveMobile.Data.IRepositories;
using EffectiveMobile.Service.DTOs.DeliveryLocation;
using EffectiveMobile.Service.Interfaces;
using EffectiveMobileTest.Web.Api.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace EffectiveMobileTest.Web.Api.Controllers.DeliveryLocation
{
    public class DeliveryLocationController : BaseController
    {
        private readonly IDeliveryLocationSerive _locationService;

        public DeliveryLocationController(IDeliveryLocationSerive locationService)
        {
            _locationService = locationService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(DeliveryLocationForCreationDto dto)
            => Ok(new Response
            {
                StatusCode = 200,
                StatusMassage = "Ok",
                Data = await _locationService.CreateAsync(dto)
            });

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
            => Ok(new Response
            {
                StatusCode = 200,
                StatusMassage = "OK",
                Data = await _locationService.GetAllAsync()
            });

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(long id)
            => Ok(new Response
            {
                StatusCode = 200,
                StatusMassage = "OK",
                Data = await _locationService.GetByIdAsync(id)
            });

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(long id, DeliveryLocationForUpdateDto dto)
            => Ok(new Response
            {
                StatusCode = 200,
                StatusMassage = "OK",
                Data = await _locationService.UpdateAsync(id, dto)
            });

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(long id)
            => Ok(new Response
            {
                StatusCode = 200,
                StatusMassage = "OK",
                Data = await _locationService.DeleteAsync(id)
            });
    }

}
