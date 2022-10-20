using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Task\task8-2.txt";

            int countStr = 0;
            int countChar = 0;
            string text = "";
            string[] wordArray;

            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream != true)
                {
                    string stroka = sr.ReadLine();
                    countStr++;
                    foreach (char c in stroka)
                    {
                        countChar++;
                    }
                    text = text + stroka + " ";
                }
            }
            text = text.Trim();
            wordArray = text.Split();
            Console.WriteLine();
            Console.WriteLine("Строк = {0}", countStr);
            Console.WriteLine("Слов = {0}", wordArray.Count());
            Console.WriteLine("Символов = {0}", countChar);
            Console.ReadKey();
        }
    }
}
