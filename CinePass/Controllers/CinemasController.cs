using CinePass.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CinePass.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;/*IActorsService _service;*/

        public CinemasController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Cinemas.ToListAsync();
            return View();
        }
    }
}
