using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public abstract class Creator : Deliver
    {
        protected Transport transport;
        abstract public Transport CreateTransport(string type);
        public void Operations() {
            //Transport transport = CreateTransport("");
            transport.display();
            transport.deliver();
            transport.delivertime();
        }
    }
}
