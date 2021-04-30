using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NET_2.Enitity
{
    public class EFContext : DbContext
    {
        public EFContext() : base("name=defaultString")
        {

        }

        public DbSet<Student> Students { get; set; }


        public DbSet<Student> MyProperty { get; set; }
    }
}