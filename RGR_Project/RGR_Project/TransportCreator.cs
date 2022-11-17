using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public class TransportCreator : Creator
    {
        public override Transport CreateTransport(string type)
        {
            if (type == "ship") return new Ship();
            else if (type == "truck") return new Truck();
            else return new Plane();
        }
    }
}
