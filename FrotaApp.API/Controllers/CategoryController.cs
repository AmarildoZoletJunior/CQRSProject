using FluentValidation;
using FluentValidation.Results;
using FrotaApp.Application.DTOs.ClassDTOs;
using FrotaApp.Application.Validators;
using FrotaApp.Data.Repository;
using FrotaApp.Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace FrotaApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository category)
        {
            _categoryRepository = category;
        }

        [HttpPost]
        public async Task<IActionResult> PostTesteAsync([Required][FromBody]CategoryDTO categoryDto)
        {
            var category = CategoryDTO.MapToEntity(categoryDto);
            var validator = new CategoryValidator();
            ValidationResult result = await validator.ValidateAsync(category);
            if (!result.IsValid)
            {
                var failure = result.Errors.Select(x => new { x.ErrorMessage, x.PropertyName });
                return BadRequest(failure);
            }

            var number = await _categoryRepository.AddCategory(category);
            return Ok(category);
        }
    }
}
