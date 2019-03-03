﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class SickLeavesRepository : IRepository<SickLeave>
    {
        
        public void Add(SickLeave entity)
        {
            using (var context = new ClassBookContext())
            {
                context.SickLeaves.Add(entity);
                context.SaveChanges();
            }
            
        }

        public void Delete(SickLeave entity)
        {
            using (var context = new ClassBookContext())
            {
                context.SickLeaves.Remove(entity);
                context.SaveChanges();
            }
            
        }

        public void Edit(SickLeave entity)
        {
            using (var context = new ClassBookContext())
            {
                var result = context.SickLeaves.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
            
        }

        public SickLeave GetById(int id)
        {
            SickLeave result;
            using (var context = new ClassBookContext())
            {
                result = context.SickLeaves.Single(x => x.Id == id);
            }
            return result;
        }

        public IEnumerable<SickLeave> List()
        {
            List<SickLeave> result;
            using (var context = new ClassBookContext())
            {
                result = context.SickLeaves.ToList();
            }
            return result;
        }
    }
}
