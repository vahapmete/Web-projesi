using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class ProductViewModel:DbContext
    {
        public ProductViewModel(DbContextOptions<ProductViewModel> options) : base(options)
        {
        }
        public DbSet<Product>TblProducts { get; set; }
    }
}
