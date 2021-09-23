﻿using System;

namespace BasicLogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Fibonacci Series\n2.Perfect Number\n3.Prime Number\n 4.Reverse of Number\n5.Coupon Number\n6.DaysofWeek\n" +
                "7.Temperature Conversion\n8.StopWatch\n");
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
                    value = perfect.IsPerfect(Convert.ToInt32(Console.ReadLine()));
                    if (value)
                        Console.WriteLine("Given number is perfect number");
                    else
                        Console.WriteLine("Given number is not perfect number");
                    break;
                case 3:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.Prime(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 4:
                    ReverseOfNumber reverseOfNumber = new ReverseOfNumber();
                    reverseOfNumber.Reverse();
                    break;
                case 5:
                    CouponNumber coupon = new CouponNumber();
                    coupon.Coupon();
                    break;
                case 6:
                    DaysOfWeek daysOfWeek = new DaysOfWeek();
                    Console.WriteLine("Enter MM DD YYYY\n");
                    daysOfWeek.Days(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    break;
                case 7:
                    TemperatureConversion temp = new TemperatureConversion();
                    System.Console.WriteLine("Please select anyone\n 1. From Celsius to Fahrenheit.\n2. From Fahrenheit to Celsius.");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Please enter the temperature in celsius");
                            double faren = temp.CelsiusToFahrenheit(Convert.ToDouble(Console.ReadLine()));
                            Console.WriteLine("Temperature in Fahrenheit:", faren);
                            break;
                        case 2:
                            Console.WriteLine("Please enter the temperature in farenheit");
                            double cel = temp.FahrenheitToCelsius(Convert.ToDouble(Console.ReadLine()));
                            Console.WriteLine("Temperature in Fahrenheit:", cel);
                            break;
                    }
                    break;
                case 8:
                    StopWatch stopWatch = new StopWatch();
                    stopWatch.Time();
                    break;

            }
        }
    }
}
