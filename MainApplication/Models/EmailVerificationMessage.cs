using System.Net;
using System.Net.Mail;

namespace AthletesRating.Models
{
    internal class EmailVerificationMessage
    {
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static async void SendMessage(string to_Address, string VerCode)
        {
            MailAddress from = new MailAddress("d.fatkhullin@mail.ru", "Athletes Rating Programm (admin)");
            MailAddress to = new MailAddress(to_Address);
            MailMessage message = new MailMessage(from, to);

            message.Subject = "E-mail verification";
            message.Body = $"<h2>Код подтверждения: {VerCode}</h2>";
            message.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
            smtp.Credentials = new NetworkCredential("d.fatkhullin@mail.ru", "tUAbJSTMqxY8HKDRsK8U");
            smtp.EnableSsl = true;

            await smtp.SendMailAsync(message);
        }
    }
}
