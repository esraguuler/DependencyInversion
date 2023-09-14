using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Email  :IMessage
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendMessage()
        {
            Console.WriteLine("Yeni Mail Geldi");
            Console.WriteLine("Kimden:" + ToAddress + "Konu:" + Subject + "İçerik:" + Content);

        }
    }
}
