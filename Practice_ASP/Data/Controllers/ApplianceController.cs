using Microsoft.AspNetCore.Mvc;
using Practice_ASP.Data.Interfaces;
using Practice_ASP.Data.Models;

namespace Practice_ASP.Data.Controllers
{
    public class ApplianceController : Controller
    {
        private readonly IAppliance _appliance;
        private readonly ICategory _category;

        public ApplianceController(IAppliance appliance, ICategory category)
        {
            _appliance = appliance;
            _category = category;
        }

        public IActionResult ApplianceDetails(int id)
        {
            var appliance = _appliance.GetAppliances().FirstOrDefault(i => i.Id == id);
            if (appliance == null)
            {
                return NotFound();
            }

            var category = _category.GetCategories().FirstOrDefault(i => i.Id == appliance.IdCategory);
            if (category == null)
            {
                return NotFound();
            }

            var viewModel = new ApplianceDetail(appliance, category);

            return View(viewModel);
        }
    }
    public record ApplianceDetail(Appliance appliance, Category category);
}
