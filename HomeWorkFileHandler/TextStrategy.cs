using System;
using System.Text;

namespace TaskDirectory1
{
    public class TextStrategy: IFileService
    {
        public bool IsSuitable(byte[] s)
        {
            return true;
        }

        public string GetInfo(byte[] bytes)
        {
           // - *.txt -- выводим первые 50 символов текста
           
           var text = Encoding.UTF8.GetString(bytes).Substring(0,50);
           Console.WriteLine(text);
           return text;
        }

        public void HandleFile(byte[] bytes)
        {
            IsSuitable(bytes);
            GetInfo(bytes);
        }
    }
}