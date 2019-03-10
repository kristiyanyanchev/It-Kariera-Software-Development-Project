using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Test.Repositories
{
    class ClassesTestRepository : ClassesRepository
    {
        public override void Add(Class entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.Classes.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Delete(Class entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.Classes.Remove(entity);
                context.SaveChanges();
            }
        }

        public override void Edit(Class entity)
        {
            using (var context = new TestClassbookContext())
            {
                var result = context.Classes.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
        }

        public override Class GetById(int id)
        {
            Class result;
            using (var context = new TestClassbookContext())
            {
                result = context.Classes.Single(x => x.Id == id);
            }
            return result;
        }

        public override IEnumerable<Class> List()
        {
            List<Class> result;
            using (var context = new TestClassbookContext())
            {
                result = context.Classes.ToList();
            }
            return result;
        }
    }
}
