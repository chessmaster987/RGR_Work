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
        int DeliveryWeight;
        int DeliveryDistance;
        public void deliver() {
            DeliveryWeight = random.Next(1, 1500);
            Console.WriteLine("Вага вантажу = {0}", DeliveryWeight);
            int Dist_first;
            DeliveryDistance = random.Next(1, 3000);
            Dist_first = DeliveryDistance;
            Console.WriteLine("Dist_first: {0}", Dist_first);
            if (DeliveryWeight < 250)
                DeliveryDistance += 0;
            else if (DeliveryWeight >= 250 && DeliveryWeight <= 800)
                DeliveryDistance += 5;
            else if (DeliveryWeight > 800 && DeliveryWeight <= 1200)
                DeliveryDistance += 10;
            else
                DeliveryDistance += 15;
            Console.WriteLine("Дистанцiя доставки = {0}", DeliveryDistance);
        }

    }
}
