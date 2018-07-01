using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sublime_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n;
            int space = width - 2;
            int stars = width - space;

            // TOP
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ',space));
                Console.WriteLine(new string('*',stars));
                space -= 2;
                stars += 2;
            }
            // AFTER TOP
            Console.Write(new string('*', width - 2));
            Console.WriteLine(new string(' ', 2));

            // SECOND FOR++
            stars = (width - 4);
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(new string('*',stars));
                 stars += 2;
            }

            // MIDDLE ROW
            Console.WriteLine(new string('*',width));

            // SECOND FOR--
            space = 2;
            stars = width - space;
            for (int i = 0; i < 2; i++)
            {
                Console.Write(new string(' ', space));
                Console.WriteLine(new string('*',stars));
                space += 2;
                stars -= 2;
            }

            //LAST SINGLE ROW
            Console.Write(new string(' ', 2));
            Console.WriteLine(new string('*', width-2));

            // BOTTOM
            width = 2 * n;
            stars = width; 
            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(new string('*', stars));
                stars -= 2;

            }

        }
    }
}
