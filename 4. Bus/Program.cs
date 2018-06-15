using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int passingers = int.Parse(Console.ReadLine());
            int station = int.Parse(Console.ReadLine());
            int totalPassengers = 0;



            for (int i = 1; i <= station; i++)
            {
                int down = int.Parse(Console.ReadLine());
                int up = int.Parse(Console.ReadLine());
                passingers += up;
                passingers -= down;

                if (i % 2 != 0)
                {
                    passingers += 2;
                }
                else
                {
                    passingers -= 2;
                }
            }
            Console.WriteLine($"The final number of passengers is : {passingers}");
        }
    }
}
