using AdmirMuhicAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdmirMuhicAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetHomeInfo()
        {
            var info = await _homeService.GetHomeAsync();

            if (info == null)
            {
                return NotFound("Ingen data hittades i databasen.");
            }

            return Ok(info);
        }
    }
}