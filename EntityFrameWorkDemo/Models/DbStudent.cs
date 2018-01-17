using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameWorkDemo.Models
{
    public class DbStudent : DbContext
    {
        public DbStudent() : base("studentconn")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DbStudent, EntityFrameWorkDemo.Migrations.Configuration>("studentconn"));
        }

        public DbSet<Student> Student { get; set; }
      //  public DbSet<Standard> Standard { get; set; }
    }
}