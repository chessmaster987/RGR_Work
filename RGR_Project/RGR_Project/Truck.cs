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
            Console.WriteLine("Дистанцiя доставки = {0}. До оплати: {1}", TruckDeliveryDistance, TruckDeliveryPrice);
        }
        public void delivertime()
        {
            DeliveryTime = TruckDeliveryDistance / TruckDeliverySpeed;
            Console.WriteLine("Приблизний час прибуття вантажу: {0} годин", DeliveryTime);
        }
        public void display()
        {
            Console.WriteLine("Вантажiвка");
        }
    }
}
