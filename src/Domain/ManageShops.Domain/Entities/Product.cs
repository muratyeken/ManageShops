﻿using ManageShops.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageShops.Domain.Entities
{
    public class Product : IBaseEntity
    {
        public DateTime CreateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Status Status { get; set; }

        public Guid ID { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public string ImagePath { get; set; }
        [NotMapped]
        public IFormFile UploadPath { get; set; }

        public List<Category> Categories { get; set; }
        public Product()
        {
            Categories = new List<Category>();
        }
    }
}
