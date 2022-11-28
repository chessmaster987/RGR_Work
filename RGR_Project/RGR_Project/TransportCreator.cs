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
            if (type == "ship") return new Ship(80,60,15);
            else if (type == "truck") return new Truck(40,20,15);
            else return new Plane(70,65,20);
        }
    }
}
