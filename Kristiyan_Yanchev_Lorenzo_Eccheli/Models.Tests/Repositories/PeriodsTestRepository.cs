using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Test.Repositories
{
    class PeriodsTestRepository : PeriodsRepository
    {
        public override void Add(Period entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.Periods.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Delete(Period entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.Periods.Remove(entity);
                context.SaveChanges();
            }
        }

        public override void Edit(Period entity)
        {
            using (var context = new TestClassbookContext())
            {
                var result = context.Periods.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
        }

        public override Period GetById(int id)
        {
            Period result;
            using (var context = new TestClassbookContext())
            {
                result = context.Periods.Single(x => x.Id == id);
            }
            return result;
        }

        public override IEnumerable<Period> List()
        {
            List<Period> result;
            using (var context = new ClassBookContext())
            {
                result = context.Periods.ToList();
            }
            return result;
        }
    }
}
