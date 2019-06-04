using System;
using System.Net;
using System.Net.Mail;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string host = "smtp.gmail.com";
            int i = 0;
            while (i < 20)
            {
                SmtpClient client = new SmtpClient(host, 587);
                client.Credentials = new NetworkCredential("21edqcds@gmail.com", "P@ssw0rd_");
                client.EnableSsl = true;
                MailAddress from = new MailAddress("21edqcds@gmail.com");

                MailAddress to = new MailAddress("rufffiankax@gmail.com");
                MailMessage message = new MailMessage(from, to);
                message.Body = "Kghkjhhjdjd" + i;
                message.Subject = "Nfsafam sfaIe ! ;*" + i;
                client.Send(message);
                client.Dispose();
                Console.WriteLine("Message sent");
                i++;
            }
        }
    }
}

