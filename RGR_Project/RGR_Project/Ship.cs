using RGR_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public class Ship : Transport
    {
        public Ship(int price, int distance, int speed)
        {
            this.GetPrice = 80;
            this.GetDistance = 60;
            this.GetSpeed = 15;
        }
        public override string deliver()
        {
            return "Дистанция доставки = " + GetDistance.ToString() + ". " + "К оплате: " + GetPrice.ToString();
        }
        public override string display()
        {
            return "Корабль";
        }
    }
}
