using BenchmarkDotNet.Toolchains.Roslyn;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Quiz.Entity
{
    public class EFConext : DbContext
    {
        public EFConext() : base("name-defaultString3")
        {

        }

        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}