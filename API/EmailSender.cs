using System.Net.Mail;
using System.Net;

namespace API
{
    public class EmailSender
    {
        public void SendEmailWithAttachment(string senderEmail, string senderPassword, string receiverEmail, string subject, string body, string attachmentPath = null)
        {
            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress(senderEmail);
                message.To.Add(receiverEmail);
                message.Subject = subject;
                message.Body = body;

                if (!string.IsNullOrEmpty(attachmentPath))
                {
                    if (File.Exists(attachmentPath))
                    {
                        Attachment attachment = new Attachment(attachmentPath);
                        message.Attachments.Add(attachment);
                    }
                    else
                    {
                        Console.WriteLine($"Warning: Attachment file not found: {attachmentPath}");
                    }
                }

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)) // Use port 587 for STARTTLS
                {
                    smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                    smtp.EnableSsl = true; // Enable SSL
                    smtp.Send(message);
                    Console.WriteLine("Email sent successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending email: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
            }
        }
    }
}
