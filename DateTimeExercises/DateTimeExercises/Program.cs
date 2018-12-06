using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateOG = DateTime.Today.ToString();
            var dateShort = dateOG.Substring(0, 10);
            var date24Hlong = DateTime.Today.ToString("dd/MM/yyyy HH:mm");
            var date24Hshort = DateTime.Today.ToString("M/d/yy") + DateTime.Today.ToString("g");

          
            Console.WriteLine($"Complete date:\t{DateTime.Now}");
            Console.WriteLine($"Short date:\t{dateShort}");
            Console.WriteLine($"24H Format:\t{date24Hlong}");
            Console.WriteLine($"\t\t{date24Hshort}");
        }
    }
}
