using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API_1.Entity
{
    public class EFContext : DbContext
    {
        public EFContext() : base("defaultConnection2")
        {
        }

        public DbSet<Blogger> bloggers { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}