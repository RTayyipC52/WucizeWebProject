using DataAccess.Abstract;
using DataAccess.Repository;
using Entities.Concrete;
using DataAccess.Concrete.DContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductRepository : GenericRepository<Product>, IProductDal
    {
        public List<Product> FindProduct(string a)
        {
            using (var c = new Context())
            {
                return c.Products.Where(x=>x.ProductName.Contains(a)).Include(x => x.Category).ToList();
            }
        }

        public List<Product> GetProductWithCategory()
        {
            using (var c = new Context())
            {
                return c.Products.Include(x => x.Category).ToList();
            }
        }

        public List<Product> ListProductWithCategory(int id)
        {
            using (var c = new Context())
            {
                return c.Products.Include(x => x.Category).Where(x=> x.CategoryId == id).ToList();
            }
        }
    }
}
