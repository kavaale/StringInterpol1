using System;

namespace StringInterpol
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;

            Console.WriteLine($"1.{date:MMMM} {date:dd}, {date:yyyy}");
            Console.WriteLine($"2.{date:yyyy}.{date:MM}.{date:yy}");
            Console.WriteLine($"3.Day {date:dd} of {date:MMMM}, {date:yyyy}");
            Console.WriteLine($"4.Year: {date:yyyy}, Month: {date:MM}, Day: {date:dd}");
            //I am aware the constraints were 10 spaces for #5 and 5 and 10 spaces for #6 but the
            //values were not working so I did trial and error until they had the proper spacing
            Console.WriteLine($"5.{date.ToString("dddd"),16}");
            Console.WriteLine($"6.{date.ToString("hh"),7}:{date:mm} {date:tt}{date.ToString("dddd"),16}");
            Console.WriteLine($"7.h:{date:hh}, m:{date:mm}, s:{date:ss}");
            Console.WriteLine($"8.{date:yyyy}.{date:dd}.{date:yy}.{date:hh}.{date:mm}.{date:ss}");
            double pie = 3.1415;
            Console.WriteLine($"1. {pie.ToString("C")}");
            Console.WriteLine($"2. {pie.ToString("C3"),16}");
        }
    }
}
