using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        { // ЗАДАЧА 5 - ОТ Coding 101 Exam - 6 March 2016
            int n = int.Parse(Console.ReadLine());

            // top

            Console.Write("/");
            Console.Write(new string('^',n/2));
            Console.Write("\\");
            Console.Write(new string('_', 2 * n - 2*(n/2)-4));
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.WriteLine("\\");

            // middle
            int space = (2 * n) - 2;
            int height = n - 2;

            if (n <= 4)
            {

                for (int i = 1; i <= n-3; i++)
                {
                    Console.Write("|");
                    Console.Write(new string(' ', space));
                    Console.WriteLine("|");
                }
            }
            else
            {
                for (int i = 1; i <= n-3; i++)
                {
                    Console.Write("|");
                    Console.Write(new string(' ', space));
                    Console.WriteLine("|");
                }
            }
            // row before the last
            Console.Write("|");
            Console.Write(new string(' ',n/2 + 1));
            Console.Write(new string('_', 2 * n - 2 * (n / 2) - 4));
            Console.Write(new string(' ', n / 2 + 1));
            Console.WriteLine("|");

            // buttom
            Console.Write("\\");
            Console.Write(new string('_',n/2));
            Console.Write("/");
            Console.Write(new string(' ', 2 * n - 2 * (n / 2) - 4));
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.WriteLine("/");





        }
    }
}
