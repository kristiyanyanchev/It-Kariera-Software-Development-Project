﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class AnnualLeavesRepository : IRepository<AnnualLeave>
    {
        

        public virtual void Add(AnnualLeave entity)
        {
            using (var context = new ClassBookContext())
            {
                context.AnnualLeaves.Add(entity);
                context.SaveChanges();
            }
           
        }

        public virtual void Delete(AnnualLeave entity)
        {
            using (var context = new ClassBookContext())
            {
                context.AnnualLeaves.Remove(entity);
                context.SaveChanges();
            }
            
            
           
        }

        public virtual void Edit(AnnualLeave entity)
        {
            using (var context = new ClassBookContext())
            {
                var result = context.AnnualLeaves.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
            
        }

        public virtual AnnualLeave GetById(int id)
        {
            AnnualLeave result;
            using (var context = new ClassBookContext())
            {
                result = context.AnnualLeaves.Single(x => x.Id == id);
            }
            return result;
        }

        public virtual IEnumerable<AnnualLeave> List()
        {
            List<AnnualLeave> result;
            using (var context = new ClassBookContext())
            {
                result = context.AnnualLeaves.ToList();
            }
            return result;
        }
    }
}
