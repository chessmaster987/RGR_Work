namespace RGR_Project
{
    public class TransportCreator : Creator
    {
        public override Transport CreateTransport(string type)
        {
            return type.ToLowerInvariant() switch
            {
                "ship" => new Ship(80, 60, 15),
                "truck" => new Truck(40, 20, 15),
                "plane" => new Plane(70, 65, 20),
                _ => throw new ArgumentException($"Unknown transport type: {type}")
            };
        }
    }
}
