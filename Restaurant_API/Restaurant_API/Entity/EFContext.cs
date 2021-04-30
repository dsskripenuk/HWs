using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Entity
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
