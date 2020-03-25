using System;
using TaskDirectory1.Strategies.Base;

namespace TaskDirectory1.Strategies
{
    public class PngFileStrategy : StrategyBase
    {
        private string Signature { get; set; }

        public override bool IsSuitable(byte[] s)
        {
            Signature = ConvertByteToHex(s);
            return Signature == "89504E470D0A1A0A";
        }

        public override string GetInfo(byte[] d)
        {
            //-- выводим заголовок, достаточно PNG signature 

            Console.WriteLine($"signature png : {Signature}");
            return Signature;
        }
    }
}