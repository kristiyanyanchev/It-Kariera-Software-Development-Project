using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Test.Repositories
{
    public class AbsenceTestRepository : AbsencesRepository
    {
        //new TestClassbookContext()
        public override void Add(Absence entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.Absences.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Delete(Absence entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.Absences.Attach(entity);
                context.Absences.Remove(entity);
                context.SaveChanges();
            }
        }

        public override void Edit(Absence entity)
        {
            using (var context = new TestClassbookContext())
            {
                var result = context.Absences.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
        }

        public override Absence GetById(int id)
        {
            Absence result;
            using (var context = new TestClassbookContext())
            {
                result = context.Absences.Single(x => x.Id == id);
            }
            return result;
        }

        public override IEnumerable<Absence> List()
        {
            List<Absence> result;
            using (var context = new TestClassbookContext())
            {
                result = context.Absences.ToList();
            }
            return result;
        }
    }
}
