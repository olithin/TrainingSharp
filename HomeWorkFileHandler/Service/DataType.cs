using System.Collections.Generic;

namespace TaskDirectory1.Service
{
    public static class DataType
    {
        public static List<string> DetailsTypes => new List<string>()
        {
            ".csv",
            ".png",
            ".txt",
            ".mp3"
        };
    }
}