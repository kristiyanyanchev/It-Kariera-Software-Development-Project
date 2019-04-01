using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;


namespace Data.Repositories
{
    public class ParentsRepository : IRepository<Parent>
    {
        
        public virtual void Add(Parent entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Parents.Add(entity);
                context.SaveChanges();
            }
            
        }

        public virtual void Delete(Parent entity)
        {
            using (var context = new ClassBookContext())
            {
                context.Parents.Attach(entity);
                context.Parents.Remove(entity);
                context.SaveChanges();
            }
            
        }

        public virtual void Edit(Parent entity)
        {
            using (var context = new ClassBookContext())
            {
                var result = context.Parents.Single(x => x.Id == entity.Id);
                result.Address = entity.Address;
                result.Children = entity.Children;
                result.Email = entity.Email;
                result.FirstName = entity.FirstName;
                result.LastName = entity.LastName;
                result.PhoneNumber = entity.PhoneNumber;
                result.ValidationCode = entity.ValidationCode;
                context.SaveChanges();
            }
            
        }

        public virtual Parent GetById(int id)
        {
            Parent result;
            using (var context = new ClassBookContext())
            {
                result = context.Parents.Single(x => x.Id == id);
            }
            return result;
        }

        public virtual IEnumerable<Parent> List()
        {
            List<Parent> result;
            using (var context = new ClassBookContext())
            {
                result = context.Parents.Include(b => b.Children).ToList();
            }
            return result;

        }

        public virtual void AddParentWithChildren(Parent parent, IList<Student> students)
        {
            using (var context = new ClassBookContext())
            {
                
                students.ToList().ForEach(x => context.Students.Attach(x));
                students.ToList().ForEach(x => parent.Children.Add(x));
                context.Parents.Add(parent);

                context.SaveChanges();

            }

        }
    }

}
