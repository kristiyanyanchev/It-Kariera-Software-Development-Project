﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Data
{
    public class ClassBookContext : DbContext
    {
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<GradeRecord> GradeRecords { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Physician> Physicians { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Absences> Absences { get; set; }
        public DbSet<Responsibility> Responsibilities { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<Bonus> Bonuses { get; set; }
        public DbSet<AnnualLeave> AnnualLeaves { get; set; }
        public DbSet<SickLeave> SickLeaves { get; set; }

        private static string connectionString = "Server=.;Database=TestClassBook;Trusted_Connection=True;";
        public ClassBookContext() : base(connectionString)
        {

        }
    }
}
