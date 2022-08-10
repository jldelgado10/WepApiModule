using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientSample.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Productname { get; set; }

        public Category Category { get; set; }

        public Supplier Supplier { get; set; }
    }
}
