using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class MonthlyPayment
    {
        public void CalculateMonthlyPayment(double principal, double year, double rate)
        {
            double rateOfInterestMonthly = rate / (12 * 100);
            double n = 12 * year;//year in monthly
            double payment = (principal * rateOfInterestMonthly) / (1 - Math.Pow((1 + rateOfInterestMonthly), (-n)));
            Console.WriteLine("Monthly payment " + payment);
        }
    }
}
