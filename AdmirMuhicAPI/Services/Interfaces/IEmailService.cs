using AdmirMuhicAPI.Models;

namespace AdmirMuhicAPI.Services.Interfaces;

public interface IEmailService
{
    Task SendContactEmailAsync(ContactMessage message);
}