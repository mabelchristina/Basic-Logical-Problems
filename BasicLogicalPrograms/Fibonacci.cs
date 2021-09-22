using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class Fibonacci
    {
        //public void CalculateFibonacci(int length)
        //{
        //    int val1 = 0, val2 = 1, val3;
        //    for (int i = 2; i < length; i++)
        //    {
        //        val3 = val1 + val2;
        //        Console.Write(val3 + "  ");
        //        val1 = val2;
        //        val2 = val3;
        //    }
        //}
        public void CalculateFibRecursion(int val1, int val2, int counter, int number)
        {
            Console.WriteLine(val1);
            if (counter < number)
            {
                CalculateFibRecursion(val2, val1 + val2, counter + 1, number);
            }
        }
    }
}
