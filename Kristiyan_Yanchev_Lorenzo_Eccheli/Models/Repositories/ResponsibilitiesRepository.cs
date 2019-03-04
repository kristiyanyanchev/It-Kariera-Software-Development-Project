using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class ResponsibilitiesRepository : IRepository<Responsibility>
    {
        
        public void Add(Responsibility entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Responsibilities.Add(entity);
                context.SaveChanges();
            }
            
        }

        public void Delete(Responsibility entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Responsibilities.Remove(entity);
                context.SaveChanges();
            }
            
        }

        public void Edit(Responsibility entity)
        {
            using (var context = new ClassBookContext())
            {
                var result = context.Responsibilities.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
            
        }

        public Responsibility GetById(int id)
        {
            Responsibility result;
            using (var context = new ClassBookContext())
            {
                result = context.Responsibilities.Single(x => x.Id == id);
            }
            return result;
        }

        public IEnumerable<Responsibility> List()
        {
            List<Responsibility> result;
            using (var context = new ClassBookContext())
            {
                result = context.Responsibilities.ToList();
            }
            return result;
        }
    }
}
