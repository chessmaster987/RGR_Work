using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public class Truck : Transport
    {
        //private int DeliveryTime = 0;
        public Truck(int price, int distance, int speed) {
            this.GetPrice = 40;
            this.GetDistance = 20;
            this.GetDistance = 15;
        }
        public override  string deliver()
        {
            return "Дистанция доставки = " + GetDistance.ToString() + ". " + "К оплате: " + GetPrice.ToString();
            //Console.WriteLine("Дистанция доставки = {0}. К оплате: {1}", TruckDeliveryDistance, TruckDeliveryPrice);
        }
        //public void delivertime()
        //{
        //    DeliveryTime = TruckDeliveryDistance / TruckDeliverySpeed;
        //    Console.WriteLine("Примерное время прибытия груза: {0} часов", DeliveryTime);
        //}
        public override string display()
        {
            //Console.WriteLine("Грузовик");
            return "Грузовик";
        }
    }
}
