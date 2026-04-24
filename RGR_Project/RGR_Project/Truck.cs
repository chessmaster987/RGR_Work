namespace RGR_Project
{
    public class Truck : Transport
    {
        public Truck(int price, int distance, int speed) : base(price, distance, speed)
        {
        }
        public override string DeliveryInfo()
        {
            return $"Road delivery over a distance of {GetDistance} km. Total cost: ${GetPrice}.";
        }

        public override string display()
        {
            return "Truck";
        }
    }
}
