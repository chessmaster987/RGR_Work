﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public class WindDelivery : Delivery
    {
        override public Transport CreateTransport()
        {
            return new Plane();
        }
    }
}
