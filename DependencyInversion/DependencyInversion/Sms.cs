using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Sms : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendMessage()
        {
            Console.WriteLine("Yeni SMS Geldi");
            Console.WriteLine("Kimden: " + PhoneNumber +   "İçerik: " + Message );
        }
    }
}