using System;

namespace TaskDirectory1.Strategies
{
    public class PngFileStrategy : AbstractStrategy
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