using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Test.Repositories
{
    class GradesTestRepository : GradesRepository
    {
        public override void Add(GradeRecord entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.GradeRecords.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Delete(GradeRecord entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.GradeRecords.Attach(entity);
                context.GradeRecords.Remove(entity);
                context.SaveChanges();
            }
        }

        public override void Edit(GradeRecord entity)
        {
            using (var context = new TestClassbookContext())
            {
                var result = context.GradeRecords.Single(x => x.Id == entity.Id);
                result.Date = entity.Date;
                result.Grade = entity.Grade;
                result.Student = entity.Student;
                result.StudentId = entity.StudentId;
                result.Subject = entity.Subject;
                context.SaveChanges();
            }
        }

        public override GradeRecord GetById(int id)
        {
            GradeRecord result;
            using (var context = new TestClassbookContext())
            {
                result = context.GradeRecords.Single(x => x.Id == id);
            }
            return result;
        }

        public override IEnumerable<GradeRecord> List()
        {
            List<GradeRecord> result;
            using (var context = new TestClassbookContext())
            {
                result = context.GradeRecords.ToList();
            }
            return result;
        }
    }
}
