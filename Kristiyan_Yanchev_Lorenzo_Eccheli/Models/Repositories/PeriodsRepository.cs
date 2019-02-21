using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class PeriodsRepository : IRepository<Period>
    {
        static ClassBookContext context = new ClassBookContext();

        public void Add(Period entity)
        {
            context.Periods.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Period entity)
        {
            context.Periods.Remove(entity);
            context.SaveChanges();
        }

        public void Edit(Period entity)
        {
            var result = context.Periods.Single(x => x.Id == entity.Id);
            result = entity;
            context.SaveChanges();
        }

        public Period GetById(int id)
        {
            return context.Periods.Single(x => x.Id == id);
        }

        public IEnumerable<Period> List()
        {
            return context.Periods.ToList();
        }
    }
}
