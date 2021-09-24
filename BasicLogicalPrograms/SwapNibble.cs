using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class SwapNibble
    {
        public void CalSwapNibbles(int x)
        {
            int swapnumber= ((x & 0x0F) << 4 | (x & 0xF0) >> 4);// bitwise conversion 
            Console.WriteLine("the number after swapping nibble is "+swapnumber);
        }
    }
}
