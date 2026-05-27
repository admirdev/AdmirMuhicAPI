using AdmirMuhicAPI.Models;

namespace AdmirMuhicAPI.Services.Interfaces
{
    public interface IProjectService
    {
        Task<IEnumerable<Project>> GetProjectsAsync();
    }
}
