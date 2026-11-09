using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Context;

namespace PortfolioProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly PortfolioContext _context;

        public ContactController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult ContactList()
        {
            var values = _context.contacts.ToList();
            return View(values);
        }
    }
}
