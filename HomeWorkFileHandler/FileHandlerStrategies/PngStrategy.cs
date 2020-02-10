using System;
using System.Linq;
using TaskDirectory1.Service;

namespace TaskDirectory1.FileHandlerStrategies
{
    public class PngStrategy:AbstractFileFormat
    {
        public override bool IsSuitable(byte[] s)
        {
            var h = ConvertByteToHex(s);
            if ( h!= "89504E470D0A1A0A")
            {
                throw new Exception("Format is not correct");  
            }
            return true;
        }

        public override string GetInfo(byte[] d)
        {
            //-- выводим заголовок, достаточно PNG signature 
            var info = ConvertByteToHex(d);
            Console.WriteLine(info);
            return info;
        }
        private string ConvertByteToHex(byte[] byteData)
        {
            var hexValues = BitConverter.ToString(byteData.Take(8).ToArray()).Replace("-", "");
            return hexValues;
        }
    }
}