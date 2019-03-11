using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class AbsencesRepository : IRepository<Absence>
    {
      
        public virtual void Add(Absence entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Absences.Add(entity);
                context.SaveChanges();
            }
           
        }

        public virtual void Delete(Absence entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Absences.Remove(entity);
                context.SaveChanges();
            }
                
        }

        public virtual void Edit(Absence entity)
        {
            using (var context = new ClassBookContext())
            {
                var result = context.Absences.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
            
        }

        public virtual Absence GetById(int id)
        {
            Absence result;
            using(var context = new ClassBookContext())
            {
                result = context.Absences.Single(x => x.Id == id);
            }
            return result;
        }

        public virtual IEnumerable<Absence> List()
        {
            List<Absence> result;
            using (var context = new ClassBookContext())
            {
                result = context.Absences.ToList();
            }
            return result;
        }

    }
}
