using System;
using System.IO;

namespace TrainPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new DirectoryInfo(@"C:\temp");
            FileInfo[] files = t.GetFiles();
            foreach (var item in files)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}