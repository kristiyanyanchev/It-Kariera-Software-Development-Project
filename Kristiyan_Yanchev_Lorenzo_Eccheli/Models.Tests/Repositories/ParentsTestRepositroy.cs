﻿using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Test.Repositories
{
    class ParentsTestRepositroy : ParentsRepository
    {
        public override void Add(Parent entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.Parents.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Delete(Parent entity)
        {
            using (var context = new TestClassbookContext())
            {
                context.Parents.Remove(entity);
                context.SaveChanges();
            }
        }

        public override void Edit(Parent entity)
        {
            using (var context = new TestClassbookContext())
            {
                var result = context.Parents.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
        }

        public override Parent GetById(int id)
        {
            Parent result;
            using (var context = new TestClassbookContext())
            {
                result = context.Parents.Single(x => x.Id == id);
            }
            return result;
        }

        public override IEnumerable<Parent> List()
        {
            List<Parent> result;
            using (var context = new TestClassbookContext())
            {
                result = context.Parents.ToList();
            }
            return result;
        }
    }
}
