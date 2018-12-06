﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateProps
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateDefault = new DateTime(2016, 8, 16, 3, 57, 32, 11);
            var dateY = dateDefault.ToString("Y").Substring(7, 4);
            var dateM = dateDefault.ToString("M").Substring(4, 6);
            var dateD = dateDefault.ToString("M").Substring(0, 2);
            var dateH = dateDefault.ToString("HH");
            var dateMin = dateDefault.ToString("mm");
            var dateS = dateDefault.ToString("ss");
            var dateMS = dateDefault.ToString("");

            Console.WriteLine
                (
                    $"Year:\t{dateY}" +
                    $"\nMonth:\t{dateM}" +
                    $"\nDay:\t{dateD}" +
                    $"\nHour:\t{dateH}" +
                    $"\nMinute:\t{dateMin}" +
                    $"\nSecond:\t{dateS}"
                );
        }
    }
}
