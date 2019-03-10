using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Test.Repositories
{
    class ResponsibilitiesTestRepository : ResponsibilitiesRepository
    {
        public override void Add(Responsibility entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.Responsibilities.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Delete(Responsibility entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.Responsibilities.Remove(entity);
                context.SaveChanges();
            }
        }

        public override void Edit(Responsibility entity)
        {
            using (var context = new TestClassbookContext())
            {
                var result = context.Responsibilities.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
        }

        public override Responsibility GetById(int id)
        {
            Responsibility result;
            using (var context = new TestClassbookContext())
            {
                result = context.Responsibilities.Single(x => x.Id == id);
            }
            return result;
        }

        public override IEnumerable<Responsibility> List()
        {
            List<Responsibility> result;
            using (var context = new TestClassbookContext())
            {
                result = context.Responsibilities.ToList();
            }
            return result;
        }
    }
}
