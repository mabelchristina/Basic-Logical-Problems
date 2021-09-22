using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class PrimeNumber
    {
        public void Prime(int n)
        {
            int a = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
                Console.WriteLine("Given number is prime", n);
            else
                Console.WriteLine("Not a Prime Number");
        }
    }
}