using System;
using System.Linq;
using TaskDirectory1.Service;

namespace TaskDirectory1.FileHandlerStrategies
{
    public class Mp3Strategy: AbstractFileFormat
    {
        public override bool IsSuitable(byte[] s)
        {
            var h = ConvertByteToHex(s);
            if ( h!= "494433")
            {
                throw new Exception("Format is not correct");  
            }
            return true;
        }

        public override string GetInfo(byte[] d)
        {
            // -- выводим заголовок, достаточно Version и Layer https://ru.wikipedia.org/wiki/MP3
            return "finish";
        }
        private string ConvertByteToHex(byte[] byteData)
        {
            var hexValues = BitConverter.ToString(byteData.Take(3).ToArray()).Replace("-", "");
            return hexValues;
        }
    }
}