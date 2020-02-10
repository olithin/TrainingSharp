using System;
using System.Text;
using TaskDirectory1.Service;

namespace TaskDirectory1.FileHandlerStrategies
{
    public class TextStrategy: AbstractFileFormat
    {
        public override bool IsSuitable(byte[] s)
        {
            return true;
        }

        public override string GetInfo(byte[] bytes)
        {
           // - *.txt -- выводим первые 50 символов текста
           
           var text = Encoding.UTF8.GetString(bytes).Substring(0,50);
           Console.WriteLine(text);
           return text;
        }
    }
}