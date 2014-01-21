using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        public static string[] ones = new string[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        public static string[] tens = new string[] { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        public static string huns = "hundred";
        public static string thou = "thousand";

        static void Main(string[] args)
        {
            List<string> currentNums = new List<string>();

            for (int i = 1; i < 1001; i++)
            {
                if (i == 1000)
                {
                    currentNums.Add(ones[1] + thou);
                }
                else if (i < 20)
                {
                    currentNums.Add(ones[i]);
                }
                else
                {
                    currentNums.Add(ones[(int)Math.Floor(i / 100d)] + ((int)Math.Floor(i / 100d) > 0 ? huns + (i % 100 != 0 ? "and" : "") : "") + rest(i % 100));
                }
            }
            int count = 0;
            foreach (string myString in currentNums)
            {
                count += myString.Length;
            }
            Console.WriteLine(count);
            Console.ReadKey(true);
        }

        static string rest(int i)
        {
            return i < 20 ? ones[i] : tens[(int)Math.Floor(i / 10d) - 2] + ones[i % 10];
        }
    }
}
