using System;

namespace PartTimeEmpWage
{
    class program
    {
        static void Main(string[] args)
        {
            int IsPartTime = 1;
            int IsFullTime = 2;
            int EmpRatePrHr = 20;

            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            int empCheck = random.Next(0, 3);
            if (empCheck == IsPartTime)
            {
                empHrs = 4;
            }
            else if (empCheck == IsFullTime)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EmpRatePrHr;
            Console.WriteLine("Emp Wage= " + empWage);
        }
    }
}
