using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Context;

namespace PortfolioProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        private readonly PortfolioContext _context;

        public MessageController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult MessageList()
        {
            var values= _context.Messages.ToList();
            return View(values);
        }
    }
}
