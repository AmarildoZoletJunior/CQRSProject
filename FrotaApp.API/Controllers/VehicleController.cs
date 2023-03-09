using FluentValidation;
using FluentValidation.Results;
using FrotaApp.Data.Repository;
using FrotaApp.Domain.Entities;
using FrotaApp.Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrotaApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository _vehicleRepository;
        public VehicleController(IVehicleRepository vehicle)
        {
            _vehicleRepository = vehicle;
        }

        [HttpPost]
        public async Task<IActionResult> PostTesteAsync(VehicleDTO vehicleDto)
        {
            var Vehicle = FrotaApp.Application.VehicleDTO.MapToEntity(vehicleDto);
            var validator = new VehicleValidator(_vehicleRepository);
            ValidationResult result = await validator.ValidateAsync(vehicleDto);
            if (!result.IsValid)
            {
                var failure = result.Errors.Select(x => new { x.ErrorMessage, x.PropertyName });
                return BadRequest(failure);
            }
            
           var number = await _vehicleRepository.AddVehicle(Vehicle);
            return Ok(Vehicle);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var total = await _vehicleRepository.GetVehicles();
            return Ok(total);
        }
    }
}
