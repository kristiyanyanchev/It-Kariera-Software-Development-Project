﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    class ValidationCodeRepository : IRepository<ValidationCode>
    {
        public void Add(ValidationCode entity)
        {
            
            using (var context = new ClassBookContext())
            {
                context.ValidationCodes.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(ValidationCode entity)
        {
            using (var context = new ClassBookContext())
            {
                context.ValidationCodes.Remove(entity);
                context.SaveChanges();
            }
            
        }

        public void Edit(ValidationCode entity)
        {
            using (var context = new ClassBookContext())
            {
                var result = context.ValidationCodes.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
            
        }

        public ValidationCode GetById(int id)
        {
            ValidationCode result;
            using (var context = new ClassBookContext())
            {
                result = context.ValidationCodes.Single(x => x.Id == id);
            }
            return result;
            
        }

        public IEnumerable<ValidationCode> List()
        {
            List<ValidationCode> result;
            using (var context = new ClassBookContext())
            {
                result = context.ValidationCodes.ToList();
            }
            return result;
            
        }
    }
}