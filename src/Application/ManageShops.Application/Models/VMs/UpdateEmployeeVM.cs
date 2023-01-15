using ManageShops.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageShops.Application.Models.VMs
{
    public class UpdateEmployeeVM
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? UpdatedDate => DateTime.Now;
        public Status Status => Status.Modified;
        public Roles Roles => Roles.Personnel;
        public string? ImagePath { get; set; }
        public IFormFile UploadPath { get; set; }
    }
}
