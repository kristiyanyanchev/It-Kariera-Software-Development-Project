using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    class PhysiciansRepository : IRepository<Physician>
    {
        static ClassBookContext context = new ClassBookContext();

        public void Add(Physician entity)
        {
            context.Physicians.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Physician entity)
        {
            context.Physicians.Remove(entity);
            context.SaveChanges();
        }

        public void Edit(Physician entity)
        {
            var result = context.Physicians.Single(x => x.Id == entity.Id);
            result = entity;
            context.SaveChanges();
        }

        public Physician GetById(int id)
        {
            return context.Physicians.Single(x => x.Id == id);
        }

        public IEnumerable<Physician> List()
        {
            return context.Physicians.ToList();
        }
    }
}
