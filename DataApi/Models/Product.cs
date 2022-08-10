using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataApi.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "The Product Name must be between 5 and 40 characters long.")]
        public string Productname { get; set; }

        public Category Category { get; set; }

        public Supplier Supplier { get; set; }
    }
}
