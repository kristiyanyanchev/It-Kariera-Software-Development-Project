using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class BonusesRepository : IRepository<Bonus>
    {

        public void Add(Bonus entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Bonuses.Add(entity);
                context.SaveChanges();
            }
            
        }

        public void Delete(Bonus entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Bonuses.Remove(entity);
                context.SaveChanges();
            }
           
        }

        public void Edit(Bonus entity)
        {
            using (var context = new ClassBookContext())
            {
                var result = context.Bonuses.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
            
        }

        public Bonus GetById(int id)
        {
            Bonus result;
            using (var context = new ClassBookContext())
            {
                result = context.Bonuses.Single(x => x.Id == id);
            }
            return result;
        }

        public IEnumerable<Bonus> List()
        {
            List<Bonus> result;
            using (var context = new ClassBookContext())
            {
                result = context.Bonuses.ToList();
            }
            return result;
        }
    }
}
