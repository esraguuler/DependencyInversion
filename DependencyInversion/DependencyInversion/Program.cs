using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Email email = new Email();
            email.Content = "Bu bir deneme mailidir ";
            email.Subject = "Test ";
            email.ToAddress = "deneme@gmail.com ";
            email.SendMessage();
            Console.WriteLine();

            Whatsapp wp = new Whatsapp();
            wp.Message = "Selam ";
            wp.PhoneNumber = "123456789 ";
            wp.Emoji = ":) ";
            wp.SendMessage();

            Console.Read();
        }
    }
}
