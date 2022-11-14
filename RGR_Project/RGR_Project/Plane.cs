using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public class Plane : Transport
    {
        Random random = new Random();
        private int PlaneDeliveryWeight { get; set; }
        private int PlaneDeliveryDistance { get; set; }
        private int PlaneFuel { get; set; }
        private int DeliveryTime = 0;
        public void deliver()
        {
            PlaneDeliveryWeight = random.Next(1, 5000);
            Console.WriteLine("Вага вантажу = {0}", PlaneDeliveryWeight);
            //int Dist_first;
            PlaneDeliveryDistance = random.Next(1, 5000);
            //Dist_first = ShipDeliveryDistance;
            //Console.WriteLine("Dist_first: {0}", Dist_first);
            if (PlaneDeliveryWeight <= 1500)
            {
                PlaneDeliveryDistance += 100;
            }
            else if (PlaneDeliveryWeight >= 1501 && PlaneDeliveryWeight <= 3000)
            {
                PlaneDeliveryDistance += 150;
            }
            else if (PlaneDeliveryWeight >= 3001 && PlaneDeliveryWeight <= 5000)
            {
                PlaneDeliveryDistance += 300;
            }
            Console.WriteLine("Дистанцiя доставки = {0}", PlaneDeliveryDistance);
        }
        public void fillfuel()
        {
            PlaneFuel = random.Next(0, 500);
            Console.WriteLine("Кiлькiсть пального: {0}", PlaneFuel);
            if (PlaneDeliveryWeight <= 1500)
            {
                PlaneFuel -= random.Next(85, 100);
            }
            else if (PlaneDeliveryWeight >= 1501 && PlaneDeliveryWeight <= 3000)
            {
                PlaneFuel -= random.Next(150, 250);
            }
            else if (PlaneDeliveryWeight >= 3001 && PlaneDeliveryWeight <= 5000)
            {
                PlaneFuel -= random.Next(260, 400);
            }
            Console.WriteLine("Очiкуваний залишок пального: {0}", PlaneFuel);
            DeliveryTime = PlaneDeliveryDistance / 120;//середня швидкість 120
            Console.WriteLine("Приблизний час прибуття вантажу: {0} годин", DeliveryTime);
        }
        public void display()
        {
            Console.WriteLine("Я корабель");
        }
    }
}
