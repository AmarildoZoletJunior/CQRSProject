using FluentValidation;
using FrotaApp.Application.DTOs.ClassDTOs;
using FrotaApp.Domain.Entities;
using FrotaApp.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.Validators
{
    public class VehicleValidator : AbstractValidator<Vehicle>
    {
        private readonly IVehicleRepository _vehicleRepository;
        public VehicleValidator(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
            RuleFor(x => x.Price).NotEmpty().NotNull();
            RuleFor(x => x.ModelYear).NotEmpty().NotNull();
            RuleFor(x => x.Name).NotEmpty().NotNull().Length(2, 250);
            RuleFor(x => x.CategoryId).NotEmpty().NotNull();
            RuleFor(x => x.Color).NotEmpty().NotNull();
            RuleFor(x => x.Type).NotEmpty().NotNull();
            RuleFor(x => x.NumberChassi).NotEmpty().WithMessage("O campo NumberChassi não pode ser vazio").NotNull().WithMessage("O campo NumberChassi não pode ser null").MustAsync(VerificarExisteNumeroCadastrado).WithMessage("Ja existe um carro com este chassi cadastrado");
        }

        private async Task<bool> VerificarExisteNumeroCadastrado(int chassi, CancellationToken cancellationToken)
        {
            var pesquisa = await _vehicleRepository.GetVehicleForChassi(chassi);
            if (pesquisa == null) return true;
            return false;
        }
    }
}
