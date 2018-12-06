using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array of DateTime's
            DateTime[] dates =
            {
                DateTime.Now,
                new DateTime(2016, 8, 16, 9, 28, 0),
                new DateTime(2011, 5, 28, 10, 35, 0),
                new DateTime(1979, 12, 25, 14, 30, 0),
            };

            Console.WriteLine($"Day: {dates[0]:dd/MM/yyyy} \t Time: {dates[0]:hh:mm:ss:ffffff}");
            Console.WriteLine($"Day: {dates[0]:dd/MM/yyyy} \t Time: {dates[0]:HH:mm tt}\n");

            Console.WriteLine($"Day: {dates[1]:dd/MM/yyyy} \t Time: {dates[1]:hh:mm:ss}");
            Console.WriteLine($"Day: {dates[1]:dd/MM/yyyy} \t Time: {dates[1]:HH:mm tt}\n");

            Console.WriteLine($"Day: {dates[2]:dd/MM/yyyy} \t Time: {dates[2]:hh:mm:ss}");
            Console.WriteLine($"Day: {dates[2]:dd/MM/yyyy} \t Time: {dates[2]:HH:mm tt}\n");

            Console.WriteLine($"Day: {dates[3]:dd/MM/yyyy} \t Time: {dates[3]:hh:mm:ss}");
            Console.WriteLine($"Day: {dates[3]:dd/MM/yyyy} \t Time: {dates[3]:HH:mm tt}\n");
        }
    }
}
