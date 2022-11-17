using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public class PowerfulEngine : TransportDecorator
    {
        public override void TransportType()
        {
            Console.WriteLine("Engine changed to VERY power");
        }
    }
}
