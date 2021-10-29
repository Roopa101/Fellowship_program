using System;

namespace UC5_WagesForMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            int WageOfMonth = 0, FullDayWage = 0, HalfDayWage = 0, FullDayHr = 10, HalfDayHr = 6, WagePrHr = 100;
            Random random = new Random();

            for (int i = 1; i <= 20; i++)
            {
                int valueToCheck = random.Next(3);
                switch (valueToCheck)
                {
                    case 0:
                        Console.WriteLine("Employee is absent on " + i);
                        break;
                    case 1:
                        FullDayWage = FullDayWage + (FullDayHr * WagePrHr);
                        //Console.WriteLine("FullDayWage: " + FullDayWage);
                        break;
                    case 2:
                        HalfDayWage = HalfDayWage + (HalfDayHr * WagePrHr);
                        //Console.WriteLine("HalfDaywage: " + HalfDayWage);
                        break;
                }
            }
            WageOfMonth = FullDayWage + HalfDayWage;
            Console.WriteLine("wages of total month " + WageOfMonth);
        }
    }
}

