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
        private int ShipDeliveryWeight;
        private int ShipDeliveryDistance;
        private int ShipFuel;
        public void deliver()
        {
            ShipDeliveryWeight = random.Next(1, 8500);
            Console.WriteLine("Вага вантажу = {0}", ShipDeliveryWeight);
            //int Dist_first;
            ShipDeliveryDistance = random.Next(1, 5000);
            //Dist_first = ShipDeliveryDistance;
            //Console.WriteLine("Dist_first: {0}", Dist_first);
            //if (ShipDeliveryWeight < 250)
            //{
            //    ShipDeliveryDistance += 0;
            //}
            //else if (ShipDeliveryWeight >= 250 && ShipDeliveryWeight <= 800)
            //{
            //    ShipDeliveryDistance += 5;
            //}
            //else if (ShipDeliveryWeight > 800 && ShipDeliveryWeight <= 1200)
            //{
            //    ShipDeliveryDistance += 10;
            //}
            //else
            //{
            //    ShipDeliveryDistance += 15;
            //}
            //Console.WriteLine("Дистанцiя доставки = {0}", ShipDeliveryDistance);
        }
        public void fillfuel()
        {
            //ShipFuel = random.Next(0, 250);
            //Console.WriteLine("Кiлькiсть пального: {0}", ShipFuel);
            //if (ShipDeliveryWeight < 250)
            //{
            //    ShipFuel -= random.Next(10, 16);
            //}
            //else if (ShipDeliveryWeight >= 250 && ShipDeliveryWeight <= 800)
            //{
            //    ShipFuel -= random.Next(20, 26);
            //}
            //else if (ShipDeliveryWeight > 800 && ShipDeliveryWeight <= 1200)
            //{
            //    ShipFuel -= random.Next(30, 36);
            //}
            //else
            //{
            //    ShipFuel -= random.Next(40, 45);
            //}
            //Console.WriteLine("Очiкуваний залишок пального: {0}", ShipFuel);
        }
        public void display()
        {
            Console.WriteLine("Я корабель");
        }
    }
}
