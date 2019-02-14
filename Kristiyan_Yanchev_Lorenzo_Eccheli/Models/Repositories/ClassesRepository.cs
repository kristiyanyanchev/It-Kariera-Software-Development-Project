using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Data.Repositories 
{
    class ClassesRepository : IRepository<Class>
    {
        static ClassBookContext context = new ClassBookContext();

        public void Add(Class entity)
        {
            context.Classes.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Class entity)
        {
            context.Classes.Remove(entity);
            context.SaveChanges();
        }

        public void Edit(Class entity)
        {
            var result = context.Classes.Single(x => x.Id == entity.Id);
            result = entity;
            context.SaveChanges();
        }

        public Class GetById(int id)
        {
            return context.Classes.Single(x => x.Id == id);
        }

        public IEnumerable<Class> List()
        {
            return context.Classes.ToList();
        }
    }
}
