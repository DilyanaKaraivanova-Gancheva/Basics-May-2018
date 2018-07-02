using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_And_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isFound = false;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 9; b >= a; b--)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int d = 9; d >= c; d--)
                        {
                            int sum = (a + b + c + d);
                            int multiplication = (a * b * c * d);

                            if (sum == multiplication)
                            {
                                if (n % 10 == 5)
                                {
                                    Console.WriteLine($"{a}{b}{c}{d}");
                                    isFound = true;
                                    return;
                                }
                              
                            }
                            else if ((multiplication / sum) == 3)
                            {
                                if (n % 3 == 0)
                                {
                                    Console.WriteLine($"{d}{c}{b}{a}");
                                    isFound = true;
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            if (isFound == false)
            {
                Console.WriteLine("Nothing found");
            }
        }
    }
}
