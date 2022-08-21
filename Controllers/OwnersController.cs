using ImmoBook.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ImmoBook.Controllers
{
    public class OwnersController : Controller
    {
        private readonly AppDbContext _context;

        public OwnersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allOwners = await _context.Owners.ToListAsync();
            return View(allOwners);
        }
    }
}
