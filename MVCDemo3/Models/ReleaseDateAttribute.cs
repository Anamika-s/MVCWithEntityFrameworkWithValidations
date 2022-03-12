using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo3.Models
{
    public class ReleaseDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime? date = Convert.ToDateTime(value);
                if(date!=null)
                {
                    if (date >= DateTime.UtcNow)
                    {
                        return ValidationResult.Success;
                    }

                }
            }
            return new ValidationResult(ErrorMessage ?? "Make sure your date is >= than today");
        }
    }
}
