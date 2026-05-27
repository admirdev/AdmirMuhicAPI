using AdmirMuhicAPI.Models;

namespace AdmirMuhicAPI.Services.Interfaces
{
    public interface IHomeService
    {
        Task<Home?> GetHomeAsync();
    }
}
