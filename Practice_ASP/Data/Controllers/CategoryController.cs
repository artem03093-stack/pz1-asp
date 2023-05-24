using Microsoft.AspNetCore.Mvc;
using Practice_ASP.Data.Interfaces;
using Practice_ASP.Data.Models;

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

        public IActionResult GetAppliancesByCategory(int idCategory)
        {
            var category = _category.GetCategories().FirstOrDefault(c => c.Id == idCategory);
            if (category == null)
            {
                return NotFound();
            }
            else
            {
                var appliances = _category.GetApplianceByCategory(category);
                return Json(appliances);
            }
        }
    }
}
