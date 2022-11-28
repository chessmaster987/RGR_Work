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
        private int TruckDeliveryPrice { get; set; }
        private int TruckDeliveryDistance { get; set; }
        private int TruckDeliverySpeed { get; set; }
        private int DeliveryTime = 0;
        public Truck() {
            TruckDeliveryPrice = 40;
            TruckDeliveryDistance = 20;
            TruckDeliverySpeed = 15;
        }
        public void deliver()
        {
            Console.WriteLine("Дистанция доставки = {0}. К оплате: {1}", TruckDeliveryDistance, TruckDeliveryPrice);
        }
        public void delivertime()
        {
            DeliveryTime = TruckDeliveryDistance / TruckDeliverySpeed;
            Console.WriteLine("Примерное время прибытия груза: {0} часов", DeliveryTime);
        }
        public virtual void display()
        {
            Console.WriteLine("Грузовик");
        }
    }
}
