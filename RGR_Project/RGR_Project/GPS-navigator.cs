namespace RGR_Project
{
    public class GPS_navigator : TransportDecorator
    {
        public GPS_navigator(Transport transport) : base(transport)
        {
        }
        public override string TransportType()
        {
            return $"{transport.TransportType()}, GPS navigator";
        }

        public override string display()
        {
            return $"{transport.display()} + GPS";
        }

        public override string deliver()
        {
            return DeliveryInfo();
        }
    }
}
