using FrotaApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrotaApp.Domain.Interface
{
    public interface ICategoryRepository
    {
        public Task<List<Category>> GetCategories();
        public Task<int> AddCategory(Category category);
    }
}
