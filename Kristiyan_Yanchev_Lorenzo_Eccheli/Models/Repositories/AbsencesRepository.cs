using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    class AbsencesRepository : IRepository<Absences>
    {
        static ClassBookContext context = new ClassBookContext();
        public void Add(Absences entity)
        {
            context.Absences.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Absences entity)
        {
            context.Absences.Remove(entity);
            context.SaveChanges();
        }

        public void Edit(Absences entity)
        {
            var result = context.Absences.Single(x => x.Id == entity.Id);
            result = entity;
            context.SaveChanges();
        }

        public Absences GetById(int id)
        {
            return context.Absences.Single(x => x.Id == id);
        }

        public IEnumerable<Absences> List()
        {
            return context.Absences.ToList();
        }
    }
}
