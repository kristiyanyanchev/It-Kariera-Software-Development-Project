using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    class ResponsibilitiesRepository : IRepository<Responsibility>
    {
        static ClassBookContext context = new ClassBookContext();

        public void Add(Responsibility entity)
        {
            context.Responsibilities.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Responsibility entity)
        {
            context.Responsibilities.Remove(entity);
            context.SaveChanges();
        }

        public void Edit(Responsibility entity)
        {
            var result = context.Responsibilities.Single(x => x.Id == entity.Id);
            result = entity;
            context.SaveChanges();
        }

        public Responsibility GetById(int id)
        {
            return context.Responsibilities.Single(x => x.Id == id);
        }

        public IEnumerable<Responsibility> List()
        {
            return context.Responsibilities.ToList();
        }
    }
}
