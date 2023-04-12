using da;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            RealSubject realSubject = new RealSubject();
            Console.WriteLine("Client: Запитання до проксi працiвника");
            Proxy proxy = new Proxy(realSubject);
            client.ClientCode(proxy);
            Console.ReadLine();
        }
    }
}
