using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class PerfectNumber
    {
        public bool IsPerfect(int number)
        {
            int sum = 0;
            for (int value = 1; value < number; value++)
            {
                if (number % value == 0)
                    sum = sum + value;
            }
            if (sum == number)
            {
                return true;
            }
            return false;
        }
    }
}
