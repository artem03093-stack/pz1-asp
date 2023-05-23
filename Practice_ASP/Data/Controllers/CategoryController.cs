using Microsoft.AspNetCore.Mvc;
using Practice_ASP.Data.Interfaces;

namespace Practice_ASP.Data.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategory _category;

        public CategoryController(ICategory category)
        {
            _category = category;
        }

        public IActionResult Index()
        {
            return View(_category.GetCategories());
        }
    }
}
