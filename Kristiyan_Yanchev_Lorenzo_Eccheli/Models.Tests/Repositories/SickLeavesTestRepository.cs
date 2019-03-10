using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Test.Repositories
{
    class SickLeavesTestRepository : SickLeavesRepository
    {
        public override void Add(SickLeave entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.SickLeaves.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Delete(SickLeave entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.SickLeaves.Remove(entity);
                context.SaveChanges();
            }
        }

        public override void Edit(SickLeave entity)
        {
            using (var context = new TestClassbookContext())
            {
                var result = context.SickLeaves.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
        }

        public override SickLeave GetById(int id)
        {
            SickLeave result;
            using (var context = new TestClassbookContext())
            {
                result = context.SickLeaves.Single(x => x.Id == id);
            }
            return result;
        }

        public override IEnumerable<SickLeave> List()
        {
            List<SickLeave> result;
            using (var context = new TestClassbookContext())
            {
                result = context.SickLeaves.ToList();
            }
            return result;
        }

    }
}
