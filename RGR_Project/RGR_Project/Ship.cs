using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public class Ship : Transport
    {
        private int ShipDeliveryPrice { get; set; }
        private int ShipDeliveryDistance { get; set; }
        private int ShipDeliverySpeed { get; set; }
        private int DeliveryTime = 0;
        public Ship()
        {
            ShipDeliveryPrice = 80;
            ShipDeliveryDistance = 60;
            ShipDeliverySpeed = 15;
        }
        public void deliver()
        {
            Console.WriteLine("Дистанция доставки = {0}. К оплате: {1}", ShipDeliveryDistance, ShipDeliveryPrice);
        }
        public void delivertime()
        {
            DeliveryTime = ShipDeliveryDistance / ShipDeliverySpeed;
            Console.WriteLine("Примерное время прибытия груза: {0} часов", DeliveryTime);
        }
        public virtual void display()
        {
            Console.WriteLine("Корабль");
        }
    }
}
