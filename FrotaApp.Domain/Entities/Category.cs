using FrotaApp.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrotaApp.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; private set; }
        public Category(string Category)
        {
            CategoryName = Category;
        }
    }
}
