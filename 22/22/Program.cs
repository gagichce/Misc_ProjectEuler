using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myNames = File.ReadAllText("names.txt").Split(',');
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < myNames.Length; i++)
            {
                myNames[i] = myNames[i].Substring(1, myNames[i].Length - 2);
            }
            List<string> myList = myNames.ToList();
            myList.Sort();
            int total = 0;
            for (int i = 0; i < myList.Count; i++)
            {
                int wordScore = 0;
                foreach(char myChar in myList[i])
                {
                    wordScore += alpha.IndexOf(myChar) + 1;
                }
                total += wordScore * (i + 1);
            }
            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
