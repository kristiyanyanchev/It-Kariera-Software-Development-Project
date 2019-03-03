using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class PhysiciansRepository : IRepository<Physician>
    {

        public void Add(Physician entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Physicians.Add(entity);
                context.SaveChanges();
            }
            
        }

        public void Delete(Physician entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Physicians.Remove(entity);
                context.SaveChanges();
            }
            
        }

        public void Edit(Physician entity)
        {
            using (var context = new ClassBookContext())
            {
                var result = context.Physicians.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
            
        }

        public Physician GetById(int id)
        {
            Physician result;
            using (var context = new ClassBookContext())
            {
                result = context.Physicians.Single(x => x.Id == id);
            }
            return result;
        }

        public IEnumerable<Physician> List()
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
