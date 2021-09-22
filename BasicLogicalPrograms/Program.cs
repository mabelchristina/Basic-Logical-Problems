using System;

namespace BasicLogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci();
            //fibonacci.CalculateFibonacci(Convert.ToInt32(Console.ReadLine()));
            int number = Convert.ToInt32(Console.ReadLine());
            fibonacci.CalculateFibRecurrsion(0,1,1,number);
        }
    }
}
