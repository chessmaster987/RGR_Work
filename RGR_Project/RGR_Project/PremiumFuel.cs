namespace RGR_Project
{
    public class PremiumFuel : TransportDecorator
    {
        public PremiumFuel(Transport transport) : base(transport)
        {
        }

        public override string TransportType()
        {
            return $"{transport.TransportType()}, premium fuel";
        }

        public override string display()
        {
            return $"{transport.display()} + premium fuel";
        }

        public override string deliver()
        {
            return DeliveryInfo();
        }
    }
}
