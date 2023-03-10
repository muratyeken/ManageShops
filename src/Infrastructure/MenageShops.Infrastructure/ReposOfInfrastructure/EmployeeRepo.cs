using ManageShops.Domain.Entities;
using ManageShops.Domain.ReposOfDomain;
using MenageShops.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MenageShops.Infrastructure.ReposOfInfrastructure
{
    public class EmployeeRepo : BaseRepo<Employee>, IEmployeeRepo
    {
        public EmployeeRepo(MenageShopsDbContext menageShopsDbContext) : base(menageShopsDbContext)
        {
        }
    }
}
