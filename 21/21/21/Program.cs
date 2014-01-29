using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            for (int i = 1; i <= 10000; i++)
            {
                for (int j = i + 1; j <= 10000; j++)
                {
                    if (isAmicable(i, j))
                    {
                        if (!myList.Contains(j))
                            myList.Add(j);
                        if (!myList.Contains(i))
                            myList.Add(i);
                    }
                }
            }
            Console.WriteLine(myList.Sum());
            Console.ReadKey();
        }
        static List<int> properDivisors(int n)
        {
            List<int> myList = new List<int>();
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    myList.Add(i);
            }
            return myList;
        }

        static bool isAmicable(int n, int m)
        {
            return sum(properDivisors(n)) == m && sum(properDivisors(m)) == n && n != m;
        }

        static int sum(List<int> toSum)
        {
            int temp = 0;
            foreach (int myInt in toSum)
                temp += myInt;
            return temp;
        }
    }
}
