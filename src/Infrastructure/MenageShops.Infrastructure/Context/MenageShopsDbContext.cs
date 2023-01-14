using ManageShops.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenageShops.Infrastructure.Context
{
    public class MenageShopsDbContext : DbContext
    {
        public MenageShopsDbContext(DbContextOptions<MenageShopsDbContext> options) : base(options)
        {

        }

        public DbSet<Shop> Shops { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
