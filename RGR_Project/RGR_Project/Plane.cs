using RGR_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public class Plane : Transport
    {
        public Plane(int price, int distance, int speed)
        {
            this.GetPrice = 70;
            this.GetDistance = 65;
            this.GetSpeed = 20;
        }
        public override string deliver()
        {
            return "Дистанция доставки = " + GetDistance.ToString() + ". " + "К оплате: " + GetPrice.ToString();
        }
        public override string display()
        {
            return "Самолет";
        }
    }
}


