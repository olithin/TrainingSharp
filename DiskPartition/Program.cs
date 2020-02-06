using System;
using System.IO;

namespace DiskPartition
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] di = DriveInfo.GetDrives();
            Console.WriteLine("Total Partitions");
            Console.WriteLine("-------");
            foreach (var item in di)
            {
                Console.WriteLine(item.Name);
            }
            
            Console.Write("\nEnter the Partiton::");
            string text = Console.ReadLine();
            DriveInfo df = new DriveInfo(text);
            Console.WriteLine("Driver Total size::{0}",df.TotalSize );
            Console.WriteLine("Free Space::{0}", df.TotalFreeSpace);

            Console.WriteLine("Drive Format::{0}", df.DriveFormat);

            Console.WriteLine("Volume Label::{0}", df.VolumeLabel);

            Console.WriteLine("Drive Type::{0}", df.DriveType);

            Console.WriteLine("Root dir::{0}", df.RootDirectory);

            Console.WriteLine("Ready::{0}", df.IsReady);

            Console.ReadKey();
        }
    }
}