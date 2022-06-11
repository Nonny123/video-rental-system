using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VRSWeb.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
                                     //gives access to the containing class (e.g customer)
            var customer = (Customer) validationContext.ObjectInstance;

            if(customer.MembershipTypeId == 1)
                return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("Birthdate is required.");

        }
    }
}