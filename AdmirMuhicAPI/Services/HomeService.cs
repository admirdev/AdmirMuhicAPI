using AdmirMuhicAPI.Data;
using AdmirMuhicAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AdmirMuhicAPI.Services
{
    public class HomeService : IHomeService
    {
        private readonly AppDbContext _context;

        public HomeService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Home?> GetHomeAsync()
        {
            return await _context.Home.FirstOrDefaultAsync();
        }
    }
}