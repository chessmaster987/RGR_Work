using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public class Ship : Transport
    {
        Random random = new Random();
        private int ShipDeliveryWeight { get; set; }
        private int ShipDeliveryDistance { get; set; }
        private int ShipFuel { get; set; }
        private int DeliveryTime = 0;
        public void deliver()
        {
            ShipDeliveryWeight = random.Next(1, 8500);
            Console.WriteLine("Вага вантажу = {0}", ShipDeliveryWeight);
            //int Dist_first;
            ShipDeliveryDistance = random.Next(1, 7000);
            //Dist_first = ShipDeliveryDistance;
            //Console.WriteLine("Dist_first: {0}", Dist_first);
            if (ShipDeliveryWeight <= 2000)
            {
                ShipDeliveryDistance += 50;
            }
            else if (ShipDeliveryWeight >= 2001 && ShipDeliveryWeight <= 5000)
            {
                ShipDeliveryDistance += 100;
            }
            else if (ShipDeliveryWeight >= 5001 && ShipDeliveryWeight <= 8000)
            {
                ShipDeliveryDistance += 150;
            }
            else
            {
                ShipDeliveryDistance += 170;
            }
            Console.WriteLine("Дистанцiя доставки = {0}", ShipDeliveryDistance);
        }
        public void fillfuel()
        {
            ShipFuel = random.Next(0, 1000);
            Console.WriteLine("Кiлькiсть пального: {0}", ShipFuel);
            if (ShipDeliveryWeight <= 2000)
            {
                ShipFuel -= random.Next(120, 126);
            }
            else if (ShipDeliveryWeight >= 2001 && ShipDeliveryWeight <= 5000)
            {
                ShipFuel -= random.Next(240, 246);
            }
            else if (ShipDeliveryWeight >= 5001 && ShipDeliveryWeight <= 8000)
            {
                ShipFuel -= random.Next(460, 500);
            }
            else
            {
                ShipFuel -= random.Next(501, 750);
            }
            Console.WriteLine("Очiкуваний залишок пального: {0}", ShipFuel);
        }
        public void delivertime() {
            DeliveryTime = ShipDeliveryDistance / 60;//середня швидкість 60
            Console.WriteLine("Приблизний час прибуття вантажу: {0} годин", DeliveryTime);
        }
        public void display()
        {
            Console.WriteLine("Я корабель");
        }
    }
}
