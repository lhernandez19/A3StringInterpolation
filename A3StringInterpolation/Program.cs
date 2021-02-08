using System;
using System.Globalization;


namespace A3StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
    
            var todaysDate = DateTime.Now;
            var pi = Math.PI;

            Console.WriteLine("From today’s date");
            Console.WriteLine("");
        
            Console.WriteLine($"1.{todaysDate.ToString("MMMM dd, yyyy")}");
            Console.WriteLine($"2.{todaysDate.ToString("yyyy.MM.dd")}");
            Console.WriteLine($"3.Day {todaysDate.ToString("dd")} of {todaysDate.ToString("MMMM, yyyy")}");
            Console.WriteLine($"4.Year: {todaysDate.ToString("yyyy")}, Month:{todaysDate.ToString("MM")}, Day: {todaysDate.ToString("dd")}");
            Console.WriteLine($"5.{todaysDate.ToString("dddd"),10}");
            Console.WriteLine($"6.{todaysDate.ToString("hh:mm tt"),10} {todaysDate.ToString("dddd"),10}");
            Console.WriteLine($"7.h:{todaysDate.ToString("hh")}, m:{todaysDate.ToString("mm")}, s:{todaysDate.ToString("ss")}");
            Console.WriteLine($"8.{todaysDate.ToString("yyyy.MM.dd.hh.mm.ss")}");

            Console.WriteLine("");
            Console.WriteLine("If you have PI (3.1415)");
            Console.WriteLine("");
            
            Console.WriteLine($"1. Output as currency: {pi.ToString("C")}");
            Console.WriteLine($"2. Output as right-aligned (10 spaces), number with 3 decimal places: {pi.ToString("#.000"),10}");

        }
    }
}
