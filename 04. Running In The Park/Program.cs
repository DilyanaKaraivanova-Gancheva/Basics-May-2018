using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Running_In_The_Park
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalDistance = 0.0;
            int totalMinutes = 0;
            double calories = 0;

            for (int i = 1; i <= days; i++)
            {
                int minutes = int.Parse(Console.ReadLine());
                double distance = double.Parse(Console.ReadLine());
                string metric = Console.ReadLine();

                if (metric == "m")
                {
                    distance /= 1000.0; 
                }
                totalDistance += distance;
                totalMinutes += minutes;           
            }

            calories = (totalMinutes / 20.0) * 400;

            Console.WriteLine($"He ran {totalDistance:f2}km for {totalMinutes} minutes and burned {calories} calories.");
        }
    }
}
