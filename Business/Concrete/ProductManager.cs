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
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;   
        }

        public void Add(Product t)
        {
            _productDal.Add(t);
        }

        public void Delete(Product t)
        {
            _productDal.Delete(t);
        }

        public List<Product> FindProduct(string a)
        {
            return _productDal.FindProduct(a);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> GetProductWithCategory()
        {
            return _productDal.GetProductWithCategory();
        }

        public List<Product> ListProductWithCategory(int id)
        {
            return _productDal.ListProductWithCategory(id);
        }

        public void Update(Product t)
        {
            _productDal.Update(t);
        }
    }
}
