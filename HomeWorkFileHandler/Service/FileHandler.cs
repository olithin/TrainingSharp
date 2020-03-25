using System;
using System.Collections.Generic;
using System.IO;

namespace TaskDirectory1.Service
{
    public class FileHandler
    {
        public void SelectFile(string directoryPath)
        {
            var files = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories);

            var list = new List<string>();

            foreach (var file in files)
            {
                list.AddRange(SelectFileByExtensionToList(file));
            }
            GetFileHandler(list);
        }

        private IList<string> SelectFileByExtensionToList(string file)
        {
            
            var listDetailsFiles=new List<string>();
            if (DataType.DetailsTypes.Contains(Path.GetExtension(file)))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                listDetailsFiles.Add(file);
            }
            Console.WriteLine(file);
            Console.ResetColor();
            return listDetailsFiles;
        }

        private void GetFileHandler(List<string> files)
        {
            var fileInfoFabric = new FileHandlerFactory();
            foreach (var fileName in files)
            {
                try
                {
                    GetFileHandler(fileInfoFabric, fileName);
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                catch (DirectoryNotFoundException e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                catch (IOException e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        private void GetFileHandler(FileHandlerFactory fileHandlerFabric, string fileName)
        {
            var currentStrategy = fileHandlerFabric.GetInfoFile(fileName);

            var fileBytes = File.ReadAllBytes(fileName);
            if (currentStrategy.IsSuitable(fileBytes))
            {
                Console.WriteLine(fileName);
                Console.WriteLine(currentStrategy.GetInfo(fileBytes));
            }
        }
    }
}