using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NET_HW_2.Entity
{
    public class EFContext : DbContext
    {
        public EFContext() : base("name=defaultString")
        {

        }

        public DbSet<Card> Cards { get; set; }


        //public DbSet<Card> MyProperty { get; set; }
    }
}