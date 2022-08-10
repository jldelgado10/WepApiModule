using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataApi.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        [Display(Name = "Category Name")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "The Category Name must be between 5 and 15 characters long.")]
        public string CategoryName { get; set; }

        public string Description { get; set; }
    }
}
