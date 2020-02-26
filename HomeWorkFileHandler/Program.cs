using System;
using TaskDirectory1.Service;

namespace TaskDirectory1
{
    class Program
    {
        static void Main(string[] args)
        {
            var insertValue = Environment.CurrentDirectory;
            Console.WriteLine($"Path of the project folder: {insertValue}");

            var fileHandler = new FileHandler();
            fileHandler.SelectFile(insertValue);

            Console.ReadKey();
        }
    }
}