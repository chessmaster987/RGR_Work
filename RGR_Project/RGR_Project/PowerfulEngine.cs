namespace RGR_Project
{
    public class PowerfulEngine : TransportDecorator
    {
        public PowerfulEngine(Transport transport) : base(transport)
        {
        }

        public override string TransportType()
        {
            return $"{transport.TransportType()}, powerful engine";
        }

        public override string display()
        {
            return $"{transport.display()} + powerful engine";
        }

        public override string deliver()
        {
            return DeliveryInfo();
        }
    }
}
