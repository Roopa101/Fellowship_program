﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class cal
    {
        int totalvalue;
        public int sumis(int num1, int num2)
        {
            return totalvalue = num1 + num2;
        }
        static void Main(string[] args)
        {
            cal objcal = new cal();
<<<<<<< HEAD
            Console.WriteLine("total values is:" + objcal.sumis(80, 38));
=======
            Console.WriteLine("total values is:" + objcal.sumis(90, 38));
>>>>>>> uc
            Console.ReadKey();
        }
    }
}
