using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myString = File.ReadAllLines("this.txt");

            BigInteger myBigInt = 0;

            foreach (string tempString in myString)
            {
                myBigInt += BigInteger.Parse(tempString);
            }
            Console.WriteLine(myBigInt.ToString().Substring(0,10));
            Console.ReadKey();
        }

        static int SUms(string myString)
        {
            int temp = 0;
            foreach (char myChar in myString)
            {
                temp += int.Parse(myChar.ToString());
            }
            return temp;
        }
    }
}
