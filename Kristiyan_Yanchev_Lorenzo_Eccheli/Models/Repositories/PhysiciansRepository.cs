using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class PhysiciansRepository : IRepository<Physician>
    {

        public virtual void Add(Physician entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Physicians.Add(entity);
                context.SaveChanges();
            }
            
        }

        public virtual void Delete(Physician entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Physicians.Remove(entity);
                context.SaveChanges();
            }
            
        }

        public virtual void Edit(Physician entity)
        {
            using (var context = new ClassBookContext())
            {
                var result = context.Physicians.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
            
        }

        public virtual Physician GetById(int id)
        {
            Physician result;
            using (var context = new ClassBookContext())
            {
                result = context.Physicians.Single(x => x.Id == id);
            }
            return result;
        }

        public virtual IEnumerable<Physician> List()
        {
            List<Physician> result;
            using (var context = new ClassBookContext())
            {
                result = context.Physicians.ToList();
            }
            return result;
        }
    }
}
