using EffectiveMobile.Service.DTOs.Region;
using EffectiveMobile.Service.Interfaces;
using EffectiveMobileTest.Web.Api.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace EffectiveMobileTest.Web.Api.Controllers.Region
{
    public class RegionController : BaseController
    {
        private readonly IRegionService _regionService;

        public RegionController(IRegionService regionService)
        {
            _regionService = regionService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(RegionForCreationDto dto)
            => Ok(new Response
            {
                StatusCode = 200,
                StatusMassage = "Ok",
                Data = await _regionService.CreateAsync(dto)
            });

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
            => Ok(new Response
            {
                StatusCode = 200,
                StatusMassage = "ok",
                Data = await _regionService.GetAllAsync()
            });

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(long id)
            => Ok(new Response
            {
                StatusCode = 200,
                StatusMassage = "ok",
                Data = await _regionService.GetByIdAsync(id)
            });

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(long id, RegionForUpdateDto dto)
            => Ok(new Response
            {
                StatusCode = 200,
                StatusMassage = "ok",
                Data = await _regionService.UpdateAsync(id, dto)
            });

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(long id)
            => Ok(new Response
            {
                StatusCode = 200,
                StatusMassage = "Ok",
                Data = await _regionService.DeleteAsync(id)
            });
    }
}
