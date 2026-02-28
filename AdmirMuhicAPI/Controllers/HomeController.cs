using AdmirMuhicAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdmirMuhicAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetHomeInfo()
        {
            var info = await _context.Home.FirstOrDefaultAsync();

            if (info == null)
            {
                return NotFound("Ingen data hittades i databasen.");
            }

            return Ok(info);
        }
    }
}