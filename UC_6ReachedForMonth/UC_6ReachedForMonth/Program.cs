using System;

namespace UC_6ReachedForMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalHr = 0, WageOfMonth = 0, WorkingDays = 1, FullDayWage = 0, HalfDayWage = 0, FullDayHr = 20, HalfDayHr = 10, WagePrHr = 100;
            Random random = new Random();

            while (WorkingDays <= 20 & TotalHr <= 200)
            {
                int ValueToCheck = random.Next(3);
                switch (ValueToCheck)
                {
                    case 0:
                        Console.WriteLine("Employee is absent on " + WorkingDays);
                        WorkingDays++;
                        break;
                    case 1:
                        FullDayWage = FullDayWage + (FullDayHr * WagePrHr);
                        WorkingDays++;
                        TotalHr = TotalHr + FullDayHr;
                        break;
                    case 2:
                        HalfDayWage = HalfDayWage + (HalfDayHr * WagePrHr);
                        WorkingDays++;
                        TotalHr = TotalHr + HalfDayHr;
                        break;
                }
            }
            WageOfMonth = FullDayWage + HalfDayWage;
            Console.WriteLine("working hours " + TotalHr);
            Console.WriteLine("working days " + WorkingDays);
            Console.WriteLine("wages of total month " + WageOfMonth);
        }
    }
}