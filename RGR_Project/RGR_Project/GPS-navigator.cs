using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public class GPS_navigator : TransportDecorator
    {
        public override void TransportType()
        {
            Console.WriteLine("I have a gps-tracker");
        }
    }
}
