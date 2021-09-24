using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class DecimalToBinary
    {
        public void decToBinary(int n)
        {
            int[] binaryNum = new int[32];
            int i = 0;
            while (n > 0)
            {
                binaryNum[i] = n % 2;
                n /= 2;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
                Console.WriteLine(binaryNum[j]);
            Console.ReadLine();
        }
    }
}
