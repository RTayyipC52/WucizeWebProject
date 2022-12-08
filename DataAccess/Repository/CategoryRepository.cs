using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CategoryRepository : ICategoryDal
    {
        Context context = new Context();
        public void Add(Category category)
        {
            context.Add(category);
            context.SaveChanges();
        }

        public void Delete(Category category)
        {
            context.Remove(category);
            context.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return context.Categories.Find(id);
        }

        public void Update(Category category)
        {
            context.Update(category);
            context.SaveChanges();
        }
    }
}
