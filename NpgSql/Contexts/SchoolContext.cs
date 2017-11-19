using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NpgSql.Contexts
{
    using System.Data.Entity;

    using NpgSql.Models;

    public class SchoolContext : DbContext
    {
        public SchoolContext()
            : base("name=dbTestConnectionString")
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Standard> Standards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // PostgreSQL uses the public schema by default - not dbo.
            Console.WriteLine("HEI HI");
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }

    }
}
