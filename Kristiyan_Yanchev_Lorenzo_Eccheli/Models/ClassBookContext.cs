using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;

namespace Data
{
    public class ClassBookContext : DbContext
    {
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<GradeRecord> GradeRecords { get; set; }
        public DbSet<Class> Classes { get; set; }  
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Absence> Absences { get; set; }
        public DbSet<ValidationCode> ValidationCodes { get; set; }

        private static string connectionString = "Server=.;Database=ClassBookDb;Trusted_Connection=True;";
        public ClassBookContext() : base(connectionString)
        {
            
        }

        public ClassBookContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }
        

    }
}
