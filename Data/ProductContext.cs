using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SwaggerWithEfSupport.Models;

namespace SwaggerWithEfSupport.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext (DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public DbSet<SwaggerWithEfSupport.Models.Product> Product { get; set; }
    }
}
