﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public abstract class Creator
    {
        abstract public Transport CreateTransport(string type);
    }
}
