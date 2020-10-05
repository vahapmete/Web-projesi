using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contcrete.EntityFramework.Contexts
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;initial catalog=northwind;integrated security=true");
        }
        public DbSet<Register> Users { get; set; }
        public DbSet<Product> TblProducts { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
