using System;
using System.IO;
using System.Reflection;

namespace DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Получим имя и базовый каталог текущего домена и выведем все загруженные в домен сборки
            //DriveInfo -содержит серию методов создания, удаления, перемещения и перечень каталогов и подкаталогов
            AppDomain domain = AppDomain.CurrentDomain;
            
            var di = new DriveInfo(domain.BaseDirectory);
            Console.WriteLine("Name::{0}", di.Name);
            Console.WriteLine("RootDirectory::{0}", di.RootDirectory);
            
            Assembly[] assemblies = domain.GetAssemblies();
            foreach (Assembly asm in assemblies)
                Console.WriteLine(asm.GetName().Name);
                 
            Console.Read();
        }
    }
}