using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class BonusesRepository : IRepository<Bonus>
    {
        static ClassBookContext context = new ClassBookContext();

        public void Add(Bonus entity)
        {
            context.Bonuses.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Bonus entity)
        {
            context.Bonuses.Remove(entity);
            context.SaveChanges();
        }

        public void Edit(Bonus entity)
        {
            var result = context.Bonuses.Single(x => x.Id == entity.Id);
            result = entity;
            context.SaveChanges();
        }

        public Bonus GetById(int id)
        {
            return context.Bonuses.Single(x => x.Id == id);
        }

        public IEnumerable<Bonus> List()
        {
            return context.Bonuses.ToList();
        }
    }
}
