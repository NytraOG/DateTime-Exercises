using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoOfDaysInYear
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2001; i < 2010; i++)
            {
                var date = new DateTime(i, 12, 31);

                if (DateTime.IsLeapYear(i))
                {
                    Console.WriteLine($"{date:MM/dd/yyyy}: day {date.DayOfYear} (Leap year)");
                }
                else
                {
                    Console.WriteLine($"{date:MM/dd/yyyy}: day {date.DayOfYear}");
                }
            }
        }
    }
}
