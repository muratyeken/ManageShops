using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageShops.Application.Extensions
{
    public class BirthDateExtension : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime birthDate = (DateTime)value;
                int result = DateTime.Now.Year - birthDate.Year;
                if (birthDate < DateTime.Now && result > 18)
                {
                    return ValidationResult.Success;
                }
            }

            return new ValidationResult(ErrorMessage);
        }
    }
}
