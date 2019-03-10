using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Test.Repositories
{
    public class AnnualLeaveTestRepository : AnnualLeavesRepository
    {
        public override void Add(AnnualLeave entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.AnnualLeaves.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Delete(AnnualLeave entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.AnnualLeaves.Remove(entity);
                context.SaveChanges();
            }
        }

        public override void Edit(AnnualLeave entity)
        {
            using (var context = new TestClassbookContext())
            {
                var result = context.AnnualLeaves.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
        }

        public override AnnualLeave GetById(int id)
        {
            AnnualLeave result;
            using (var context = new TestClassbookContext())
            {
                result = context.AnnualLeaves.Single(x => x.Id == id);
            }
            return result;
        }

        public override IEnumerable<AnnualLeave> List()
        {
            List<AnnualLeave> result;
            using (var context = new TestClassbookContext())
            {
                result = context.AnnualLeaves.ToList();
            }
            return result;
        }
    }
}
