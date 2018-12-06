using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2016, 8, 16, 12, 0, 0);

            Console.WriteLine($"{dateTime} + 0,08333 Stunden = {dateTime.AddHours(0.08333)}");
            Console.WriteLine($"{dateTime} + 0,16667 Stunden = {dateTime.AddHours(0.16667)}");
            Console.WriteLine($"{dateTime} + 0,25 Stunden = {dateTime.AddHours(0.25)}");
            Console.WriteLine($"{dateTime} + 0,3333 Stunden = {dateTime.AddHours(0.3333)}");
            Console.WriteLine($"{dateTime} + 0,5 Stunden = {dateTime.AddHours(0.5)}");
            Console.WriteLine($"{dateTime} + 0,66667 Stunden = {dateTime.AddHours(0.66667)}");
            Console.WriteLine($"{dateTime} + 1 Stunden = {dateTime.AddHours(1)}");
            Console.WriteLine($"{dateTime} + 2 Stunden = {dateTime.AddHours(2)}");
            Console.WriteLine($"{dateTime} + 29 Stunden = {dateTime.AddHours(29)}");
            Console.WriteLine($"{dateTime} + 30 Stunden = {dateTime.AddHours(30)}");
            Console.WriteLine($"{dateTime} + 31 Stunden = {dateTime.AddHours(31)}");
            Console.WriteLine($"{dateTime} + 90 Stunden = {dateTime.AddHours(90)}");
            Console.WriteLine($"{dateTime} + 365 Stunden = {dateTime.AddHours(365)}");
        }
    }
}
