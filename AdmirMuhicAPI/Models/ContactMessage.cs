using System.ComponentModel.DataAnnotations;

namespace AdmirMuhicAPI.Models;

public class ContactMessage
{
    [Required(ErrorMessage = "Namn är obligatoriskt.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "E-post är obligatoriskt.")]
    [EmailAddress(ErrorMessage = "Ogiltig e-postadress.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Meddelande är obligatoriskt.")]
    public string Message { get; set; } = string.Empty;
}