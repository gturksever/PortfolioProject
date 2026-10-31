using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
