using CinePass.Data;
using CinePass.Data.Static;
using CinePass.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CinePass.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class ReportingController : Controller
    {

        private readonly AppDbContext _context;

        public ReportingController(AppDbContext context)
        {
            _context = context;
        }
        //Producers
        public async Task<IActionResult> Index()
        {
            var data = await ObtenerDatos();

            return new ViewAsPdf("Index", data);
        }

        private async Task<List<Producer>> ObtenerDatos()
        {
            return await _context.Producers.ToListAsync();
        }
        //public IActionResult Index()
        //{
        //    var data = ObtenerDatos();

        //    return new ViewAsPdf("Index", data);
        //}

        //private List<Producer> ObtenerDatos()
        //{
        //    return _context.Producers.ToList();
        //}

        //Movies

        public async Task<IActionResult> Index2()
        {
            var data = await ObtenerDatos2();

            return new ViewAsPdf("Index2", data);
        }

        private async Task<List<Movie>> ObtenerDatos2()
        {
            return await _context.Movies.ToListAsync();
        }
        //public IActionResult Index2()
        //{
        //    var data = ObtenerDatos2();

        //    return new ViewAsPdf("Index2", data);
        //}

        //private List<Movie> ObtenerDatos2()
        //{
        //    return _context.Movies.ToList();
        //}
    }
}
