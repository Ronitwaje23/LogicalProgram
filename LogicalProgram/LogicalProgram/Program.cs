using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to logical program");

            /*FibonacciSeries Fibonacci = new FibonacciSeries();
            Fibonacci.Fibo();*/
            /*
            PerfectNumber perfectnum = new PerfectNumber();
            perfectnum.Perfect();
            */
            /*
            Primenumber primenum = new Primenumber();
            primenum.Prime();*/
            /*
            ReverseNumber reversenum = new ReverseNumber();
            reversenum.Reverse();*/
            /*
            CouponNumber couponNumbers = new CouponNumber();
            couponNumbers.couponsNumbers();*/
            /*
            ProgramStopwatch bhosale = new ProgramStopwatch();
            bhosale.ElapsedTime(); *//*
            Console.WriteLine("Enter Amount to get Change");
            int amount = Convert.ToInt32(Console.ReadLine());
            VendingMachine vending = new VendingMachine();
            vending.Getchange(amount);*//*
            DayOFWeek weekday = new DayOFWeek();
            Console.WriteLine("Enter day");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month");
            int Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            weekday.Day(day, Month, year);*//*
            TemperatureConversion temperature = new TemperatureConversion();
            Console.WriteLine("Enter value of temperature ");
            int temp = Convert.ToInt32(Console.ReadLine());
            temperature.temperatureconversion(temp);*//*
            MonthlyPayment month = new MonthlyPayment();
            Console.WriteLine("Enter the value of principal");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the year");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the rate : ");
            double R = Convert.ToDouble(Console.ReadLine());
            month.monthlypayment(p, y, R);*//*
            SquareRoot.Sqrt();*//*
            BinaryConvertion bin = new BinaryConvertion();
            bin.decimalToBinary();*//*
            SwapNibles obj12 = new SwapNibles();
            Console.WriteLine("Enter number to convert in Binary :");
            int number = Convert.ToInt32(Console.ReadLine());
            obj12.ToBinary(number);*/
            

            Console.ReadLine();
        }
    }
}
