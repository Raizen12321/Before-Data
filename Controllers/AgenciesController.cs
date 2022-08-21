using ImmoBook.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ImmoBook.Controllers
{
    public class AgenciesController : Controller
    {
        private readonly AppDbContext _context;

        public AgenciesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var AllCinemas = await _context.Agencies.ToListAsync();
            return View(AllCinemas);
        }
    }
}
