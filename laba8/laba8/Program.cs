using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using da;

namespace laba8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Composite tree = new Composite("Корпус | Яхта");

            Composite branch1 = new Composite("Правий Борт");
            Composite branch2 = new Composite("Лiвий Борт");
            Composite branch3 = new Composite("Корма");

            branch1.Add(new Leaf("Рубка"));
            branch1.Add(new Leaf("Бак для води"));
            branch2.Add(new Leaf("Якiр"));
            branch3.Add(new Leaf("Кормовий релинг"));
            branch3.Add(new Leaf("Штурвал"));

            tree.Add(branch1);
            tree.Add(branch2);
            tree.Add(branch3);


            Console.WriteLine("Client: Now I've got a composite tree:");
            client.ClientCode(tree);
            Console.ReadLine();
        }
    }
}
