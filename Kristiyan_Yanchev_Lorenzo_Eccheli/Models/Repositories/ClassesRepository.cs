using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Data.Repositories 
{
    public class ClassesRepository : IRepository<Class>
    {
       
        public void Add(Class entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Classes.Add(entity);
                context.SaveChanges();
            }
            
        }

        public void Delete(Class entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Classes.Remove(entity);
                context.SaveChanges();
            }
           
        }

        public void Edit(Class entity)
        {
            using (var context = new ClassBookContext())
            {
                var result = context.Classes.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
           
        }

        public Class GetById(int id)
        {
            Class result;
            using (var context = new ClassBookContext())
            {
                result = context.Classes.Single(x => x.Id == id);
            }
            return result;
        }

        public IEnumerable<Class> List()
        {
            List<Class> result;
            using (var context = new ClassBookContext())
            {
                result = context.Classes.ToList();
            }
            return result;
        }
    }
}
