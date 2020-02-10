using System;
using System.Linq;

namespace TaskDirectory1
{
    public class PngStrategy: IFileService
    {
        public bool IsSuitable(byte[] s)
        {
            var h = ConvertByteToHex(s);
            if ( h!= "89504E470D0A1A0A")
            {
                throw new Exception("Format is not correct");  
            }
            return true;
        }

        public string GetInfo(byte[] d)
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
        public void HandleFile(byte[] s)
        {
            IsSuitable(s);
            GetInfo(s);
        }
    }
}