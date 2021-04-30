using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace University_HW.Entity
{
    public class EFContext : DbContext
    {
        public EFContext() : base("name-universityString")
        {

        }

    }
}