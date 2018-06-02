using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Calorie_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender = Console.ReadLine();
            double kg = double.Parse(Console.ReadLine());
            double heightInMeters = double.Parse(Console.ReadLine());
            double age = double.Parse(Console.ReadLine());
            string activityLevel = Console.ReadLine();

            double bml = 0;

            if (gender == "m")
            {
                bml = 66 + (13.7 * kg) + (5 * (heightInMeters * 100)) - (6.8 * age);

            }
            else
            {
                bml = 655 + (9.6 * kg) + (1.8 * (heightInMeters * 100)) - (4.7 * age);

            }
            double result = 0;

            if (activityLevel == "sedentary")
            {
                result = bml * 1.2;
            }
            else if (activityLevel == "lightly active")
            {
                result = bml * 1.375;
            }
            else if (activityLevel == "moderately active")
            {
                result = bml * 1.55;
            }
            else if (activityLevel == "very active")
            {
                result = bml * 1.725;
            }
           // Math.Ceiling(result);

            Console.WriteLine($"To maintain your current weight you will need {Math.Ceiling(result)} calories per day.");


        }
    }
}
