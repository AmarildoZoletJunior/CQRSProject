using FrotaApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrotaApp.Data.Mapping
{
    internal class VehicleMapping : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.Property(X => X.Id).ValueGeneratedOnAdd().IsRequired();
            builder.HasKey(x => x.Id);


            builder.Property(x => x.NumberChassi).IsRequired();
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.ModelYear).IsRequired();
            builder.Property(x => x.CategoryId).IsRequired();
            builder.Property(x => x.Color).IsRequired();
        }
    }
}
