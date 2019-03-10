using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class StudentsRepository : IRepository<Student>
    {
         

        public virtual void Add(Student entity)
        {
            using (var context = new ClassBookContext())
            {
               

                context.Students.Add(entity);
                context.SaveChanges();
            }
            
        }

        public virtual void Delete(Student entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Students.Remove(entity);
                context.SaveChanges();
            }
            
        }

        public virtual void Edit(Student entity)
        {
            using (var context = new ClassBookContext())
            {
                var result = context.Students.Single(x => x.Id == entity.Id);
                result = entity;
                context.SaveChanges();
            }
            
        }

        public virtual Student GetById(int id)
        {
            Student result;
            using (var context = new ClassBookContext())
            {
                result = context.Students.Single(x => x.Id == id);
            }
            return result;

        }

        public virtual IEnumerable<Student> List()
        {
            List<Student> result;
            using (var context = new ClassBookContext())
            {
                result = context.Students.ToList();
            }
            return result;
        }
    }
}
