using FrotaApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrotaApp.Application.DTOs.ClassDTOs
{
    public class CategoryDTO
    {
        public string CategoryName { get; set; }
        public static Category MapToEntity(CategoryDTO dto)
        {
            return new Category { CategoryName = dto.CategoryName };
        }
    }
}
