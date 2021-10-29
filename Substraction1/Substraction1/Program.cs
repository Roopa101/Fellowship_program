
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class cal
    {
        int totalvalue;
        public int isSub(int num1, int num2)
        {
            return totalvalue = num1 - num2;
        }
        static void Main(string[] args)
        {
            cal objcal = new cal();
            Console.WriteLine("total values is:" + objcal.isSub(80, 38));
            Console.ReadKey();
        }
    }
}