using System;

namespace DailyEmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int IsFullTime = 1;
            int EmpRatePrHr = 20;

            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == IsFullTime)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * EmpRatePrHr;
            Console.WriteLine("Emp Wage ="+ empWage);
        }
    }
}
