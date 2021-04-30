using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NET_3.Entity
{
    public class EFConext : DbContext
    {
        public EFConext() : base("name-defaultString1")
        {

        }
        public DbSet<Actor> Actors { get; set; }
    }
}