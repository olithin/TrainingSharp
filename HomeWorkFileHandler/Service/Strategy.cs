using System;
using System.IO;
using System.Linq;
using System.Text;
using TaskDirectory1.FileHandlerStrategies;

namespace TaskDirectory1.Service
{
    public class Strategy
    {
        public void SelectSuitable(string file, byte[] bytes)
        {
            var sign = ConvertByteToHex(bytes);
            var signatures = new CsvReader()
                .readText(Environment.CurrentDirectory + "/resources/signatures/signatures.csv").ToList();

            if (signatures.Contains(sign))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(file, Console.ForegroundColor);
                SelectStrategy(file, bytes);
                Console.ResetColor();
            }
            else if (AsciiCharsContains(Encoding.Default.GetString(bytes)))
            {
                var ext = Path.GetExtension(file);
                switch (ext)
                {
                    case ".csv":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(file, Console.ForegroundColor);
                        new CsvStrategy().HandleFile(bytes);
                        Console.ResetColor();
                        break;
                    case ".txt":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(file, Console.ForegroundColor);
                        new TextStrategy().HandleFile(bytes);
                        Console.ResetColor();
                        break;
                    default:
                        return;
                }
            }
            else
            {
                Console.WriteLine(file);
            }
        }

        private bool AsciiCharsContains(string str)
        {
            return Encoding.UTF8.GetByteCount(str) != str.Length;
        }

        private string SelectStrategy(string file, byte[] bytes)
        {
            var ext = Path.GetExtension(file);
            switch (ext)
            {
                case ".png":
                    return new PngStrategy().HandleFile(bytes);
                case ".mp3":
                    return new Mp3Strategy().HandleFile(bytes);
                default:
                    return null;
            }
        }


        private static string ConvertByteToHex(byte[] byteData)
        {
            var hexValues = BitConverter.ToString(byteData.Take(8).ToArray()).Replace("-", "");
            return hexValues;
        }
    }
}