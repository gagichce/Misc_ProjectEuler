using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSundays = 0;
            for (int year = 1901; year < 2001; year++)
            {
                for (int month = 1; month < 13; month++)
                {
                    if ((new DateTime(year, month, 1)).DayOfWeek == DayOfWeek.Sunday)
                    {
                        numSundays++;
                    }
                }
            }
            Console.WriteLine("There were " + numSundays + " sundays in the set time");
            Console.ReadKey(true);
        }
    }
}
