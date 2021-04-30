using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Quiz_HW.Entity
{
    public class EFContext : DbContext
    {
        public EFContext() : base("name-defaultString4")
        {

        }

        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }
    }
}