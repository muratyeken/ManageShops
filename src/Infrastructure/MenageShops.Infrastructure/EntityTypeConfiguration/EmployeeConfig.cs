using ManageShops.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenageShops.Infrastructure.EntityTypeConfiguration
{
    public class EmployeeConfig:BaseEntityConfig<Employee>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired(true);

            builder.HasOne(x => x.Shop)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.ShopID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Employees)
                .WithOne(x => x.Manager)
                .HasForeignKey(x => x.ManagerID)
                .OnDelete(DeleteBehavior.Restrict);

            base.Configure(builder);
        }
    }
}
