using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class PrimeNumber
    {
        public void Prime()
        {
            Console.Write("Enter The Start Number: ");
            int startNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the End Number : ");
            int endNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Prime Numbers between" +startNumber+"and" +endNumber+ "are : ");
            for (int i = startNumber; i <= endNumber; i++)
            {
                int count = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0 && i != 1)
                {
                    Console.Write(i+"\n");
                }
            }
        }
    }
}