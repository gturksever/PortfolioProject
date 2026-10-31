using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.Areas.Admin.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult ExperienceList()
        {
            return View();
        }
    }
}
