using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yo
{
    public class Flyweight
    {
        private Mushroom _sharedState;
        public Flyweight(Mushroom mushroom)
        {
            this._sharedState = mushroom;
        }
        public void MushroomGrow()
        {
            Random number = new Random();
            this._sharedState.Size += number.Next(1, 5);
        }

        public int PrintGrow()
        {
            return this._sharedState.Size;
        }
        public void Operation(Mushroom uniqueState)
        {
            string s = JsonConvert.SerializeObject(this._sharedState);
            string u = JsonConvert.SerializeObject(uniqueState);
            Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
        }
    }
    public class FlyweightFactory
    {
        private List<Tuple<Flyweight, string>> flyweights = new List<Tuple<Flyweight, string>>();

        public FlyweightFactory(params Mushroom[] args)
        {
            foreach (var elem in args)
            {
                flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(elem), this.getKey(elem)));
            }
        }
        public string getKey(Mushroom key)
        {
            List<string> elements = new List<string>();
            elements.Add(key.Name);
            elements.Sort();
            return string.Join("_", elements);
        }
        public Flyweight GetFlyweight(Mushroom sharedState)
        {
            string key = this.getKey(sharedState);

            if (flyweights.Where(t => t.Item2 == key).Count() == 0)
            {
                Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
                this.flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
            }
            return this.flyweights.Where(t => t.Item2 == key).FirstOrDefault().Item1;
        }
        public void listFlyweights()
        {
            var count = flyweights.Count;
            Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
            foreach (var flyweight in flyweights)
            {
                Console.WriteLine(flyweight.Item2 + " | Size: " + flyweight.Item1.PrintGrow());
            }
        }
        public List<Flyweight> GetlistFlyweights()
        {
            var list = new List<Flyweight>();

            foreach (var flyweight in flyweights)
            {
                list.Add(flyweight.Item1);
            }

            return list;
        }
    }
    public class Mushroom
    {
        public string Name { get; set; }

        public int Size { get; set; }
    }
}
