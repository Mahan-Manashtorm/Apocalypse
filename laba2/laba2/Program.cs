using da;

HouseCompany builder = new HouseCompany();
IHouseCompany woodHouseBuilder = new WoodHouseCompany();
IHouseCompany brickHouseBuilder = new BrickHouseCompany();

House woodHouse = builder.Construct(woodHouseBuilder);
House brickHouse = builder.Construct(brickHouseBuilder);

Console.WriteLine(woodHouse.ToString() + "; Company - " + woodHouseBuilder.nameCompany);
Console.WriteLine(brickHouse.ToString() + "; Company - " + brickHouseBuilder.nameCompany);