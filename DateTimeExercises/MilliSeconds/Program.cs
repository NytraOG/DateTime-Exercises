using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilliSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateOG = new DateTime(2016, 8, 16, 4, 0, 0, 0);
            var date1ms = dateOG.AddMilliseconds(1);
            var diff1msOg = date1ms - dateOG;
            var date2Point5ms = dateOG.AddTicks(25000);
            var diff2msOG = date2Point5ms - dateOG;

            Console.WriteLine($"Original Date:\t {dateOG:dd/MM/yyyy HH:mm:ss:fffffff}\t ({dateOG.Ticks} ticks)");
            Console.WriteLine($"\nSecond Date:\t {date1ms:dd/MM/yyyy HH:mm:ss:fffffff}\t ({date1ms.Ticks} ticks)");
            Console.WriteLine($"Difference between date:\t{diff1msOg.Ticks} ticks");
            Console.WriteLine($"\nSecond Date:\t {date2Point5ms:dd/MM/yyyy HH:mm:ss:fffffff}\t ({date2Point5ms.Ticks} ticks)");
            Console.WriteLine($"Difference between date:\t{diff2msOG.Ticks} ticks");
        }
    }
}
