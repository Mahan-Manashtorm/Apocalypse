using da;

Phone p1 = new Phone();
p1.Screen = "6.1 inch Super Retina XDR display";
p1.Battery = "Built-in rechargeable lithium-ion battery";
p1.Camera = "Dual-camera system with 12MP Ultra Wide and Wide cameras";
p1.Processor = "A15 Bionic chip with Neural Engine";
Phone p2 = p1.ShallowCopy();
Phone p3 = p1.DeepCopy();
Console.WriteLine("Original values of p1, p2, p3:");
Console.WriteLine("   p1 instance values: ");
p1.DisplayValues();
Console.WriteLine("   p2 instance values:");
p2.DisplayValues();
Console.WriteLine("   p3 instance values:");
p3.DisplayValues();
p1.Screen = "6.7-inch Dynamic AMOLED 2X";
p1.Battery = "5000mAh (typical) battery capacity";
p1.Camera = "Triple Rear Camera: 108MP Wide-angle Camera, 12MP Ultra Wide Camera, 10MP Telephoto Camera";
p1.Processor = "Exynos 2200 with integrated AMD GPU";
Console.WriteLine("Values of p1, p2 and p3 after changes to p1:");
Console.WriteLine("   p1 instance values: ");
p1.DisplayValues();
Console.WriteLine("   p2 instance values (reference values have changed):");
p2.DisplayValues();
Console.WriteLine("   p3 instance values (everything was kept the same):");
p3.DisplayValues();
      
