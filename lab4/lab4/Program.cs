using da;

var director = new PhoneDirector();
var basicBuilder = new BasicPhoneBuilder();
var premiumBuilder = new PremiumPhoneBuilder();
director.BuildBasicPhone(basicBuilder);
var basicPhone = basicBuilder.GetPhone();
Console.WriteLine($"Basic phone built:\n{basicPhone}\n");
director.BuildPremiumPhone(premiumBuilder);
var premiumPhone = premiumBuilder.GetPhone();
Console.WriteLine($"Premium phone built:\n{premiumPhone}\n");
Console.ReadLine();
