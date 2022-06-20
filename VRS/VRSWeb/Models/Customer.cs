using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VRSWeb.Models
{
    public class Customer
    {
        public int Id { get; set; } 
        
        [Required(ErrorMessage = "Please enter customer's name")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; } //nav property - for loading an object and its related object
        
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; } //FK for when the FKID only is needed and not the related object
    }
}