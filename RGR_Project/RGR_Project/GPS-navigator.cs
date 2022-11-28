using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public class GPS_navigator : TransportDecorator
    {
        public GPS_navigator(Transport transport) : base(transport)
        {
            this.transport = transport;
        }
        //Console.WriteLine("I have a gps-tracker");
       
        public new void TransportType()
        {
            Console.WriteLine("I have a gps-tracker");
        }
        public new void display() {
            Console.WriteLine("dqwdbhowqbdoq");
        }
    }
}
