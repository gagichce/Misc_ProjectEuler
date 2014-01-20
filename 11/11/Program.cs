using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _11
{
    class Program
    {
        static long largestFactor = 0;
        static List<int[]> lines = new List<int[]>();

        static void Main(string[] args)
        {
            string[] myString = File.ReadAllLines("this.txt");

            int[][] myInts = new int[20][];

            for (int i = 0; i < 20; i++)
            {
                string[] tempString = myString[i].Split();
                myInts[i] = new int[20];
                for (int j = 0; j < 20; j++)
                {
                    myInts[i][j] = int.Parse(tempString[j]);
                }
                lines.Add(myInts[i]);
            }
            for (int i = 0; i < 20; i++)
            {
                int[] temp = new int[20];

                for (int j = 0; j < 20; j++)
                {
                    temp[j] = myInts[j][i];
                }
                lines.Add(temp);
            }

            for (int i = 0; i < 20; i++)
            {
                List<int> temp1 = new List<int>();
                List<int> temp2 = new List<int>();
                for (int j = 0; i + j < 20; j++)
                {
                    temp1.Add(myInts[i + j][j]);
                    temp2.Add(myInts[j][i + j]);
                }
                if (temp1.Count > 3)
                {
                    lines.Add(temp1.ToArray());
                }
                if (temp2.Count > 3)
                {
                    lines.Add(temp2.ToArray());
                }
            }

            for (int i = 19; i >= 0; i--)
            {
                List<int> temp1 = new List<int>();
                List<int> temp2 = new List<int>();
                for (int j = 0; i - j >= 0; j++)
                {
                    temp1.Add(myInts[i - j][j]);
                    temp2.Add(myInts[19 - (i - j)][19 - j]);
                }
                if (temp1.Count > 3)
                {
                    lines.Add(temp1.ToArray());
                }
                if (temp2.Count > 3)
                {
                    lines.Add(temp2.ToArray());
                }
            }
            foreach (int[] tempInt in lines)
            {
                for (int i = 0; tempInt.Length - i > 3; i++)
                {
                    int tempProd = tempInt[i] * tempInt[i + 1] * tempInt[i + 2] * tempInt[i + 3];
                    if (tempProd > largestFactor)
                    {
                        largestFactor = tempProd;
                    }
                }
            }
            Console.WriteLine(largestFactor);
            Console.ReadKey();
        }
    }
}
