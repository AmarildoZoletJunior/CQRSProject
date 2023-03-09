using FluentValidation.Results;
using FrotaApp.Application.Input.Commands.VehicleContext;
using FrotaApp.Application.Input.Receivers.Interfaces;
using FrotaApp.Domain.Entities;
using FrotaApp.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste.Validators;

namespace FrotaApp.Application.Input.Receivers
{
    public class InsertVehicleReceiver : IReceiver<VehicleCommand, Task<State>>
    {
        private readonly IVehicleRepository _vehicle;

        public InsertVehicleReceiver(IVehicleRepository vehicle)
        {
            _vehicle = vehicle;
        }
        public async Task<State> Action(VehicleCommand command)
        {
            var vehicle = new Vehicle
            {
                CategoryId = command.CategoryId,
                Color = command.Color,
                 ModelYear = command.ModelYear,
                  Name = command.Name,
                   NumberChassi = command.NumberChassi,
                    Price = command.Price,
                     Type = command.Type,
            };
            var validator = new VehicleValidator(_vehicle);
            ValidationResult result = await validator.ValidateAsync(vehicle);
            if (!result.IsValid)
            {
                var failure = result.Errors.Select(x => new { x.ErrorMessage, x.PropertyName });
                return new State
                {

                };
            }
            var number = await _vehicle.AddVehicle(vehicle);
            return new State
            {

            };
        }
    }
}
