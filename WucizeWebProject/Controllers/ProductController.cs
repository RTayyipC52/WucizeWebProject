using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WucizeWebProject.Controllers
{
    public class ProductController : Controller
    {
        ProductManager product = new ProductManager(new EfProductRepository());
        public IActionResult Index()
        {
            var products = product.GetProductWithCategory();
            return View(products);
        }

        [HttpGet]
        public IActionResult ProductDetail(int id)
        {
            var products = product.GetById(id);
            return PartialView("_ProductDetail", products);
        }

        TrProductManager trProduct = new TrProductManager(new EfTrProductRepository());
        public IActionResult IndexTr()
        {
            var trProducts = trProduct.GetProductWithCategory();
            return View(trProducts);
        }

        [HttpPost]
        public IActionResult Index(string a)
        {
            var products = product.FindProduct(a);
            return View(products);
        }

        [HttpPost]
        public IActionResult IndexTr(string a)
        {
            var trProducts = trProduct.FindProduct(a);
            return View(trProducts);
        }

        [HttpGet]
        public IActionResult TrProductDetail(int id)
        {
            var trProducts = trProduct.GetById(id);
            return PartialView("_TrProductDetail", trProducts);
        }
    }
}
