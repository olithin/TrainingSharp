using System;
using System.IO;

namespace TaskDirectory1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the path of working directory : ");
            string insertValue = Console.ReadLine();
            Console.WriteLine(insertValue);

            var files = Directory.GetFiles(insertValue);
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
        }
    }
}