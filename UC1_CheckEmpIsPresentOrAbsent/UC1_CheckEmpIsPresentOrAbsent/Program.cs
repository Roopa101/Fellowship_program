using System;

namespace UC1_CheckEmpIsPresentOrAbsent
{
    class Program
    {
        static void Main(string[] args)
        {
            int IsFullTime = 1;
            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == IsFullTime)
            {

                Console.WriteLine("Emp is Present");

            }
            else
            {

                Console.WriteLine("Emp is Absent");

            }

        }
    }
}