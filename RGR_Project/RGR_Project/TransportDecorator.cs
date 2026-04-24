namespace RGR_Project
{
    public abstract class TransportDecorator : Transport
    {
        protected readonly Transport transport;

        protected TransportDecorator(Transport transport)
            : base(transport.GetPrice, transport.GetDistance, transport.GetSpeed)
        {
            this.transport = transport;
        }

        public override string deliver()
        {
            return transport.deliver();
        }

        public override string display()
        {
            return transport.display();
        }

        public override string DeliveryInfo()
        {
            return transport.DeliveryInfo();
        }

        public override double DeliveryTime()
        {
            return transport.DeliveryTime();
        }

        public override string TransportType()
        {
            return transport.TransportType();
        }
    }
}
