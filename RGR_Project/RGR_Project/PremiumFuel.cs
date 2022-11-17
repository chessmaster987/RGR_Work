using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public class PremiumFuel : PowerfulEngine
    {
        public override void TransportType() {
            base.TransportType();
            Console.WriteLine("I have a premium fuel in my fuelbank");
        }
    }
}
