using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public class PowerfulEngine : TransportDecorator
    {
        public PowerfulEngine(Transport transport) : base(transport) {
            this.transport = transport;
        }
        public new void TransportType()
        {
            Console.WriteLine("Engine changed to VERY power");
        }
    }
}
