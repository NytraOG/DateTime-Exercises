using System;

namespace SpecificDayOfDate
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2016, 11, 7);
            Console.WriteLine($"The day of the week for {date:yyyy MM dd} is {date.DayOfWeek}");
        }
    }
}
