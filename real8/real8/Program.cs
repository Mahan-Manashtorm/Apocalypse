using da;

Client client = new Client();
var simple = new ConcreteMuschroom();
Console.WriteLine("Client: I get a simple Muschroom:");
client.ClientCode(simple);
Console.WriteLine();
Portobello decorator1 = new Portobello(simple);
Chanterelle decorator2 = new Chanterelle(simple);
Console.WriteLine("Client: Now I've got a decorated Muschroom:");
client.ClientCode(decorator1);
client.ClientCode(decorator2);
Console.ReadLine();