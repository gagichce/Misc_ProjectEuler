using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myStrings = File.ReadAllLines("triangle.txt");

            List<int[]> myRows = new List<int[]>();

            foreach (string myString in myStrings)
            {
                List<int> tempLst = new List<int>();
                foreach (string tempString in myString.Split())
                {
                    tempLst.Add(int.Parse(tempString));
                }
                myRows.Add(tempLst.ToArray());
            }
            while (myRows.Count > 1)
            {
                for (int i = 0; i < myRows[myRows.Count - 2].Length; i++)
                {
                    myRows[myRows.Count - 2][i] += (myRows[myRows.Count - 1][i] > myRows[myRows.Count - 1][i + 1]) ? myRows[myRows.Count - 1][i] : myRows[myRows.Count - 1][i + 1];
                }
                    myRows.RemoveAt(myRows.Count - 1);
            }
            Console.WriteLine(myRows[0][0]);
            Console.ReadKey();
        }
    }
}
