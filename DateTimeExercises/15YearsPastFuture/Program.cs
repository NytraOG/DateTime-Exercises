using System;

namespace _15YearsPastFuture
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseDate = new DateTime(2016, 2, 29);

            for (int i = 2031; i > 2016; i--)
            {
                Console.WriteLine($" {i-2016} year(s) ahead: \t{baseDate.AddYears(i-2016):dd/MM/yyyy}");
            }

            Console.WriteLine($"\n\tBase Date: \t{baseDate:dd/MM/yyyy}\n");

            for (int j = 2015; j > 2001; j--)
            {
                Console.WriteLine($" {2016-j} year(s) ago: \t{baseDate.AddYears(-(2016-j)):dd/MM/yyyy}");
            }
        }
    }
}
