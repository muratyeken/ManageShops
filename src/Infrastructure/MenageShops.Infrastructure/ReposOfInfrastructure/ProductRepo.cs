using ManageShops.Domain.Entities;
using MenageShops.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MenageShops.Infrastructure.ReposOfInfrastructure
{
    public class ProductRepo : BaseRepo<Product>
    {
        public ProductRepo(MenageShopsDbContext menageShopDbContext) : base(menageShopDbContext)
        {
        }
    }
}
