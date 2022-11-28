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
            Console.WriteLine("Дистанция доставки = {0}. К оплате: {1}", PlaneDeliveryDistance, PlaneDeliveryPrice);
        }
        public void delivertime()
        {
            DeliveryTime = PlaneDeliveryDistance / PlaneDeliverySpeed;
            Console.WriteLine("Примерное время прибытия груза: {0} часов", DeliveryTime);
        }
        public void display()
        {
            Console.WriteLine("Самолет");
        }
    }
}
