using ManageShops.Application.Extensions;
using ManageShops.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageShops.Application.Models.DTOs
{
    public class AddManagerDTO
    {
        public Guid Id => Guid.NewGuid();

        [Required(ErrorMessage = "Cannot be Empty")]
        [MaxLength(25, ErrorMessage = "You Cannot Enter More Than 25 Characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Cannot be Empty")]
        [MaxLength(50, ErrorMessage = "You Cannot Enter More Than 50 Characters")]
        public string Surname { get; set; }
        public DateTime CreateDate => DateTime.Now;

        [BirthDateExtension(ErrorMessage = "The age of the employee must be over 18")]
        public DateTime BirthDate { get; set; }
        public Status Status => Status.Active;
        public Roles Roles => Roles.Manager;
        public string EmailAddress { get; set; }
        public string Password { get; set; }

        public string? ImagePath { get; set; }

        [ImageExtension]
        public IFormFile UploadPath { get; set; }
    }
}
