using ManageShops.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageShops.Domain.Entities
{
    public class Employee : IBaseEntity
    {
        public DateTime CreateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Status Status { get; set; }
        public Roles Roles { get; set; }
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }        

        public string EmailAddress { get; set; }

        public string Password { get; set; }
        public string? ImagePath { get; set; }
        [NotMapped]
        public IFormFile UploadPath { get; set; }

        //Navigation Property
        public Guid? ShopID { get; set; }
        public Shop? Shop { get; set; }


        //Navigation Property For Managers
        public Guid? ManagerID { get; set; }
        public Employee? Manager { get; set; }


        public List<Employee> Employees { get; set; }

        public Employee()
        {
            Employees = new List<Employee>();
        }

    }
}
