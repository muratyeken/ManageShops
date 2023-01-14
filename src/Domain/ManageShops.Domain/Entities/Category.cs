using ManageShops.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageShops.Domain.Entities
{
    public class Category : IBaseEntity
    {
        public DateTime CreateDate { get; set;}
        public DateTime? DeleteDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Status Status { get; set; }
        public Guid ID { get; set; }
        public string CategoryName { get; set; }
        public List<Product> Products { get; set; }

        public Category()
        {
            Products = new List<Product>();
        }
    }
}
