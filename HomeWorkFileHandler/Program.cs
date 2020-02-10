using System;
using System.IO;

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
                var isDefined = Enum.IsDefined(typeof(Extension), ext.Replace(".",""));
                if (isDefined)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(file, Console.ForegroundColor);
                    Console.ResetColor();
                    new ContentFactory().GetFileInfo(file, ext);
                }
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}