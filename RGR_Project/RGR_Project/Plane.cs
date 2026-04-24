namespace RGR_Project
{
    public class Plane : Transport
    {
        public Plane(int price, int distance, int speed) : base(price, distance, speed)
        {
        }

        public override string DeliveryInfo()
        {
            return $"Air delivery over a distance of {GetDistance} km. Total cost: ${GetPrice}.";
        }

        public override string display()
        {
            return "Plane";
        }
    }
}
