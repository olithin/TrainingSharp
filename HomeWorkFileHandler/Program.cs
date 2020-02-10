using System;
using System.IO;

namespace TaskDirectory1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the path of working directory : ");
            var insertValue = Console.ReadLine();

            var directoryInfo = Directory.GetFiles(insertValue);
            foreach (var file in directoryInfo)
            {
                Console.WriteLine(file);
            }

            foreach (var item in directoryInfo)
            {
                var ext = Path.GetExtension(item);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(item, Console.ForegroundColor);
                Console.ResetColor();
                var array = File.ReadAllBytes(item);
                new ContentFactory().GetFileInfo(ext, array);
            }
            Console.ReadKey();
        }
    }
}