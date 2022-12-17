using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TrProductManager : ITrProductService
    {
        ITrProductDal _trProductDal;
        public TrProductManager(ITrProductDal trProductDal)
        {
            _trProductDal = trProductDal;
        }

        public void Add(TrProduct t)
        {
            _trProductDal.Add(t);
        }

        public void Delete(TrProduct t)
        {
            _trProductDal.Delete(t);
        }

        public List<TrProduct> FindProduct(string a)
        {
            return _trProductDal.FindProduct(a);
        }

        public List<TrProduct> GetAll()
        {
            return _trProductDal.GetAll();
        }

        public TrProduct GetById(int id)
        {
            return _trProductDal.GetById(id);
        }

        public List<TrProduct> GetProductWithCategory()
        {
            return _trProductDal.GetProductWithCategory();
        }

        public List<TrProduct> ListProductWithCategory(int id)
        {
            return _trProductDal.ListProductWithCategory(id);
        }

        public void Update(TrProduct t)
        {
            _trProductDal.Update(t);
        }
    }
}
