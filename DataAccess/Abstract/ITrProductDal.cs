using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ITrProductDal : IGenericDal<TrProduct>
    {
        List<TrProduct> GetProductWithCategory();
        List<TrProduct> ListProductWithCategory(int id);
        List<TrProduct> FindProduct(string a);
    }
}
