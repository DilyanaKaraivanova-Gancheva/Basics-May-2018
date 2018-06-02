using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 01_Programming_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            double sheetPrice = double.Parse(Console.ReadLine());
            double coverPrice = double.Parse(Console.ReadLine());
            double discountPaper = double.Parse(Console.ReadLine());
            double designer = double.Parse(Console.ReadLine());
            double discountTeam = double.Parse(Console.ReadLine());


            double money = (sheetPrice * 899) + (coverPrice * 2);
            double discountPaperTotal = discountPaper / 100.0;
            double moneyBook = money * (1 - discountPaperTotal) + designer;
            double discountTeamTotal = discountTeam / 100.0;

            double totalMoney = moneyBook *( 1 - discountTeamTotal);
            Console.WriteLine("Avtonom should pay {0:f2} BGN.", totalMoney);







        }
            
    }
}
