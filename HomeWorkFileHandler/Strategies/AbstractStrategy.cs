using System;
using System.Linq;
using System.Text;

namespace TaskDirectory1.Strategies
{
    public abstract class AbstractStrategy : IStrategy
    {
        public abstract bool IsSuitable(byte[] s);
        public abstract string GetInfo(byte[] s);


        protected string ConvertByteToHex(byte[] byteData)
        {
            var hexValues = BitConverter.ToString(byteData.Take(8).ToArray()).Replace("-", "");
            return hexValues;
        }

        protected bool AsciiCharsContains(string str)
        {
            return Encoding.UTF8.GetByteCount(str) != str.Length;
        }
    }
}