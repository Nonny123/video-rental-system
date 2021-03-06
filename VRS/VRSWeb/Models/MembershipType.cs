using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VRSWeb.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }

        public short SignUpFee { get; set; }

        public byte DurationInMonths { get; set; }

        public byte DiscountRate { get; set; }

        //to prevent use of magic numbers
        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}