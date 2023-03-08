using FrotaApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrotaApp.Data.Context
{
    public class FrotaContext : DbContext
    {
        public FrotaContext(DbContextOptionsBuilder<FrotaContext> options)
        {
            options.UseInMemoryDatabase(databaseName: "FrotaDb");
        }
        public DbSet<Category> Categories  { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
