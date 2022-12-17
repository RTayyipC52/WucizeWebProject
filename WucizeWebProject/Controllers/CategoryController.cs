using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WucizeWebProject.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager category = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var categories = category.GetAll();
            return View(categories);
        }

        TrCategoryManager trCategory = new TrCategoryManager(new EfTrCategoryRepository());
        public IActionResult IndexTr()
        {
            var trCategories = trCategory.GetAll();
            return View(trCategories);
        }
    }
}
