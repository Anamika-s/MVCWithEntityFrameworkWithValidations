using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo3.Models
{
    public class RatingAttribute :ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                int? Rating = (int)value;
                if (Rating != null)
                {
                    if (Rating >= 10)
                        return ValidationResult.Success;
                }
            } 
        
        
           return new ValidationResult(ErrorMessage ?? "Rating should be more than 10");



            }

        }
    }
