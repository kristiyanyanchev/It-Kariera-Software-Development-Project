using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Data.Repositories
{
    public class ParentsRepository : IRepository<Parent>
    {
        static ClassBookContext context = new ClassBookContext();

        public void Add(Parent entity)
        {
            context.Parents.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Parent entity)
        {
            context.Parents.Remove(entity);
            context.SaveChanges();
        }

        public void Edit(Parent entity)
        {
            var result = context.Parents.Single(x => x.Id == entity.Id);
            result = entity;
            context.SaveChanges();
        }

        public Parent GetById(int id)
        {
            return context.Parents.Single(x => x.Id == id);
        }

        public IEnumerable<Parent> List()
        {
            return context.Parents.ToList();

        }
    }

}
