using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoOfDaysInYear
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (var i = 2001; i < 2030; i++)
            {
                var date = new DateTime(i, 12, 31);

                Console.WriteLine(DateTime.IsLeapYear(i)
                    ? $"{date:dd/MM/yyyy}: Tag {date.DayOfYear} (Schaltjahr)"
                    : $"{date:dd/MM/yyyy}: Tag {date.DayOfYear}");
            }
        }
    }
}
