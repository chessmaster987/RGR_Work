using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public class Truck : Transport
    {
        Random random = new Random();
        private int TruckDeliveryWeight { get; set; }
        private int TruckDeliveryDistance { get; set; }
        private int TruckFuel { get; set; }
        private int DeliveryTime = 0;
        public void deliver() {
            TruckDeliveryWeight = random.Next(1, 1500);
            Console.WriteLine("Вага вантажу = {0}", TruckDeliveryWeight);
            //int Dist_first;
            TruckDeliveryDistance = random.Next(1, 3000);
            //Dist_first = TruckDeliveryDistance;
            //Console.WriteLine("Dist_first: {0}", Dist_first);
            if (TruckDeliveryWeight < 250)
            {
                TruckDeliveryDistance += 0;
            }
            else if (TruckDeliveryWeight >= 250 && TruckDeliveryWeight <= 800)
            {
                TruckDeliveryDistance += 5;
            }
            else if (TruckDeliveryWeight > 800 && TruckDeliveryWeight <= 1200)
            {
                TruckDeliveryDistance += 10;
            }
            else {
                TruckDeliveryDistance += 15;
            }
            Console.WriteLine("Дистанцiя доставки = {0}", TruckDeliveryDistance);
        }
        public void fillfuel() {
            TruckFuel = random.Next(50, 250);
            Console.WriteLine("Кiлькiсть пального: {0}", TruckFuel);
            if (TruckDeliveryWeight < 250)
            {
                TruckFuel -= random.Next(10, 16);
            }
            else if (TruckDeliveryWeight >= 250 && TruckDeliveryWeight <= 800)
            {
                TruckFuel -= random.Next(20, 26);
            }
            else if (TruckDeliveryWeight > 800 && TruckDeliveryWeight <= 1200)
            {
                TruckFuel -= random.Next(30, 36);
            }
            else
            {
                TruckFuel -= random.Next(40, 45);
            }
            if (TruckFuel <= 0)
            {
                TruckFuel += 250;
                DeliveryTime += 1;
            }
            Console.WriteLine("Очiкуваний залишок пального: {0}", TruckFuel);
            DeliveryTime = TruckDeliveryDistance / 75;//середня швидкість 75
            Console.WriteLine("Приблизний час прибуття вантажу: {0} годин", DeliveryTime);
        }
        public void display() {
            Console.WriteLine("Вантажiвка");
        }
    }
}
