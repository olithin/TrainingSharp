namespace TaskDirectory1.Strategies
{
    public class Mp3FileStrategy : AbstractStrategy
    {
        public override bool IsSuitable(byte[] s)
        {
            return ConvertByteToHex(s) == "4944330400000000";
        }

        public override string GetInfo(byte[] d)
        {
            // -- выводим заголовок, достаточно Version и Layer https://ru.wikipedia.org/wiki/MP3
            return "finish";
        }
    }
}