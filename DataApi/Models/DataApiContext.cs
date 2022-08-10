using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataApi.Models
{
    public class DataApiContext : DbContext
    {
        public DataApiContext(DbContextOptions<DataApiContext> options)
            : base(options)
        {
        }

        public DbSet<DataApi.Models.Category> Category { get; set; }

        public DbSet<DataApi.Models.Product> Product { get; set; }

        public DbSet<DataApi.Models.Supplier> Supplier { get; set; }
    }
}
