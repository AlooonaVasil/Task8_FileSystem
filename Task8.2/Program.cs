using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Task\task8-2.txt";
            Random random = new Random();
            int sum = 0;
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-10, 10));
                }
            }
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    int number = Convert.ToInt32(sr.ReadLine());
                    sum += number;
                    Console.WriteLine(number);
                }
            }
            Console.WriteLine("Сумма чисел = {0}", sum);
            Console.ReadKey();
        }
    }
}
