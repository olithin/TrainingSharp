using System;
using System.IO;
using TaskDirectory1.Service;

namespace TaskDirectory1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the path of working directory : ");
            var insertValue = Environment.CurrentDirectory;
            Console.WriteLine(insertValue);

            var files = Directory.GetFiles(insertValue, "*.*",SearchOption.AllDirectories);

            foreach (var file in files)
            {
                var byteData = File.ReadAllBytes(file);
                new Strategy().SelectSuitable(file, byteData);
            }
            Console.ReadKey();
        }
    }
}