using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    class AbsencesRepository : IRepository<Absence>
    {
        static ClassBookContext context = new ClassBookContext();
        public void Add(Absence entity)
        {
            context.Absences.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Absence entity)
        {
            context.Absences.Remove(entity);
            context.SaveChanges();
        }

        public void Edit(Absence entity)
        {
            var result = context.Absences.Single(x => x.Id == entity.Id);
            result = entity;
            context.SaveChanges();
        }

        public Absence GetById(int id)
        {
            return context.Absences.Single(x => x.Id == id);
        }

        public IEnumerable<Absence> List()
        {
            return context.Absences.ToList();
        }
    }
}
