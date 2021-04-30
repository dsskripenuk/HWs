using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NET_4.Entity
{
    public class EFContext : DbContext
    {
        public EFContext() : base("name=DBModel")
        {

        }

        public DbSet<Games> Games { get; set; }
    }
}