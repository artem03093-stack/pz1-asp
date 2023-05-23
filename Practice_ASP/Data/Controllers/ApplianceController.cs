using Microsoft.AspNetCore.Mvc;
using Practice_ASP.Data.Interfaces;

namespace Practice_ASP.Data.Controllers
{
    public class ApplianceController : Controller
    {
        private readonly IAppliance _appliance;

        public ApplianceController(IAppliance appliance)
        {
            _appliance = appliance;
        }

        public IActionResult Index()
        {
            return View(_appliance.GetAppliances());
        }
    }
}
