using System;

namespace BasicLogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Fibonacci Series\n 2.Perfect Number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Fibonacci fibonacci = new Fibonacci();
                    //fibonacci.CalculateFibonacci(Convert.ToInt32(Console.ReadLine()));
                    int number = Convert.ToInt32(Console.ReadLine());
                    fibonacci.CalculateFibRecursion(0, 1, 1, number);
                    break;
                case 2:
                    bool value = false;
                    PerfectNumber perfect = new PerfectNumber();
                    Console.WriteLine("Enter a number \n");
                    value=perfect.IsPerfect(Convert.ToInt32(Console.ReadLine()));
                    if (value)
                        Console.WriteLine("Given number is perfect number");
                    else
                        Console.WriteLine("Given number is not perfect number");
                    break;
            }

        }
    }
}
