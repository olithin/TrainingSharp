using System;
using System.IO;
using TaskDirectory1.Helpers;
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

            var files = Directory.GetFiles(insertValue,
                "*.*",
                SearchOption.AllDirectories);
            
            foreach (var file in files)
            {
                var ext = Path.GetExtension(file);
                var isDefined = Enum.IsDefined(typeof(FileExtensions), ext.Replace(".",""));
                if (isDefined)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(file, Console.ForegroundColor);
                    Console.ResetColor();
                    new ContentFactory().GetFileInfo(file, ext);
                }
                else
                {
                    Console.WriteLine(file);    
                }
            }
            Console.ReadKey();
        }
    }
}