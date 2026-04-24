namespace RGR_Project
{
    public abstract class Transport
    {
        protected Transport(int price, int distance, int speed)
        {
            GetPrice = price;
            GetDistance = distance;
            GetSpeed = speed;
        }

        public int GetPrice { get; protected set; }

        public int GetDistance { get; protected set; }

        public int GetSpeed { get; protected set; }

        public virtual string display()
        {
            return $"Transport: {GetType().Name}";
        }

        public virtual string DeliveryInfo()
        {
            return $"Delivery distance = {GetDistance} km. Total cost: ${GetPrice}.";
        }

        public virtual string deliver()
        {
            return DeliveryInfo();
        }

        public virtual double DeliveryTime()
        {
            return Math.Round((double)GetDistance / GetSpeed, 2);
        }

        public virtual string TransportType()
        {
            return "Basic configuration";
        }
    }
}
