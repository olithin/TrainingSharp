using System;
using System.IO;
using TaskDirectory1.FileHandlerStrategies;

namespace TaskDirectory1.Service
{
    public class ContentFactory
    {
        public void GetFileInfo(string file, string ext)
        {
            var bytes = File.ReadAllBytes(file);
            switch (ext)
            {
                case ".txt":
                    new TextStrategy().HandleFile(bytes);
                    break;
                case ".csv":
                     new CsvStrategy().HandleFile(bytes);
                    break;
                case ".png":
                    new PngStrategy().HandleFile(bytes);
                    break;
                case ".mp3":
                    new Mp3Strategy().HandleFile(bytes);
                    break;
                default:
                    throw new ArgumentException("No type format provided");
            }
        }
    }
}