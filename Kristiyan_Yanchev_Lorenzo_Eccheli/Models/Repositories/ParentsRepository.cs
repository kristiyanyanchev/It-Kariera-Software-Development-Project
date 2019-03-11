using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Data.Repositories
{
    public class ParentsRepository : IRepository<Parent>
    {
        
        public virtual void Add(Parent entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Parents.Add(entity);
                context.SaveChanges();
            }
            
        }

        public virtual void Delete(Parent entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Parents.Remove(entity);
                context.SaveChanges();
            }
            
        }

        public virtual void Edit(Parent entity)
        {
            using (var context = new ClassBookContext())
            {
                var result = context.Parents.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
            
        }

        public virtual Parent GetById(int id)
        {
            Parent result;
            using (var context = new ClassBookContext())
            {
                result = context.Parents.Single(x => x.Id == id);
            }
            return result;
        }

        public virtual IEnumerable<Parent> List()
        {
            List<Parent> result;
            using (var context = new ClassBookContext())
            {
                result = context.Parents.ToList();
            }
            return result;

        }
    }

}
