using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TaskDirectory1
{
    public class CsvStrategy: IFileService
    {
        public bool IsSuitable(byte[] s)
        {
            //NONE/VARIES
            return true;
        }

        public string GetInfo(byte[] bytes)
        {
            // выводим первую строку, отдельно показываем какой разделитель используются
            // (нужно построить регурярное выражение, детектор патернов повторений)
            var text = Encoding.UTF8.GetString(bytes);
            var regex = new Regex(@".+");
            var t = regex.Match(text);
            Console.WriteLine(t.ToString());
            
            var regex2 = new Regex(@"[,]");
            var  separator = regex2.Matches(text);
            
            foreach (Match mat in separator)
            {
                Console.WriteLine("Separator: "+mat.ToString());
            }
            Console.WriteLine("Separator count: " + separator.Count);

            return t.ToString();
        }
        public void HandleFile(byte[] bytes)
        {
            IsSuitable(bytes);
            GetInfo(bytes);
        }
    }
}