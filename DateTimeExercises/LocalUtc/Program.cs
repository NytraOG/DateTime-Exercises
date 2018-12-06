using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalUtc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dateTime = DateTime.Now;

            Console.WriteLine($"Local date and time:\t{dateTime}");
            Console.WriteLine($"UTC date and time:\t{dateTime.ToUniversalTime()}");
        }
    }
}
