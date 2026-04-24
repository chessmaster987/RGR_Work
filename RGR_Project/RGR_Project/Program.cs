using RGR_Project;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("<< RGR: Cargo Delivery >>");

Creator creator = new TransportCreator();

Transport truck = creator.CreateTransport("truck");
Transport plane = creator.CreateTransport("plane");
Transport ship = creator.CreateTransport("ship");
Transport upgradedTruck = new PremiumFuel(new PowerfulEngine(new GPS_navigator(truck)));

Transport[] transports = { truck, plane, ship, upgradedTruck };

foreach (Transport transport in transports)
{
    Console.WriteLine(transport.display());
    Console.WriteLine(transport.deliver());
    Console.WriteLine($"Estimated delivery time: {transport.DeliveryTime()} h.");
    Console.WriteLine($"Equipment: {transport.TransportType()}");
    Console.WriteLine(new string('-', 50));
}
