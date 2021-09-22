using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class CouponNumber
    {
        public void Coupon()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int count=0;
            int check = Random(number);
            for(int i=0; i<number;i++)
            {
                if (check == number)
                {
                    Console.WriteLine("Coupon number count is 1");  
                    return;
                }
                count++;
                number--;
            }
            Console.WriteLine("coupon number count is" + count);
        }
        public static int Random(int number)
        {
            Random random = new Random();
            number = random.Next(1,10);
            return number;
        }
    }
}
