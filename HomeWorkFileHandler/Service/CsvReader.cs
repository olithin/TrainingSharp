using System.Collections.Generic;
using System.IO;

namespace TaskDirectory1
{
    public class CsvReader
    {
        public List<string> readText(string path)
        {
            var dict = new List<string>();
            var lines=File.ReadLines(path);
            foreach (var line in lines)
            {
                dict.Add(line);
            }

            return dict;
        }

       
        
    }
}