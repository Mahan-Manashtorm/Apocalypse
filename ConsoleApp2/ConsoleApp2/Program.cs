using System;
using yo;

class Program
{
    static void Main(string[] args)
    {
        var factory = new FlyweightFactory(
            new Mushroom { Name = "Portobello", Size = 2 },
            new Mushroom { Name = "Chanterelle", Size = 32 },
            new Mushroom { Name = "Truffle", Size = 15 }
        );
        factory.listFlyweights();

        addCarToPoliceDatabase(factory, new Mushroom
        {
            Name = "Portobello",
            Size = 22
        });

        addCarToPoliceDatabase(factory, new Mushroom
        {
            Name = "Toadstool",
            Size = 11
        });

        factory.listFlyweights();
        addGrow(factory, 10);
        factory.listFlyweights();
        Console.ReadLine();
    }

    public static void addCarToPoliceDatabase(FlyweightFactory factory, Mushroom mushroom)
    {
        Console.WriteLine("\nClient: Adding a Mushroom to database.");

        var flyweight = factory.GetFlyweight(new Mushroom
        {
            Name = mushroom.Name,
            Size = mushroom.Size,
        });
        flyweight.Operation(mushroom);
    }

    public static void addGrow(FlyweightFactory factory, int time)
    {
        Console.WriteLine("\nClient: Adding a Mushroom to database.");


        for (int i = 0; i < time; i++)
        {
            foreach (var flyweight in factory.GetlistFlyweights())
            {
                flyweight.MushroomGrow();
            }
        }
    }

}
