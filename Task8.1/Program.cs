using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\vasilevaea\Documents\АЛЕНА";
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}
