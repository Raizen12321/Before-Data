using ImmoBook.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ImmoBook.Controllers
{
    public class PropertiesController : Controller
    {
        private readonly AppDbContext _context;

        public PropertiesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProperties = await _context.Properties.Include(n => n.Agencie).ToListAsync();
            return View(allProperties);
        }
    }
}
