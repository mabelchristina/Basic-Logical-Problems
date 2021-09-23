using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class TemperatureConversion
    {
        public void CalculateTempearture(float temp)
        {
            Console.WriteLine("option 1 for Temperature in celcius\noption 2 for Tempearture in fahrenheit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    float celcius = (temp - 32) * 5 / 9;
                    Console.WriteLine("The temperatue conversion farahenite to celcius is " + celcius);
                    break;
                case 2:
                    float fahrenheit = (temp * 9 / 5) + 32;
                    Console.WriteLine("The temperatue conversion celcius to farahenite is " + fahrenheit);
                    break;
                default:
                    Console.WriteLine("enter a valid temperatue");
                    break;
            }
        }
    }
}