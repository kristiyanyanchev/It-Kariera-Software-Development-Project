﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class PeriodsRepository : IRepository<Period>
    {

        public virtual void Add(Period entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Periods.Add(entity);
                context.SaveChanges();
            }
            
        }

        public virtual void Delete(Period entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Periods.Remove(entity);
                context.SaveChanges();
            }
            
        }

        public virtual void Edit(Period entity)
        {
            using (var context = new ClassBookContext())
            {
                var result = context.Periods.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
           
        }

        public virtual Period GetById(int id)
        {
            Period result;
            using (var context = new ClassBookContext())
            {
                result = context.Periods.Single(x => x.Id == id);
            }
            return result;
            
        }

        public virtual IEnumerable<Period> List()
        {
            List<Period> result;
            using (var context = new ClassBookContext())
            {
                result = context.Periods.ToList();
            }
            return result;
        }
    }
}
