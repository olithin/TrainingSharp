using System;
using TaskDirectory1.Service;

namespace TaskDirectory1.FileHandlerStrategies
{
    public class Mp3Strategy: AbstractFileFormat
    {
        public override bool IsSuitable(byte[] s)
        {
            Console.WriteLine("Mp3 file is suitable: ");
            return true;
        }

        public override string GetInfo(byte[] d)
        {
            // -- выводим заголовок, достаточно Version и Layer https://ru.wikipedia.org/wiki/MP3
            return "finish";
        }
    }
}