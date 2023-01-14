using ManageShops.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenageShops.Infrastructure.EntityTypeConfiguration
{
    public class ShopConfig:BaseEntityConfig<Shop>
    {
        public override void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired(true);

            base.Configure(builder);
        }
    }
}
