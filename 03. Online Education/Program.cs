using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Online_Education
{
    class Program
    {
        static void Main(string[] args)
        {
            string early = Console.ReadLine();
            int countEarly = int.Parse(Console.ReadLine());
            string regular = Console.ReadLine();
            int countRegular = int.Parse(Console.ReadLine());
            string late = Console.ReadLine();
            int countLate = int.Parse(Console.ReadLine());

            int onlineStudents = 0;
            int onsiteSudents = 0;
            int totalStudents = 0;

            switch (early)
            {
                case "online":
                    onlineStudents = onlineStudents + countEarly;
                    break;
                case "onsite":
                    onsiteSudents = onsiteSudents + countEarly;
                    break;
            }
            switch (regular)
            {
                case "online":
                    onlineStudents = onlineStudents + countRegular;
                    break;
                case "onsite":
                    onsiteSudents = onsiteSudents + countRegular;
                    break;
            }
            switch (late)
            {
                case "online":
                    onlineStudents = onlineStudents + countLate;
                    break;
                case "onsite":
                    onsiteSudents = onsiteSudents + countLate;
                    break;
            }

            if (onsiteSudents > 600)
            {
                onlineStudents = onlineStudents + (onsiteSudents - 600);

                onsiteSudents = 600;
            }
            totalStudents = onsiteSudents + onlineStudents;

            Console.WriteLine($"Online students: {onlineStudents}");
            Console.WriteLine($"Onsite students: {onsiteSudents}");
            Console.WriteLine($"Total students: {totalStudents}");
        }
    }
}
