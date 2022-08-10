using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataApi.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }

        [Required]
        [Display(Name = "Company Name")]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "The Company Name must be between 5 and 40 characters long.")]
        public string CompanyName { get; set; }

        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }

        public string Phone { get; set; }
    }
}
