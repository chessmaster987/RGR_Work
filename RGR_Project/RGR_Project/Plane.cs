using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public class Plane : Transport
    {
        private int PlaneDeliveryPrice { get; set; }
        private int PlaneDeliveryDistance { get; set; }
        private int PlaneDeliverySpeed { get; set; }
        private int DeliveryTime = 0;
        public Plane()
        {
            PlaneDeliveryPrice = 70;
            PlaneDeliveryDistance = 65;
            PlaneDeliverySpeed = 20;
        }
        public void deliver()
        {
            Console.WriteLine("Дистанцiя доставки = {0}. До оплати: {1}", PlaneDeliveryDistance, PlaneDeliveryPrice);
        }
        public void delivertime()
        {
            DeliveryTime = PlaneDeliveryDistance / PlaneDeliverySpeed;
            Console.WriteLine("Приблизний час прибуття вантажу: {0} годин", DeliveryTime);
        }
        public void display()
        {
            Console.WriteLine("Лiтак");
        }
    }
}
