using System;

namespace SwitchCaseStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int FullDayWage = 0, HalfDayWage = 0, FullDayPrHr = 10, HalfDayPrHr = 6, WagePrHr = 100;
            Random random = new Random();
            int ValueToCheck = random.Next(3);

            switch (ValueToCheck)
            {
                case 0:
                    Console.WriteLine("Employee is absent");
                    break;
                case 1:
                    FullDayWage = FullDayPrHr * WagePrHr;
                    Console.WriteLine("FullDay wage: " + FullDayWage);
                    break;
                case 2:
                    HalfDayWage = HalfDayPrHr * WagePrHr;
                    Console.WriteLine("HalfDayWage: " + HalfDayWage);
                    break;
            }
        }
    }
}
