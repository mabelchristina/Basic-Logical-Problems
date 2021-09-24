using System;

namespace BasicLogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Fibonacci Series\n2.Perfect Number\n3.Prime Number\n" +
                " 4.Reverse of Number\n5.Coupon Number\n6.DaysofWeek\n" +
                "7.Temperature Conversion\n8.StopWatch\n9.Monthly Payment\n" +
                "10.Vending Machine of Notes\n11.Square Root \n12.Decimal to Binary\n13.Swap Nibble\n");
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
                    primeNumber.Prime();
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
                    Console.WriteLine("Enter the Temperature");
                    temp.CalculateTempearture(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 8:
                    StopWatch stopWatch = new StopWatch();
                    stopWatch.Time();
                    break;
                case 9:
                    MonthlyPayment monthlyPayment = new MonthlyPayment();
                    Console.WriteLine("Enter Principal\nYear\nRate\n");
                    monthlyPayment.CalculateMonthlyPayment(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                    break;
                case 10:
                    VendingMachineOfNotes vendingMachine = new VendingMachineOfNotes();
                    Console.WriteLine("Enter the amount needed from Vending Machine\n");
                    vendingMachine.Notes(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 11:
                    SquareRoot squareRoot = new SquareRoot();
                    Console.WriteLine("Enter a number to find square root");
                    squareRoot.CalSquareRoot(Convert.ToDouble(Console.ReadLine()));
                    break;
                case 12:
                    DecimalToBinary decimalToBinary = new DecimalToBinary();
                    Console.WriteLine("Enter a decimal number");
                    decimalToBinary.decToBinary(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 13:
                    SwapNibble swapNibble = new SwapNibble();
                    Console.WriteLine("Enter a decimal Number");
                    swapNibble.CalSwapNibbles(Convert.ToInt32(Console.ReadLine()));
                    break;
            }
        }
    }
}
