using System;
using TaskDirectory1.Service;

namespace TaskDirectory1.FileHandlerStrategies
{
    public class PngStrategy: AbstractFileFormat
    {
        public override bool IsSuitable(byte[] s)
        {
            Console.WriteLine("PNG file is suitable: ");
            return true;
        }

        public override string GetInfo(byte[] d)
        {
//            //-- выводим заголовок, достаточно PNG signature 
//            var info = ConvertByteToHex(d);
//            Console.WriteLine(info);
            return "";
        }

    }
}