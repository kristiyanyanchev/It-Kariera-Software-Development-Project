using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Test.Repositories
{
    class PhysiciansTestRepository : PhysiciansRepository
    {
        public override void Add(Physician entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.Physicians.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Delete(Physician entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.Physicians.Remove(entity);
                context.SaveChanges();
            }
        }

        public override void Edit(Physician entity)
        {
            using (var context = new TestClassbookContext())
            {
                var result = context.Physicians.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
        }

        public override Physician GetById(int id)
        {
            Physician result;
            using (var context = new TestClassbookContext())
            {
                result = context.Physicians.Single(x => x.Id == id);
            }
            return result;
        }
        public override IEnumerable<Physician> List()
        {
            List<Physician> result;
            using (var context = new TestClassbookContext())
            {
                result = context.Physicians.ToList();
            }
            return result;
        }
    }
}
