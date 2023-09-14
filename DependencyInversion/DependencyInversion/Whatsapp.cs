using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Whatsapp : IMessage
    {
        public string PhoneNumber { get; set; }
        public string  Message { get; set; }
        public string  Emoji { get; set; }

        public void SendMessage()
            
        {
            Console.WriteLine("Yeni Whatsapp Mesajı Geldi");
            Console.WriteLine("Kimden:" + PhoneNumber + "Mesaj:" + Message + "Emoji:" + Emoji);

        }
    }
}
