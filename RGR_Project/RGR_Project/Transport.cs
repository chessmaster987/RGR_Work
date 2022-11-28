using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public abstract class Transport
    {
        private int price;
        private int distance;
        private int speed;
        public int GetPrice { 
            get { return price; }
            set { price = value; }
        }
        public int GetDistance { 
            get { return distance; }
            set { distance = value; }   
        }
        public int GetSpeed { 
            get { return speed; }
            set { speed = value; }  
        }
        public virtual string deliver() {
            return "Deliver information";
        }
        public virtual string display() { return "Transport information"; }
    }
}
