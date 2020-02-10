using System;
using System.Linq;

namespace TaskDirectory1
{
    public class Mp3Strategy: IFileHandler
    {
        public bool IsSuitable(byte[] s)
        {
            var h = ConvertByteToHex(s);
            if ( h!= "494433")
            {
                throw new Exception("Format is not correct");  
            }
            return true;
        }

        public string GetInfo(byte[] d)
        {
            // -- выводим заголовок, достаточно Version и Layer https://ru.wikipedia.org/wiki/MP3
            return "finish";
        }
        public void HandleFile(byte[] s)
        {
            IsSuitable(s);
            GetInfo(s);
        }
        
        private string ConvertByteToHex(byte[] byteData)
        {
            var hexValues = BitConverter.ToString(byteData.Take(3).ToArray()).Replace("-", "");
            return hexValues;
        }
    }
}