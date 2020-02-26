using System;
using System.IO;
using TaskDirectory1.Strategies;

namespace TaskDirectory1.Service
{
    public class FileHandlerFactory
    {
        public IStrategy GetInfoFile(string file)
        {
            var ext = Path.GetExtension(file);
            switch (ext)
            {
                case ".png":
                    return new PngFileStrategy();
                case ".mp3":
                    return new Mp3FileStrategy();
                case ".txt":
                    return new TxtFileStrategy();
                case ".csv":
                    return new CsvFileStrategy();
                default:
                    throw new NotImplementedException("No extension provided");
            }
        }
    }
}