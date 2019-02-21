using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class AnnualLeavesRepository : IRepository<AnnualLeave>
    {
        static ClassBookContext context = new ClassBookContext();

        public void Add(AnnualLeave entity)
        {
            context.AnnualLeaves.Add(entity);
            context.SaveChanges();
        }

        public void Delete(AnnualLeave entity)
        {
            context.AnnualLeaves.Remove(entity);
            context.SaveChanges();
           
        }

        public void Edit(AnnualLeave entity)
        {
            var result = context.AnnualLeaves.Single(x => x.Id == entity.Id);
            result = entity;
            context.SaveChanges();
        }

        public AnnualLeave GetById(int id)
        {
            return context.AnnualLeaves.Single(x => x.Id == id);
        }

        public IEnumerable<AnnualLeave> List()
        {
            return context.AnnualLeaves.ToList();
        }
    }
}
