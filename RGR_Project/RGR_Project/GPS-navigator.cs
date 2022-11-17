using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public class GPS_navigator : TransportDecorator
    {
        private Transport transport;
        public void TransportDecorator(Transport transport)
        {
            this.truck = transport;
        }
    }
}
