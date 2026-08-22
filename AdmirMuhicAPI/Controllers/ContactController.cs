using AdmirMuhicAPI.Models;
using AdmirMuhicAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdmirMuhicAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public ContactController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public async Task<IActionResult> SendContactEmail([FromBody] ContactMessage message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _emailService.SendContactEmailAsync(message);
                return Ok(new { message = "Meddelandet har skickats framgångsrikt." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Ett fel uppstod när meddelandet skulle skickas.", error = ex.Message });
            }
        }
    }
}