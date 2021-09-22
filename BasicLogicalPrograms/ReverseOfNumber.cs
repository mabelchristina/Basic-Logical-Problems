using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class ReverseOfNumber
    {
        
        public void Reverse()
        {
            int reverse = 0;
            int number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                int remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number /= 10;
            }
            Console.WriteLine("Reverse No. is "+ reverse);
        }
    }
}
