using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Test.Repositories
{
    class TeachersTestRepository : TeachersRepository
    {
        public override void Add(Teacher entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.Teachers.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Delete(Teacher entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.Teachers.Attach(entity);
                context.Teachers.Remove(entity);
                context.SaveChanges();
            }
        }

        public override void Edit(Teacher entity)
        {
            using (var context = new TestClassbookContext())
            {
                var result = context.Teachers.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
        }

        public override Teacher GetById(int id)
        {
            Teacher result;
            using (var context = new TestClassbookContext())
            {
                result = context.Teachers.Single(x => x.Id == id);
            }

            return result;
        }

        public override IEnumerable<Teacher> List()
        {
            List<Teacher> result;
            using (var context = new TestClassbookContext())
            {
                result = context.Teachers.ToList();
            }
            return result;
        }
    }
}
