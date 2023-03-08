using FluentValidation;
using FrotaApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrotaApp.Application.Validators
{
    public class VehicleValidator : AbstractValidator<Vehicle>
    {
        public VehicleValidator()
        {
            RuleFor(x => x.Price).NotEmpty().NotNull();
            RuleFor(x => x.ModelYear).NotEmpty().NotNull();
            RuleFor(x => x.Name).NotEmpty().NotNull();
            RuleFor(x => x.CategoryId).NotEmpty().NotNull();
            RuleFor(x => x.Color).NotEmpty().NotNull();
            RuleFor(x => x.Type).NotEmpty().NotNull();
        }
    }
}
