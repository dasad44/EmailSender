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
            string login, password, destmail;
            login = Console.ReadLine();
            password = Console.ReadLine();
            destmail = Console.ReadLine();
            while (i < 20)
            {
                SmtpClient client = new SmtpClient(host, 587);
                client.Credentials = new NetworkCredential(login, password);
                client.EnableSsl = true;
                MailAddress from = new MailAddress(login);

                MailAddress to = new MailAddress(destmail);
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

