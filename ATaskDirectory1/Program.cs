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

            var files = Directory.GetFiles(insertValue);
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("Please insert the file extension : ");
            string fileEx = Console.ReadLine();
            foreach (var item in files)
            {
                if (fileEx.Contains("txt"))
                {
                    string[] ex = Directory.GetFiles(insertValue,"*.txt", SearchOption.TopDirectoryOnly);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(item);
                }
            }

            Console.ReadKey();
        }
    }
}