using System;
using System.Text;
using TaskDirectory1.Strategies.Base;

namespace TaskDirectory1.Strategies
{
    public class TxtFileStrategy : StrategyBase
    {
        public override bool IsSuitable(byte[] s)
        {
            return AsciiCharsContains(Encoding.Default.GetString(s));
        }

        public override string GetInfo(byte[] bytes)
        {
            // - *.txt -- выводим первые 50 символов текста

            var text = Encoding.UTF8.GetString(bytes).Substring(0, 50);
            return text;
        }
    }
}