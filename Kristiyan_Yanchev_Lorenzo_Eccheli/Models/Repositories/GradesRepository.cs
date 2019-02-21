using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class GradesRepository : IRepository<GradeRecord>
    {
        static ClassBookContext context = new ClassBookContext();

        public void Add(GradeRecord entity)
        {
            context.GradeRecords.Add(entity);
            context.SaveChanges();
        }

        public void Delete(GradeRecord entity)
        {
            context.GradeRecords.Remove(entity);
        }

        public void Edit(GradeRecord entity)
        {
            var result = context.GradeRecords.Single(x => x.Id == entity.Id);
            result = entity;
            context.SaveChanges();
        }

        public GradeRecord GetById(int id)
        {
            return context.GradeRecords.Single(x => x.Id == id);

        }

        public IEnumerable<GradeRecord> List()
        {
            return context.GradeRecords.ToList();

        }
    }
}
