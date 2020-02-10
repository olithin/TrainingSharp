using System;

namespace TaskDirectory1
{
    public class ContentFactory
    {
        public void GetFileInfo(string ext, byte[] bytes)
        {

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