using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double price = 0.0;

            if (gender == "m")
            {
                switch (sport)
                {
                    case "Gym":
                        price = 42;
                        break;
                    case "Boxing":
                        price = 41;
                        break;
                    case "Yoga":
                        price = 45;
                        break;
                    case "Zumba":
                        price = 34;
                        break;
                    case "Dances":
                        price = 51;
                        break;
                    case "Pilates":
                        price = 39;
                        break;
                }
            }
            else
            {
                switch (sport)
                {
                    case "Gym":
                        price = 35;
                        break;
                    case "Boxing":
                        price = 37;
                        break;
                    case "Yoga":
                        price = 42;
                        break;
                    case "Zumba":
                        price = 31;
                        break;
                    case "Dances":
                        price = 53;
                        break;
                    case "Pilates":
                        price = 37;
                        break;
                }
            }

            if (age <= 19)
            {
                price = price - price * 0.2;
            }
            double diff = price - money;
            if (price > money)
            {
                //double diff = price - money;
                Console.Writeline($"you don't have enough money! you need ${diff:f2} more.");
            }
            else
            {
                Console.Writeline($"you purchased a 1 month pass for {sport}.");
            }

            //Console.WriteLine(price > money? $"You don't have enough money! You need ${diff:f2} more." : $"You purchased a 1 month pass for {sport}.");

        }
    }
}
