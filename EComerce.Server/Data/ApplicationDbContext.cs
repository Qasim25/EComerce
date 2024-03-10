using EComerce.Server.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EComerce.Server.Data
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
