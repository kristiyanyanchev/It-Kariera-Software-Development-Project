using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    class SickLeavesRepository : IRepository<SickLeave>
    {
        static ClassBookContext context = new ClassBookContext();

        public void Add(SickLeave entity)
        {
            context.SickLeaves.Add(entity);
            context.SaveChanges();
        }

        public void Delete(SickLeave entity)
        {
            context.SickLeaves.Remove(entity);
            context.SaveChanges();
        }

        public void Edit(SickLeave entity)
        {
            var result = context.SickLeaves.Single(x => x.Id == entity.Id);
            result = entity;
            context.SaveChanges();
        }

        public SickLeave GetById(int id)
        {
            return context.SickLeaves.Single(x => x.Id == id);
        }

        public IEnumerable<SickLeave> List()
        {
            return context.SickLeaves.ToList();
        }
    }
}
