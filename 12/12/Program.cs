using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(numDivisors(76576500L) + " " + 76576500L);
            long count = 0;
            do
            {
                count++;
            } while (numDivisors(sum(count)) < 501);
            Console.WriteLine(numDivisors(sum(count)) + " " + sum(count) + " " + count);
            Console.ReadKey();
        }

        static long sum(long i)
        {
            long temp = 0;
            for (long t = i; t > 0; t--)
            {
                temp += t;
            }
            return temp;
        }

        static long numDivisors(long n)
        {
            Dictionary<long, long> myFactors = new Dictionary<long, long>();
            while (n > 1)
            {
                for (long i = 2; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        if (!myFactors.ContainsKey(i))
                        {
                            myFactors.Add(i, 1);
                        }
                        else
                            myFactors[i]++;
                        n /= i;
                        break;
                    }
                }
            }
            long temp = 1;
            foreach (KeyValuePair<long, long> myPair in myFactors)
            {
                temp *= (myPair.Value + 1);
            }
            return temp;
        }
    }
}
