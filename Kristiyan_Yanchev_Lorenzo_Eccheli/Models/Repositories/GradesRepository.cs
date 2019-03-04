using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class GradesRepository : IRepository<GradeRecord>
    {
        
        public void Add(GradeRecord entity)
        {
            using (var context = new ClassBookContext())
            {
                context.GradeRecords.Add(entity);
                context.SaveChanges();
            }
            
        }

        public void Delete(GradeRecord entity)
        {
            using (var context = new ClassBookContext())
            {
                context.GradeRecords.Remove(entity);
            }
            
        }

        public void Edit(GradeRecord entity)
        {
            using (var context = new ClassBookContext())
            {
                var result = context.GradeRecords.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
           
        }

        public GradeRecord GetById(int id)
        {
            GradeRecord result;
            using (var context = new ClassBookContext())
            {
                result = context.GradeRecords.Single(x => x.Id == id);
            }
            return result;

        }

        public IEnumerable<GradeRecord> List()
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
