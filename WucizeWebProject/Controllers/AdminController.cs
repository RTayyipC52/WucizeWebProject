using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WucizeWebProject.Models;

namespace WucizeWebProject.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        CategoryManager category = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index()
        {
            var categories = category.GetAll();
            return View(categories);
        }

        ProductManager product = new ProductManager(new EfProductRepository());
        public IActionResult Sliders()
        {
            var products = product.GetProductWithCategory();
            return View(products);
        }

        [HttpGet]
        public IActionResult AddMenu()
        {
            Category category = new Category(); 
            return PartialView("_AddMenu", category);
        }

        [HttpPost]
        public IActionResult AddMenu(AddCategoryImage i)
        {
            Category c = new Category();
            if (i.CategoryImage != null)
            {
                var extension = Path.GetExtension(i.CategoryImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/teknik-mulakat/Tasarım/img/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                i.CategoryImage.CopyTo(stream); 
                c.CategoryImage = newImageName;
            }
            c.CategoryName = i.CategoryName;
            c.Status = i.Status;
            c.Order = i.Order;
            c.ContentType = i.ContentType;
            category.Add(c);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddSlider()
        {
            List<SelectListItem> categoryValues = (from x in category.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.cl = categoryValues;
            Product product = new Product();
            return PartialView("_AddSlider", product);
        }

        [HttpPost]
        public IActionResult AddSlider(AddProductImage i)
        {
            Product p = new Product();
            if (i.ProductImage != null)
            {
                var extension = Path.GetExtension(i.ProductImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/teknik-mulakat/Tasarım/img/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                i.ProductImage.CopyTo(stream);
                p.ProductImage = newImageName;
            }
            p.ProductName = i.ProductName;
            p.ProductDescription = i.ProductDescription;
            p.CategoryId = 2;
            product.Add(p);
            return RedirectToAction("Sliders");
        }

        [HttpGet]
        public IActionResult AltMenu(int id)
        {
            ProductManager product = new ProductManager(new EfProductRepository());
            var products = product.ListProductWithCategory(id);
            return PartialView("_AltMenu", products);
        }

        [HttpGet]
        public IActionResult DeleteMenu(int id)
        {
            var categorys = category.GetById(id);
            category.Delete(categorys);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteSlider(int id)
        {
            var products = product.GetById(id);
            product.Delete(products);
            return RedirectToAction("Sliders");
        }

        public IActionResult UpdateMenu(int id)
        {
            var categorys = category.GetById(id);
            return PartialView("_UpdateMenu", categorys);
        }

        [HttpPost]
        public IActionResult UpdateMenu(Category c)
        {
            category.Update(c);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateSlider(int id)
        {
            var products = product.GetById(id);
            return PartialView("_UpdateSlider", products);
        }

        [HttpPost]
        public IActionResult UpdateSlider(Product p)
        {
            product.Update(p);
            return RedirectToAction("Sliders");
        }

        TrCategoryManager trCategory = new TrCategoryManager(new EfTrCategoryRepository());

        public IActionResult IndexTr()
        {
            var trCategories = trCategory.GetAll();
            return View(trCategories);
        }

        TrProductManager trProduct = new TrProductManager(new EfTrProductRepository());
        public IActionResult SlidersTr()
        {
            var trProducts = trProduct.GetProductWithCategory();
            return View(trProducts);
        }

        [HttpGet]
        public IActionResult AddTrMenu()
        {
            TrCategory trCategory = new TrCategory();
            return PartialView("_AddTrMenu", trCategory);
        }

        [HttpPost]
        public IActionResult AddTrMenu(AddCategoryImage i)
        {
            TrCategory c = new TrCategory(); ;
            if (i.CategoryImage != null)
            {
                var extension = Path.GetExtension(i.CategoryImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/teknik-mulakat/Tasarım/img/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                i.CategoryImage.CopyTo(stream);
                c.CategoryImage = newImageName;
            }
            c.TrCategoryName = i.CategoryName;
            c.Status = i.Status;
            c.Order = i.Order;
            c.ContentType = i.ContentType;
            trCategory.Add(c);
            return RedirectToAction("IndexTr");
        }

        [HttpGet]
        public IActionResult AddTrSlider()
        {
            TrProduct trProduct = new TrProduct();
            return PartialView("_AddTrSlider", trProduct);
        }

        [HttpPost]
        public IActionResult AddTrSlider(AddProductImage i)
        {
            TrProduct p = new TrProduct();
            if (i.ProductImage != null)
            {
                var extension = Path.GetExtension(i.ProductImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/teknik-mulakat/Tasarım/img/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                i.ProductImage.CopyTo(stream);
                p.ProductImage = newImageName;
            }
            p.TrProductName = i.ProductName;
            p.TrProductDescription = i.ProductDescription;
            p.TrCategoryId = 2;
            trProduct.Add(p);
            return RedirectToAction("SlidersTr");
        }

        [HttpGet]
        public IActionResult DeleteTrMenu(int id)
        {
            var trCategorys = trCategory.GetById(id);
            trCategory.Delete(trCategorys);
            return RedirectToAction("IndexTr");
        }

        [HttpGet]
        public IActionResult DeleteTrSlider(int id)
        {
            var trProducts = trProduct.GetById(id);
            trProduct.Delete(trProducts);
            return RedirectToAction("SlidersTr");
        }

        public IActionResult UpdateTrMenu(int id)
        {
            var trCategorys = trCategory.GetById(id);
            return PartialView("_UpdateTrMenu", trCategorys);
        }

        [HttpPost]
        public IActionResult UpdateTrMenu(TrCategory c)
        {
            trCategory.Update(c);
            return RedirectToAction("IndexTr");
        }

        public IActionResult UpdateTrSlider(int id)
        {
            var trProducts = trProduct.GetById(id);
            return PartialView("_UpdateTrSlider", trProducts);
        }

        [HttpPost]
        public IActionResult UpdateTrSlider(TrProduct p)
        {
            trProduct.Update(p);
            return RedirectToAction("SlidersTr");
        }
    }
}
