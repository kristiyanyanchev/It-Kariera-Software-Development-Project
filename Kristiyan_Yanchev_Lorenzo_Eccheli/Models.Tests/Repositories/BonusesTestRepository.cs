using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Test.Repositories
{
    class BonusesTestRepository : BonusesRepository
    {
        public override void Add(Bonus entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.Bonuses.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Delete(Bonus entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.Bonuses.Remove(entity);
                context.SaveChanges();
            }
        }

        public override void Edit(Bonus entity)
        {
            using (var context = new TestClassbookContext())
            {
                var result = context.Bonuses.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
        }

        public override Bonus GetById(int id)
        {
            Bonus result;
            using (var context = new TestClassbookContext())
            {
                result = context.Bonuses.Single(x => x.Id == id);
            }
            return result;
        }

        public override IEnumerable<Bonus> List()
        {
            List<Bonus> result;
            using (var context = new TestClassbookContext())
            {
                result = context.Bonuses.ToList();
            }
            return result;
        }
    }
}
