using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public abstract class TransportDecorator : Transport
    {
        protected Transport transport;
        public TransportDecorator(Transport transport)
        {
            this.transport = transport;
        }
        public void deliver() {
            transport.deliver();
        }
        public void display()
        {
            transport.display();
        }
        public void TransportType() { }
    }
}
