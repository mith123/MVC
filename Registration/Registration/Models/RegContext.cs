using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Registration.Models
{
    public class RegContext:DbContext
    {
        public RegContext(): base("Regnew")
        {
            DropCreateDatabaseIfModelChanges<RegContext> r = new DropCreateDatabaseIfModelChanges<RegContext>();
            Database.SetInitializer<RegContext>(r);
        }
        public DbSet<Login1> Login1s { get; set; }
        public DbSet<Reg> Regs { get; set; }

        public DbSet<Dept> Depts { get; set; }
    }
}  