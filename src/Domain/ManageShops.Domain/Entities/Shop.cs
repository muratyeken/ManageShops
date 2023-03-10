using ManageShops.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageShops.Domain.Entities
{
    public class Shop : IBaseEntity
    {
        DateTime IBaseEntity.CreateDate { get; set; }
        DateTime? IBaseEntity.DeleteDate { get; set; }
        DateTime? IBaseEntity.UpdateDate { get; set; }
        Status IBaseEntity.Status { get; set; }
        public Guid ID { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }

        public Shop()
        {
            Employees = new List<Employee>();
        }
    }
}
