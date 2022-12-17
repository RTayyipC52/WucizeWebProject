using DataAccess.Abstract;
using DataAccess.Concrete.DContext;
using DataAccess.Repository;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTrProductRepository : GenericRepository<TrProduct>, ITrProductDal
    {
        public List<TrProduct> FindProduct(string a)
        {
            using (var c = new Context())
            {
                return c.TrProducts.Where(x => x.TrProductName.Contains(a)).Include(x => x.TrCategory).ToList();
            }
        }

        public List<TrProduct> GetProductWithCategory()
        {
            using (var c = new Context())
            {
                return c.TrProducts.Include(x => x.TrCategory).ToList();
            }
        }

        public List<TrProduct> ListProductWithCategory(int id)
        {
            using (var c = new Context())
            {
                return c.TrProducts.Include(x => x.TrCategory).Where(x => x.TrCategoryId == id).ToList();
            }
        }
    }
}
