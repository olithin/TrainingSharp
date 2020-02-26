using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TaskDirectory1.Strategies
{
    public class CsvFileStrategy : AbstractStrategy
    {
        public override bool IsSuitable(byte[] s)
        {
            return ConvertByteToHex(s) == "4944330400000000";
        }

        public override string GetInfo(byte[] bytes)
        {
            // выводим первую строку, отдельно показываем какой разделитель используются
            // (нужно построить регурярное выражение, детектор патернов повторений)
            var text = Encoding.UTF8.GetString(bytes);
            var regex = new Regex(@".+");
            var t = regex.Match(text);

            var regexSeparator = new Regex(@"[,.]{1,}");
            var separator = regexSeparator.Matches(text);

            Console.WriteLine("Separator count: " + separator.Count);
            return t.ToString();
        }
    }
}