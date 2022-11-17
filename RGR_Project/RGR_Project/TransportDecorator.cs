using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public abstract class TransportDecorator
    {
        private Transport transport;
        public virtual void TransportType()
        {
            Console.WriteLine("Simple Transport");
        }
    }
}
