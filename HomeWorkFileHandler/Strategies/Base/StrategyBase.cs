using System;
using System.Linq;
using System.Text;

namespace TaskDirectory1.Strategies.Base
{
    public abstract class StrategyBase : IStrategy
    {
        public abstract bool IsSuitable(byte[] s);
        public abstract string GetInfo(byte[] s);

        private static int a;
        protected static string ConvertByteToHex(byte[] byteData)
        {
            a +=1;
            var hexValues = BitConverter.ToString(byteData.Take(8).ToArray()).Replace("-", "");
            return hexValues;
        }

        protected bool AsciiCharsContains(string str)
        {
            return Encoding.UTF8.GetByteCount(str) != str.Length;
        }
    }
}