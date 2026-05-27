using AdmirMuhicAPI.Data;
using AdmirMuhicAPI.Models;
using AdmirMuhicAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AdmirMuhicAPI.Services
{
    public class ProjectService : IProjectService
    {
        private readonly AppDbContext _context;

        public ProjectService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Project>> GetProjectsAsync()
        {
            return await _context.Projects.ToListAsync();
        }
    }
}
