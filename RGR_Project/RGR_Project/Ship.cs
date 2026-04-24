namespace RGR_Project
{
    public class Ship : Transport
    {
        public Ship(int price, int distance, int speed) : base(price, distance, speed)
        {
        }

        public override string DeliveryInfo()
        {
            return $"Sea delivery over a distance of {GetDistance} km. Total cost: ${GetPrice}.";
        }

        public override string display()
        {
            return "Ship";
        }
    }
}
