using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class GradesRepository : IRepository<GradeRecord>
    {
        
        public virtual void Add(GradeRecord entity)
        {
            using (var context = new ClassBookContext())
            {
                context.GradeRecords.Add(entity);
                context.SaveChanges();
            }
            
        }

        public virtual void Delete(GradeRecord entity)
        {
            using (var context = new ClassBookContext())
            {
                context.GradeRecords.Attach(entity);
                context.GradeRecords.Remove(entity);
                context.SaveChanges();
            }
            
        }

        public virtual void Edit(GradeRecord entity)
        {
            using (var context = new ClassBookContext())
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

        public virtual GradeRecord GetById(int id)
        {
            GradeRecord result;
            using (var context = new ClassBookContext())
            {
                result = context.GradeRecords.Single(x => x.Id == id);
            }
            return result;

        }

        public virtual IEnumerable<GradeRecord> List()
        {
            List<GradeRecord> result;
            using (var context = new ClassBookContext())
            {
                result = context.GradeRecords.ToList();
            }
            return result;

        }
    }
}
