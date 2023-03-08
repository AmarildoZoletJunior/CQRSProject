using FrotaApp.Data.Context;
using FrotaApp.Domain.Entities;
using FrotaApp.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrotaApp.Data.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly FrotaContext context;
        public CategoryRepository(FrotaContext _context)
        {
            context = _context;
        }
        public async Task<int> AddCategory(Category category)
        {
                await context.Categories.AddAsync(category);
                await context.SaveChangesAsync();
                return category.Id;
        }

        public async Task<List<Category>> GetCategories()
        {
            return await context.Categories.ToListAsync();
        }
    }
}
