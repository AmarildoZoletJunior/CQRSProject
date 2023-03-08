using FrotaApp.Domain.Entities;
using FrotaApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrotaApp.Application.DTOs.ClassDTOs
{
    public class VehicleDTO
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int ModelYear { get; set; }
        public int CategoryId { get; set; }
        public double Price { get; set; }
        public EVehicleType Type { get; set; }
        public int NumberChassi { get; set; }

        public static Vehicle MapToEntity(VehicleDTO dto)
        {
            return new Vehicle{  Name = dto.Name,  Color = dto.Color,  ModelYear = dto.ModelYear,  CategoryId =  dto.CategoryId,  Price = dto.Price,  Type = dto.Type, NumberChassi = dto.NumberChassi};
        }
    }
}
