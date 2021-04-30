using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NET_Practice_4.Entity
{
    public class EFConext : DbContext
    {
        public EFConext() : base("name-defaultString2")
        {

        }

        public DbSet<Character> Actors { get; set; }
        public DbSet<Animes> Anime { get; set; }
        public DbSet<Films> Film { get; set; }
        public DbSet<Arts> Art { get; set; }



    }
}