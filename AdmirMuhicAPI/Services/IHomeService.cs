using AdmirMuhicAPI.Models;

namespace AdmirMuhicAPI.Services
{
    public interface IHomeService
    {
        Task<Home?> GetHomeAsync();
    }
}