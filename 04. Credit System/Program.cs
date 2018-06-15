using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Credit_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int grade = 0;
            double credits = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                int currentGrade = num % 10;
                double currentCredits = num / 10;

                switch (currentGrade) {
                    case 2:
                        currentCredits = 0;
                        break;
                    case 3:
                      currentCredits *= 0.5;
                        break;
                    case 4:
                        currentCredits *= 0.7;
                        break;
                    case 5:
                        currentCredits *= 0.85;
                        break;
                    
                }
                grade += currentGrade;
                credits += currentCredits;
            }
            double avGrade = grade / (double)n;

            Console.WriteLine($"{credits:f2}");
            Console.WriteLine($"{avGrade:f2}");
        }
    }
}
