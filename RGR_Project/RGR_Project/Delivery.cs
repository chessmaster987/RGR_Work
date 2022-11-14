using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public abstract class Delivery
    {
        public abstract Transport CreateTransport();
        public void someOperation()
        {
            Transport transport = CreateTransport();
            transport.deliver();
            transport.fillfuel();
            transport.display();
            transport.delivertime();
        }
    }
}
