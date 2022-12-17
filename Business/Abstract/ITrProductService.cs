using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITrProductService : IGenericService<TrProduct>
    {
        List<TrProduct> GetProductWithCategory();
        List<TrProduct> ListProductWithCategory(int id);
        List<TrProduct> FindProduct(string a);
    }
}
