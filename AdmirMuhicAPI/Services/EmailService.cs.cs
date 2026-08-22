using AdmirMuhicAPI.Models;
using AdmirMuhicAPI.Services.Interfaces;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace AdmirMuhicAPI.Services;

public class EmailService : IEmailService
{
    private readonly IConfiguration _config;

    public EmailService(IConfiguration config)
    {
        _config = config;
    }

    public async Task SendContactEmailAsync(ContactMessage message)
    {
        var email = new MimeMessage();
        var senderEmail = _config["SmtpSettings:SenderEmail"];
        email.From.Add(new MailboxAddress(_config["SmtpSettings:SenderName"], senderEmail));

        var recipient = _config["SmtpSettings:RecipientEmail"] ?? "admir@admirmuhic.se";
        email.To.Add(MailboxAddress.Parse(recipient));

        email.ReplyTo.Add(new MailboxAddress(message.Name, message.Email));

        email.Subject = $"Nytt kontaktmeddelande från {message.Name}";

        var bodyBuilder = new BodyBuilder
        {
            HtmlBody = $"<h3>Nytt meddelande från din portföljsida</h3>" +
                       $"<p><b>Namn:</b> {message.Name}</p>" +
                       $"<p><b>E-post:</b> {message.Email}</p>" +
                       $"<p><b>Meddelande:</b><br/>{message.Message}</p>"
        };
        email.Body = bodyBuilder.ToMessageBody();

        using var client = new SmtpClient();

        var port = 587;
        if (!int.TryParse(_config["SmtpSettings:Port"], out port))
        {
            port = 587;
        }

        await client.ConnectAsync(
            _config["SmtpSettings:Server"],
            port,
            SecureSocketOptions.StartTls
        );

        var username = _config["SmtpSettings:Username"] ?? "resend";
        await client.AuthenticateAsync(username, _config["SmtpSettings:Password"]);
        await client.SendAsync(email);
        await client.DisconnectAsync(true);
    }
}