using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;

            Console.WriteLine($"Today:\t\t\t{date.DayOfWeek}");
            Console.WriteLine($"40 Days from now:\t{date.AddDays(40).DayOfWeek}");
        }
    }
}
