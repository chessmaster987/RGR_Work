using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public interface Transport
    {
        public void deliver();
        public void fillfuel();
        public void display();
        public void delivertime();
    }
}
