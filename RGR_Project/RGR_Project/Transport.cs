using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
     public interface Transport
    {
        public abstract void deliver();
        public abstract void display();
        public abstract void delivertime();
    }
}
