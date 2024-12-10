using Microsoft.AspNetCore.Mvc; 
using FinalApp.Models; 
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinalApp.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            var items = await _context.Items.ToListAsync();

 
            return View(items);
        }
    }
}
